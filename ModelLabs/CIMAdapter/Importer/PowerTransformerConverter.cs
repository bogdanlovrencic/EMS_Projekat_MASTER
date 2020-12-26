namespace FTN.ESI.SIMES.CIM.CIMAdapter.Importer
{
    using System;
    using FTN.Common;

    /// <summary>
    /// PowerTransformerConverter has methods for populating
    /// ResourceDescription objects using PowerTransformerCIMProfile_Labs objects.
    /// </summary>
    public static class PowerTransformerConverter
	{

		#region Populate ResourceDescription
		public static void PopulateIdentifiedObjectProperties(FTN.IdentifiedObject cimIdentifiedObject, ResourceDescription rd)
		{
			if ((cimIdentifiedObject != null) && (rd != null))
			{
				if (cimIdentifiedObject.MRIDHasValue)
				{
					rd.AddProperty(new Property(ModelCode.IDOBJ_MRID, cimIdentifiedObject.MRID));
				}
				if (cimIdentifiedObject.NameHasValue)
				{
					rd.AddProperty(new Property(ModelCode.IDOBJ_NAME, cimIdentifiedObject.Name));
				}
				if (cimIdentifiedObject.AliasNameHasValue)
				{
					rd.AddProperty(new Property(ModelCode.IDOBJ_ALIASNAME, cimIdentifiedObject.AliasName));
				}
            }
		}

        public static void PopulateMeasurementProperties(FTN.Measurement cimConductingEquipment, ResourceDescription rd, ImportHelper importHelper, TransformAndLoadReport report)
        {
            if ((cimConductingEquipment != null) && (rd != null))
            {
                PowerTransformerConverter.PopulateIdentifiedObjectProperties(cimConductingEquipment, rd);

                if (cimConductingEquipment.SaveAdressHasValue)
                {
                    rd.AddProperty(new Property(ModelCode.MEASUREMENT_SAVEADRESS, cimConductingEquipment.SaveAdress));
                }
                if (cimConductingEquipment.DirectionHasValue)
                {
                    rd.AddProperty(new Property(ModelCode.MEASUREMENT_DIRECTIONMETHOD, (short)GetDirection(cimConductingEquipment.Direction)));
                }
                if (cimConductingEquipment.MeasurementTypeHasValue)
                {
                    rd.AddProperty(new Property(ModelCode.MEASUREMENT_MEASUREMENTTYPE, (short)GetMeasurementType(cimConductingEquipment.MeasurementType)));
                }

                if (cimConductingEquipment.PowerSystemResourceHasValue)
                {
                    long gid = importHelper.GetMappedGID(cimConductingEquipment.PowerSystemResource.ID);
                    if (gid < 0)
                    {
                        report.Report.Append("WARNING: Convert ").Append(cimConductingEquipment.GetType().ToString()).Append(" rdfID = \"").Append(cimConductingEquipment.ID);
                        report.Report.Append("\" - Failed to set reference to PowerSystemResource: rdfID \"").Append(cimConductingEquipment.PowerSystemResource.ID).AppendLine(" \" is not mapped to GID!");
                    }
                    rd.AddProperty(new Property(ModelCode.MEASUREMENT_POWERSYSRES, gid));
                }
            }
        }

        

        public static void PopulateDiscreteProperties(FTN.Discrete cimIdentifiedObject, ResourceDescription rd, ImportHelper importHelper, TransformAndLoadReport report)
        {
            if ((cimIdentifiedObject != null) && (rd != null))
            {
                PowerTransformerConverter.PopulateMeasurementProperties(cimIdentifiedObject, rd, importHelper, report);

                if (cimIdentifiedObject.MaxValueHasValue)
                {
                    rd.AddProperty(new Property(ModelCode.DISCRETE_MAXVALUE, cimIdentifiedObject.MaxValue));
                }
                if (cimIdentifiedObject.MinValueHasValue)
                {
                    rd.AddProperty(new Property(ModelCode.DISCRETE_MINVALUE, cimIdentifiedObject.MinValue));
                }
                if (cimIdentifiedObject.NormalValueHasValue)
                {
                    rd.AddProperty(new Property(ModelCode.DISCRETE_NORMALVALUE, cimIdentifiedObject.NormalValue));
                }
            }
        }

        public static void PopulateAnalogProperties(FTN.Analog cimIdentifiedObject, ResourceDescription rd, ImportHelper importHelper, TransformAndLoadReport report)
        {
            if ((cimIdentifiedObject != null) && (rd != null))
            {
                PowerTransformerConverter.PopulateMeasurementProperties(cimIdentifiedObject, rd, importHelper, report);

                if (cimIdentifiedObject.MaxValueHasValue)
                {
                    rd.AddProperty(new Property(ModelCode.ANALOG_MAXVALUE, cimIdentifiedObject.MaxValue));
                }
                if (cimIdentifiedObject.MinValueHasValue)
                {
                    rd.AddProperty(new Property(ModelCode.ANALOG_MINVALUE, cimIdentifiedObject.MinValue));
                }
                if (cimIdentifiedObject.NormalValueHasValue)
                {
                    rd.AddProperty(new Property(ModelCode.ANALOG_NORMALVALUE, cimIdentifiedObject.NormalValue));
                }
            }
        }

        public static void PopulateEnergyConsumerProperties(FTN.EnergyConsumer cimIdentifiedObject, ResourceDescription rd, ImportHelper importHelper, TransformAndLoadReport report)
        {
            if ((cimIdentifiedObject != null) && (rd != null))
            {
                PowerTransformerConverter.PopulateConductingEquipmentProperties(cimIdentifiedObject, rd, importHelper, report);

                if (cimIdentifiedObject.PfixedHasValue)
                {
                    rd.AddProperty(new Property(ModelCode.ENERGYCONSUMER_PFIXED, cimIdentifiedObject.Pfixed));
                }
                //if (cimIdentifiedObject.QfixedHasValue)       //PITATI PROFESORA DA LI JE POTREBNO UOPSTE
                //{
                //    rd.AddProperty(new Property(ModelCode.ENERGYCONSUMER_QFIXED, cimIdentifiedObject.Qfixed));
                //}
            }
        }

        public static void PopulateGeneratorProperties(FTN.Generator cimIdentifiedObject, ResourceDescription rd, ImportHelper importHelper, TransformAndLoadReport report)
        {
            if ((cimIdentifiedObject != null) && (rd != null))
            {
                PowerTransformerConverter.PopulateRotatingMachineProperties(cimIdentifiedObject, rd, importHelper, report);

                if (cimIdentifiedObject.MaxQHasValue)
                {
                    rd.AddProperty(new Property(ModelCode.GENERATOR_MAXQ, cimIdentifiedObject.MaxQ));
                }
                if (cimIdentifiedObject.MinQHasValue)
                {
                    rd.AddProperty(new Property(ModelCode.GENERATOR_MINQ, cimIdentifiedObject.MinQ));
                }
                if (cimIdentifiedObject.GeneratorTypeHasValue)
                {
                    rd.AddProperty(new Property(ModelCode.GENERATOR_GENERATORTYPE, (short)GetGeneratorType(cimIdentifiedObject.GeneratorType)));
                }
            }
        }

        public static void PopulateConductingEquipmentProperties(FTN.ConductingEquipment cimIdentifiedObject, ResourceDescription rd, ImportHelper importHelper, TransformAndLoadReport report)
        {
            if ((cimIdentifiedObject != null) && (rd != null))
            {
                PowerTransformerConverter.PopulateEquipmentProperties(cimIdentifiedObject, rd, importHelper, report);
            }
        }

        public static void PopulateSubstationProperties(FTN.Substation cimIdentifiedObject, ResourceDescription rd, ImportHelper importHelper, TransformAndLoadReport report)
        {
            if ((cimIdentifiedObject != null) && (rd != null))
            {
                PowerTransformerConverter.PopulateEquipmentContainerProperties(cimIdentifiedObject, rd, importHelper, report);

            }
        }

        public static void PopulateRegulatingConductingEqProperties(FTN.RegulatingCondEq cimIdentifiedObject, ResourceDescription rd, ImportHelper importHelper, TransformAndLoadReport report)
        {
            if ((cimIdentifiedObject != null) && (rd != null))
            {
                PowerTransformerConverter.PopulateConductingEquipmentProperties(cimIdentifiedObject, rd, importHelper, report);

            }
        }
        public static void PopulateGeographicalRegionProperties(FTN.GeographicalRegion cimIdentifiedObject, ResourceDescription rd, ImportHelper importHelper, TransformAndLoadReport report)
        {
            if ((cimIdentifiedObject != null) && (rd != null))
            {
                PowerTransformerConverter.PopulateIdentifiedObjectProperties(cimIdentifiedObject, rd);
            }
        }
        public static void PopulateConnectivityNodeContainerProperties(FTN.ConnectivityNodeContainer cimIdentifiedObject, ResourceDescription rd, ImportHelper importHelper, TransformAndLoadReport report)
        {
            if ((cimIdentifiedObject != null) && (rd != null))
            {
                PowerTransformerConverter.PopulatePowerSystemResourceProperties(cimIdentifiedObject, rd, importHelper, report);
            }
        }

        public static void PopulateRotatingMachineProperties(FTN.RotatingMachine cimIdentifiedObject, ResourceDescription rd, ImportHelper importHelper, TransformAndLoadReport report)
        {
            if ((cimIdentifiedObject != null) && (rd != null))
            {
                PowerTransformerConverter.PopulateRegulatingConductingEqProperties(cimIdentifiedObject, rd, importHelper, report);

                if (cimIdentifiedObject.RatedSHasValue)
                {
                    rd.AddProperty(new Property(ModelCode.ROTATINGMACHINE_RATEDS, cimIdentifiedObject.RatedS));
                }
            }
        }

        public static void PopulatePowerSystemResourceProperties(FTN.PowerSystemResource cimBaseVoltage, ResourceDescription rd, ImportHelper importHelper, TransformAndLoadReport report)
        {
            if ((cimBaseVoltage != null) && (rd != null))
            {
                PowerTransformerConverter.PopulateIdentifiedObjectProperties(cimBaseVoltage, rd);
            }
        }

        public static void PopulateEquipmentContainerProperties(FTN.EquipmentContainer cimBaseVoltage, ResourceDescription rd, ImportHelper importHelper, TransformAndLoadReport report)
        {
            if ((cimBaseVoltage != null) && (rd != null))
            {
                PowerTransformerConverter.PopulateConnectivityNodeContainerProperties(cimBaseVoltage, rd, importHelper, report);
            }
        }


        public static void PopulateEquipmentProperties(FTN.Equipment cimConductingEquipment, ResourceDescription rd, ImportHelper importHelper, TransformAndLoadReport report)
        {
            if ((cimConductingEquipment != null) && (rd != null))
            {
                PowerTransformerConverter.PopulatePowerSystemResourceProperties(cimConductingEquipment, rd, importHelper, report);
                if (cimConductingEquipment.EquipmentContainerHasValue)
                {
                    long gid = importHelper.GetMappedGID(cimConductingEquipment.EquipmentContainer.ID);
                    if (gid < 0)
                    {
                        report.Report.Append("WARNING: Convert ").Append(cimConductingEquipment.GetType().ToString()).Append(" rdfID = \"").Append(cimConductingEquipment.ID);
                        report.Report.Append("\" - Failed to set reference to EquipmentContainer: rdfID \"").Append(cimConductingEquipment.EquipmentContainer.ID).AppendLine(" \" is not mapped to GID!");
                    }
                    rd.AddProperty(new Property(ModelCode.EQUIPMENT_EQUIPMENTCONT, gid));
                }
            }
        }






        #endregion Populate ResourceDescription

        #region Enums convert

        private static MeasurementType GetMeasurementType(FTN.MeasurementType measurementType)
        {
            switch (measurementType)
            {
                case FTN.MeasurementType.voltage:
                    return MeasurementType.voltage;
                case FTN.MeasurementType.activePower:
                    return MeasurementType.activePower;

                default: return MeasurementType.other;

            }
        }

        private static Direction GetDirection(FTN.Direction direction)
        {
            switch (direction)
            {
                case FTN.Direction.read:
                    return Direction.read;
                case FTN.Direction.write:
                    return Direction.write;
                case FTN.Direction.readWrite:
                    return Direction.readWrite;

                default: return Direction.other;

            }
        }
        public static GeneratorType GetGeneratorType(FTN.GeneratorType generatorType)
        {
            switch (generatorType)
            {
                case FTN.GeneratorType.wind:
                    return GeneratorType.wind;
                case FTN.GeneratorType.solar:
                    return GeneratorType.solar;
                case FTN.GeneratorType.oil:
                    return GeneratorType.oil;
                case FTN.GeneratorType.hydro:
                    return GeneratorType.hydro;
                case FTN.GeneratorType.gas:
                    return GeneratorType.gas;
                case FTN.GeneratorType.coal:
                    return GeneratorType.coal;

                default: return GeneratorType.other;

            }
        }
        //public static PhaseCode GetDMSPhaseCode(FTN.PhaseCode phases)
        //{
        //	switch (phases)
        //	{
        //		case FTN.PhaseCode.A:
        //			return PhaseCode.A;
        //		case FTN.PhaseCode.AB:
        //			return PhaseCode.AB;
        //		case FTN.PhaseCode.ABC:
        //			return PhaseCode.ABC;
        //		case FTN.PhaseCode.ABCN:
        //			return PhaseCode.ABCN;
        //		case FTN.PhaseCode.ABN:
        //			return PhaseCode.ABN;
        //		case FTN.PhaseCode.AC:
        //			return PhaseCode.AC;
        //		case FTN.PhaseCode.ACN:
        //			return PhaseCode.ACN;
        //		case FTN.PhaseCode.AN:
        //			return PhaseCode.AN;
        //		case FTN.PhaseCode.B:
        //			return PhaseCode.B;
        //		case FTN.PhaseCode.BC:
        //			return PhaseCode.BC;
        //		case FTN.PhaseCode.BCN:
        //			return PhaseCode.BCN;
        //		case FTN.PhaseCode.BN:
        //			return PhaseCode.BN;
        //		case FTN.PhaseCode.C:
        //			return PhaseCode.C;
        //		case FTN.PhaseCode.CN:
        //			return PhaseCode.CN;
        //		case FTN.PhaseCode.N:
        //			return PhaseCode.N;
        //		case FTN.PhaseCode.s12N:
        //			return PhaseCode.ABN;
        //		case FTN.PhaseCode.s1N:
        //			return PhaseCode.AN;
        //		case FTN.PhaseCode.s2N:
        //			return PhaseCode.BN;
        //		default: return PhaseCode.Unknown;
        //	}
        //}

        //public static TransformerFunction GetDMSTransformerFunctionKind(FTN.TransformerFunctionKind transformerFunction)
        //{
        //	switch (transformerFunction)
        //	{
        //		case FTN.TransformerFunctionKind.voltageRegulator:
        //			return TransformerFunction.Voltreg;
        //		default:
        //			return TransformerFunction.Consumer;
        //	}
        //}

        //public static WindingType GetDMSWindingType(FTN.WindingType windingType)
        //{
        //	switch (windingType)
        //	{
        //		case FTN.WindingType.primary:
        //			return WindingType.Primary;
        //		case FTN.WindingType.secondary:
        //			return WindingType.Secondary;
        //		case FTN.WindingType.tertiary:
        //			return WindingType.Tertiary;
        //		default:
        //			return WindingType.None;
        //	}
        //}

        //public static WindingConnection GetDMSWindingConnection(FTN.WindingConnection windingConnection)
        //{
        //	switch (windingConnection)
        //	{
        //		case FTN.WindingConnection.D:
        //			return WindingConnection.D;
        //		case FTN.WindingConnection.I:
        //			return WindingConnection.I;
        //		case FTN.WindingConnection.Z:
        //			return WindingConnection.Z;
        //		case FTN.WindingConnection.Y:
        //			return WindingConnection.Y;
        //		default:
        //			return WindingConnection.Y;
        //	}
        //}
        #endregion Enums convert
    }
}
