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
    
    
    /// A Measurement represents any measured, calculated or non-measured non-calculated quantity. Any piece of equipment may contain Measurements, e.g. a substation may have temperature measurements and door open indications, a transformer may have oil temperature and tank pressure measurements, a bay may contain a number of power flow measurements and a Breaker may contain a switch status measurement. 
    ///The PSR - Measurement association is intended to capture this use of Measurement and is included in the naming hierarchy based on EquipmentContainer. The naming hierarchy typically has Measurements as leafs, e.g. Substation-VoltageLevel-Bay-Switch-Measurement.
    ///Some Measurements represent quantities related to a particular sensor location in the network, e.g. a voltage transformer (PT) at a busbar or a current transformer (CT) at the bar between a breaker and an isolator. The sensing position is not captured in the PSR - Measurement association. Instead it is captured by the Measurement - Terminal association that is used to define the sensing location in the network topology. The location is defined by the connection of the Terminal to ConductingEquipment. 
    ///If both a Terminal and PSR are associated, and the PSR is of type ConductingEquipment, the associated Terminal should belong to that ConductingEquipment instance.
    ///When the sensor location is needed both Measurement-PSR and Measurement-Terminal are used. The Measurement-Terminal association is never used alone.
    public class Measurement : IdentifiedObject {
        
        private Direction? cim_directionMethod;
        
        private const bool isDirectionMethodMandatory = true;
        
        private const string _directionMethodPrefix = "cim";
        
        /// Specifies the type of measurement.  For example, this specifies if the measurement represents an indoor temperature, outdoor temperature, bus voltage, line flow, etc.
        private MeasurementType? cim_measurementType;
        
        private const bool isMeasurementTypeMandatory = true;
        
        private const string _measurementTypePrefix = "cim";
        
        /// The power system resource that contains the measurement.
        private PowerSystemResource cim_PowerSystemResource;
        
        private const bool isPowerSystemResourceMandatory = false;
        
        private const string _PowerSystemResourcePrefix = "cim";
        
        private string cim_saveAddress;
        
        private const bool isSaveAddressMandatory = false;
        
        private const string _saveAddressPrefix = "cim";
        
        public virtual Direction DirectionMethod {
            get {
                return this.cim_directionMethod.GetValueOrDefault();
            }
            set {
                this.cim_directionMethod = value;
            }
        }
        
        public virtual bool DirectionMethodHasValue {
            get {
                return this.cim_directionMethod != null;
            }
        }
        
        public static bool IsDirectionMethodMandatory {
            get {
                return isDirectionMethodMandatory;
            }
        }
        
        public static string DirectionMethodPrefix {
            get {
                return _directionMethodPrefix;
            }
        }
        
        public virtual MeasurementType MeasurementType {
            get {
                return this.cim_measurementType.GetValueOrDefault();
            }
            set {
                this.cim_measurementType = value;
            }
        }
        
        public virtual bool MeasurementTypeHasValue {
            get {
                return this.cim_measurementType != null;
            }
        }
        
        public static bool IsMeasurementTypeMandatory {
            get {
                return isMeasurementTypeMandatory;
            }
        }
        
        public static string MeasurementTypePrefix {
            get {
                return _measurementTypePrefix;
            }
        }
        
        public virtual PowerSystemResource PowerSystemResource {
            get {
                return this.cim_PowerSystemResource;
            }
            set {
                this.cim_PowerSystemResource = value;
            }
        }
        
        public virtual bool PowerSystemResourceHasValue {
            get {
                return this.cim_PowerSystemResource != null;
            }
        }
        
        public static bool IsPowerSystemResourceMandatory {
            get {
                return isPowerSystemResourceMandatory;
            }
        }
        
        public static string PowerSystemResourcePrefix {
            get {
                return _PowerSystemResourcePrefix;
            }
        }
        
        public virtual string SaveAddress {
            get {
                return this.cim_saveAddress;
            }
            set {
                this.cim_saveAddress = value;
            }
        }
        
        public virtual bool SaveAddressHasValue {
            get {
                return this.cim_saveAddress != null;
            }
        }
        
        public static bool IsSaveAddressMandatory {
            get {
                return isSaveAddressMandatory;
            }
        }
        
        public static string SaveAddressPrefix {
            get {
                return _saveAddressPrefix;
            }
        }
    }
}
