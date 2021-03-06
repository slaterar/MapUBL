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
    [System.Xml.Serialization.XmlRootAttribute("PricingReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class PricingReferenceType
    {

        private ItemLocationQuantityType originalItemLocationQuantityField;

        private PriceType[] alternativeConditionPriceField;

        /// <remarks/>
        public ItemLocationQuantityType OriginalItemLocationQuantity
        {
            get
            {
                return this.originalItemLocationQuantityField;
            }
            set
            {
                this.originalItemLocationQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AlternativeConditionPrice")]
        public PriceType[] AlternativeConditionPrice
        {
            get
            {
                return this.alternativeConditionPriceField;
            }
            set
            {
                this.alternativeConditionPriceField = value;
            }
        }
    }
}
