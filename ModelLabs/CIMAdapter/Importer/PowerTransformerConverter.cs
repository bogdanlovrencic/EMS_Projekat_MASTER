namespace FTN.ESI.SIMES.CIM.CIMAdapter.Importer
{
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

        public static void PopulateConnectivityNodeProperties(FTN.ConnectivityNode cimConnectivityNode, ResourceDescription rd)
        {
            if ((cimConnectivityNode != null) && (rd != null))
            {
                PowerTransformerConverter.PopulateIdentifiedObjectProperties(cimConnectivityNode, rd);

                if(cimConnectivityNode.DescriptionHasValue)
                {
                    rd.AddProperty(new Property(ModelCode.CONNODE_DESCRIPTION, cimConnectivityNode.Description));
                }
            }

        }

        public static void PopulatePowerSystemResourceProperties(FTN.PowerSystemResource cimPowerSystemResource, ResourceDescription rd)
        {
            if ((cimPowerSystemResource != null) && (rd != null))
            {
                PowerTransformerConverter.PopulateIdentifiedObjectProperties(cimPowerSystemResource, rd);
            }

        }

        public static void PopulateEquipmentProperties(FTN.Equipment cimEquipment, ResourceDescription rd)
        {
            if ((cimEquipment != null) && (rd != null))
            {
                PowerTransformerConverter.PopulatePowerSystemResourceProperties(cimEquipment, rd);
            }

        }

        public static void PopulateConductingEquipmentProperties(FTN.ConductingEquipment cimConductingEquipment, ResourceDescription rd)
        {
            if ((cimConductingEquipment != null) && (rd != null))
            {
                PowerTransformerConverter.PopulateEquipmentProperties(cimConductingEquipment, rd);
            }

        }

        public static void PopulateSeriesCompensatorProperties(FTN.SeriesCompensator cimSeriesCompensator, ResourceDescription rd)
        {
            if ((cimSeriesCompensator != null) && (rd != null))
            {
                PowerTransformerConverter.PopulateConductingEquipmentProperties(cimSeriesCompensator, rd);

                if (cimSeriesCompensator.RHasValue)
                {
                    rd.AddProperty(new Property(ModelCode.SERCOMPENSATOR_R, cimSeriesCompensator.R));
                }
                if (cimSeriesCompensator.R0HasValue)
                {
                    rd.AddProperty(new Property(ModelCode.SERCOMPENSATOR_R0, cimSeriesCompensator.R0));
                }
                if (cimSeriesCompensator.XHasValue)
                {
                    rd.AddProperty(new Property(ModelCode.SERCOMPENSATOR_X, cimSeriesCompensator.X));
                }
                if (cimSeriesCompensator.X0HasValue)
                {
                    rd.AddProperty(new Property(ModelCode.SERCOMPENSATOR_X0, cimSeriesCompensator.X0));
                }
            }

        }

        public static void PopulateConductorProperties(FTN.Conductor cimConductor, ResourceDescription rd)
        {
            if ((cimConductor != null) && (rd != null))
            {
                PowerTransformerConverter.PopulateConductingEquipmentProperties(cimConductor, rd);

                if(cimConductor.LengthHasValue)
                {
                    rd.AddProperty(new Property(ModelCode.CONDUCTOR_LENGTH, cimConductor.Length));
                }
            }

        }

        public static void PopulateDCLineSegmentProperties(FTN.DCLineSegment cimDCLineSegment, ResourceDescription rd)
        {
            if ((cimDCLineSegment != null) && (rd != null))
            {
                PowerTransformerConverter.PopulateConductorProperties(cimDCLineSegment, rd);
            }

        }

        public static void PopulateACLineSegmentProperties(FTN.ACLineSegment cimACLineSegment, ResourceDescription rd)
        {
            if ((cimACLineSegment != null) && (rd != null))
            {
                PowerTransformerConverter.PopulateConductorProperties(cimACLineSegment, rd);

                if(cimACLineSegment.B0chHasValue)
                {
                    rd.AddProperty(new Property(ModelCode.ACLINESEG_B0CH, cimACLineSegment.B0ch));
                }
                if (cimACLineSegment.BchHasValue)
                {
                    rd.AddProperty(new Property(ModelCode.ACLINESEG_BCH, cimACLineSegment.Bch));
                }
                if (cimACLineSegment.G0chHasValue)
                {
                    rd.AddProperty(new Property(ModelCode.ACLINESEG_G0CH, cimACLineSegment.G0ch));
                }
                if (cimACLineSegment.GchHasValue)
                {
                    rd.AddProperty(new Property(ModelCode.ACLINESEG_GCH, cimACLineSegment.Gch));
                }
                if (cimACLineSegment.RHasValue)
                {
                    rd.AddProperty(new Property(ModelCode.ACLINESEG_R, cimACLineSegment.R));
                }
                if (cimACLineSegment.R0HasValue)
                {
                    rd.AddProperty(new Property(ModelCode.ACLINESEG_R0, cimACLineSegment.R0));
                }
                if (cimACLineSegment.XHasValue)
                {
                    rd.AddProperty(new Property(ModelCode.ACLINESEG_X, cimACLineSegment.X));
                }
                if (cimACLineSegment.X0HasValue)
                {
                    rd.AddProperty(new Property(ModelCode.ACLINESEG_X0, cimACLineSegment.X0));
                }
            }

        }
        public static void PopulatePerLengthImpedanceProperties(FTN.PerLengthImpedance cimPerLengthImpedance, ResourceDescription rd)
        {
            if ((cimPerLengthImpedance != null) && (rd != null))
            {
                PowerTransformerConverter.PopulateIdentifiedObjectProperties(cimPerLengthImpedance, rd);
            }

        }

        public static void PopulatePerLengthSequenceImpedanceProperties(FTN.PerLengthSequenceImpedance cimPerLengthSequenceImpedance, ResourceDescription rd)
        {
            if ((cimPerLengthSequenceImpedance != null) && (rd != null))
            {
                PowerTransformerConverter.PopulatePerLengthImpedanceProperties(cimPerLengthSequenceImpedance, rd);

                if (cimPerLengthSequenceImpedance.B0chHasValue)
                {
                    rd.AddProperty(new Property(ModelCode.PLENSIM_B0CH, cimPerLengthSequenceImpedance.B0ch));
                }
                if (cimPerLengthSequenceImpedance.BchHasValue)
                {
                    rd.AddProperty(new Property(ModelCode.PLENSIM_BCH, cimPerLengthSequenceImpedance.Bch));
                }
                if (cimPerLengthSequenceImpedance.G0chHasValue)
                {
                    rd.AddProperty(new Property(ModelCode.PLENSIM_G0CH, cimPerLengthSequenceImpedance.G0ch));
                }
                if (cimPerLengthSequenceImpedance.GchHasValue)
                {
                    rd.AddProperty(new Property(ModelCode.PLENSIM_GCH, cimPerLengthSequenceImpedance.Gch));
                }
                if (cimPerLengthSequenceImpedance.RHasValue)
                {
                    rd.AddProperty(new Property(ModelCode.PLENSIM_R, cimPerLengthSequenceImpedance.R));
                }
                if (cimPerLengthSequenceImpedance.R0HasValue)
                {
                    rd.AddProperty(new Property(ModelCode.PLENSIM_R0, cimPerLengthSequenceImpedance.R0));
                }
                if (cimPerLengthSequenceImpedance.XHasValue)
                {
                    rd.AddProperty(new Property(ModelCode.PLENSIM_X, cimPerLengthSequenceImpedance.X));
                }
                if (cimPerLengthSequenceImpedance.X0HasValue)
                {
                    rd.AddProperty(new Property(ModelCode.PLENSIM_X0, cimPerLengthSequenceImpedance.X0));
                }
            }

        }

        public static void PopulateTerminalProperties(FTN.Terminal cimTerminal, ResourceDescription rd, ImportHelper importHelper, TransformAndLoadReport report)
        {
            if ((cimTerminal != null) && (rd != null))
            {
                PowerTransformerConverter.PopulateIdentifiedObjectProperties(cimTerminal, rd);
                long gid = importHelper.GetMappedGID(cimTerminal.ConductingEquipment.ID);
                if (gid < 0)
                {
                    report.Report.Append("WARNING: Convert ").Append(cimTerminal.GetType().ToString()).Append(" rdfID = \"").Append(cimTerminal.ID);
                    report.Report.Append("\" - Failed to set reference to ConductingEquipment: rdfID \"").Append(cimTerminal.ConductingEquipment.ID).AppendLine(" \" is not mapped to GID!");
                }
                rd.AddProperty(new Property(ModelCode.TERMINAL_CONEQ, gid));
            }
            if (cimTerminal.ConnectivityNodeHasValue)
            {
                long gid = importHelper.GetMappedGID(cimTerminal.ConnectivityNode.ID);
                if (gid < 0)
                {
                    report.Report.Append("WARNING: Convert ").Append(cimTerminal.GetType().ToString()).Append(" rdfID = \"").Append(cimTerminal.ID);
                    report.Report.Append("\" - Failed to set reference to ConnectivityNode: rdfID \"").Append(cimTerminal.ConnectivityNode.ID).AppendLine(" \" is not mapped to GID!");
                }
                rd.AddProperty(new Property(ModelCode.TERMINAL_CONNODE, gid));
            }

        }

        
        #endregion Populate ResourceDescription

        #region Enums convert
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
