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
    [System.Xml.Serialization.XmlRootAttribute("AccountingCustomerParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class CustomerPartyType
    {

        private CustomerAssignedAccountIDType customerAssignedAccountIDField;

        private SupplierAssignedAccountIDType supplierAssignedAccountIDField;

        private AdditionalAccountIDType[] additionalAccountIDField;

        private PartyType partyField;

        private ContactType deliveryContactField;

        private ContactType accountingContactField;

        private ContactType buyerContactField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CustomerAssignedAccountIDType CustomerAssignedAccountID
        {
            get
            {
                return this.customerAssignedAccountIDField;
            }
            set
            {
                this.customerAssignedAccountIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SupplierAssignedAccountIDType SupplierAssignedAccountID
        {
            get
            {
                return this.supplierAssignedAccountIDField;
            }
            set
            {
                this.supplierAssignedAccountIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalAccountID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AdditionalAccountIDType[] AdditionalAccountID
        {
            get
            {
                return this.additionalAccountIDField;
            }
            set
            {
                this.additionalAccountIDField = value;
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

        /// <remarks/>
        public ContactType DeliveryContact
        {
            get
            {
                return this.deliveryContactField;
            }
            set
            {
                this.deliveryContactField = value;
            }
        }

        /// <remarks/>
        public ContactType AccountingContact
        {
            get
            {
                return this.accountingContactField;
            }
            set
            {
                this.accountingContactField = value;
            }
        }

        /// <remarks/>
        public ContactType BuyerContact
        {
            get
            {
                return this.buyerContactField;
            }
            set
            {
                this.buyerContactField = value;
            }
        }
    }
}
