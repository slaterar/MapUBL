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
    [System.Xml.Serialization.XmlRootAttribute("ContractingParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class ContractingPartyType
    {

        private BuyerProfileURIType buyerProfileURIField;

        private ContractingPartyTypeType[] contractingPartyType1Field;

        private ContractingActivityType[] contractingActivityField;

        private PartyType partyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BuyerProfileURIType BuyerProfileURI
        {
            get
            {
                return this.buyerProfileURIField;
            }
            set
            {
                this.buyerProfileURIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ContractingPartyType")]
        public ContractingPartyTypeType[] ContractingPartyType1
        {
            get
            {
                return this.contractingPartyType1Field;
            }
            set
            {
                this.contractingPartyType1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ContractingActivity")]
        public ContractingActivityType[] ContractingActivity
        {
            get
            {
                return this.contractingActivityField;
            }
            set
            {
                this.contractingActivityField = value;
            }
        }

        /// <remarks/>
        public PartyType Party
        {
            get
            {
                return this.partyField;
            }
            set
            {
                this.partyField = value;
            }
        }
    }
}
