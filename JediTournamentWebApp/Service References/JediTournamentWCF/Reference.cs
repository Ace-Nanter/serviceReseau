﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JediTournamentWebApp.JediTournamentWCF {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="JediWCF", Namespace="http://schemas.datacontract.org/2004/07/JediTournamentWCF.EntitiesWCF")]
    [System.SerializableAttribute()]
    public partial class JediWCF : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<JediTournamentWebApp.JediTournamentWCF.CaracteristiqueWCF> CaracteristiquesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsSithField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<JediTournamentWebApp.JediTournamentWCF.CaracteristiqueWCF> Caracteristiques {
            get {
                return this.CaracteristiquesField;
            }
            set {
                if ((object.ReferenceEquals(this.CaracteristiquesField, value) != true)) {
                    this.CaracteristiquesField = value;
                    this.RaisePropertyChanged("Caracteristiques");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsSith {
            get {
                return this.IsSithField;
            }
            set {
                if ((this.IsSithField.Equals(value) != true)) {
                    this.IsSithField = value;
                    this.RaisePropertyChanged("IsSith");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nom {
            get {
                return this.NomField;
            }
            set {
                if ((object.ReferenceEquals(this.NomField, value) != true)) {
                    this.NomField = value;
                    this.RaisePropertyChanged("Nom");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CaracteristiqueWCF", Namespace="http://schemas.datacontract.org/2004/07/JediTournamentWCF.EntitiesWCF")]
    [System.SerializableAttribute()]
    public partial class CaracteristiqueWCF : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int DefinitionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ValeurField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Definition {
            get {
                return this.DefinitionField;
            }
            set {
                if ((this.DefinitionField.Equals(value) != true)) {
                    this.DefinitionField = value;
                    this.RaisePropertyChanged("Definition");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nom {
            get {
                return this.NomField;
            }
            set {
                if ((object.ReferenceEquals(this.NomField, value) != true)) {
                    this.NomField = value;
                    this.RaisePropertyChanged("Nom");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Type {
            get {
                return this.TypeField;
            }
            set {
                if ((this.TypeField.Equals(value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Valeur {
            get {
                return this.ValeurField;
            }
            set {
                if ((this.ValeurField.Equals(value) != true)) {
                    this.ValeurField = value;
                    this.RaisePropertyChanged("Valeur");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StadeWCF", Namespace="http://schemas.datacontract.org/2004/07/JediTournamentWCF.EntitiesWCF")]
    [System.SerializableAttribute()]
    public partial class StadeWCF : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<JediTournamentWebApp.JediTournamentWCF.CaracteristiqueWCF> CaracteristiquesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PlanetField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int nbPlacesField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<JediTournamentWebApp.JediTournamentWCF.CaracteristiqueWCF> Caracteristiques {
            get {
                return this.CaracteristiquesField;
            }
            set {
                if ((object.ReferenceEquals(this.CaracteristiquesField, value) != true)) {
                    this.CaracteristiquesField = value;
                    this.RaisePropertyChanged("Caracteristiques");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Planet {
            get {
                return this.PlanetField;
            }
            set {
                if ((object.ReferenceEquals(this.PlanetField, value) != true)) {
                    this.PlanetField = value;
                    this.RaisePropertyChanged("Planet");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int nbPlaces {
            get {
                return this.nbPlacesField;
            }
            set {
                if ((this.nbPlacesField.Equals(value) != true)) {
                    this.nbPlacesField = value;
                    this.RaisePropertyChanged("nbPlaces");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MatchWCF", Namespace="http://schemas.datacontract.org/2004/07/JediTournamentWCF.EntitiesWCF")]
    [System.SerializableAttribute()]
    public partial class MatchWCF : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private JediTournamentWebApp.JediTournamentWCF.JediWCF Jedi1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private JediTournamentWebApp.JediTournamentWCF.JediWCF Jedi2Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private JediTournamentWebApp.JediTournamentWCF.EPhaseTournoi PhaseField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private JediTournamentWebApp.JediTournamentWCF.StadeWCF StadeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public JediTournamentWebApp.JediTournamentWCF.JediWCF Jedi1 {
            get {
                return this.Jedi1Field;
            }
            set {
                if ((object.ReferenceEquals(this.Jedi1Field, value) != true)) {
                    this.Jedi1Field = value;
                    this.RaisePropertyChanged("Jedi1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public JediTournamentWebApp.JediTournamentWCF.JediWCF Jedi2 {
            get {
                return this.Jedi2Field;
            }
            set {
                if ((object.ReferenceEquals(this.Jedi2Field, value) != true)) {
                    this.Jedi2Field = value;
                    this.RaisePropertyChanged("Jedi2");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public JediTournamentWebApp.JediTournamentWCF.EPhaseTournoi Phase {
            get {
                return this.PhaseField;
            }
            set {
                if ((this.PhaseField.Equals(value) != true)) {
                    this.PhaseField = value;
                    this.RaisePropertyChanged("Phase");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public JediTournamentWebApp.JediTournamentWCF.StadeWCF Stade {
            get {
                return this.StadeField;
            }
            set {
                if ((object.ReferenceEquals(this.StadeField, value) != true)) {
                    this.StadeField = value;
                    this.RaisePropertyChanged("Stade");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EPhaseTournoi", Namespace="http://schemas.datacontract.org/2004/07/EntitiesLayer")]
    public enum EPhaseTournoi : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        HuitiemeFinale1 = 14,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        HuitiemeFinale2 = 13,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        HuitiemeFinale3 = 12,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        HuitiemeFinale4 = 11,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        HuitiemeFinale5 = 10,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        HuitiemeFinale6 = 9,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        HuitiemeFinale7 = 8,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        HuitiemeFinale8 = 7,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        QuartFinale1 = 6,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        QuartFinale2 = 5,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        QuartFinale3 = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        QuartFinale4 = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        DemiFinale1 = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        DemiFinale2 = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Finale = 0,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TournoiWCF", Namespace="http://schemas.datacontract.org/2004/07/JediTournamentWCF.EntitiesWCF")]
    [System.SerializableAttribute()]
    public partial class TournoiWCF : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="JediTournamentWCF.IServiceJediTournament")]
    public interface IServiceJediTournament {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceJediTournament/getJedis", ReplyAction="http://tempuri.org/IServiceJediTournament/getJedisResponse")]
        System.Collections.Generic.List<JediTournamentWebApp.JediTournamentWCF.JediWCF> getJedis();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceJediTournament/getJedis", ReplyAction="http://tempuri.org/IServiceJediTournament/getJedisResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<JediTournamentWebApp.JediTournamentWCF.JediWCF>> getJedisAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceJediTournament/updateJedis", ReplyAction="http://tempuri.org/IServiceJediTournament/updateJedisResponse")]
        bool updateJedis(System.Collections.Generic.List<JediTournamentWebApp.JediTournamentWCF.JediWCF> jediList);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceJediTournament/updateJedis", ReplyAction="http://tempuri.org/IServiceJediTournament/updateJedisResponse")]
        System.Threading.Tasks.Task<bool> updateJedisAsync(System.Collections.Generic.List<JediTournamentWebApp.JediTournamentWCF.JediWCF> jediList);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceJediTournament/getStades", ReplyAction="http://tempuri.org/IServiceJediTournament/getStadesResponse")]
        System.Collections.Generic.List<JediTournamentWebApp.JediTournamentWCF.StadeWCF> getStades();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceJediTournament/getStades", ReplyAction="http://tempuri.org/IServiceJediTournament/getStadesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<JediTournamentWebApp.JediTournamentWCF.StadeWCF>> getStadesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceJediTournament/getMatchs", ReplyAction="http://tempuri.org/IServiceJediTournament/getMatchsResponse")]
        System.Collections.Generic.List<JediTournamentWebApp.JediTournamentWCF.MatchWCF> getMatchs();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceJediTournament/getMatchs", ReplyAction="http://tempuri.org/IServiceJediTournament/getMatchsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<JediTournamentWebApp.JediTournamentWCF.MatchWCF>> getMatchsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceJediTournament/getTournois", ReplyAction="http://tempuri.org/IServiceJediTournament/getTournoisResponse")]
        System.Collections.Generic.List<JediTournamentWebApp.JediTournamentWCF.TournoiWCF> getTournois();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceJediTournament/getTournois", ReplyAction="http://tempuri.org/IServiceJediTournament/getTournoisResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<JediTournamentWebApp.JediTournamentWCF.TournoiWCF>> getTournoisAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceJediTournament/getCaracs", ReplyAction="http://tempuri.org/IServiceJediTournament/getCaracsResponse")]
        System.Collections.Generic.List<JediTournamentWebApp.JediTournamentWCF.CaracteristiqueWCF> getCaracs();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceJediTournament/getCaracs", ReplyAction="http://tempuri.org/IServiceJediTournament/getCaracsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<JediTournamentWebApp.JediTournamentWCF.CaracteristiqueWCF>> getCaracsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceJediTournamentChannel : JediTournamentWebApp.JediTournamentWCF.IServiceJediTournament, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceJediTournamentClient : System.ServiceModel.ClientBase<JediTournamentWebApp.JediTournamentWCF.IServiceJediTournament>, JediTournamentWebApp.JediTournamentWCF.IServiceJediTournament {
        
        public ServiceJediTournamentClient() {
        }
        
        public ServiceJediTournamentClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceJediTournamentClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceJediTournamentClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceJediTournamentClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<JediTournamentWebApp.JediTournamentWCF.JediWCF> getJedis() {
            return base.Channel.getJedis();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<JediTournamentWebApp.JediTournamentWCF.JediWCF>> getJedisAsync() {
            return base.Channel.getJedisAsync();
        }
        
        public bool updateJedis(System.Collections.Generic.List<JediTournamentWebApp.JediTournamentWCF.JediWCF> jediList) {
            return base.Channel.updateJedis(jediList);
        }
        
        public System.Threading.Tasks.Task<bool> updateJedisAsync(System.Collections.Generic.List<JediTournamentWebApp.JediTournamentWCF.JediWCF> jediList) {
            return base.Channel.updateJedisAsync(jediList);
        }
        
        public System.Collections.Generic.List<JediTournamentWebApp.JediTournamentWCF.StadeWCF> getStades() {
            return base.Channel.getStades();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<JediTournamentWebApp.JediTournamentWCF.StadeWCF>> getStadesAsync() {
            return base.Channel.getStadesAsync();
        }
        
        public System.Collections.Generic.List<JediTournamentWebApp.JediTournamentWCF.MatchWCF> getMatchs() {
            return base.Channel.getMatchs();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<JediTournamentWebApp.JediTournamentWCF.MatchWCF>> getMatchsAsync() {
            return base.Channel.getMatchsAsync();
        }
        
        public System.Collections.Generic.List<JediTournamentWebApp.JediTournamentWCF.TournoiWCF> getTournois() {
            return base.Channel.getTournois();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<JediTournamentWebApp.JediTournamentWCF.TournoiWCF>> getTournoisAsync() {
            return base.Channel.getTournoisAsync();
        }
        
        public System.Collections.Generic.List<JediTournamentWebApp.JediTournamentWCF.CaracteristiqueWCF> getCaracs() {
            return base.Channel.getCaracs();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<JediTournamentWebApp.JediTournamentWCF.CaracteristiqueWCF>> getCaracsAsync() {
            return base.Channel.getCaracsAsync();
        }
    }
}
