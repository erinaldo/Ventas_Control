﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaPresentacion.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    public sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("server=127.0.0.1;user id=root;database=sale_manager")]
        public string sale_managerConnectionString {
            get {
                return ((string)(this["sale_managerConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("server=127.0.0.1;user id=root;database=sale_manager;allowuservariables=True")]
        public string sale_managerConnectionString1 {
            get {
                return ((string)(this["sale_managerConnectionString1"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool EstablecerStockMinimo {
            get {
                return ((bool)(this["EstablecerStockMinimo"]));
            }
            set {
                this["EstablecerStockMinimo"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public decimal StockMinimo {
            get {
                return ((decimal)(this["StockMinimo"]));
            }
            set {
                this["StockMinimo"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool RecordarReponer {
            get {
                return ((bool)(this["RecordarReponer"]));
            }
            set {
                this["RecordarReponer"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool MostrarMensajeCumpleanios {
            get {
                return ((bool)(this["MostrarMensajeCumpleanios"]));
            }
            set {
                this["MostrarMensajeCumpleanios"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string MensajeCumpleanios {
            get {
                return ((string)(this["MensajeCumpleanios"]));
            }
            set {
                this["MensajeCumpleanios"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string RutaImgenCumpleanios {
            get {
                return ((string)(this["RutaImgenCumpleanios"]));
            }
            set {
                this["RutaImgenCumpleanios"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool RecordarDeudores {
            get {
                return ((bool)(this["RecordarDeudores"]));
            }
            set {
                this["RecordarDeudores"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool PermitirNuevasDeudas {
            get {
                return ((bool)(this["PermitirNuevasDeudas"]));
            }
            set {
                this["PermitirNuevasDeudas"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool RecordarPagos {
            get {
                return ((bool)(this["RecordarPagos"]));
            }
            set {
                this["RecordarPagos"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int DiasAnticipacion {
            get {
                return ((int)(this["DiasAnticipacion"]));
            }
            set {
                this["DiasAnticipacion"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool PrimerInicioSistema {
            get {
                return ((bool)(this["PrimerInicioSistema"]));
            }
            set {
                this["PrimerInicioSistema"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int IdCaja {
            get {
                return ((int)(this["IdCaja"]));
            }
            set {
                this["IdCaja"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int IdAperturaPredefinida {
            get {
                return ((int)(this["IdAperturaPredefinida"]));
            }
            set {
                this["IdAperturaPredefinida"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AbrirCaja {
            get {
                return ((bool)(this["AbrirCaja"]));
            }
            set {
                this["AbrirCaja"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("08/29/2018 16:07:00")]
        public global::System.DateTime FechaHoraApertura {
            get {
                return ((global::System.DateTime)(this["FechaHoraApertura"]));
            }
            set {
                this["FechaHoraApertura"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AbrirCajaSiempre {
            get {
                return ((bool)(this["AbrirCajaSiempre"]));
            }
            set {
                this["AbrirCajaSiempre"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool CajaAbierta {
            get {
                return ((bool)(this["CajaAbierta"]));
            }
            set {
                this["CajaAbierta"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int IdAperturaCierre {
            get {
                return ((int)(this["IdAperturaCierre"]));
            }
            set {
                this["IdAperturaCierre"] = value;
            }
        }
    }
}