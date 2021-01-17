using System;
using System.Collections.Generic;
using CIM.Model;
using FTN.Common;
using FTN.ESI.SIMES.CIM.CIMAdapter.Manager;

namespace FTN.ESI.SIMES.CIM.CIMAdapter.Importer
{
	/// <summary>
	/// PowerTransformerImporter
	/// </summary>
	public class PowerTransformerImporter
	{
		/// <summary> Singleton </summary>
		private static PowerTransformerImporter ptImporter = null;
		private static object singletoneLock = new object();

		private ConcreteModel concreteModel;
		private Delta delta;
		private ImportHelper importHelper;
		private TransformAndLoadReport report;


		#region Properties
		public static PowerTransformerImporter Instance
		{
			get
			{
				if (ptImporter == null)
				{
					lock (singletoneLock)
					{
						if (ptImporter == null)
						{
							ptImporter = new PowerTransformerImporter();
							ptImporter.Reset();
						}
					}
				}
				return ptImporter;
			}
		}

		public Delta NMSDelta
		{
			get 
			{
				return delta;
			}
		}
		#endregion Properties


		public void Reset()
		{
			concreteModel = null;
			delta = new Delta();
			importHelper = new ImportHelper();
			report = null;
		}

		public TransformAndLoadReport CreateNMSDelta(ConcreteModel cimConcreteModel)
		{
			LogManager.Log("Importing EMS Elements...", LogLevel.Info);
			report = new TransformAndLoadReport();
			concreteModel = cimConcreteModel;
			delta.ClearDeltaOperations();

			if ((concreteModel != null) && (concreteModel.ModelMap != null))
			{
				try
				{
					// convert into DMS elements
					ConvertModelAndPopulateDelta();
				}
				catch (Exception ex)
				{
					string message = string.Format("{0} - ERROR in data import - {1}", DateTime.Now, ex.Message);
					LogManager.Log(message);
					report.Report.AppendLine(ex.Message);
					report.Success = false;
				}
			}
			LogManager.Log("Importing EMS Elements - END.", LogLevel.Info);
			return report;
		}

		/// <summary>
		/// Method performs conversion of network elements from CIM based concrete model into DMS model.
		/// </summary>
		private void ConvertModelAndPopulateDelta()
		{
			LogManager.Log("Loading elements and creating delta...", LogLevel.Info);

            //// import all concrete model types (DMSType enum)
            ImportGeographicalRegion();
            ImportSubstation();
            ImportGenerator();
            ImportEnergyConsumer();
            ImportAnalog();
            ImportDiscrete();                      

            LogManager.Log("Loading elements and creating delta completed.", LogLevel.Info);
		}

		#region Import
        private void ImportGeographicalRegion()
        {
            SortedDictionary<string, object> cimGeographicalRegions = concreteModel.GetAllObjectsOfType("FTN.GeographicalRegion");
            if (cimGeographicalRegions != null)
            {
                foreach (KeyValuePair<string, object> cimGeographicalRegionPair in cimGeographicalRegions)
                {
                    FTN.GeographicalRegion cimGeographicalRegion = cimGeographicalRegionPair.Value as FTN.GeographicalRegion;

                    ResourceDescription rd = CreateGeographicalRegionDescription(cimGeographicalRegion);
                    if (rd != null)
                    {
                        delta.AddDeltaOperation(DeltaOpType.Insert, rd, true);
                        report.Report.Append("GeographicalRegion ID = ").Append(cimGeographicalRegion.ID).Append(" SUCCESSFULLY converted to GID = ").AppendLine(rd.Id.ToString());
                    }
                    else
                    {
                        report.Report.Append("GeographicalRegion ID = ").Append(cimGeographicalRegion.ID).AppendLine(" FAILED to be converted");
                    }
                }
                report.Report.AppendLine();
            }
        }
        private ResourceDescription CreateGeographicalRegionDescription(FTN.GeographicalRegion cimGeographicalRegion)
        {
            ResourceDescription rd = null;
            if (cimGeographicalRegion != null)
            {
                long gid = ModelCodeHelper.CreateGlobalId(0, (short)DMSType.GEOGRAPHICALREGION, importHelper.CheckOutIndexForDMSType(DMSType.GEOGRAPHICALREGION));
                rd = new ResourceDescription(gid);
                importHelper.DefineIDMapping(cimGeographicalRegion.ID, gid);

                ////populate ResourceDescription
                PowerTransformerConverter.PopulateGeographicalRegionProperties(cimGeographicalRegion, rd, importHelper, report);
            }
            return rd;
        }

