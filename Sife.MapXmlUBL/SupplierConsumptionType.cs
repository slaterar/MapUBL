using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sife.MapXmlUBL
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("SupplierConsumption", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class SupplierConsumptionType
    {

        private DescriptionType[] descriptionField;

        private PartyType utilitySupplierPartyField;

        private PartyType utilityCustomerPartyField;

        private ConsumptionType consumptionField;

        private ContractType contractField;

        private ConsumptionLineType[] consumptionLineField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DescriptionType[] Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public PartyType UtilitySupplierParty
        {
            get
            {
                return this.utilitySupplierPartyField;
            }
            set
            {
                this.utilitySupplierPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType UtilityCustomerParty
        {
            get
            {
                return this.utilityCustomerPartyField;
            }
            set
            {
                this.utilityCustomerPartyField = value;
            }
        }

        /// <remarks/>
        public ConsumptionType Consumption
        {
            get
            {
                return this.consumptionField;
            }
            set
            {
                this.consumptionField = value;
            }
        }

        /// <remarks/>
        public ContractType Contract
        {
            get
            {
                return this.contractField;
            }
            set
            {
                this.contractField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ConsumptionLine")]
        public ConsumptionLineType[] ConsumptionLine
        {
            get
            {
                return this.consumptionLineField;
            }
            set
            {
                this.consumptionLineField = value;
            }
        }
    }
}
