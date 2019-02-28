﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sife.MapXmlUBL
{

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WebsiteURIType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VesselIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VersionIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VariantIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ValidatorIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UpperOrangeHazardPlacardIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UUIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(URIType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UBLVersionIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TransportationServiceDetailsURIType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TransportExecutionPlanReferenceIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TrainIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TrackingIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TraceIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TenderEnvelopeIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SupplierAssignedAccountIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SuccessiveSequenceIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SubscriberIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SpecificationIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SignatureIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ShippingOrderIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SerialIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SequenceNumberIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SequenceIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SellerEventIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SecurityIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SchemeURIType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SalesOrderLineIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SalesOrderIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RevisedForecastLineIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RequiredCustomsIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RequestForQuotationLineIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ReleaseIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RegistrationNationalityIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RegistrationIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ReferencedConsignmentIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ReferenceIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RailCarIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RadioCallSignIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProfileIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProfileExecutionIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProductTraceIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PrimaryAccountNumberIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PreviousVersionIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PreviousJobIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PrepaidPaymentReferenceIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PerformingCarrierAssignedIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PaymentTermsDetailsURIType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PaymentMeansIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PaymentIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ParentDocumentVersionIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ParentDocumentLineReferenceIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ParentDocumentIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OriginalJobIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OriginalContractingSystemIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OpenTenderIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OntologyURIType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NetworkIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NationalityIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MarkingIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LowerOrangeHazardPlacardIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LotNumberIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LogoReferenceIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LocationIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LoadingSequenceIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LineIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LicensePlateIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LanguageIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(JourneyIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IssuerIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IssueNumberIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InstructionIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InformationURIType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ImmobilizationCertificateIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IdentificationIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HazardClassIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FreightForwarderAssignedIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExtendedIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExchangeMarketIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EndpointIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EconomicOperatorRegistryURIType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DocumentIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CustomizationIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CustomerAssignedAccountIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ContractedCarrierAssignedIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ContractFolderIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConsumptionReportIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConsumptionIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConsignorAssignedIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConsigneeAssignedIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CompanyIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ChipApplicationIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CarrierAssignedIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CV2IDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BuyerProfileURIType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BuyerEventIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BusinessIdentityEvidenceIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BusinessClassificationEvidenceIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BrokerAssignedIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BarcodeSymbologyIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AwardingCriterionIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AuctionURIType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AttributeIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AircraftIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AgencyIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdditionalAccountIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AccountIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExtensionVersionIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExtensionURIType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExtensionAgencyURIType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExtensionAgencyIDType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "IdentifierType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    public partial class IdentifierType1 : IdentifierType
    {
    }
}