        private void ImportSubstation()
        {
            SortedDictionary<string, object> cimSubstations = concreteModel.GetAllObjectsOfType("FTN.Substation");
            if (cimSubstations != null)
            {
                foreach (KeyValuePair<string, object> SubstationPair in cimSubstations)
                {
                    FTN.Substation cimSubstation = SubstationPair.Value as FTN.Substation;

                    ResourceDescription rd = CreateSubstationDescription(cimSubstation);
                    if (rd != null)
                    {
                        delta.AddDeltaOperation(DeltaOpType.Insert, rd, true);
                        report.Report.Append("Substation ID = ").Append(cimSubstation.ID).Append(" SUCCESSFULLY converted to GID = ").AppendLine(rd.Id.ToString());
                    }
                    else
                    {
                        report.Report.Append("Substation ID = ").Append(cimSubstation.ID).AppendLine(" FAILED to be converted");
                    }
                }
                report.Report.AppendLine();
            }
        }
        private ResourceDescription CreateSubstationDescription(FTN.Substation cimSubstation)
        {
            ResourceDescription rd = null;
            if (cimSubstation != null)
            {
                long gid = ModelCodeHelper.CreateGlobalId(0, (short)DMSType.SUBSTATION, importHelper.CheckOutIndexForDMSType(DMSType.SUBSTATION));
                rd = new ResourceDescription(gid);
                importHelper.DefineIDMapping(cimSubstation.ID, gid);

                ////populate ResourceDescription
                PowerTransformerConverter.PopulateSubstationProperties(cimSubstation, rd, importHelper, report);
            }
            return rd;
        }

        private void ImportAnalog()
        {
            SortedDictionary<string, object> cimAnalogs = concreteModel.GetAllObjectsOfType("FTN.Analog");
            if (cimAnalogs != null)
            {
                foreach (KeyValuePair<string, object> AnalogPair in cimAnalogs)
                {
                    FTN.Analog cimAnalog = AnalogPair.Value as FTN.Analog;

                    ResourceDescription rd = CreateAnalogDescription(cimAnalog);
                    if (rd != null)
                    {
                        delta.AddDeltaOperation(DeltaOpType.Insert, rd, true);
                        report.Report.Append("Analog ID = ").Append(cimAnalog.ID).Append(" SUCCESSFULLY converted to GID = ").AppendLine(rd.Id.ToString());
                    }
                    else
                    {
                        report.Report.Append("Analog ID = ").Append(cimAnalog.ID).AppendLine(" FAILED to be converted");
                    }
                }
                report.Report.AppendLine();
            }
        }
        private ResourceDescription CreateAnalogDescription(FTN.Analog cimAnalog)
        {
            ResourceDescription rd = null;
            if (cimAnalog != null)
            {
                long gid = ModelCodeHelper.CreateGlobalId(0, (short)DMSType.ANALOG, importHelper.CheckOutIndexForDMSType(DMSType.ANALOG));
                rd = new ResourceDescription(gid);
                importHelper.DefineIDMapping(cimAnalog.ID, gid);

                ////populate ResourceDescription
                PowerTransformerConverter.PopulateAnalogProperties(cimAnalog, rd, importHelper, report);
            }
            return rd;
        }

        private void ImportDiscrete()
        {
            SortedDictionary<string, object> cimDiscretes = concreteModel.GetAllObjectsOfType("FTN.Discrete");
            if (cimDiscretes != null)
            {
                foreach (KeyValuePair<string, object> DiscretePair in cimDiscretes)
                {
                    FTN.Discrete cimDiscrete = DiscretePair.Value as FTN.Discrete;

                    ResourceDescription rd = CreateDiscreteDescription(cimDiscrete);
                    if (rd != null)
                    {
                        if (ModelCodeHelper.ExtractEntityIdFromGlobalId(rd.Id) > 0)
                        {
                            delta.AddDeltaOperation(DeltaOpType.Update, rd, true);
                            report.Report.Append("EnergyConsumer ID = ").Append(cimDiscrete.ID).Append(" SUCCESSFULLY converted to GID = ").AppendLine(rd.Id.ToString());
                        }
                        else
                        {
                            delta.AddDeltaOperation(DeltaOpType.Insert, rd, true);
                            report.Report.Append("Discrete ID = ").Append(cimDiscrete.ID).Append(" SUCCESSFULLY converted to GID = ").AppendLine(rd.Id.ToString());
                        }
                    }
                    else
                    {
                        report.Report.Append("Discrete ID = ").Append(cimDiscrete.ID).AppendLine(" FAILED to be converted");
                    }
                }
                report.Report.AppendLine();
            }
        }
        private ResourceDescription CreateDiscreteDescription(FTN.Discrete cimDiscrete)
        {
            ResourceDescription rd = null;
            if (cimDiscrete != null)
            {
                long gid = ModelCodeHelper.CreateGlobalId(0, (short)DMSType.DISCRETE, importHelper.CheckOutIndexForDMSType(DMSType.DISCRETE));
                rd = new ResourceDescription(gid);
                importHelper.DefineIDMapping(cimDiscrete.ID, gid);

                ////populate ResourceDescription
                PowerTransformerConverter.PopulateDiscreteProperties(cimDiscrete, rd, importHelper, report);
            }
            return rd;
        }

