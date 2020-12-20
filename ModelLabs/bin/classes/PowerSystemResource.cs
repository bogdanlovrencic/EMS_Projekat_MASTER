//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FTN {
    using System;
    using FTN;
    using System.Collections.Generic;
    
    
    /// A power system resource can be an item of equipment such as a switch, an equipment container containing many individual items of equipment such as a substation, or an organisational entity such as sub-control area. Power system resources can have measurements associated.
    public class PowerSystemResource : IdentifiedObject {
        
        /// The measurements associated with this power system resource.
        private List<Measurement> cim_Measurements = new List<Measurement>();
        
        private const bool isMeasurementsMandatory = false;
        
        private const string _MeasurementsPrefix = "cim";
        
        public virtual List<Measurement> Measurements {
            get {
                return this.cim_Measurements;
            }
            set {
                this.cim_Measurements = value;
            }
        }
        
        public virtual bool MeasurementsHasValue {
            get {
                return this.cim_Measurements != null;
            }
        }
        
        public static bool IsMeasurementsMandatory {
            get {
                return isMeasurementsMandatory;
            }
        }
        
        public static string MeasurementsPrefix {
            get {
                return _MeasurementsPrefix;
            }
        }
    }
}