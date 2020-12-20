using FTN.Common;
using FTN.Services.NetworkModelService.DataModel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FTN.Services.NetworkModelService.DataModel.Wires
{
    public class Terminal : IdentifiedObject
    {
        public Terminal(long globalId) : base(globalId)
        {
        }


        private long conductingEquipment;
        private long connectivityNode;

        public long ConnectivityNode
        {
            get { return connectivityNode; }
            set { connectivityNode = value; }
        }

        public long ConductingEquipment
        {
            get { return conductingEquipment; }
            set { conductingEquipment = value; }
        }



        public override bool Equals(object obj)
        {
            if (base.Equals(obj))
            {
                Terminal x = (Terminal)obj;
                return ((x.conductingEquipment == this.conductingEquipment) &&
                        (x.connectivityNode == this.connectivityNode));
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #region IAccess implementation

        public override bool HasProperty(ModelCode property)
        {
            switch (property)
            {
                case ModelCode.TERMINAL_CONEQ:
                case ModelCode.TERMINAL_CONNODE:
                    return true;

                default:
                    return base.HasProperty(property);
            }
        }

        public override void GetProperty(Property property)
        {
            switch (property.Id)
            {
                case ModelCode.TERMINAL_CONEQ:
                    property.SetValue(conductingEquipment);
                    break;
                case ModelCode.TERMINAL_CONNODE:
                    property.SetValue(connectivityNode);
                    break;

                default:
                    base.GetProperty(property);
                    break;
            }
        }

        public override void SetProperty(Property property)
        {
            switch (property.Id)
            {
                case ModelCode.TERMINAL_CONEQ:
                    conductingEquipment = property.AsReference();
                    break;
                case ModelCode.TERMINAL_CONNODE:
                    connectivityNode = property.AsReference();
                    break;

                default:
                    base.SetProperty(property);
                    break;
            }
        }

        #endregion IAccess implementation

        #region IReference implementation

        public override bool IsReferenced
        {
            get
            {
               return base.IsReferenced;
            }
        }


        public override void GetReferences(Dictionary<ModelCode, List<long>> references, TypeOfReference refType)
        {
            if (conductingEquipment != 0 && (refType == TypeOfReference.Target || refType == TypeOfReference.Both))
            {
                references[ModelCode.TERMINAL_CONEQ] = new List<long>();
                references[ModelCode.TERMINAL_CONEQ].Add(conductingEquipment);
            }
            if (connectivityNode != 0 && (refType == TypeOfReference.Target || refType == TypeOfReference.Both))
            {
                references[ModelCode.TERMINAL_CONNODE] = new List<long>();
                references[ModelCode.TERMINAL_CONNODE].Add(connectivityNode);
            }

            base.GetReferences(references, refType);
        }


        public override void AddReference(ModelCode referenceId, long globalId)
        {
            switch (referenceId)
            {

                default:
                    base.AddReference(referenceId, globalId);
                    break;
            }
        }

        public override void RemoveReference(ModelCode referenceId, long globalId)
        {
            switch (referenceId)
            {

                default:
                    base.RemoveReference(referenceId, globalId);
                    break;
            }
        }

        #endregion IReference implementation	
    }
}
