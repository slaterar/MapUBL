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
    [System.Xml.Serialization.XmlRootAttribute("ImmobilizedSecurity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class ImmobilizedSecurityType
    {

        private ImmobilizationCertificateIDType immobilizationCertificateIDField;

        private SecurityIDType securityIDField;

        private IssueDateType issueDateField;

        private FaceValueAmountType faceValueAmountField;

        private MarketValueAmountType marketValueAmountField;

        private SharesNumberQuantityType sharesNumberQuantityField;

        private PartyType issuerPartyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ImmobilizationCertificateIDType ImmobilizationCertificateID
        {
            get
            {
                return this.immobilizationCertificateIDField;
            }
            set
            {
                this.immobilizationCertificateIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SecurityIDType SecurityID
        {
            get
            {
                return this.securityIDField;
            }
            set
            {
                this.securityIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IssueDateType IssueDate
        {
            get
            {
                return this.issueDateField;
            }
            set
            {
                this.issueDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FaceValueAmountType FaceValueAmount
        {
            get
            {
                return this.faceValueAmountField;
            }
            set
            {
                this.faceValueAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MarketValueAmountType MarketValueAmount
        {
            get
            {
                return this.marketValueAmountField;
            }
            set
            {
                this.marketValueAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SharesNumberQuantityType SharesNumberQuantity
        {
            get
            {
                return this.sharesNumberQuantityField;
            }
            set
            {
                this.sharesNumberQuantityField = value;
            }
        }

        /// <remarks/>
        public PartyType IssuerParty
        {
            get
            {
                return this.issuerPartyField;
            }
            set
            {
                this.issuerPartyField = value;
            }
        }
    }
}
