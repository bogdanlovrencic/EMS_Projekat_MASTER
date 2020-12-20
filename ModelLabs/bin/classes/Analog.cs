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
    
    
    /// Analog represents an analog Measurement.
    public class Analog : Measurement {
        
        /// Normal value range maximum for any of the MeasurementValue.values. Used for scaling, e.g. in bar graphs or of telemetered raw values.
        private System.Single? cim_maxValue;
        
        private const bool isMaxValueMandatory = false;
        
        private const string _maxValuePrefix = "cim";
        
        /// Normal value range minimum for any of the MeasurementValue.values. Used for scaling, e.g. in bar graphs or of telemetered raw values.
        private System.Single? cim_minValue;
        
        private const bool isMinValueMandatory = false;
        
        private const string _minValuePrefix = "cim";
        
        /// Normal measurement value, e.g., used for percentage calculations.
        private System.Single? cim_normalValue;
        
        private const bool isNormalValueMandatory = false;
        
        private const string _normalValuePrefix = "cim";
        
        public virtual float MaxValue {
            get {
                return this.cim_maxValue.GetValueOrDefault();
            }
            set {
                this.cim_maxValue = value;
            }
        }
        
        public virtual bool MaxValueHasValue {
            get {
                return this.cim_maxValue != null;
            }
        }
        
        public static bool IsMaxValueMandatory {
            get {
                return isMaxValueMandatory;
            }
        }
        
        public static string MaxValuePrefix {
            get {
                return _maxValuePrefix;
            }
        }
        
        public virtual float MinValue {
            get {
                return this.cim_minValue.GetValueOrDefault();
            }
            set {
                this.cim_minValue = value;
            }
        }
        
        public virtual bool MinValueHasValue {
            get {
                return this.cim_minValue != null;
            }
        }
        
        public static bool IsMinValueMandatory {
            get {
                return isMinValueMandatory;
            }
        }
        
        public static string MinValuePrefix {
            get {
                return _minValuePrefix;
            }
        }
        
        public virtual float NormalValue {
            get {
                return this.cim_normalValue.GetValueOrDefault();
            }
            set {
                this.cim_normalValue = value;
            }
        }
        
        public virtual bool NormalValueHasValue {
            get {
                return this.cim_normalValue != null;
            }
        }
        
        public static bool IsNormalValueMandatory {
            get {
                return isNormalValueMandatory;
            }
        }
        
        public static string NormalValuePrefix {
            get {
                return _normalValuePrefix;
            }
        }
    }
}