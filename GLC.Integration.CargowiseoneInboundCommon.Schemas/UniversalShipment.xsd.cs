namespace GLC.Integration.CargowiseoneInboundCommon.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://www.cargowise.com/Schemas/Universal/2011/11",@"UniversalShipment")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"UniversalShipment"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"GLC.Integration.CargowiseoneInboundCommon.Schemas.UniversalCommon", typeof(global::GLC.Integration.CargowiseoneInboundCommon.Schemas.UniversalCommon))]
    public sealed class UniversalShipment : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://www.cargowise.com/Schemas/Universal/2011/11"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" elementFormDefault=""qualified"" targetNamespace=""http://www.cargowise.com/Schemas/Universal/2011/11"" version=""1.1"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:include schemaLocation=""GLC.Integration.CargowiseoneInboundCommon.Schemas.UniversalCommon"" />
  <xs:element name=""UniversalShipment"" type=""UniversalShipmentData"" />
  <xs:complexType name=""UniversalShipmentData"">
    <xs:all>
      <xs:element name=""Shipment"" type=""Shipment"" />
    </xs:all>
    <xs:attribute name=""version"" type=""xs:token"" />
  </xs:complexType>
  <xs:complexType name=""Shipment"">
    <xs:all>
      <xs:element minOccurs=""0"" name=""DataContext"" type=""DataContext"" />
      <xs:element minOccurs=""0"" name=""ActualChargeable"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""AdditionalTerms"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""50"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""AgentsReference"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""AviationSecurityInspectionType"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""AWBServiceLevel"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""BookingConfirmationReference"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Branch"" type=""Branch"" />
      <xs:element minOccurs=""0"" name=""CarrierCorrectedChargeable"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""CarrierCorrectedVolume"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""CarrierCorrectedVolumeUnit"" type=""UnitOfVolume"" />
      <xs:element minOccurs=""0"" name=""CarrierCorrectedWeight"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""CarrierCorrectedWeightUnit"" type=""UnitOfWeight"" />
      <xs:element minOccurs=""0"" name=""CarrierServiceLevel"" type=""ServiceLevel"" />
      <xs:element minOccurs=""0"" name=""CartageWaybillNumber"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""20"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CFSReference"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""20"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""ChargeableRate"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""CoLoadBookingConfirmationReference"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CoLoadMasterBillNumber"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CommercialInfo"" type=""CommercialInfo"" />
      <xs:element minOccurs=""0"" name=""ConsigneeBussinessNumber"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""15"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""ConsigneeIdentifier"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""11"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""ConsignorIdentifier"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""11"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""ConsolCosts"">
        <xs:complexType>
          <xs:all>
            <xs:element minOccurs=""0"" name=""ConsolCostLineCollection"">
              <xs:complexType>
                <xs:sequence>
                  <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ConsolCostLine"">
                    <xs:complexType>
                      <xs:all>
                        <xs:element minOccurs=""0"" name=""ApportionmentMethod"">
                          <xs:simpleType>
                            <xs:restriction base=""xs:string"">
                              <xs:maxLength value=""3"" />
                            </xs:restriction>
                          </xs:simpleType>
                        </xs:element>
                        <xs:element minOccurs=""0"" name=""ApportionToSubShipments"" type=""xs:boolean"" />
                        <xs:element minOccurs=""0"" name=""ChargeCode"" type=""ChargeCode"" />
                        <xs:element minOccurs=""0"" name=""ChargeCodeGroup"" type=""CodeDescriptionPair"" />
                        <xs:element minOccurs=""0"" name=""CostAPInvoiceNumber"">
                          <xs:simpleType>
                            <xs:restriction base=""xs:string"">
                              <xs:maxLength value=""38"" />
                            </xs:restriction>
                          </xs:simpleType>
                        </xs:element>
                        <xs:element minOccurs=""0"" name=""CostDueDate"" type=""emptiable_dateTime"" />
                        <xs:element minOccurs=""0"" name=""CostExchangeRate"" type=""xs:decimal"" />
                        <xs:element minOccurs=""0"" name=""CostGSTVATID"" type=""TaxID"" />
                        <xs:element minOccurs=""0"" name=""CostInvoiceDate"" type=""emptiable_dateTime"" />
                        <xs:element minOccurs=""0"" name=""CostIsPosted"" type=""xs:boolean"" />
                        <xs:element minOccurs=""0"" name=""CostLocalAmount"" type=""xs:decimal"" />
                        <xs:element minOccurs=""0"" name=""CostOSAmount"" type=""xs:decimal"" />
                        <xs:element minOccurs=""0"" name=""CostOSCurrency"" type=""Currency"" />
                        <xs:element minOccurs=""0"" name=""CostOSGSTVATAmount"" type=""xs:decimal"" />
                        <xs:element minOccurs=""0"" name=""Creditor"" type=""OrganizationReference"" />
                        <xs:element minOccurs=""0"" name=""ExternalCreditorCode"">
                          <xs:simpleType>
                            <xs:restriction base=""xs:string"">
                              <xs:maxLength value=""25"" />
                            </xs:restriction>
                          </xs:simpleType>
                        </xs:element>
                        <xs:element minOccurs=""0"" name=""GovernmentReportingCostChargeCode"">
                          <xs:simpleType>
                            <xs:restriction base=""xs:string"">
                              <xs:maxLength value=""20"" />
                            </xs:restriction>
                          </xs:simpleType>
                        </xs:element>
                        <xs:element minOccurs=""0"" name=""GovernmentReportingSellChargeCode"">
                          <xs:simpleType>
                            <xs:restriction base=""xs:string"">
                              <xs:maxLength value=""20"" />
                            </xs:restriction>
                          </xs:simpleType>
                        </xs:element>
                        <xs:element minOccurs=""0"" name=""ImportMetaData"" type=""ImportMetaData"" />
                        <xs:element minOccurs=""0"" name=""IncludeOnCollectInvoice"" type=""xs:boolean"" />
                        <xs:element minOccurs=""0"" name=""PrepaidCollectFilter"">
                          <xs:simpleType>
                            <xs:restriction base=""xs:string"">
                              <xs:maxLength value=""3"" />
                            </xs:restriction>
                          </xs:simpleType>
                        </xs:element>
                        <xs:element minOccurs=""0"" name=""SupplierReference"">
                          <xs:simpleType>
                            <xs:restriction base=""xs:string"">
                              <xs:maxLength value=""38"" />
                            </xs:restriction>
                          </xs:simpleType>
                        </xs:element>
                        <xs:element minOccurs=""0"" name=""CostRatingBasisCollection"">
                          <xs:complexType>
                            <xs:sequence>
                              <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CostRatingBasis"" type=""RatingBasis"" />
                            </xs:sequence>
                          </xs:complexType>
                        </xs:element>
                      </xs:all>
                    </xs:complexType>
                  </xs:element>
                </xs:sequence>
              </xs:complexType>
            </xs:element>
          </xs:all>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""ConsolidatedCargoStatus"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""ContainerCount"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""ContainerMode"" type=""ContainerMode"" />
      <xs:element minOccurs=""0"" name=""CountryOfSupply"" type=""Country"" />
      <xs:element minOccurs=""0"" name=""CustomsBroker"" type=""Staff"" />
      <xs:element minOccurs=""0"" name=""CustomsContainerMode"" type=""ContainerMode"" />
      <xs:element minOccurs=""0"" name=""CustomsDischargePort"" type=""CodeDescriptionPair10Char"" />
      <xs:element minOccurs=""0"" name=""CustomsLoadPort"" type=""CodeDescriptionPair10Char"" />
      <xs:element minOccurs=""0"" name=""CustomsOffice"" type=""CodeDescriptionPair10Char"" />
      <xs:element minOccurs=""0"" name=""CustomsProfileIdentifier"" type=""ValueTypePair"" />
      <xs:element minOccurs=""0"" name=""CustomsValuationPort"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""DeclarantType"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""DefermentAccountNumber"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""DeliveryMode"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""DocumentedChargeable"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""DocumentedVolume"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""DocumentedWeight"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""EFTMode"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""EntryStatus"" type=""EntryStatus"" />
      <xs:element minOccurs=""0"" name=""ExportGoodsType"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""FirstBuyerContact"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Folio"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""20"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""FreightRate"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""FreightRateCurrency"" type=""Currency"" />
      <xs:element minOccurs=""0"" name=""GoodsDescription"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""2560"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""GoodsOrigin"" type=""Country"" />
      <xs:element minOccurs=""0"" name=""GoodsValue"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""GoodsValueCurrency"" type=""Currency"" />
      <xs:element minOccurs=""0"" name=""HasProhibitedPackaging"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""HBLAWBChargesDisplay"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""HBLContainerPackModeOverride"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""9"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""InsuranceValue"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""InsuranceValueCurrency"" type=""Currency"" />
      <xs:element minOccurs=""0"" name=""InterimReceiptNumber"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""IsAuthorizedToLeave"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""IsBooking"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""IsCancelled"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""IsCFSRegistered"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""IsDirectBooking"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""IsFinalManifest"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""IsForwardRegistered"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""IsHazardous"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""IsLastMileDeliverySelfBooked"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""IsNeutralMaster"" type=""IsNeutralMaster"" />
      <xs:element minOccurs=""0"" name=""IsPersonalEffects"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""IsShipping"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""IsSignatureRequired"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""IsSplitShipment"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""JobCosting"" type=""JobCosting"" />
      <xs:element minOccurs=""0"" name=""LloydsIMO"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""7"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""LocalTransportEquipmentNeeded"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""LocalTransportJobType"" type=""CodeDescriptionPair4Char"" />
      <xs:element minOccurs=""0"" name=""LocationAtClearance"" type=""CodeDescriptionPair35Char"" />
      <xs:element minOccurs=""0"" name=""ManifestedChargeable"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""ManifestedVolume"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""ManifestedWeight"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""MergeBy"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""MessageStatus"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""MessageSubType"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""MessageType"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""MessagingApplicationCode"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""NoCopyBills"" type=""xs:unsignedByte"" />
      <xs:element minOccurs=""0"" name=""NoOriginalBills"" type=""xs:unsignedByte"" />
      <xs:element minOccurs=""0"" name=""OperationalStatus"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""OuterPacks"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""OuterPacksPackageType"" type=""PackageType"" />
      <xs:element minOccurs=""0"" name=""OwnerRef"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""PackingOrder"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""PaymentMethod"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""PickupMode"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""PlaceOfDelivery"" type=""UNLOCO"" />
      <xs:element minOccurs=""0"" name=""PlaceOfIssue"" type=""UNLOCO"" />
      <xs:element minOccurs=""0"" name=""PlaceOfReceipt"" type=""UNLOCO"" />
      <xs:element minOccurs=""0"" name=""PortFirstForeign"" type=""UNLOCO"" />
      <xs:element minOccurs=""0"" name=""PortLastForeign"" type=""UNLOCO"" />
      <xs:element minOccurs=""0"" name=""PortMessaging"" type=""PortMessaging"" />
      <xs:element minOccurs=""0"" name=""PortOfDestination"" type=""UNLOCO"" />
      <xs:element minOccurs=""0"" name=""PortOfDischarge"" type=""UNLOCO"" />
      <xs:element minOccurs=""0"" name=""PortOfFirstArrival"" type=""UNLOCO"" />
      <xs:element minOccurs=""0"" name=""PortOfLoading"" type=""UNLOCO"" />
      <xs:element minOccurs=""0"" name=""PortOfOrigin"" type=""UNLOCO"" />
      <xs:element minOccurs=""0"" name=""QuoteNumber"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""20"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""RatingTransportMode"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""ReleaseType"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""RequiresRefrigeration"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""ScreeningStatus"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""SecondBuyerContact"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""ServiceLevel"" type=""ServiceLevel"" />
      <xs:element minOccurs=""0"" name=""ShipmentIncoTerm"" type=""IncoTerm"" />
      <xs:element minOccurs=""0"" name=""ShipmentStatus"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""ShipmentSubType"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""ShipmentType"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""ShippedOnBoard"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""ShipperCODAmount"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""ShipperCODPayMethod"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""SubLocationAtClearance"" type=""CodeDescriptionPair10Char"" />
      <xs:element minOccurs=""0"" name=""TotalNoOfPacks"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""TotalNoOfPacksDecimal"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""TotalNoOfPacksPackageType"" type=""PackageType"" />
      <xs:element minOccurs=""0"" name=""TotalNoOfPieces"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""TotalPreallocatedChargeable"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""TotalPreallocatedVolume"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""TotalPreallocatedVolumeUnit"" type=""UnitOfVolume"" />
      <xs:element minOccurs=""0"" name=""TotalPreallocatedWeight"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""TotalPreallocatedWeightUnit"" type=""UnitOfWeight"" />
      <xs:element minOccurs=""0"" name=""TotalVolume"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""TotalVolumeUnit"" type=""UnitOfVolume"" />
      <xs:element minOccurs=""0"" name=""TotalWeight"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""TotalWeightUnit"" type=""UnitOfWeight"" />
      <xs:element minOccurs=""0"" name=""TranshipToOtherCFS"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""TransportBookingDirection"">
        <xs:complexType>
          <xs:all>
            <xs:element minOccurs=""1"" name=""Code"">
              <xs:simpleType>
                <xs:restriction base=""xs:string"">
                  <xs:maxLength value=""3"" />
                </xs:restriction>
              </xs:simpleType>
            </xs:element>
            <xs:element minOccurs=""0"" name=""Description"">
              <xs:simpleType>
                <xs:restriction base=""xs:string"">
                  <xs:maxLength value=""35"" />
                </xs:restriction>
              </xs:simpleType>
            </xs:element>
          </xs:all>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""TransportMode"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""TransportNationality"" type=""Country"" />
      <xs:element minOccurs=""0"" name=""VendorIdentifier"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""15"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""VesselCountryOfRegistration"" type=""Country"" />
      <xs:element minOccurs=""0"" name=""VesselName"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""VoyageFlightNo"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""10"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""WarehouseLocation"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""10"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""WarehouseReleaseStatus"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""WayBillNumber"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""WayBillType"" type=""WayBillType"" />
      <xs:element minOccurs=""0"" name=""CarrierAccount"">
        <xs:complexType>
          <xs:all>
            <xs:element minOccurs=""0"" name=""AccountNumber"">
              <xs:simpleType>
                <xs:restriction base=""xs:string"">
                  <xs:maxLength value=""10"" />
                </xs:restriction>
              </xs:simpleType>
            </xs:element>
            <xs:element minOccurs=""0"" name=""DepotID"">
              <xs:simpleType>
                <xs:restriction base=""xs:string"">
                  <xs:maxLength value=""20"" />
                </xs:restriction>
              </xs:simpleType>
            </xs:element>
            <xs:element minOccurs=""0"" name=""MerchantNumber"">
              <xs:simpleType>
                <xs:restriction base=""xs:string"">
                  <xs:maxLength value=""20"" />
                </xs:restriction>
              </xs:simpleType>
            </xs:element>
          </xs:all>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CarrierDocumentsOverride"">
        <xs:complexType>
          <xs:all>
            <xs:element minOccurs=""0"" name=""AWBHeader"">
              <xs:complexType>
                <xs:all>
                  <xs:element minOccurs=""0"" name=""AgentAccountNo"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""14"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""AgentIATACode"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""11"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""AgentName"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""35"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""AgentPlace"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""17"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""AirportOfDepartureAndRequestRouteText"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""35"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""AirportOfDestinationCode"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""3"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""AirportOfDestinationText"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""35"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""AlsoNotify"" type=""AWBParty"" />
                  <xs:element minOccurs=""0"" name=""AmountOfInsurance"" type=""xs:decimal"" />
                  <xs:element minOccurs=""0"" name=""AsAgreedOn1stAWBSet"" type=""xs:boolean"" />
                  <xs:element minOccurs=""0"" name=""AsAgreedOn2ndAWBSet"" type=""xs:boolean"" />
                  <xs:element minOccurs=""0"" name=""AsAgreedTypeOn1stAWBSet"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""3"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""AsAgreedTypeOn2ndAWBSet"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""3"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""AWBIssueDate"" type=""emptiable_dateTime"" />
                  <xs:element minOccurs=""0"" name=""AWBIssuePlace"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""17"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""AWBIssuerApprovedExporterNumber"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""70"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""AWBIssuerExtraInfo"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""64"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""AWBIssuerSignature"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""35"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""AWBNumber"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""35"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""AWBType"" type=""CodeDescriptionPair"" />
                  <xs:element minOccurs=""0"" name=""CargoSecurityDeclaration"">
                    <xs:complexType>
                      <xs:all>
                        <xs:element minOccurs=""0"" name=""AdditionalScreeningMethods"">
                          <xs:simpleType>
                            <xs:restriction base=""xs:string"">
                              <xs:maxLength value=""256"" />
                            </xs:restriction>
                          </xs:simpleType>
                        </xs:element>
                        <xs:element minOccurs=""0"" name=""AgentApprovalCategory"" type=""CodeDescriptionPair"" />
                        <xs:element minOccurs=""0"" name=""AgentApprovalCountry"" type=""Country"" />
                        <xs:element minOccurs=""0"" name=""AgentApprovalExpiryDate"" type=""emptiable_dateTime"" />
                        <xs:element minOccurs=""0"" name=""AgentApprovalNumber"">
                          <xs:simpleType>
                            <xs:restriction base=""xs:string"">
                              <xs:maxLength value=""15"" />
                            </xs:restriction>
                          </xs:simpleType>
                        </xs:element>
                        <xs:element minOccurs=""0"" name=""SecurityStatus"" type=""CodeDescriptionPair"" />
                        <xs:element minOccurs=""0"" name=""SecurityStatusIssueDate"" type=""emptiable_dateTime"" />
                        <xs:element minOccurs=""0"" name=""SecurityStatusIssuedBy"">
                          <xs:simpleType>
                            <xs:restriction base=""xs:string"">
                              <xs:maxLength value=""50"" />
                            </xs:restriction>
                          </xs:simpleType>
                        </xs:element>
                        <xs:element minOccurs=""0"" name=""TSASecurityStatement"">
                          <xs:simpleType>
                            <xs:restriction base=""xs:string"">
                              <xs:maxLength value=""512"" />
                            </xs:restriction>
                          </xs:simpleType>
                        </xs:element>
                        <xs:element minOccurs=""0"" name=""GroundsForExemptionCollection"">
                          <xs:complexType>
                            <xs:sequence>
                              <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""GroundsForExemption"" type=""CodeDescriptionPair4Char"" />
                            </xs:sequence>
                          </xs:complexType>
                        </xs:element>
                        <xs:element minOccurs=""0"" name=""ReceivedFromShipperCollection"">
                          <xs:complexType>
                            <xs:sequence>
                              <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ReceivedFromShipper"" type=""ReceivedFromShipper"" />
                            </xs:sequence>
                          </xs:complexType>
                        </xs:element>
                        <xs:element minOccurs=""0"" name=""ScreeningMethodCollection"">
                          <xs:complexType>
                            <xs:sequence>
                              <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ScreeningMethod"" type=""CodeDescriptionPair"" />
                            </xs:sequence>
                          </xs:complexType>
                        </xs:element>
                      </xs:all>
                    </xs:complexType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""ChargesPayment"" type=""CodeDescriptionPair2Char"" />
                  <xs:element minOccurs=""0"" name=""Consignee"" type=""AWBParty"" />
                  <xs:element minOccurs=""0"" name=""Currency"" type=""Currency"" />
                  <xs:element minOccurs=""0"" name=""ForwardingAgentReference"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""20"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""HandlingInformation"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""2147483647"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""IssuedByAddress1"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""50"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""IssuedByAddress2"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""50"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""IssuedByName"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""50"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""NetRateCode"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""10"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""OptionalShippingInformation1"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""15"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""OptionalShippingInformation2"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""15"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""OriginCode"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""3"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""OtherChargesPayment"" type=""CodeDescriptionPair"" />
                  <xs:element minOccurs=""0"" name=""Requested1stCarrier"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""2"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""Requested1stFlight"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""5"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""Requested1stFlightDate"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""2"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""Requested2ndCarrier"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""2"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""Requested2ndFlight"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""5"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""Requested2ndFlightDate"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""2"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""Routing1stBy"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""2"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""Routing1stTo"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""3"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""Routing2ndBy"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""2"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""Routing2ndTo"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""3"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""Routing3rdBy"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""2"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""Routing3rdTo"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""3"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""Shipper"" type=""AWBParty"" />
                  <xs:element minOccurs=""0"" name=""ShipperExtraInfoLine1"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""64"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""ShipperExtraInfoLine2"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""64"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""ShippersLoadAndCount"" type=""xs:short"" />
                  <xs:element minOccurs=""0"" name=""ShippersSignature"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""35"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""SpecialHandlingCode"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""3"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""TotalTaxesCollect"" type=""xs:decimal"" />
                  <xs:element minOccurs=""0"" name=""TotalTaxesPrepaid"" type=""xs:decimal"" />
                  <xs:element minOccurs=""0"" name=""TotalValuationCollect"" type=""xs:decimal"" />
                  <xs:element minOccurs=""0"" name=""TotalValuationPrepaid"" type=""xs:decimal"" />
                  <xs:element minOccurs=""0"" name=""ValueForCarriage"" type=""xs:decimal"" />
                  <xs:element minOccurs=""0"" name=""ValueForCustoms"" type=""xs:decimal"" />
                  <xs:element minOccurs=""0"" name=""WeightChargesPayment"" type=""CodeDescriptionPair"" />
                  <xs:element minOccurs=""0"" name=""AccountingInfoCollection"">
                    <xs:complexType>
                      <xs:sequence>
                        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""AccountingInfo"">
                          <xs:complexType>
                            <xs:all>
                              <xs:element minOccurs=""0"" name=""Information"">
                                <xs:simpleType>
                                  <xs:restriction base=""xs:string"">
                                    <xs:maxLength value=""34"" />
                                  </xs:restriction>
                                </xs:simpleType>
                              </xs:element>
                              <xs:element minOccurs=""0"" name=""Type"" type=""CodeDescriptionPair"" />
                            </xs:all>
                          </xs:complexType>
                        </xs:element>
                      </xs:sequence>
                    </xs:complexType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""OtherChargesCollection"">
                    <xs:complexType>
                      <xs:sequence>
                        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""OtherCharges"">
                          <xs:complexType>
                            <xs:all>
                              <xs:element minOccurs=""0"" name=""Amount"" type=""xs:decimal"" />
                              <xs:element minOccurs=""0"" name=""ChargeCode"" type=""CodeDescriptionPair2Char"" />
                              <xs:element minOccurs=""0"" name=""Description"">
                                <xs:simpleType>
                                  <xs:restriction base=""xs:string"">
                                    <xs:maxLength value=""35"" />
                                  </xs:restriction>
                                </xs:simpleType>
                              </xs:element>
                              <xs:element minOccurs=""0"" name=""EntitlementDue"" type=""CodeDescriptionPair1Char"" />
                              <xs:element minOccurs=""0"" name=""PrepaidCollect"" type=""CodeDescriptionPair"" />
                            </xs:all>
                          </xs:complexType>
                        </xs:element>
                      </xs:sequence>
                    </xs:complexType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""RateLineCollection"">
                    <xs:complexType>
                      <xs:sequence>
                        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""RateLine"">
                          <xs:complexType>
                            <xs:all>
                              <xs:element minOccurs=""0"" name=""ChargeableWeight"" type=""xs:decimal"" />
                              <xs:element minOccurs=""0"" name=""CommodityItem"">
                                <xs:simpleType>
                                  <xs:restriction base=""xs:string"">
                                    <xs:maxLength value=""7"" />
                                  </xs:restriction>
                                </xs:simpleType>
                              </xs:element>
                              <xs:element minOccurs=""0"" name=""Consolidation"">
                                <xs:simpleType>
                                  <xs:restriction base=""xs:string"">
                                    <xs:maxLength value=""35"" />
                                  </xs:restriction>
                                </xs:simpleType>
                              </xs:element>
                              <xs:element minOccurs=""0"" name=""CountryOfOrigin"" type=""Country"" />
                              <xs:element minOccurs=""0"" name=""Dimensions"">
                                <xs:complexType>
                                  <xs:all>
                                    <xs:element minOccurs=""0"" name=""Count"" type=""xs:int"" />
                                    <xs:element minOccurs=""0"" name=""Height"" type=""xs:int"" />
                                    <xs:element minOccurs=""0"" name=""Length"" type=""xs:int"" />
                                    <xs:element minOccurs=""0"" name=""Unit"" type=""CodeDescriptionPair"" />
                                    <xs:element minOccurs=""0"" name=""Width"" type=""xs:int"" />
                                  </xs:all>
                                </xs:complexType>
                              </xs:element>
                              <xs:element minOccurs=""0"" name=""GoodsDescription"">
                                <xs:simpleType>
                                  <xs:restriction base=""xs:string"">
                                    <xs:maxLength value=""35"" />
                                  </xs:restriction>
                                </xs:simpleType>
                              </xs:element>
                              <xs:element minOccurs=""0"" name=""GrossWeight"" type=""xs:decimal"" />
                              <xs:element minOccurs=""0"" name=""HarmonizedCommodityCode"">
                                <xs:simpleType>
                                  <xs:restriction base=""xs:string"">
                                    <xs:maxLength value=""35"" />
                                  </xs:restriction>
                                </xs:simpleType>
                              </xs:element>
                              <xs:element minOccurs=""0"" name=""LineNumber"" type=""xs:int"" />
                              <xs:element minOccurs=""0"" name=""NatureAndQtyOfGoodsType"" type=""CodeDescriptionPair1Char"" />
                              <xs:element minOccurs=""0"" name=""NoOfPiecesOrRCP"">
                                <xs:simpleType>
                                  <xs:restriction base=""xs:string"">
                                    <xs:maxLength value=""4"" />
                                  </xs:restriction>
                                </xs:simpleType>
                              </xs:element>
                              <xs:element minOccurs=""0"" name=""RateChargeOrDiscount"" type=""xs:decimal"" />
                              <xs:element minOccurs=""0"" name=""RateClass"" type=""CodeDescriptionPair1Char"" />
                              <xs:element minOccurs=""0"" name=""ShippersLoadAndCount"" type=""xs:int"" />
                              <xs:element minOccurs=""0"" name=""TotalCharge"" type=""xs:decimal"" />
                              <xs:element minOccurs=""0"" name=""ULDNumber"">
                                <xs:simpleType>
                                  <xs:restriction base=""xs:string"">
                                    <xs:maxLength value=""35"" />
                                  </xs:restriction>
                                </xs:simpleType>
                              </xs:element>
                              <xs:element minOccurs=""0"" name=""Volume"">
                                <xs:complexType>
                                  <xs:all>
                                    <xs:element minOccurs=""0"" name=""Unit"" type=""CodeDescriptionPair"" />
                                    <xs:element minOccurs=""0"" name=""Volume"" type=""xs:decimal"" />
                                  </xs:all>
                                </xs:complexType>
                              </xs:element>
                              <xs:element minOccurs=""0"" name=""WeightUnit"" type=""CodeDescriptionPair1Char"" />
                            </xs:all>
                          </xs:complexType>
                        </xs:element>
                      </xs:sequence>
                    </xs:complexType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""SpecialHandlingCollection"">
                    <xs:complexType>
                      <xs:sequence>
                        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""SpecialHandling"" type=""CodeDescriptionPair"" />
                      </xs:sequence>
                    </xs:complexType>
                  </xs:element>
                </xs:all>
              </xs:complexType>
            </xs:element>
          </xs:all>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""LocalProcessing"">
        <xs:complexType>
          <xs:all>
            <xs:element minOccurs=""0"" name=""ArrivalCartageRef"">
              <xs:simpleType>
                <xs:restriction base=""xs:string"">
                  <xs:maxLength value=""20"" />
                </xs:restriction>
              </xs:simpleType>
            </xs:element>
            <xs:element minOccurs=""0"" name=""DeliveryCartageAdvised"" type=""emptiable_dateTime"" />
            <xs:element minOccurs=""0"" name=""DeliveryCartageCompleted"" type=""emptiable_dateTime"" />
            <xs:element minOccurs=""0"" name=""DeliveryLabourCharge"" type=""xs:decimal"" />
            <xs:element minOccurs=""0"" name=""DeliveryLabourTime"" type=""emptiable_dateTime"" />
            <xs:element minOccurs=""0"" name=""DeliveryRequiredBy"" type=""emptiable_dateTime"" />
            <xs:element minOccurs=""0"" name=""DemurrageOnDeliveryCharge"" type=""xs:decimal"" />
            <xs:element minOccurs=""0"" name=""DemurrageOnDeliveryTime"" type=""emptiable_dateTime"" />
            <xs:element minOccurs=""0"" name=""DemurrageOnPickupCharge"" type=""xs:decimal"" />
            <xs:element minOccurs=""0"" name=""DemurrageOnPickupTime"" type=""emptiable_dateTime"" />
            <xs:element minOccurs=""0"" name=""EstimatedDelivery"" type=""emptiable_dateTime"" />
            <xs:element minOccurs=""0"" name=""EstimatedPickup"" type=""emptiable_dateTime"" />
            <xs:element minOccurs=""0"" name=""ExportStatement"" type=""CodeDescriptionPair"" />
            <xs:element minOccurs=""0"" name=""FCLAvailable"" type=""emptiable_dateTime"" />
            <xs:element minOccurs=""0"" name=""FCLDeliveryEquipmentNeeded"" type=""CodeDescriptionPair"" />
            <xs:element minOccurs=""0"" name=""FCLPickupEquipmentNeeded"" type=""CodeDescriptionPair"" />
            <xs:element minOccurs=""0"" name=""FCLStorageCommences"" type=""emptiable_dateTime"" />
            <xs:element minOccurs=""0"" name=""HasProhibitedPackaging"" type=""xs:boolean"" />
            <xs:element minOccurs=""0"" name=""InsuranceRequired"" type=""xs:boolean"" />
            <xs:element minOccurs=""0"" name=""IsContingencyRelease"" type=""xs:boolean"" />
            <xs:element minOccurs=""0"" name=""LCLAirStorageCharge"" type=""xs:decimal"" />
            <xs:element minOccurs=""0"" name=""LCLAirStorageDaysOrHours"" type=""xs:unsignedByte"" />
            <xs:element minOccurs=""0"" name=""LCLAvailable"" type=""emptiable_dateTime"" />
            <xs:element minOccurs=""0"" name=""LCLDatesOverrideConsol"" type=""xs:boolean"" />
            <xs:element minOccurs=""0"" name=""LCLStorageCommences"" type=""emptiable_dateTime"" />
            <xs:element minOccurs=""0"" name=""PickupCartageAdvised"" type=""emptiable_dateTime"" />
            <xs:element minOccurs=""0"" name=""PickupCartageCompleted"" type=""emptiable_dateTime"" />
            <xs:element minOccurs=""0"" name=""PickupLabourCharge"" type=""xs:decimal"" />
            <xs:element minOccurs=""0"" name=""PickupLabourTime"" type=""emptiable_dateTime"" />
            <xs:element minOccurs=""0"" name=""PickupRequiredBy"" type=""emptiable_dateTime"" />
            <xs:element minOccurs=""0"" name=""PrintOptionForPackagesOnAWB"" type=""CodeDescriptionPair"" />
            <xs:element minOccurs=""0"" name=""AdditionalServiceCollection"">
              <xs:complexType>
                <xs:sequence>
                  <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""AdditionalService"" type=""AdditionalService"" />
                </xs:sequence>
              </xs:complexType>
            </xs:element>
            <xs:element minOccurs=""0"" name=""OrderNumberCollection"">
              <xs:complexType>
                <xs:sequence>
                  <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""OrderNumber"">
                    <xs:complexType>
                      <xs:all>
                        <xs:element minOccurs=""0"" name=""OrderReference"">
                          <xs:simpleType>
                            <xs:restriction base=""xs:string"">
                              <xs:maxLength value=""35"" />
                            </xs:restriction>
                          </xs:simpleType>
                        </xs:element>
                        <xs:element minOccurs=""0"" name=""Sequence"" type=""xs:short"" />
                      </xs:all>
                    </xs:complexType>
                  </xs:element>
                </xs:sequence>
              </xs:complexType>
            </xs:element>
          </xs:all>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Order"">
        <xs:complexType>
          <xs:all>
            <xs:element minOccurs=""1"" name=""OrderNumber"">
              <xs:simpleType>
                <xs:restriction base=""xs:string"">
                  <xs:maxLength value=""35"" />
                </xs:restriction>
              </xs:simpleType>
            </xs:element>
            <xs:element minOccurs=""0"" name=""AddPalletWeightToOrder"" type=""xs:boolean"" />
            <xs:element minOccurs=""0"" name=""ClientReference"">
              <xs:simpleType>
                <xs:restriction base=""xs:string"">
                  <xs:maxLength value=""35"" />
                </xs:restriction>
              </xs:simpleType>
            </xs:element>
            <xs:element minOccurs=""0"" name=""DropMode"" type=""DropMode"" />
            <xs:element minOccurs=""0"" name=""FulfillmentRule"" type=""CodeDescriptionPair"" />
            <xs:element minOccurs=""0"" name=""LocalCartageInsuranceValue"" type=""xs:decimal"" />
            <xs:element minOccurs=""0"" name=""OrderNumberSplit"" type=""xs:unsignedByte"" />
            <xs:element minOccurs=""0"" name=""PalletsSent"" type=""xs:short"" />
            <xs:element minOccurs=""0"" name=""PickOption"" type=""CodeDescriptionPair"" />
            <xs:element minOccurs=""0"" name=""RequiresPacking"" type=""xs:boolean"" />
            <xs:element minOccurs=""0"" name=""RequiresQualityAudit"" type=""xs:boolean"" />
            <xs:element minOccurs=""0"" name=""StagingArea"">
              <xs:simpleType>
                <xs:restriction base=""xs:string"">
                  <xs:maxLength value=""25"" />
                </xs:restriction>
              </xs:simpleType>
            </xs:element>
            <xs:element minOccurs=""0"" name=""Status"" type=""CodeDescriptionPair"" />
            <xs:element minOccurs=""0"" name=""TotalLineVolume"" type=""xs:decimal"" />
            <xs:element minOccurs=""0"" name=""TotalLineWeight"" type=""xs:decimal"" />
            <xs:element minOccurs=""0"" name=""TotalNetWeightSent"" type=""xs:decimal"" />
            <xs:element minOccurs=""0"" name=""TotalUnits"" type=""xs:decimal"" />
            <xs:element minOccurs=""0"" name=""TransportReference"">
              <xs:simpleType>
                <xs:restriction base=""xs:string"">
                  <xs:maxLength value=""35"" />
                </xs:restriction>
              </xs:simpleType>
            </xs:element>
            <xs:element minOccurs=""0"" name=""Type"" type=""CodeDescriptionPair"" />
            <xs:element minOccurs=""0"" name=""UnitsSent"" type=""xs:decimal"" />
            <xs:element minOccurs=""0"" name=""Warehouse"">
              <xs:complexType>
                <xs:all>
                  <xs:element minOccurs=""1"" name=""Code"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""3"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""Name"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""50"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:element>
                </xs:all>
              </xs:complexType>
            </xs:element>
            <xs:element minOccurs=""0"" name=""DateCollection"">
              <xs:complexType>
                <xs:sequence>
                  <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Date"" type=""Date"" />
                </xs:sequence>
              </xs:complexType>
            </xs:element>
            <xs:element minOccurs=""0"" name=""OrderLineCollection"">
              <xs:complexType>
                <xs:sequence>
                  <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""OrderLine"">
                    <xs:complexType>
                      <xs:all>
                        <xs:element minOccurs=""0"" name=""AdditionalInformation"">
                          <xs:simpleType>
                            <xs:restriction base=""xs:string"">
                              <xs:maxLength value=""2147483647"" />
                            </xs:restriction>
                          </xs:simpleType>
                        </xs:element>
                        <xs:element minOccurs=""0"" name=""AdditionalTerms"">
                          <xs:simpleType>
                            <xs:restriction base=""xs:string"">
                              <xs:maxLength value=""50"" />
                            </xs:restriction>
                          </xs:simpleType>
                        </xs:element>
                        <xs:element minOccurs=""0"" name=""AdjustmentReason"" type=""CodeDescriptionPair"" />
                        <xs:element minOccurs=""0"" name=""ArrivalDate"" type=""emptiable_dateTime"" />
                        <xs:element minOccurs=""0"" name=""CommercialInvoiceNumber"">
                          <xs:simpleType>
                            <xs:restriction base=""xs:string"">
                              <xs:maxLength value=""20"" />
                            </xs:restriction>
                          </xs:simpleType>
                        </xs:element>
                        <xs:element minOccurs=""0"" name=""Commodity"" type=""Commodity"" />
                        <xs:element minOccurs=""0"" name=""ConfirmationNumber"">
                          <xs:simpleType>
                            <xs:restriction base=""xs:string"">
                              <xs:maxLength value=""35"" />
                            </xs:restriction>
                          </xs:simpleType>
                        </xs:element>
                        <xs:element minOccurs=""0"" name=""Consignee"" type=""OrganizationAddress"" />
                        <xs:element minOccurs=""0"" name=""ContainerNumber"">
                          <xs:simpleType>
                            <xs:restriction base=""xs:string"">
                              <xs:maxLength value=""20"" />
                            </xs:restriction>
                          </xs:simpleType>
                        </xs:element>
                        <xs:element minOccurs=""0"" name=""ContainerPackingOrder"" type=""xs:int"" />
                        <xs:element minOccurs=""0"" name=""CrossDockOrderNumber"">
                          <xs:simpleType>
                            <xs:restriction base=""xs:string"">
                              <xs:maxLength value=""35"" />
                            </xs:restriction>
                          </xs:simpleType>
                        </xs:element>
                        <xs:element minOccurs=""0"" name=""CurrentHoldCode"" type=""CodeDescriptionPair9Char"" />
                        <xs:element minOccurs=""0"" name=""CustomsData"">
                          <xs:complexType>
                            <xs:all>
                              <xs:element minOccurs=""0"" name=""AdditionalInformation"">
                                <xs:simpleType>
                                  <xs:restriction base=""xs:string"">
                                    <xs:maxLength value=""250"" />
                                  </xs:restriction>
                                </xs:simpleType>
                              </xs:element>
                              <xs:element minOccurs=""0"" name=""CountryOfOrigin"" type=""Country"" />
                              <xs:element minOccurs=""0"" name=""CustomsQuantity"" type=""xs:decimal"" />
                              <xs:element minOccurs=""0"" name=""CustomsQuantityUnit"" type=""CodeDescriptionPair"" />
                              <xs:element minOccurs=""0"" name=""CustomsSecondQuantity"" type=""xs:decimal"" />
                              <xs:element minOccurs=""0"" name=""CustomsSecondUnitQty"" type=""CodeDescriptionPair"" />
                              <xs:element minOccurs=""0"" name=""CustomsThirdQuantity"" type=""xs:decimal"" />
                              <xs:element minOccurs=""0"" name=""CustomsThirdUnitQty"" type=""CodeDescriptionPair"" />
                              <xs:element minOccurs=""0"" name=""DeclarationReference"">
                                <xs:simpleType>
                                  <xs:restriction base=""xs:string"">
                                    <xs:maxLength value=""35"" />
                                  </xs:restriction>
                                </xs:simpleType>
                              </xs:element>
                              <xs:element minOccurs=""0"" name=""EntryDate"" type=""emptiable_dateTime"" />
                              <xs:element minOccurs=""0"" name=""EntryKey"">
                                <xs:simpleType>
                                  <xs:restriction base=""xs:string"">
                                    <xs:maxLength value=""35"" />
                                  </xs:restriction>
                                </xs:simpleType>
                              </xs:element>
                              <xs:element minOccurs=""0"" name=""EntryLineNumber"" type=""xs:short"" />
                              <xs:element minOccurs=""0"" name=""InwardsEntryKey"">
                                <xs:simpleType>
                                  <xs:restriction base=""xs:string"">
                                    <xs:maxLength value=""35"" />
                                  </xs:restriction>
                                </xs:simpleType>
                              </xs:element>
                              <xs:element minOccurs=""0"" name=""InwardsEntryLineNumber"" type=""xs:short"" />
                              <xs:element minOccurs=""0"" name=""IsFromOtherFTZWarehouse"" type=""xs:boolean"" />
                              <xs:element minOccurs=""0"" name=""ManufacturerAddress"" type=""OrganizationAddress"" />
                              <xs:element minOccurs=""0"" name=""OutwardType"" type=""CodeDescriptionPair"" />
                              <xs:element minOccurs=""0"" name=""PrimaryPreference"">
                                <xs:simpleType>
                                  <xs:restriction base=""xs:string"">
                                    <xs:maxLength value=""10"" />
                                  </xs:restriction>
                                </xs:simpleType>
                              </xs:element>
                              <xs:element minOccurs=""0"" name=""Tariff"">
                                <xs:simpleType>
                                  <xs:restriction base=""xs:string"">
                                    <xs:maxLength value=""35"" />
                                  </xs:restriction>
                                </xs:simpleType>
                              </xs:element>
                              <xs:element minOccurs=""0"" name=""TILV"" type=""xs:decimal"" />
                              <xs:element minOccurs=""0"" name=""ValueForDuty"" type=""xs:decimal"" />
                              <xs:element minOccurs=""0"" name=""ZoneStatus"" type=""CodeDescriptionPair"" />
                            </xs:all>
                          </xs:complexType>
                        </xs:element>
                        <xs:element minOccurs=""0"" name=""ExpectedQuantity"" type=""xs:decimal"" />
                        <xs:element minOccurs=""0"" name=""ExpiryDate"" type=""emptiable_dateTime"" />
                        <xs:element minOccurs=""0"" name=""ExtendedLinePrice"" type=""xs:decimal"" />
                        <xs:element minOccurs=""0"" name=""IncoTerm"" type=""IncoTerm"" />
                        <xs:element minOccurs=""0"" name=""InnerPacksQty"" type=""xs:decimal"" />
                        <xs:element minOccurs=""0"" name=""InnerPacksQtyUnit"" type=""PackageType"" />
                        <xs:element minOccurs=""0"" name=""InventoryStatus"" type=""CodeDescriptionPair"" />
                        <xs:element minOccurs=""0"" name=""LineComment"">
                          <xs:simpleType>
                            <xs:restriction base=""xs:string"">
                              <xs:maxLength value=""250"" />
                            </xs:restriction>
                          </xs:simpleType>
                        </xs:element>
                        <xs:element minOccurs=""0"" name=""LineNumber"" type=""xs:int"" />
                        <xs:element minOccurs=""0"" name=""LineSplitNumber"" type=""xs:short"" />
                        <xs:element minOccurs=""0"" name=""Link"" type=""xs:int"" />
                        <xs:element minOccurs=""0"" name=""Location"">
                          <xs:complexType>
                            <xs:all>
                              <xs:element minOccurs=""0"" name=""Column"" type=""xs:short"" />
                              <xs:element minOccurs=""0"" name=""Level"" type=""xs:short"" />
                              <xs:element minOccurs=""0"" name=""Row"">
                                <xs:simpleType>
                                  <xs:restriction base=""xs:string"">
                                    <xs:maxLength value=""25"" />
                                  </xs:restriction>
                                </xs:simpleType>
                              </xs:element>
                              <xs:element minOccurs=""0"" name=""Tray"" type=""xs:short"" />
                            </xs:all>
                          </xs:complexType>
                        </xs:element>
                        <xs:element minOccurs=""0"" name=""OrderedQty"" type=""xs:decimal"" />
                        <xs:element minOccurs=""0"" name=""OrderedQtyUnit"" type=""CodeDescriptionPair"" />
                        <xs:element minOccurs=""0"" name=""OriginalHoldCode"" type=""CodeDescriptionPair9Char"" />
                        <xs:element minOccurs=""0"" name=""PackageGroupId"">
                          <xs:simpleType>
                            <xs:restriction base=""xs:string"">
                              <xs:maxLength value=""15"" />
                            </xs:restriction>
                          </xs:simpleType>
                        </xs:element>
                        <xs:element minOccurs=""0"" name=""PackageHeight"" type=""xs:decimal"" />
                        <xs:element minOccurs=""0"" name=""PackageLength"" type=""xs:decimal"" />
                        <xs:element minOccurs=""0"" name=""PackageLengthUnit"" type=""UnitOfLength"" />
                        <xs:element minOccurs=""0"" name=""PackageQty"" type=""xs:decimal"" />
                        <xs:element minOccurs=""0"" name=""PackageQtyUnit"" type=""PackageType"" />
                        <xs:element minOccurs=""0"" name=""PackageWidth"" type=""xs:decimal"" />
                        <xs:element minOccurs=""0"" name=""PackingDate"" type=""emptiable_dateTime"" />
                        <xs:element minOccurs=""0"" name=""PalletID"">
                          <xs:simpleType>
                            <xs:restriction base=""xs:string"">
                              <xs:maxLength value=""25"" />
                            </xs:restriction>
                          </xs:simpleType>
                        </xs:element>
                        <xs:element minOccurs=""0"" name=""PartAttribute1"">
                          <xs:simpleType>
                            <xs:restriction base=""xs:string"">
                              <xs:maxLength value=""25"" />
                            </xs:restriction>
                          </xs:simpleType>
                        </xs:element>
                        <xs:element minOccurs=""0"" name=""PartAttribute2"">
                          <xs:simpleType>
                            <xs:restriction base=""xs:string"">
                              <xs:maxLength value=""25"" />
                            </xs:restriction>
                          </xs:simpleType>
                        </xs:element>
                        <xs:element minOccurs=""0"" name=""PartAttribute3"">
                          <xs:simpleType>
                            <xs:restriction base=""xs:string"">
                              <xs:maxLength value=""25"" />
                            </xs:restriction>
                          </xs:simpleType>
                        </xs:element>
                        <xs:element minOccurs=""0"" name=""PerPackageQty"" type=""xs:decimal"" />
                        <xs:element minOccurs=""0"" name=""Product"" type=""Product"" />
                        <xs:element minOccurs=""0"" name=""PutAwayArea"">
                          <xs:simpleType>
                            <xs:restriction base=""xs:string"">
                              <xs:maxLength value=""25"" />
                            </xs:restriction>
                          </xs:simpleType>
                        </xs:element>
                        <xs:element minOccurs=""0"" name=""QuantityMet"" type=""xs:decimal"" />
                        <xs:element minOccurs=""0"" name=""RequiredBy"" type=""emptiable_dateTime"" />
                        <xs:element minOccurs=""0"" name=""RequiredExWorks"" type=""emptiable_dateTime"" />
                        <xs:element minOccurs=""0"" name=""RequiredInStore"" type=""emptiable_dateTime"" />
                        <xs:element minOccurs=""0"" name=""ReservedQuantity"" type=""xs:decimal"" />
                        <xs:element minOccurs=""0"" name=""ShortfallQuantity"" type=""xs:decimal"" />
                        <xs:element minOccurs=""0"" name=""SpecialInstructions"">
                          <xs:simpleType>
                            <xs:restriction base=""xs:string"">
                              <xs:maxLength value=""2147483647"" />
                            </xs:restriction>
                          </xs:simpleType>
                        </xs:element>
                        <xs:element minOccurs=""0"" name=""SplitQuantity"" type=""xs:decimal"" />
                        <xs:element minOccurs=""0"" name=""Status"" type=""CodeDescriptionPair"" />
                        <xs:element minOccurs=""0"" name=""SubLineNumber"" type=""xs:int"" />
                        <xs:element minOccurs=""0"" name=""SupplierConfirmedAcceptance"" type=""emptiable_dateTime"" />
                        <xs:element minOccurs=""0"" name=""UnitPriceAfterDiscount"" type=""xs:decimal"" />
                        <xs:element minOccurs=""0"" name=""UnitPriceCurrency"" type=""Currency"" />
                        <xs:element minOccurs=""0"" name=""UnitPriceDiscountAmount"" type=""xs:decimal"" />
                        <xs:element minOccurs=""0"" name=""UnitPriceDiscountPercent"" type=""xs:decimal"" />
                        <xs:element minOccurs=""0"" name=""UnitPriceRecommended"" type=""xs:decimal"" />
                        <xs:element minOccurs=""0"" name=""Volume"" type=""xs:decimal"" />
                        <xs:element minOccurs=""0"" name=""VolumeUnit"" type=""UnitOfVolume"" />
                        <xs:element minOccurs=""0"" name=""Weight"" type=""xs:decimal"" />
                        <xs:element minOccurs=""0"" name=""WeightUnit"" type=""UnitOfWeight"" />
                        <xs:element minOccurs=""0"" name=""CustomizedFieldCollection"">
                          <xs:complexType>
                            <xs:sequence>
                              <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CustomizedField"" type=""CustomizedField"" />
                            </xs:sequence>
                          </xs:complexType>
                        </xs:element>
                        <xs:element minOccurs=""0"" name=""UNDGCollection"">
                          <xs:complexType>
                            <xs:sequence>
                              <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""UNDG"" type=""UNDG"" />
                            </xs:sequence>
                          </xs:complexType>
                        </xs:element>
                      </xs:all>
                    </xs:complexType>
                  </xs:element>
                </xs:sequence>
                <xs:attribute name=""Content"" type=""CollectionContent"" />
              </xs:complexType>
            </xs:element>
          </xs:all>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""AddInfoCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""AddInfo"" type=""AddInfo"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""AddInfoGroupCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""AddInfoGroup"" type=""AddInfoGroup"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""AdditionalBillCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""AdditionalBill"">
              <xs:complexType>
                <xs:all>
                  <xs:element minOccurs=""0"" name=""BillNumber"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""35"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""BillType"" type=""WayBillType"" />
                  <xs:element minOccurs=""0"" name=""IssueDate"" type=""emptiable_dateTime"" />
                  <xs:element minOccurs=""0"" name=""Link"" type=""xs:int"" />
                  <xs:element minOccurs=""0"" name=""MessageStatus"" type=""CodeDescriptionPair"" />
                  <xs:element minOccurs=""0"" name=""NoOfPacks"" type=""xs:decimal"" />
                  <xs:element minOccurs=""0"" name=""PackType"" type=""PackageType"" />
                  <xs:element minOccurs=""0"" name=""ParentBillNumber"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""35"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""AddInfoCollection"">
                    <xs:complexType>
                      <xs:sequence>
                        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""AddInfo"" type=""AddInfo"" />
                      </xs:sequence>
                    </xs:complexType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""AddInfoGroupCollection"">
                    <xs:complexType>
                      <xs:sequence>
                        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""AddInfoGroup"" type=""AddInfoGroup"" />
                      </xs:sequence>
                    </xs:complexType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""CustomsReferenceCollection"">
                    <xs:complexType>
                      <xs:sequence>
                        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CustomsReference"" type=""CustomsReference"" />
                      </xs:sequence>
                    </xs:complexType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""OrganizationAddressCollection"">
                    <xs:complexType>
                      <xs:sequence>
                        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""OrganizationAddress"" type=""OrganizationAddress"" />
                      </xs:sequence>
                    </xs:complexType>
                  </xs:element>
                </xs:all>
              </xs:complexType>
            </xs:element>
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""AdditionalReferenceCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""AdditionalReference"" type=""AdditionalReference"" />
          </xs:sequence>
          <xs:attribute name=""Content"" type=""CollectionContent"" />
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""BillOfLadingClauseCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""BillOfLadingClause"" type=""BillOfLadingClause"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""ContainerCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Container"" type=""Container"" />
          </xs:sequence>
          <xs:attribute name=""Content"" type=""CollectionContent"" />
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CustomizedFieldCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CustomizedField"" type=""CustomizedField"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CustomsReferenceCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CustomsReference"" type=""CustomsReference"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CustomsSupportingInformationCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CustomsSupportingInformation"" type=""CustomsSupportingInformation"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""DateCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Date"" type=""Date"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""EntryHeaderCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""EntryHeader"" type=""EntryHeader"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""EntryInstructionCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""EntryInstruction"" type=""EntryInstruction"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""EntryNumberCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""EntryNumber"" type=""EntryNumber"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""GuaranteeCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Guarantee"" type=""Guarantee"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""InBondMoveHeaderCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""InBondMoveHeader"">
              <xs:complexType>
                <xs:all>
                  <xs:element minOccurs=""0"" name=""AdditionalText"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""500"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""BioterrorismActIndicator"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""1"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""CustomsAgent"" type=""Staff"" />
                  <xs:element minOccurs=""0"" name=""CustomsStatus"" type=""CodeDescriptionPair"" />
                  <xs:element minOccurs=""0"" name=""DestinationPortScheduleD"" type=""CodeDescriptionPair4Char"" />
                  <xs:element minOccurs=""0"" name=""EntryType"" type=""CodeDescriptionPair9Char"" />
                  <xs:element minOccurs=""0"" name=""ExportContainerMode"" type=""ContainerMode"" />
                  <xs:element minOccurs=""0"" name=""ExportTransportMode"" type=""CodeDescriptionPair"" />
                  <xs:element minOccurs=""0"" name=""ExportVesselName"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""35"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""ForeignDestinationPortScheduleK"" type=""CodeDescriptionPair5Char"" />
                  <xs:element minOccurs=""0"" name=""ForeignDestinationPortUNLOCO"" type=""UNLOCO"" />
                  <xs:element minOccurs=""0"" name=""InBondCarrierID"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""12"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""InBondCarrierSCAC"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""4"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""LastForeignPortScheduleK"" type=""CodeDescriptionPair5Char"" />
                  <xs:element minOccurs=""0"" name=""MessagingApplicationCode"" type=""CodeDescriptionPair"" />
                  <xs:element minOccurs=""0"" name=""MonetaryValue"" type=""xs:decimal"" />
                  <xs:element minOccurs=""0"" name=""MoveToFTZ"" type=""CodeDescriptionPair1Char"" />
                  <xs:element minOccurs=""0"" name=""PortOfPresentationScheduleD"" type=""CodeDescriptionPair4Char"" />
                  <xs:element minOccurs=""0"" name=""Seals"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""20"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""SequenceNumber"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""6"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""TransferOfLiabilityCarrierCode"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""4"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""TransferOfLiabilityCarrierID"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""27"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""TransferOfLiabilityCityName"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""19"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""TransferOfLiabilityStateCode"" type=""CodeDescriptionPair2Char"" />
                  <xs:element minOccurs=""0"" name=""AdditionalReferenceCollection"">
                    <xs:complexType>
                      <xs:sequence>
                        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""AdditionalReference"" type=""AdditionalReference"" />
                      </xs:sequence>
                      <xs:attribute name=""Content"" type=""CollectionContent"" />
                    </xs:complexType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""DateCollection"">
                    <xs:complexType>
                      <xs:sequence>
                        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Date"" type=""Date"" />
                      </xs:sequence>
                    </xs:complexType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""EntryNumberCollection"">
                    <xs:complexType>
                      <xs:sequence>
                        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""EntryNumber"" type=""EntryNumber"" />
                      </xs:sequence>
                    </xs:complexType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""InBondMoveDetailCollection"">
                    <xs:complexType>
                      <xs:sequence>
                        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""InBondMoveDetail"">
                          <xs:complexType>
                            <xs:all>
                              <xs:element minOccurs=""0"" name=""AdditionalBillLink"" type=""xs:int"" />
                              <xs:element minOccurs=""0"" name=""ArrivalStatus"" type=""CodeDescriptionPair"" />
                              <xs:element minOccurs=""0"" name=""CustomsStatus"" type=""CodeDescriptionPair"" />
                              <xs:element minOccurs=""0"" name=""DepartureStatus"" type=""CodeDescriptionPair"" />
                              <xs:element minOccurs=""0"" name=""ExportationStatus"" type=""CodeDescriptionPair"" />
                              <xs:element minOccurs=""0"" name=""ExportDate"" type=""emptiable_dateTime"" />
                              <xs:element minOccurs=""0"" name=""ExportVesselName"">
                                <xs:simpleType>
                                  <xs:restriction base=""xs:string"">
                                    <xs:maxLength value=""35"" />
                                  </xs:restriction>
                                </xs:simpleType>
                              </xs:element>
                              <xs:element minOccurs=""0"" name=""ForeignDestPortScheduleK"">
                                <xs:simpleType>
                                  <xs:restriction base=""xs:string"">
                                    <xs:maxLength value=""5"" />
                                  </xs:restriction>
                                </xs:simpleType>
                              </xs:element>
                              <xs:element minOccurs=""0"" name=""InBondQuantity"" type=""xs:int"" />
                              <xs:element minOccurs=""0"" name=""MessageStatus"" type=""CodeDescriptionPair"" />
                              <xs:element minOccurs=""0"" name=""MonetaryValue"" type=""xs:decimal"" />
                              <xs:element minOccurs=""0"" name=""PreviousInBondTransitDate"" type=""emptiable_dateTime"" />
                              <xs:element minOccurs=""0"" name=""PreviousInBondTransitPortScheduleD"" type=""CodeDescriptionPair4Char"" />
                              <xs:element minOccurs=""0"" name=""PreviousInBondTransitType"" type=""CodeDescriptionPair2Char"" />
                              <xs:element minOccurs=""0"" name=""SequenceNumber"">
                                <xs:simpleType>
                                  <xs:restriction base=""xs:string"">
                                    <xs:maxLength value=""5"" />
                                  </xs:restriction>
                                </xs:simpleType>
                              </xs:element>
                              <xs:element minOccurs=""0"" name=""TransferOfLiabilityStatus"" type=""CodeDescriptionPair"" />
                              <xs:element minOccurs=""0"" name=""AddInfoGroupCollection"">
                                <xs:complexType>
                                  <xs:sequence>
                                    <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""AddInfoGroup"" type=""AddInfoGroup"" />
                                  </xs:sequence>
                                </xs:complexType>
                              </xs:element>
                              <xs:element minOccurs=""0"" name=""ContainerLinkCollection"">
                                <xs:complexType>
                                  <xs:sequence>
                                    <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ContainerLink"" type=""ContainerLink"" />
                                  </xs:sequence>
                                </xs:complexType>
                              </xs:element>
                              <xs:element minOccurs=""0"" name=""CustomsReferenceCollection"">
                                <xs:complexType>
                                  <xs:sequence>
                                    <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CustomsReference"" type=""CustomsReference"" />
                                  </xs:sequence>
                                </xs:complexType>
                              </xs:element>
                              <xs:element minOccurs=""0"" name=""EntryNumberCollection"">
                                <xs:complexType>
                                  <xs:sequence>
                                    <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""EntryNumber"" type=""EntryNumber"" />
                                  </xs:sequence>
                                </xs:complexType>
                              </xs:element>
                            </xs:all>
                          </xs:complexType>
                        </xs:element>
                      </xs:sequence>
                    </xs:complexType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""OrganizationAddressCollection"">
                    <xs:complexType>
                      <xs:sequence>
                        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""OrganizationAddress"" type=""OrganizationAddress"" />
                      </xs:sequence>
                    </xs:complexType>
                  </xs:element>
                </xs:all>
              </xs:complexType>
            </xs:element>
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""InstructionCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Instruction"">
              <xs:complexType>
                <xs:all>
                  <xs:element minOccurs=""0"" name=""Address"" type=""OrganizationAddress"" />
                  <xs:element minOccurs=""0"" name=""DropMode"" type=""DropMode"" />
                  <xs:element minOccurs=""0"" name=""Equipment"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""10"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""IsAuthorisedToLeave"" type=""xs:boolean"" />
                  <xs:element minOccurs=""0"" name=""IsContainerRateable"" type=""xs:boolean"" />
                  <xs:element minOccurs=""0"" name=""IsLooseRateable"" type=""xs:boolean"" />
                  <xs:element minOccurs=""0"" name=""Sequence"" type=""xs:int"" />
                  <xs:element minOccurs=""0"" name=""ServiceInstruction"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""2147483646"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""Status"" type=""CodeDescriptionPair"" />
                  <xs:element minOccurs=""0"" name=""Type"" type=""CodeDescriptionPair"" />
                  <xs:element minOccurs=""0"" name=""CustomizedFieldCollection"">
                    <xs:complexType>
                      <xs:sequence>
                        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CustomizedField"" type=""CustomizedField"" />
                      </xs:sequence>
                    </xs:complexType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""InstructionContainerLinkCollection"">
                    <xs:complexType>
                      <xs:sequence>
                        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""InstructionContainerLink"">
                          <xs:complexType>
                            <xs:all>
                              <xs:element minOccurs=""0"" name=""ContainerLink"" type=""xs:int"" />
                              <xs:element minOccurs=""0"" name=""Quantity"" type=""xs:int"" />
                              <xs:element minOccurs=""0"" name=""ConfirmationCollection"">
                                <xs:complexType>
                                  <xs:sequence>
                                    <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Confirmation"" type=""Confirmation"" />
                                  </xs:sequence>
                                </xs:complexType>
                              </xs:element>
                            </xs:all>
                          </xs:complexType>
                        </xs:element>
                      </xs:sequence>
                    </xs:complexType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""InstructionPackingLineLinkCollection"">
                    <xs:complexType>
                      <xs:sequence>
                        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""InstructionPackingLineLink"">
                          <xs:complexType>
                            <xs:all>
                              <xs:element minOccurs=""0"" name=""PackingLineLink"" type=""xs:int"" />
                              <xs:element minOccurs=""0"" name=""Quantity"" type=""xs:int"" />
                              <xs:element minOccurs=""0"" name=""ConfirmationCollection"">
                                <xs:complexType>
                                  <xs:sequence>
                                    <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Confirmation"" type=""Confirmation"" />
                                  </xs:sequence>
                                </xs:complexType>
                              </xs:element>
                            </xs:all>
                          </xs:complexType>
                        </xs:element>
                      </xs:sequence>
                    </xs:complexType>
                  </xs:element>
                </xs:all>
              </xs:complexType>
            </xs:element>
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""MilestoneCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Milestone"" type=""Milestone"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""NoteCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Note"" type=""Note"" />
          </xs:sequence>
          <xs:attribute name=""Content"" type=""CollectionContent"" />
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""OrganizationAddressCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""OrganizationAddress"" type=""OrganizationAddress"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""PackingLineCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PackingLine"" type=""PackingLine"" />
          </xs:sequence>
          <xs:attribute name=""Content"" type=""CollectionContent"" />
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""ParentShipmentCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ParentShipment"" type=""Shipment"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""PaymentHandlingInstructionCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PaymentHandlingInstruction"" type=""PaymentHandlingInstruction"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""PostCarriageShipmentCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PostCarriageShipment"" type=""Shipment"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""PreCarriageShipmentCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PreCarriageShipment"" type=""Shipment"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""RelatedShipmentCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""RelatedShipment"" type=""Shipment"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""SubShipmentCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""SubShipment"" type=""Shipment"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""TransportLegCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""TransportLeg"" type=""TransportLeg"" />
          </xs:sequence>
          <xs:attribute name=""Content"" type=""CollectionContent"" />
        </xs:complexType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""AddInfo"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""Key"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""128"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""1"" name=""Value"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""1024"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""AddInfoGroup"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""Type"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""AddInfoCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""AddInfo"" type=""AddInfo"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""AddInfoGroupCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""AddInfoGroup"" type=""AddInfoGroup"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CustomsReferenceCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CustomsReference"" type=""CustomsReference"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""OrganizationAddressCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""OrganizationAddress"" type=""OrganizationAddress"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""AdditionalReference"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""Type"" type=""EntryType"" />
      <xs:element minOccurs=""0"" name=""ReferenceNumber"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""ContextInformation"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""15"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""IssueDate"" type=""emptiable_dateTime"" />
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""AdditionalService"">
    <xs:all>
      <xs:element minOccurs=""0"" name=""ServiceCode"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""Booked"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""Completed"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""Contractor"" type=""OrganizationAddress"" />
      <xs:element minOccurs=""0"" name=""Duration"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""Location"" type=""OrganizationAddress"" />
      <xs:element minOccurs=""0"" name=""References"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""ServiceCount"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""ServiceNote"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""256"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""AWBParty"">
    <xs:all>
      <xs:element minOccurs=""0"" name=""AccountCode"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""14"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""AddressLine1"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""50"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""AddressLine2"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""50"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""City"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""17"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""ContactDetail"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""25"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""ContactType"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""Country"" type=""Country"" />
      <xs:element minOccurs=""0"" name=""IsAddressOverriddenForPaperWaybill"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""Name"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""50"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""PaperOverrideLine1"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""75"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""PaperOverrideLine2"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""75"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""PaperOverrideLine3"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""75"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""PaperOverrideLine4"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""75"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""PaperOverrideLine5"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""75"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""PostCode"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""9"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""State"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""9"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""BillOfLadingClause"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""Type"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""Detail"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""2147483647"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""Classification"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""Code"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""15"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""1"" name=""Country"" type=""Country"" />
      <xs:element minOccurs=""1"" name=""Type"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""Description"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""CodeDescriptionPair10Char"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""Code"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""10"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Description"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""80"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""CodeDescriptionPair1Char"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""Code"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""1"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Description"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""80"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""CodeDescriptionPair2Char"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""Code"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""2"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Description"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""80"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""CodeDescriptionPair35Char"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""Code"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Description"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""80"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""CodeDescriptionPair4Char"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""Code"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""4"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Description"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""80"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""CodeDescriptionPair6Char"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""Code"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""6"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Description"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""80"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""CodeDescriptionPair7Char"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""Code"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""7"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Description"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""80"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""CodeDescriptionPair8Char"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""Code"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""8"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Description"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""80"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""CodeDescriptionPair9Char"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""Code"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""9"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Description"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""80"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""CommercialCharge"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""ChargeType"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""AdjustedCharge"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""AgreedExchangeRate"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""Amount"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""ApportionmentType"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""Currency"" type=""Currency"" />
      <xs:element minOccurs=""0"" name=""DistributeBy"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""ExchangeRateType"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""IsApportionedCharge"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""IsDutiable"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""IsGSTApplicable"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""IsIncludedInITOT"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""IsNotIncludedInInvoice"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""IsStatisticalValueApplicable"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""PercentageOfLinePrice"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""PrepaidCollect"" type=""CodeDescriptionPair"" />
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""CommercialInfo"">
    <xs:all>
      <xs:element minOccurs=""0"" name=""Name"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""DateOfLandedCostProcessing"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""AddInfoCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""AddInfo"" type=""AddInfo"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""AddInfoGroupCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""AddInfoGroup"" type=""AddInfoGroup"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CommercialChargeCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CommercialCharge"" type=""CommercialCharge"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CommercialInvoiceCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CommercialInvoice"">
              <xs:complexType>
                <xs:all>
                  <xs:element minOccurs=""0"" name=""InvoiceNumber"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""35"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""AdditionalTerms"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""35"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""AgreedExchangeRate"" type=""xs:decimal"" />
                  <xs:element minOccurs=""0"" name=""BillNumber"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""35"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""BillType"" type=""WayBillType"" />
                  <xs:element minOccurs=""0"" name=""Buyer"" type=""OrganizationAddress"" />
                  <xs:element minOccurs=""0"" name=""ExchangeRateType"" type=""CodeDescriptionPair"" />
                  <xs:element minOccurs=""0"" name=""IncoTerm"" type=""CodeDescriptionPair"" />
                  <xs:element minOccurs=""0"" name=""InvoiceAmount"" type=""xs:decimal"" />
                  <xs:element minOccurs=""0"" name=""InvoiceCurrency"" type=""Currency"" />
                  <xs:element minOccurs=""0"" name=""InvoiceDate"" type=""emptiable_dateTime"" />
                  <xs:element minOccurs=""0"" name=""LandedCostExchangeRate"" type=""xs:decimal"" />
                  <xs:element minOccurs=""0"" name=""MessageStatus"" type=""CodeDescriptionPair"" />
                  <xs:element minOccurs=""0"" name=""NetWeight"" type=""xs:decimal"" />
                  <xs:element minOccurs=""0"" name=""NetWeightUQ"" type=""UnitOfWeight"" />
                  <xs:element minOccurs=""0"" name=""NoOfPacks"" type=""xs:decimal"" />
                  <xs:element minOccurs=""0"" name=""PaymentAmount"" type=""xs:decimal"" />
                  <xs:element minOccurs=""0"" name=""PaymentDate"" type=""emptiable_dateTime"" />
                  <xs:element minOccurs=""0"" name=""PaymentExchangeRate"" type=""xs:decimal"" />
                  <xs:element minOccurs=""0"" name=""PaymentNumber"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""20"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""RelatedIndicator"" type=""CodeDescriptionPair"" />
                  <xs:element minOccurs=""0"" name=""Supplier"" type=""OrganizationAddress"" />
                  <xs:element minOccurs=""0"" name=""ValuationCode"" type=""CodeDescriptionPair"" />
                  <xs:element minOccurs=""0"" name=""ValuationDateOverride"" type=""emptiable_dateTime"" />
                  <xs:element minOccurs=""0"" name=""Volume"" type=""xs:decimal"" />
                  <xs:element minOccurs=""0"" name=""VolumeUnit"" type=""UnitOfVolume"" />
                  <xs:element minOccurs=""0"" name=""Weight"" type=""xs:decimal"" />
                  <xs:element minOccurs=""0"" name=""WeightUnit"" type=""UnitOfWeight"" />
                  <xs:element minOccurs=""0"" name=""AddInfoCollection"">
                    <xs:complexType>
                      <xs:sequence>
                        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""AddInfo"" type=""AddInfo"" />
                      </xs:sequence>
                    </xs:complexType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""AddInfoGroupCollection"">
                    <xs:complexType>
                      <xs:sequence>
                        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""AddInfoGroup"" type=""AddInfoGroup"" />
                      </xs:sequence>
                    </xs:complexType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""CommercialChargeCollection"">
                    <xs:complexType>
                      <xs:sequence>
                        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CommercialCharge"" type=""CommercialCharge"" />
                      </xs:sequence>
                    </xs:complexType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""CommercialInvoiceLineCollection"">
                    <xs:complexType>
                      <xs:sequence>
                        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CommercialInvoiceLine"">
                          <xs:complexType>
                            <xs:all>
                              <xs:element minOccurs=""0"" name=""LineNo"" type=""xs:int"" />
                              <xs:element minOccurs=""0"" name=""BondedWarehouseQuantity"" type=""xs:decimal"" />
                              <xs:element minOccurs=""0"" name=""BondedWarehouseQuantityUnit"" type=""CodeDescriptionPair"" />
                              <xs:element minOccurs=""0"" name=""BrandName"">
                                <xs:simpleType>
                                  <xs:restriction base=""xs:string"">
                                    <xs:maxLength value=""50"" />
                                  </xs:restriction>
                                </xs:simpleType>
                              </xs:element>
                              <xs:element minOccurs=""0"" name=""ClassificationCode"">
                                <xs:simpleType>
                                  <xs:restriction base=""xs:string"">
                                    <xs:maxLength value=""35"" />
                                  </xs:restriction>
                                </xs:simpleType>
                              </xs:element>
                              <xs:element minOccurs=""0"" name=""ClassUsageComment"">
                                <xs:simpleType>
                                  <xs:restriction base=""xs:string"">
                                    <xs:maxLength value=""200"" />
                                  </xs:restriction>
                                </xs:simpleType>
                              </xs:element>
                              <xs:element minOccurs=""0"" name=""ClassUsageCommentStaff"" type=""Staff"" />
                              <xs:element minOccurs=""0"" name=""Commodity"" type=""Commodity"" />
                              <xs:element minOccurs=""0"" name=""ConcessionOrder"">
                                <xs:simpleType>
                                  <xs:restriction base=""xs:string"">
                                    <xs:maxLength value=""15"" />
                                  </xs:restriction>
                                </xs:simpleType>
                              </xs:element>
                              <xs:element minOccurs=""0"" name=""ContainerMode"" type=""ContainerMode"" />
                              <xs:element minOccurs=""0"" name=""ContainerNumber"">
                                <xs:simpleType>
                                  <xs:restriction base=""xs:string"">
                                    <xs:maxLength value=""20"" />
                                  </xs:restriction>
                                </xs:simpleType>
                              </xs:element>
                              <xs:element minOccurs=""0"" name=""CountryOfExport"" type=""Country"" />
                              <xs:element minOccurs=""0"" name=""CountryOfOrigin"" type=""Country"" />
                              <xs:element minOccurs=""0"" name=""CustomsQuantity"" type=""xs:decimal"" />
                              <xs:element minOccurs=""0"" name=""CustomsQuantityUnit"" type=""CodeDescriptionPair"" />
                              <xs:element minOccurs=""0"" name=""CustomsSecondQuantity"" type=""xs:decimal"" />
                              <xs:element minOccurs=""0"" name=""CustomsSecondQuantityUnit"" type=""CodeDescriptionPair"" />
                              <xs:element minOccurs=""0"" name=""CustomsThirdQuantity"" type=""xs:decimal"" />
                              <xs:element minOccurs=""0"" name=""CustomsThirdQuantityUnit"" type=""CodeDescriptionPair"" />
                              <xs:element minOccurs=""0"" name=""CustomsValue"" type=""xs:decimal"" />
                              <xs:element minOccurs=""0"" name=""DataImportMatchingKey"">
                                <xs:simpleType>
                                  <xs:restriction base=""xs:string"">
                                    <xs:maxLength value=""35"" />
                                  </xs:restriction>
                                </xs:simpleType>
                              </xs:element>
                              <xs:element minOccurs=""0"" name=""Description"">
                                <xs:simpleType>
                                  <xs:restriction base=""xs:string"">
                                    <xs:maxLength value=""525"" />
                                  </xs:restriction>
                                </xs:simpleType>
                              </xs:element>
                              <xs:element minOccurs=""0"" name=""EntryInstructionLink"" type=""xs:int"" />
                              <xs:element minOccurs=""0"" name=""EntryLineNumber"" type=""xs:short"" />
                              <xs:element minOccurs=""0"" name=""EntryNumber"">
                                <xs:simpleType>
                                  <xs:restriction base=""xs:string"">
                                    <xs:maxLength value=""35"" />
                                  </xs:restriction>
                                </xs:simpleType>
                              </xs:element>
                              <xs:element minOccurs=""0"" name=""HarmonisedCode"">
                                <xs:simpleType>
                                  <xs:restriction base=""xs:string"">
                                    <xs:maxLength value=""35"" />
                                  </xs:restriction>
                                </xs:simpleType>
                              </xs:element>
                              <xs:element minOccurs=""0"" name=""HazardousMaterial"">
                                <xs:complexType>
                                  <xs:all>
                                    <xs:element minOccurs=""0"" name=""Code"">
                                      <xs:simpleType>
                                        <xs:restriction base=""xs:string"">
                                          <xs:maxLength value=""10"" />
                                        </xs:restriction>
                                      </xs:simpleType>
                                    </xs:element>
                                    <xs:element minOccurs=""0"" name=""CodeType"" type=""CodeDescriptionPair1Char"" />
                                    <xs:element minOccurs=""0"" name=""UNDGCollection"">
                                      <xs:complexType>
                                        <xs:sequence>
                                          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""UNDG"" type=""UNDG"" />
                                        </xs:sequence>
                                      </xs:complexType>
                                    </xs:element>
                                  </xs:all>
                                </xs:complexType>
                              </xs:element>
                              <xs:element minOccurs=""0"" name=""InvoiceQuantity"" type=""xs:decimal"" />
                              <xs:element minOccurs=""0"" name=""InvoiceQuantityUnit"" type=""CodeDescriptionPair"" />
                              <xs:element minOccurs=""0"" name=""LandedCostDetail"">
                                <xs:complexType>
                                  <xs:all>
                                    <xs:element minOccurs=""0"" name=""CustomsCostPerUnit"" type=""xs:decimal"" />
                                    <xs:element minOccurs=""0"" name=""GoodsItemCostPerUnit"" type=""xs:decimal"" />
                                    <xs:element minOccurs=""0"" name=""MarkUp1"" type=""xs:decimal"" />
                                    <xs:element minOccurs=""0"" name=""MarkUp2"" type=""xs:decimal"" />
                                    <xs:element minOccurs=""0"" name=""MarkUp3"" type=""xs:decimal"" />
                                    <xs:element minOccurs=""0"" name=""TransportAndLogisticsCostPerUnit"" type=""xs:decimal"" />
                                    <xs:element minOccurs=""0"" name=""LandedLineCostItemCollection"">
                                      <xs:complexType>
                                        <xs:sequence>
                                          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""LandedLineCostItem"" type=""LandedLineCostItem"" />
                                        </xs:sequence>
                                      </xs:complexType>
                                    </xs:element>
                                  </xs:all>
                                </xs:complexType>
                              </xs:element>
                              <xs:element minOccurs=""0"" name=""LinePrice"" type=""xs:decimal"" />
                              <xs:element minOccurs=""0"" name=""Link"" type=""xs:int"" />
                              <xs:element minOccurs=""0"" name=""Model"">
                                <xs:simpleType>
                                  <xs:restriction base=""xs:string"">
                                    <xs:maxLength value=""50"" />
                                  </xs:restriction>
                                </xs:simpleType>
                              </xs:element>
                              <xs:element minOccurs=""0"" name=""NetWeight"" type=""xs:decimal"" />
                              <xs:element minOccurs=""0"" name=""NetWeightUnit"" type=""UnitOfWeight"" />
                              <xs:element minOccurs=""0"" name=""OrderLineLink"" type=""xs:int"" />
                              <xs:element minOccurs=""0"" name=""OrderNumber"">
                                <xs:simpleType>
                                  <xs:restriction base=""xs:string"">
                                    <xs:maxLength value=""20"" />
                                  </xs:restriction>
                                </xs:simpleType>
                              </xs:element>
                              <xs:element minOccurs=""0"" name=""ParentLineNo"" type=""xs:int"" />
                              <xs:element minOccurs=""0"" name=""PartNo"">
                                <xs:simpleType>
                                  <xs:restriction base=""xs:string"">
                                    <xs:maxLength value=""35"" />
                                  </xs:restriction>
                                </xs:simpleType>
                              </xs:element>
                              <xs:element minOccurs=""0"" name=""PreviousEntryLineNumber"" type=""xs:short"" />
                              <xs:element minOccurs=""0"" name=""PreviousEntryNumber"">
                                <xs:simpleType>
                                  <xs:restriction base=""xs:string"">
                                    <xs:maxLength value=""35"" />
                                  </xs:restriction>
                                </xs:simpleType>
                              </xs:element>
                              <xs:element minOccurs=""0"" name=""PrimaryPreference"">
                                <xs:simpleType>
                                  <xs:restriction base=""xs:string"">
                                    <xs:maxLength value=""10"" />
                                  </xs:restriction>
                                </xs:simpleType>
                              </xs:element>
                              <xs:element minOccurs=""0"" name=""Procedure"">
                                <xs:simpleType>
                                  <xs:restriction base=""xs:string"">
                                    <xs:maxLength value=""7"" />
                                  </xs:restriction>
                                </xs:simpleType>
                              </xs:element>
                              <xs:element minOccurs=""0"" name=""RelatedIndicator"" type=""CodeDescriptionPair"" />
                              <xs:element minOccurs=""0"" name=""SecondaryPreference"">
                                <xs:simpleType>
                                  <xs:restriction base=""xs:string"">
                                    <xs:maxLength value=""10"" />
                                  </xs:restriction>
                                </xs:simpleType>
                              </xs:element>
                              <xs:element minOccurs=""0"" name=""StateOfOrigin"" type=""State"" />
                              <xs:element minOccurs=""0"" name=""TaxType"" type=""CodeDescriptionPair"" />
                              <xs:element minOccurs=""0"" name=""UnitPrice"" type=""xs:decimal"" />
                              <xs:element minOccurs=""0"" name=""ValuationCode"" type=""CodeDescriptionPair"" />
                              <xs:element minOccurs=""0"" name=""ValuationMarkup"" type=""xs:decimal"" />
                              <xs:element minOccurs=""0"" name=""Volume"" type=""xs:decimal"" />
                              <xs:element minOccurs=""0"" name=""VolumeUnit"" type=""UnitOfVolume"" />
                              <xs:element minOccurs=""0"" name=""Weight"" type=""xs:decimal"" />
                              <xs:element minOccurs=""0"" name=""WeightUnit"" type=""UnitOfWeight"" />
                              <xs:element minOccurs=""0"" name=""AddInfoCollection"">
                                <xs:complexType>
                                  <xs:sequence>
                                    <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""AddInfo"" type=""AddInfo"" />
                                  </xs:sequence>
                                </xs:complexType>
                              </xs:element>
                              <xs:element minOccurs=""0"" name=""AddInfoGroupCollection"">
                                <xs:complexType>
                                  <xs:sequence>
                                    <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""AddInfoGroup"" type=""AddInfoGroup"" />
                                  </xs:sequence>
                                </xs:complexType>
                              </xs:element>
                              <xs:element minOccurs=""0"" name=""AdditionalLineTariffDetailCollection"">
                                <xs:complexType>
                                  <xs:sequence>
                                    <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""AdditionalLineTariffDetail"">
                                      <xs:complexType>
                                        <xs:all>
                                          <xs:element minOccurs=""0"" name=""CustomsQuantity"" type=""xs:decimal"" />
                                          <xs:element minOccurs=""0"" name=""CustomsQuantityUnit"" type=""CodeDescriptionPair"" />
                                          <xs:element minOccurs=""0"" name=""Tariff"">
                                            <xs:simpleType>
                                              <xs:restriction base=""xs:string"">
                                                <xs:maxLength value=""35"" />
                                              </xs:restriction>
                                            </xs:simpleType>
                                          </xs:element>
                                          <xs:element minOccurs=""0"" name=""Type"" type=""CodeDescriptionPair5Char"" />
                                          <xs:element minOccurs=""0"" name=""Value"" type=""xs:decimal"" />
                                        </xs:all>
                                      </xs:complexType>
                                    </xs:element>
                                  </xs:sequence>
                                </xs:complexType>
                              </xs:element>
                              <xs:element minOccurs=""0"" name=""CommercialChargeCollection"">
                                <xs:complexType>
                                  <xs:sequence>
                                    <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CommercialCharge"" type=""CommercialCharge"" />
                                  </xs:sequence>
                                </xs:complexType>
                              </xs:element>
                              <xs:element minOccurs=""0"" name=""CustomizedFieldCollection"">
                                <xs:complexType>
                                  <xs:sequence>
                                    <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CustomizedField"" type=""CustomizedField"" />
                                  </xs:sequence>
                                </xs:complexType>
                              </xs:element>
                              <xs:element minOccurs=""0"" name=""CustomsReferenceCollection"">
                                <xs:complexType>
                                  <xs:sequence>
                                    <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CustomsReference"" type=""CustomsReference"" />
                                  </xs:sequence>
                                </xs:complexType>
                              </xs:element>
                              <xs:element minOccurs=""0"" name=""CustomsSupportingInformationCollection"">
                                <xs:complexType>
                                  <xs:sequence>
                                    <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CustomsSupportingInformation"" type=""CustomsSupportingInformation"" />
                                  </xs:sequence>
                                </xs:complexType>
                              </xs:element>
                              <xs:element minOccurs=""0"" name=""EntryReferenceCollection"">
                                <xs:complexType>
                                  <xs:sequence>
                                    <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""EntryReference"">
                                      <xs:complexType>
                                        <xs:all>
                                          <xs:element minOccurs=""1"" name=""LineNumber"" type=""xs:short"" />
                                          <xs:element minOccurs=""1"" name=""Reference"">
                                            <xs:simpleType>
                                              <xs:restriction base=""xs:string"">
                                                <xs:maxLength value=""35"" />
                                              </xs:restriction>
                                            </xs:simpleType>
                                          </xs:element>
                                          <xs:element minOccurs=""1"" name=""Type"" type=""EntryType"" />
                                        </xs:all>
                                      </xs:complexType>
                                    </xs:element>
                                  </xs:sequence>
                                </xs:complexType>
                              </xs:element>
                              <xs:element minOccurs=""0"" name=""OrganizationAddressCollection"">
                                <xs:complexType>
                                  <xs:sequence>
                                    <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""OrganizationAddress"" type=""OrganizationAddress"" />
                                  </xs:sequence>
                                </xs:complexType>
                              </xs:element>
                              <xs:element minOccurs=""0"" name=""TaxOrFeeCollection"">
                                <xs:complexType>
                                  <xs:sequence>
                                    <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""TaxOrFee"" type=""TaxOrFee"" />
                                  </xs:sequence>
                                </xs:complexType>
                              </xs:element>
                              <xs:element minOccurs=""0"" name=""TransportLogisticsCostCollection"">
                                <xs:complexType>
                                  <xs:sequence>
                                    <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""TransportLogisticsCost"" type=""TransportLogisticsCost"" />
                                  </xs:sequence>
                                </xs:complexType>
                              </xs:element>
                            </xs:all>
                          </xs:complexType>
                        </xs:element>
                      </xs:sequence>
                      <xs:attribute name=""Content"" type=""CollectionContent"" />
                    </xs:complexType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""CustomizedFieldCollection"">
                    <xs:complexType>
                      <xs:sequence>
                        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CustomizedField"" type=""CustomizedField"" />
                      </xs:sequence>
                    </xs:complexType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""CustomsReferenceCollection"">
                    <xs:complexType>
                      <xs:sequence>
                        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CustomsReference"" type=""CustomsReference"" />
                      </xs:sequence>
                    </xs:complexType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""CustomsSupportingInformationCollection"">
                    <xs:complexType>
                      <xs:sequence>
                        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CustomsSupportingInformation"" type=""CustomsSupportingInformation"" />
                      </xs:sequence>
                    </xs:complexType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""NoteCollection"">
                    <xs:complexType>
                      <xs:sequence>
                        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Note"" type=""Note"" />
                      </xs:sequence>
                    </xs:complexType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""OrganizationAddressCollection"">
                    <xs:complexType>
                      <xs:sequence>
                        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""OrganizationAddress"" type=""OrganizationAddress"" />
                      </xs:sequence>
                    </xs:complexType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""PackingLinkCollection"">
                    <xs:complexType>
                      <xs:sequence>
                        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PackingLink"">
                          <xs:complexType>
                            <xs:all>
                              <xs:element minOccurs=""1"" name=""PackingLineLink"" type=""xs:int"" />
                              <xs:element minOccurs=""0"" name=""PackedQuantity"" type=""xs:decimal"" />
                            </xs:all>
                          </xs:complexType>
                        </xs:element>
                      </xs:sequence>
                    </xs:complexType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""TransportLogisticsCostCollection"">
                    <xs:complexType>
                      <xs:sequence>
                        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""TransportLogisticsCost"" type=""TransportLogisticsCost"" />
                      </xs:sequence>
                    </xs:complexType>
                  </xs:element>
                </xs:all>
              </xs:complexType>
            </xs:element>
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CustomsReferenceCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CustomsReference"" type=""CustomsReference"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""SubGroupCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""SubGroup"" type=""CommercialInfo"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""TransportLogisticsCostCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""TransportLogisticsCost"" type=""TransportLogisticsCost"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""Commodity"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""Code"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""4"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Description"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""Confirmation"">
    <xs:all>
      <xs:element minOccurs=""0"" name=""ActualDate"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""ActualOutDate"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""DateDescription"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""80"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Demurrage"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""Distance"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""DistanceUnit"" type=""UnitOfLength"" />
      <xs:element minOccurs=""0"" name=""EstimatedDate"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""EstimatedOutDate"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""IsEmptyContainer"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""LegLink"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""Quantity"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""ReceivedBy"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""50"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Reference"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""20"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""RequiredFromDate"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""RequiredToDate"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""ServiceInstruction"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""2147483646"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""SlotDate"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""SlotReference"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""20"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""Container"">
    <xs:all>
      <xs:element minOccurs=""0"" name=""AirVentFlow"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""AirVentFlowRateUnit"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""ArrivalCartageAdvised"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""ArrivalCartageComplete"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""ArrivalCartageDemurrageCharge"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""ArrivalCartageDemurrageTime"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""ArrivalCartageRef"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""20"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""ArrivalDeliveryRequiredBy"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""ArrivalEstimatedDelivery"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""ArrivalPickupByRail"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""ArrivalSlotDateTime"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""ArrivalSlotReference"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""15"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CarbonGasLevel"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""CarbonGasLevelUnit"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""Commodity"" type=""Commodity"" />
      <xs:element minOccurs=""0"" name=""ContainerCount"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""ContainerDetentionCharge"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""ContainerDetentionDays"" type=""xs:unsignedByte"" />
      <xs:element minOccurs=""0"" name=""ContainerImportDORelease"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""15"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""ContainerNumber"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""20"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""ContainerParkEmptyPickupGateOut"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""ContainerParkEmptyReturnGateIn"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""ContainerQuality"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""ContainerStatus"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""ContainerType"">
        <xs:complexType>
          <xs:all>
            <xs:element minOccurs=""1"" name=""Code"">
              <xs:simpleType>
                <xs:restriction base=""xs:string"">
                  <xs:maxLength value=""10"" />
                </xs:restriction>
              </xs:simpleType>
            </xs:element>
            <xs:element minOccurs=""0"" name=""Category"">
              <xs:complexType>
                <xs:all>
                  <xs:element minOccurs=""1"" name=""Code"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""3"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""Description"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""35"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:element>
                </xs:all>
              </xs:complexType>
            </xs:element>
            <xs:element minOccurs=""0"" name=""Description"">
              <xs:simpleType>
                <xs:restriction base=""xs:string"">
                  <xs:maxLength value=""35"" />
                </xs:restriction>
              </xs:simpleType>
            </xs:element>
            <xs:element minOccurs=""0"" name=""ISOCode"">
              <xs:simpleType>
                <xs:restriction base=""xs:string"">
                  <xs:maxLength value=""4"" />
                </xs:restriction>
              </xs:simpleType>
            </xs:element>
          </xs:all>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CustomsContainerSize"" type=""CodeDescriptionPair2Char"" />
      <xs:element minOccurs=""0"" name=""DeliveryMode"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""7"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""DeliverySequence"" type=""xs:short"" />
      <xs:element minOccurs=""0"" name=""DepartureCartageAdvised"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""DepartureCartageComplete"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""DepartureCartageDemurrageCharge"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""DepartureCartageDemurrageTime"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""DepartureCartageRef"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""20"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""DepartureDeliveryByRail"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""DepartureDockReceipt"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""20"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""DepartureEstimatedPickup"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""DepartureSlotDateTime"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""DepartureSlotReference"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""15"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""DunnageWeight"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""EmptyReadyForReturn"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""EmptyRequired"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""EmptyReturnedBy"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""EmptyReturnRef"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""20"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""ExportDepotCustomsReference"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""20"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""FCL_LCL_AIR"" type=""ContainerMode"" />
      <xs:element minOccurs=""0"" name=""FCLAvailable"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""FCLHeldInTransitStaging"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""FCLOnBoardVessel"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""FCLStorageArrivedUnderbond"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""FCLStorageCharge"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""FCLStorageCommences"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""FCLStorageDays"" type=""xs:unsignedByte"" />
      <xs:element minOccurs=""0"" name=""FCLStorageModuleOnlyMaster"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""20"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""FCLStorageUnderbondCleared"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""FCLUnloadFromVessel"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""FCLWharfGateIn"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""FCLWharfGateOut"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""GoodsDescription"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""GoodsValue"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""GoodsValueCurrency"" type=""Currency"" />
      <xs:element minOccurs=""0"" name=""GoodsWeight"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""GrossWeight"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""GrossWeightVerificationDateTime"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""GrossWeightVerificationType"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""HarmonisedCode"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""15"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""HumidityPercent"" type=""xs:unsignedByte"" />
      <xs:element minOccurs=""0"" name=""IsCFSRegistered"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""IsChargeable"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""IsControlledAtmosphere"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""IsDamaged"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""IsEmptyContainer"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""IsNonOperating"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""IsPalletised"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""IsSealOk"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""IsShipperOwned"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""ItemCount"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""LCLAvailable"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""LCLStorageCommences"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""LCLUnpack"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""LengthUnit"" type=""UnitOfLength"" />
      <xs:element minOccurs=""0"" name=""Link"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""MessageStatus"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""NitrogenGasLevel"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""NitrogenGasLevelUnit"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""OverhangBack"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""OverhangFront"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""OverhangHeight"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""OverhangLeft"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""OverhangRight"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""OverrideFCLAvailableStorage"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""OverrideLCLAvailableStorage"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""OxygenGasLevel"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""OxygenGasLevelUnit"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""PackDate"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""PalletCount"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""RefrigGeneratorID"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""17"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""ReleaseNum"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""20"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Seal"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""20"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""SealPartyType"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""SecondSeal"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""20"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""SecondSealPartyType"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""SetPointTemp"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""SetPointTempUnit"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""1"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""StowagePosition"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""25"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""TareWeight"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""TempRecorderSerialNo"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""20"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""ThirdSeal"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""20"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""ThirdSealPartyType"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""TotalHeight"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""TotalLength"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""TotalWidth"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""TrainWagonNumber"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""10"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""TransportReference"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""UnpackGang"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""10"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""UnpackShed"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""10"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""VolumeCapacity"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""VolumeUnit"" type=""UnitOfVolume"" />
      <xs:element minOccurs=""0"" name=""WeightCapacity"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""WeightUnit"" type=""UnitOfWeight"" />
      <xs:element minOccurs=""0"" name=""AddInfoCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""AddInfo"" type=""AddInfo"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""AddInfoGroupCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""AddInfoGroup"" type=""AddInfoGroup"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""AdditionalReferenceCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""AdditionalReference"" type=""AdditionalReference"" />
          </xs:sequence>
          <xs:attribute name=""Content"" type=""CollectionContent"" />
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""AdditionalServiceCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""AdditionalService"" type=""AdditionalService"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CustomizedFieldCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CustomizedField"" type=""CustomizedField"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CustomsReferenceCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CustomsReference"" type=""CustomsReference"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""MilestoneCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Milestone"" type=""Milestone"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""OrganizationAddressCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""OrganizationAddress"" type=""OrganizationAddress"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""PackingLineCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PackingLine"" type=""PackingLine"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""TransportLogisticsCostCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""TransportLogisticsCost"" type=""TransportLogisticsCost"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""UNDGCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""UNDG"" type=""UNDG"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""ContainerLink"">
    <xs:all>
      <xs:element minOccurs=""0"" name=""ContainerNumber"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""20"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Link"" type=""xs:int"" />
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""ContainerMode"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""Code"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""3"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Description"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""CustomsReference"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""Type"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""IsOverridden"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""Order"" type=""xs:short"" />
      <xs:element minOccurs=""0"" name=""Reference"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""100"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""ReferencedEntityDescription"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""255"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""SubType"" type=""CodeDescriptionPair35Char"" />
      <xs:element minOccurs=""0"" name=""DateCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Date"" type=""Date"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""CustomsSupportingInformation"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""Category"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""Country"" type=""Country"" />
      <xs:element minOccurs=""0"" name=""CustomsOffice"" type=""CodeDescriptionPair10Char"" />
      <xs:element minOccurs=""0"" name=""DateOfIssue"" type=""emptiable_date"" />
      <xs:element minOccurs=""0"" name=""Description"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""300"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""LineNo"" type=""xs:short"" />
      <xs:element minOccurs=""0"" name=""Procedure"" type=""CodeDescriptionPair7Char"" />
      <xs:element minOccurs=""0"" name=""Quantity"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""Quantity2"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""ReferenceNumber"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""100"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Status"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""SubType"" type=""CodeDescriptionPair5Char"" />
      <xs:element minOccurs=""0"" name=""Tariff"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Type"" type=""CodeDescriptionPair6Char"" />
      <xs:element minOccurs=""0"" name=""UnitOfQuantity"" type=""CodeDescriptionPair4Char"" />
      <xs:element minOccurs=""0"" name=""UnitOfQuantity2"" type=""CodeDescriptionPair4Char"" />
      <xs:element minOccurs=""0"" name=""ReferenceNumberCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ReferenceNumber"" type=""Reference"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""Date"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""Type"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:enumeration value=""AvailableExFactory"" />
            <xs:enumeration value=""Pickup"" />
            <xs:enumeration value=""Pack"" />
            <xs:enumeration value=""Departure"" />
            <xs:enumeration value=""FirstArrivalInCountry"" />
            <xs:enumeration value=""Arrival"" />
            <xs:enumeration value=""Unpack"" />
            <xs:enumeration value=""Delivery"" />
            <xs:enumeration value=""BillIssued"" />
            <xs:enumeration value=""ShippedOnBoard"" />
            <xs:enumeration value=""WarehouseRelease"" />
            <xs:enumeration value=""BookingConfirmed"" />
            <xs:enumeration value=""DeliveryRequiredBy"" />
            <xs:enumeration value=""DepartureVesselCutoffDate"" />
            <xs:enumeration value=""ExWorksRequiredBy"" />
            <xs:enumeration value=""FollowUp"" />
            <xs:enumeration value=""ClientRequestedETA"" />
            <xs:enumeration value=""Received"" />
            <xs:enumeration value=""LoadingDate"" />
            <xs:enumeration value=""DischargeDate"" />
            <xs:enumeration value=""EntrySubmitted"" />
            <xs:enumeration value=""EntryAuthorisation"" />
            <xs:enumeration value=""LocalTransportPickup"" />
            <xs:enumeration value=""LocalTransportDelivery"" />
            <xs:enumeration value=""LocalTransportCompleted"" />
            <xs:enumeration value=""OrderDate"" />
            <xs:enumeration value=""CutOffDate"" />
            <xs:enumeration value=""FirstForeignArrival"" />
            <xs:enumeration value=""LastForeignDeparture"" />
            <xs:enumeration value=""EntryDate"" />
            <xs:enumeration value=""TransferOfLiability"" />
            <xs:enumeration value=""ISFLastAccepted"" />
            <xs:enumeration value=""BillRequiredBy"" />
            <xs:enumeration value=""DateAtOffice"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""IsEstimate"" type=""xs:boolean"" />
      <xs:element minOccurs=""1"" name=""Value"" type=""emptiable_dateTime"" />
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""DropMode"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""Code"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""3"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Description"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""80"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""EntryHeader"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""Type"" type=""EntryType"" />
      <xs:element minOccurs=""0"" name=""Reference"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""EntryInstructionLink"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""EntryReleaseDate"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""EntryStatus"" type=""EntryStatus"" />
      <xs:element minOccurs=""0"" name=""EntrySubmittedDate"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""MessageStatus"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""TotalAmountPaid"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""AddInfoCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""AddInfo"" type=""AddInfo"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""AddInfoGroupCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""AddInfoGroup"" type=""AddInfoGroup"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CustomsReferenceCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CustomsReference"" type=""CustomsReference"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CustomsSupportingInformationCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CustomsSupportingInformation"" type=""CustomsSupportingInformation"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""EntryHeaderChargeCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""EntryHeaderCharge"">
              <xs:complexType>
                <xs:all>
                  <xs:element minOccurs=""1"" name=""Type"" type=""CodeDescriptionPair"" />
                  <xs:element minOccurs=""1"" name=""Amount"" type=""xs:decimal"" />
                </xs:all>
              </xs:complexType>
            </xs:element>
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""EntryLineCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""EntryLine"">
              <xs:complexType>
                <xs:all>
                  <xs:element minOccurs=""1"" name=""LineNumber"" type=""xs:short"" />
                  <xs:element minOccurs=""0"" name=""CustomsStatus"" type=""CodeDescriptionPair"" />
                  <xs:element minOccurs=""0"" name=""CustomsValue"" type=""xs:decimal"" />
                  <xs:element minOccurs=""0"" name=""Description"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""512"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""DutyRateFlatAmount"" type=""xs:decimal"" />
                  <xs:element minOccurs=""0"" name=""DutyRateFlatAmountUnit"" type=""CodeDescriptionPair"" />
                  <xs:element minOccurs=""0"" name=""DutyRatePercent"" type=""xs:decimal"" />
                  <xs:element minOccurs=""0"" name=""HarmonisedCode"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""15"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""AddInfoCollection"">
                    <xs:complexType>
                      <xs:sequence>
                        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""AddInfo"" type=""AddInfo"" />
                      </xs:sequence>
                    </xs:complexType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""CustomsReferenceCollection"">
                    <xs:complexType>
                      <xs:sequence>
                        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CustomsReference"" type=""CustomsReference"" />
                      </xs:sequence>
                    </xs:complexType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""CustomsSupportingInformationCollection"">
                    <xs:complexType>
                      <xs:sequence>
                        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CustomsSupportingInformation"" type=""CustomsSupportingInformation"" />
                      </xs:sequence>
                    </xs:complexType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""EntryLineChargeCollection"">
                    <xs:complexType>
                      <xs:sequence>
                        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""EntryLineCharge"">
                          <xs:complexType>
                            <xs:all>
                              <xs:element minOccurs=""1"" name=""Type"" type=""CodeDescriptionPair"" />
                              <xs:element minOccurs=""1"" name=""Amount"" type=""xs:decimal"" />
                              <xs:element minOccurs=""0"" name=""BaseValue"" type=""xs:decimal"" />
                              <xs:element minOccurs=""0"" name=""IsLandedCostOnly"" type=""xs:boolean"" />
                              <xs:element minOccurs=""0"" name=""MethodOfCalculation"" type=""CodeDescriptionPair"" />
                              <xs:element minOccurs=""0"" name=""MethodOfPayment"" type=""CodeDescriptionPair"" />
                              <xs:element minOccurs=""0"" name=""Rate"" type=""xs:decimal"" />
                              <xs:element minOccurs=""0"" name=""RateOverrideReason"" type=""CodeDescriptionPair"" />
                            </xs:all>
                          </xs:complexType>
                        </xs:element>
                      </xs:sequence>
                    </xs:complexType>
                  </xs:element>
                </xs:all>
              </xs:complexType>
            </xs:element>
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""EntryNumberCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""EntryNumber"">
              <xs:complexType>
                <xs:all>
                  <xs:element minOccurs=""1"" name=""Type"" type=""EntryType"" />
                  <xs:element minOccurs=""1"" name=""Number"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""35"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""EntryIsSystemGenerated"" type=""xs:boolean"" />
                  <xs:element minOccurs=""0"" name=""EntryStatus"" type=""EntryStatus"" />
                  <xs:element minOccurs=""0"" name=""IssueDate"" type=""emptiable_dateTime"" />
                </xs:all>
              </xs:complexType>
            </xs:element>
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""RelatedEntryHeaderCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""RelatedEntryHeader"" type=""EntryHeader"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""EntryInstruction"">
    <xs:all>
      <xs:element minOccurs=""0"" name=""CustomsOffice"" type=""CodeDescriptionPair5Char"" />
      <xs:element minOccurs=""0"" name=""DateAtCustomsOffice"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""DateOfValuation"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""Description"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""50"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""FirstArrival"" type=""UNLOCO"" />
      <xs:element minOccurs=""0"" name=""Link"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""LocationAtClearance"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""MergeBy"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""Style"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""7"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""AddInfoCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""AddInfo"" type=""AddInfo"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""AddInfoGroupCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""AddInfoGroup"" type=""AddInfoGroup"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CustomsReferenceCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CustomsReference"" type=""CustomsReference"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""OrganizationAddressCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""OrganizationAddress"" type=""OrganizationAddress"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""EntryNumber"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""Number"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""1"" name=""Type"" type=""EntryType"" />
      <xs:element minOccurs=""0"" name=""CountryOfIssue"" type=""Country"" />
      <xs:element minOccurs=""0"" name=""EntryIsSystemGenerated"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""EntryLineReference"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""10"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""EntryStatus"" type=""EntryStatus"" />
      <xs:element minOccurs=""0"" name=""ExpiryDate"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""IssueDate"" type=""emptiable_dateTime"" />
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""EntryStatus"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""Code"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""3"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Description"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""EntryType"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""Code"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""3"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Description"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""Guarantee"">
    <xs:all>
      <xs:element minOccurs=""0"" name=""AccessCode"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""4"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""ActivityCode"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""BondAmount"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""BondCurrency"" type=""Currency"" />
      <xs:element minOccurs=""0"" name=""BondFiledPort"" type=""CodeDescriptionPair8Char"" />
      <xs:element minOccurs=""0"" name=""BondNumber"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""BondNumber2"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""BondType"" type=""CodeDescriptionPair1Char"" />
      <xs:element minOccurs=""0"" name=""CountryOfIssue"" type=""Country"" />
      <xs:element minOccurs=""0"" name=""HolderIdentification"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""SuretyCode"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""3"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""ValidityLimitation"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""IncoTerm"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""Code"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""3"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Description"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""IsNeutralMaster"">
    <xs:simpleContent>
      <xs:extension base=""xs:boolean"">
        <xs:attribute name=""CreateAndAllocateNeutralStock"" type=""xs:boolean"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""LandedLineCostItem"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""CostType"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""CostAmount"" type=""xs:decimal"" />
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""OrganizationContact"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""FullName"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""50"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Email"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""60"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Phone"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""20"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""PackageType"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""Code"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""3"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Description"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""PackingLine"">
    <xs:all>
      <xs:element minOccurs=""0"" name=""Barcode"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""50"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""BillNumber"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""BillType"" type=""WayBillType"" />
      <xs:element minOccurs=""0"" name=""Commodity"" type=""Commodity"" />
      <xs:element minOccurs=""0"" name=""ContainerLink"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""ContainerNumber"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""20"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""ContainerPackingOrder"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""CountryOfOrigin"" type=""Country"" />
      <xs:element minOccurs=""0"" name=""CustomsOuterPacks"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""CustomsPackType"" type=""PackageType"" />
      <xs:element minOccurs=""0"" name=""DetailedDescription"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""2147483647"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""EndItemNo"" type=""xs:short"" />
      <xs:element minOccurs=""0"" name=""EntryType"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""3"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""ExemptionReason"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""1"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""ExportReferenceNumber"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""27"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""GoodsDescription"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""65"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""HarmonisedCode"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""15"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Height"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""ImportReferenceNumber"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""27"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""InBondPackQty"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""IsFlammable"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""IsHVLVClearance"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""IsPerishable"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""IsPersonalEffects"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""IsSignatureRequired"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""IsTimber"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""ItemNo"" type=""xs:short"" />
      <xs:element minOccurs=""0"" name=""Length"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""LengthUnit"" type=""UnitOfLength"" />
      <xs:element minOccurs=""0"" name=""LinePrice"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""LinePriceCurrency"" type=""Currency"" />
      <xs:element minOccurs=""0"" name=""Link"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""LoadingMeters"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""ManifestedVolume"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""ManifestedWeight"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""MarksAndNos"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""2147483647"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""MRN"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""MRNComplete"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""1"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""NMFC"">
        <xs:complexType>
          <xs:all>
            <xs:element minOccurs=""1"" name=""Class"">
              <xs:simpleType>
                <xs:restriction base=""xs:string"">
                  <xs:maxLength value=""8"" />
                </xs:restriction>
              </xs:simpleType>
            </xs:element>
            <xs:element minOccurs=""1"" name=""Code"">
              <xs:simpleType>
                <xs:restriction base=""xs:string"">
                  <xs:maxLength value=""15"" />
                </xs:restriction>
              </xs:simpleType>
            </xs:element>
            <xs:element minOccurs=""1"" name=""ItemNo"">
              <xs:simpleType>
                <xs:restriction base=""xs:string"">
                  <xs:maxLength value=""6"" />
                </xs:restriction>
              </xs:simpleType>
            </xs:element>
            <xs:element minOccurs=""0"" name=""Description"">
              <xs:simpleType>
                <xs:restriction base=""xs:string"">
                  <xs:maxLength value=""240"" />
                </xs:restriction>
              </xs:simpleType>
            </xs:element>
          </xs:all>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""OrderReference"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""OutturnComment"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""250"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""OutturnDamagedQty"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""OutturnedHeight"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""OutturnedLength"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""OutturnedVolume"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""OutturnedWeight"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""OutturnedWidth"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""OutturnPillagedQty"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""OutturnQty"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""PackQty"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""PackType"" type=""PackageType"" />
      <xs:element minOccurs=""0"" name=""PortMessaging"" type=""PortMessaging"" />
      <xs:element minOccurs=""0"" name=""ReferenceNumber"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""46"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""RequiredTemperatureMaximum"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""RequiredTemperatureMinimum"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""RequiredTemperatureUnit"" type=""CodeDescriptionPair1Char"" />
      <xs:element minOccurs=""0"" name=""RequiresFumigationCertificate"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""RequiresTemperatureControl"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""ShippingSymbol"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""2147483647"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""TransportReference"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Vehicle"" type=""Vehicle"" />
      <xs:element minOccurs=""0"" name=""Volume"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""VolumeUnit"" type=""UnitOfVolume"" />
      <xs:element minOccurs=""0"" name=""Weight"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""WeightUnit"" type=""UnitOfWeight"" />
      <xs:element minOccurs=""0"" name=""Width"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""AddInfoCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""AddInfo"" type=""AddInfo"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""AddInfoGroupCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""AddInfoGroup"" type=""AddInfoGroup"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""AdditionalServiceCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""AdditionalService"" type=""AdditionalService"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""ClassificationCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Classification"" type=""Classification"" />
          </xs:sequence>
          <xs:attribute name=""Content"" type=""CollectionContent"" />
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CustomizedFieldCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CustomizedField"" type=""CustomizedField"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""PackedItemCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PackedItem"">
              <xs:complexType>
                <xs:all>
                  <xs:element minOccurs=""0"" name=""CommercialInvoiceLineLink"" type=""xs:int"" />
                  <xs:element minOccurs=""0"" name=""Description"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""512"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:element>
                  <xs:element minOccurs=""0"" name=""GoodsValue"" type=""xs:decimal"" />
                  <xs:element minOccurs=""0"" name=""GrossWeight"" type=""xs:decimal"" />
                  <xs:element minOccurs=""0"" name=""GrossWeightUnit"" type=""UnitOfWeight"" />
                  <xs:element minOccurs=""0"" name=""NetWeight"" type=""xs:decimal"" />
                  <xs:element minOccurs=""0"" name=""NetWeightUnit"" type=""UnitOfWeight"" />
                  <xs:element minOccurs=""0"" name=""OrderLineLink"" type=""xs:int"" />
                  <xs:element minOccurs=""0"" name=""PackedQuantity"" type=""xs:decimal"" />
                  <xs:element minOccurs=""0"" name=""Product"" type=""Product"" />
                  <xs:element minOccurs=""0"" name=""UnitOfQuantity"" type=""PackageType"" />
                </xs:all>
              </xs:complexType>
            </xs:element>
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""PackingLineCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PackingLine"" type=""PackingLine"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""ReferenceNumberCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ReferenceNumber"" type=""Reference"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""UNDGCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""UNDG"" type=""UNDG"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""PaymentHandlingInstruction"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""Category"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""1"" name=""PaymentMethod"" type=""CodeDescriptionPair"" />
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""PortMessaging"">
    <xs:all>
      <xs:element minOccurs=""0"" name=""Annex30AFailureProcess"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""Annex30AType"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""ATB"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""25"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Berth"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""10"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""BillNo"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CustomsReleaseDate"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""Date"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""Departure"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""Destination"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""5"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Email"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""128"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""ExemptionReason"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""ExportDeclarationNumber"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""18"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Fax"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""20"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""ForwardingCustomsOfficeCode"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""8"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""MessagePurpose"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""3"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""MRN"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""70"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""MRNComplete"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""1"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""OperatorName"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""100"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Remarks"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""100"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""SenderAgentCode"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""70"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""SenderAgentName"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""100"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""SendingAgentQuayAccount"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""70"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""ShipperCode"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""70"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""ShipperName"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""100"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""ShipperQuayAccount"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""70"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""ShippingLine"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""24"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Telephone"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""20"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""TypeOfDeclaration"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""VesselName"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""VoyageNo"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""10"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""Product"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""Code"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Description"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""80"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""ReceivedFromShipper"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""Code"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""2"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Description"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""80"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Number"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""15"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""Reference"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""Type"" type=""EntryType"" />
      <xs:element minOccurs=""0"" name=""ReferenceNumber"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""ServiceLevel"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""Code"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""3"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CarrierChargeCode"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""10"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CarrierProductCode"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""10"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CarrierProfileID"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""10"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CarrierServiceCode"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""4"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Description"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""TaxOrFee"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""Type"" type=""CodeDescriptionPair6Char"" />
      <xs:element minOccurs=""0"" name=""Amount"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""BaseQuantity"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""BaseQuantityUQ"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""BaseValue"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""MethodOfCalculation"" type=""CodeDescriptionPair4Char"" />
      <xs:element minOccurs=""0"" name=""MethodOfPayment"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""RateReasonOverride"" type=""CodeDescriptionPair"" />
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""TransportLeg"">
    <xs:all>
      <xs:element minOccurs=""0"" name=""PortOfDischarge"" type=""UNLOCO"" />
      <xs:element minOccurs=""0"" name=""PortOfLoading"" type=""UNLOCO"" />
      <xs:element minOccurs=""1"" name=""LegOrder"" type=""xs:unsignedByte"" />
      <xs:element minOccurs=""0"" name=""ActualArrival"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""ActualArrivalInPortOfLoading"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""ActualDeparture"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""AircraftType"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""ArrivalAt"" type=""OrganizationAddress"" />
      <xs:element minOccurs=""0"" name=""ArrivalBerth"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""10"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""ArrivalCTO"" type=""OrganizationAddress"" />
      <xs:element minOccurs=""0"" name=""ArrivalReference"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""20"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Carrier"" type=""OrganizationAddress"" />
      <xs:element minOccurs=""0"" name=""CarrierBookingReference"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""20"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CarrierServiceLevel"" type=""ServiceLevel"" />
      <xs:element minOccurs=""0"" name=""Creditor"" type=""OrganizationAddress"" />
      <xs:element minOccurs=""0"" name=""DepartureBerth"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""10"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""DepartureCTO"" type=""OrganizationAddress"" />
      <xs:element minOccurs=""0"" name=""DepartureFrom"" type=""OrganizationAddress"" />
      <xs:element minOccurs=""0"" name=""DepartureReference"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""20"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""DocumentCutOff"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""EstimatedArrival"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""EstimatedArrivalInPortOfLoading"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""EstimatedDeparture"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""FCLAvailability"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""FCLCutOff"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""FCLReceivalCommences"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""FCLStorage"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""HazzardCutOffDate"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""HazzardReceivalCommences"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""IsCargoOnly"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""LCLAvailability"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""LCLCutOff"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""LCLReceivalCommences"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""LCLStorageDate"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""LegNotes"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""2147483647"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""LegType"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:enumeration value=""Flight1"" />
            <xs:enumeration value=""Flight2"" />
            <xs:enumeration value=""Flight3"" />
            <xs:enumeration value=""Main"" />
            <xs:enumeration value=""PreCarriage"" />
            <xs:enumeration value=""OnForwarding"" />
            <xs:enumeration value=""Other"" />
            <xs:enumeration value=""LocalTransport"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Link"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""TransportMode"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:enumeration value=""Air"" />
            <xs:enumeration value=""Sea"" />
            <xs:enumeration value=""Road"" />
            <xs:enumeration value=""Rail"" />
            <xs:enumeration value=""Storage"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""VesselLloydsIMO"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""7"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""VesselName"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""VGMCutOff"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""VoyageFlightNo"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""10"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CustomizedFieldCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CustomizedField"" type=""CustomizedField"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""TransportLogisticsCost"">
    <xs:all>
      <xs:element minOccurs=""0"" name=""ChargeCode"" type=""ChargeCode"" />
      <xs:element minOccurs=""0"" name=""ChargeDescription"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CostAmount"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""CostCurrency"" type=""Currency"" />
      <xs:element minOccurs=""0"" name=""DistributeCostBy"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""LandedCostGroup"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""ServiceExRate"" type=""xs:decimal"" />
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""UNDG"">
    <xs:all>
      <xs:element minOccurs=""0"" name=""Contact"" type=""OrganizationContact"" />
      <xs:element minOccurs=""0"" name=""FlashPoint"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""25"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""IMOClass"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""4"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""MarinePollutant"" type=""UNDGMarinePollutant"" />
      <xs:element minOccurs=""0"" name=""PackedInLimitedQuantity"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""PackingGroup"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""3"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""PackQty"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""PackType"" type=""PackageType"" />
      <xs:element minOccurs=""0"" name=""ProperShippingName"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""100"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""SubLabel1"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""5"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""SubLabel2"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""3"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""TechicalName"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""100"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""UNDGCode"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""5"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Volume"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""VolumeUQ"" type=""UnitOfVolume"" />
      <xs:element minOccurs=""0"" name=""Weight"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""WeightUQ"" type=""UnitOfWeight"" />
      <xs:element minOccurs=""0"" name=""NoteCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Note"" type=""Note"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""UNDGMarinePollutant"">
    <xs:all>
      <xs:element minOccurs=""0"" name=""Code"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""1"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Description"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""50"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""UnitOfLength"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""Code"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""2"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Description"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""UnitOfVolume"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""Code"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""2"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Description"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""UnitOfWeight"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""Code"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""2"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Description"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""Vehicle"">
    <xs:all>
      <xs:element minOccurs=""0"" name=""Color"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Make"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Model"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""NumberOfDoors"" type=""xs:unsignedByte"" />
      <xs:element minOccurs=""0"" name=""Transmission"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""Year"" type=""xs:short"" />
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""WayBillType"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""Code"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""3"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Description"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
    </xs:all>
  </xs:complexType>
</xs:schema>";
        
        public UniversalShipment() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "UniversalShipment";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
