﻿using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using KFlearning.TemplateProvider;
using KFlearning.Views;
using System.Net;

namespace KFlearning.Services
{
    public class KFlearningModulesInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Component.For<WebClient>().ImplementedBy<WebClient>().LifestyleTransient(),

                // views
                Classes.FromThisAssembly()
                    .InSameNamespaceAs<StartupForm>()
                    .LifestyleTransient(),

                // services
                Component.For<KFlearningApplicationContext>().LifestyleSingleton(),
                Classes.FromThisAssembly()
                    .InSameNamespaceAs<KFlearningModulesInstaller>()
                    .WithServiceDefaultInterfaces()
                    .WithServiceAllInterfaces()
                    .LifestyleSingleton(),

                // services - template
                Classes.FromThisAssembly()
                    .BasedOn<ITemplateProvider>()
                    .WithServiceAllInterfaces()
                    .LifestyleSingleton(),

                // services - core
                Classes.FromAssemblyNamed("KFlearning.Core")
                    .Pick()
                    .WithServiceDefaultInterfaces()
                    .WithServiceAllInterfaces()
                    .LifestyleSingleton()
            );
        }
    }
}