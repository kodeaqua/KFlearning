﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KFmaintenance.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("KFmaintenance.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to KFmaintenance.
        /// </summary>
        internal static string AppName {
            get {
                return ResourceManager.GetString("AppName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Chrome driver belum dipilih/tidak ditemukan..
        /// </summary>
        internal static string ClisDriverNotFoundMessage {
            get {
                return ResourceManager.GetString("ClisDriverNotFoundMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tidak ada data untuk diproses..
        /// </summary>
        internal static string ClisNoDataMessage {
            get {
                return ResourceManager.GetString("ClisNoDataMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ....
        /// </summary>
        internal static string Dots {
            get {
                return ResourceManager.GetString("Dots", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Folder harus dipilih..
        /// </summary>
        internal static string FolderNotSelectedMessage {
            get {
                return ResourceManager.GetString("FolderNotSelectedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap KFmaintenance {
            get {
                object obj = ResourceManager.GetObject("KFmaintenance", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Jalankan aplikasi sebagai Administrator terlebih dahulu..
        /// </summary>
        internal static string NotElevatedMessage {
            get {
                return ResourceManager.GetString("NotElevatedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Kata kunci salah..
        /// </summary>
        internal static string PasswordInvalidMessage {
            get {
                return ResourceManager.GetString("PasswordInvalidMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Lakukan remote shutdown untuk cluster ini?.
        /// </summary>
        internal static string RemoteShutdownConfirmMessage {
            get {
                return ResourceManager.GetString("RemoteShutdownConfirmMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Pengaturan gagal disimpan.
        ///{0}.
        /// </summary>
        internal static string SettingsFailedMessage {
            get {
                return ResourceManager.GetString("SettingsFailedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Pengaturan berhasil disimpan..
        /// </summary>
        internal static string SettingsSavedMessage {
            get {
                return ResourceManager.GetString("SettingsSavedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Aplikasi KFmaintenance sudah berjalan. Cek pada taskbar..
        /// </summary>
        internal static string SingleInstanceMessage {
            get {
                return ResourceManager.GetString("SingleInstanceMessage", resourceCulture);
            }
        }
    }
}