        private void ImportGenerator()
        {
            SortedDictionary<string, object> cimGenerators = concreteModel.GetAllObjectsOfType("FTN.Generator");
            if (cimGenerators != null)
            {
                foreach (KeyValuePair<string, object> GeneratorPair in cimGenerators)
                {
                    FTN.Generator cimGenerator = GeneratorPair.Value as FTN.Generator;

                    ResourceDescription rd = CreateGeneratorDescription(cimGenerator);
                    if (rd != null)
                    {
                        delta.AddDeltaOperation(DeltaOpType.Insert, rd, true);
                        report.Report.Append("Generator ID = ").Append(cimGenerator.ID).Append(" SUCCESSFULLY converted to GID = ").AppendLine(rd.Id.ToString());
                    }
                    else
                    {
                        report.Report.Append("Generator ID = ").Append(cimGenerator.ID).AppendLine(" FAILED to be converted");
                    }
                }
                report.Report.AppendLine();
            }
        }
        private ResourceDescription CreateGeneratorDescription(FTN.Generator cimGenerator)
        {
            ResourceDescription rd = null;
            if (cimGenerator != null)
            {
                long gid = ModelCodeHelper.CreateGlobalId(0, (short)DMSType.GENERATOR, importHelper.CheckOutIndexForDMSType(DMSType.GENERATOR));
                rd = new ResourceDescription(gid);
                importHelper.DefineIDMapping(cimGenerator.ID, gid);

                ////populate ResourceDescription
                PowerTransformerConverter.PopulateGeneratorProperties(cimGenerator, rd, importHelper, report);
            }
            return rd;
        }

        private void ImportEnergyConsumer()
        {
            SortedDictionary<string, object> cimEnergyConsumers = concreteModel.GetAllObjectsOfType("FTN.EnergyConsumer");
            if (cimEnergyConsumers != null)
            {
                foreach (KeyValuePair<string, object> cimEnergyConsumersPair in cimEnergyConsumers)
                {
                    FTN.EnergyConsumer cimEnergyConsumer = cimEnergyConsumersPair.Value as FTN.EnergyConsumer;

                    ResourceDescription rd = CreateEnergyConsumerResourceDescription(cimEnergyConsumer);
                    if (rd != null)
                    {
                        delta.AddDeltaOperation(DeltaOpType.Insert, rd, true);
                        report.Report.Append("EnergyConsumer ID = ").Append(cimEnergyConsumer.ID).Append(" SUCCESSFULLY converted to GID = ").AppendLine(rd.Id.ToString());
                    }
                    else
                    {
                        report.Report.Append("EnergyConsumer ID = ").Append(cimEnergyConsumer.ID).AppendLine(" FAILED to be converted");
                    }
                }
                report.Report.AppendLine();
            }
        }

        private ResourceDescription CreateEnergyConsumerResourceDescription(FTN.EnergyConsumer cimEnergyConsumer)
        {
            ResourceDescription rd = null;
            if (cimEnergyConsumer != null)
            {
                long gid = ModelCodeHelper.CreateGlobalId(0, (short)DMSType.ENERGYCONSUMER, importHelper.CheckOutIndexForDMSType(DMSType.ENERGYCONSUMER));
                rd = new ResourceDescription(gid);
                importHelper.DefineIDMapping(cimEnergyConsumer.ID, gid);

                ////populate ResourceDescription
                PowerTransformerConverter.PopulateEnergyConsumerProperties(cimEnergyConsumer, rd, importHelper, report);
            }
            return rd;
        }


        #endregion Import
    }
}

