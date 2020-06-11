﻿// SOLUTION : KFlearning
// AUTHOR   : Fahmi Noor Fiqri, Kodesiana.com
// WEBSITE  : https://kodesiana.com
// REPO     : https://github.com/Kodesiana or https://github.com/fahminlb33
//
// This file is part of KFlearning, see LICENSE.
// See this code in repository URL above!

using KFmaintenance.Views;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KFmaintenance.Services
{
    public class CustomApplicationContext : ApplicationContext
    {
        private readonly ITelemetryService _telemetry;
        private Form _mainForm;

        public CustomApplicationContext(ITelemetryService telemetryService, StartupForm form)
        {
            _telemetry = telemetryService;
            _mainForm = form;

            Task.Run(() => _telemetry.Load());

            _mainForm.HandleDestroyed += OnFormDestroy;
            _mainForm.Opacity = 0;
            _mainForm.Show();
            _mainForm.Hide();
            _mainForm.Opacity = 1;
        }

        private void OnFormDestroy(object sender, EventArgs e)
        {
            if (sender is Form form && !form.RecreatingHandle)
            {
                form.HandleDestroyed -= OnFormDestroy;
                OnMainFormClosed(sender, e);
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _mainForm?.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}