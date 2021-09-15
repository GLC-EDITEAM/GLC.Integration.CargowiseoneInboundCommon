namespace GLC.Integration.CargowiseoneInboundCommon.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    public sealed class UniversalCommon : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://www.cargowise.com/Schemas/Universal/2011/11"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" elementFormDefault=""qualified"" targetNamespace=""http://www.cargowise.com/Schemas/Universal/2011/11"" version=""1.1"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:complexType name=""AttachedDocument"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""FileName"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""277"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""1"" name=""ImageData"" type=""xs:base64Binary"" />
      <xs:element minOccurs=""1"" name=""Type"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""IsPublished"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""SaveDateUTC"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""SavedBy"" type=""Staff"" />
      <xs:element minOccurs=""0"" name=""Source"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""VisibleBranchCode"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""3"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""VisibleCompanyCode"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""3"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""VisibleDepartmentCode"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""3"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""ContextCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Context"" type=""Context"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""BankAccount"">
    <xs:all>
      <xs:element minOccurs=""0"" name=""AccountName"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""AccountNumber"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""AccountType"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:enumeration value=""Credit"" />
            <xs:enumeration value=""Debit"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""AutoDDRFormat"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""BankBranch"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""15"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""BankBranchName"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""BankName"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""BankSwift"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Country"" type=""Country"" />
      <xs:element minOccurs=""0"" name=""Currency"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""3"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""EFTUserId"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""20"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""IBANNumber"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""IsDefaultAccount"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""Method"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""3"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""Branch"">
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
  <xs:complexType name=""Capability"">
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
  <xs:complexType name=""ChargeCode"">
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
  <xs:complexType name=""ChargeLine"">
    <xs:all>
      <xs:element minOccurs=""0"" name=""Branch"" type=""Branch"" />
      <xs:element minOccurs=""0"" name=""ChargeCode"" type=""ChargeCode"" />
      <xs:element minOccurs=""0"" name=""ChargeCodeGroup"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""CostAPInvoiceNumber"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""38"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CostApportionmentConsolNumber"" type=""EntityReference"" />
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
      <xs:element minOccurs=""0"" name=""Debtor"" type=""OrganizationReference"" />
      <xs:element minOccurs=""0"" name=""Department"" type=""Department"" />
      <xs:element minOccurs=""0"" name=""Description"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""1024"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""DisplaySequence"" type=""xs:short"" />
      <xs:element minOccurs=""0"" name=""ExternalCreditorCode"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""25"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""ExternalDebtorCode"">
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
      <xs:element minOccurs=""0"" name=""SellExchangeRate"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""SellGSTVATID"" type=""TaxID"" />
      <xs:element minOccurs=""0"" name=""SellInvoiceType"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""3"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""SellIsPosted"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""SellLocalAmount"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""SellOSAmount"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""SellOSCurrency"" type=""Currency"" />
      <xs:element minOccurs=""0"" name=""SellOSGSTVATAmount"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""SellPostedTransactionNumber"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""38"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""SellPostedTransactionType"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""3"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""SellReference"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
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
      <xs:element minOccurs=""0"" name=""SellRatingBasisCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""SellRatingBasis"" type=""RatingBasis"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""CodeDescriptionPair"">
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
  <xs:complexType name=""CodeDescriptionPair5Char"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""Code"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""5"" />
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
  <xs:complexType name=""Company"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""Code"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""3"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Country"" type=""Country"" />
      <xs:element minOccurs=""0"" name=""Name"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""100"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""Context"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""Type"" type=""ContextType"" />
      <xs:element minOccurs=""1"" name=""Value"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""2147483647"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""SubContextCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""SubContext"" type=""Context"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""ContextType"">
    <xs:simpleContent>
      <xs:extension base=""string_maxLength50"">
        <xs:attribute name=""Description"" type=""string_maxLength50"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""Conversation"">
    <xs:all>
      <xs:element minOccurs=""0"" name=""ConversationMessageCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ConversationMessage"" type=""ConversationMessage"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""ParticipantGroupCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ParticipantGroup"" type=""ParticipantGroup"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""ParticipantRelatedPartyCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ParticipantRelatedParty"" type=""ParticipantRelatedParty"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""ParticipantStaffCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ParticipantStaff"" type=""ParticipantStaff"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""ConversationMessage"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""ParticipantName"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""256"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""1"" name=""Text"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""2147483647"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CreatedTime"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""IsInternal"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""IsSystem"" type=""xs:boolean"" />
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""Country"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""Code"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""2"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Name"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""Currency"">
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
  <xs:complexType name=""CustomizedField"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""DataType"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:enumeration value=""String"" />
            <xs:enumeration value=""Byte"" />
            <xs:enumeration value=""Integer"" />
            <xs:enumeration value=""Decimal"" />
            <xs:enumeration value=""Boolean"" />
            <xs:enumeration value=""DateTime"" />
            <xs:enumeration value=""Short"" />
            <xs:enumeration value=""DateTimeOffset"" />
            <xs:enumeration value=""Geography"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""1"" name=""Key"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""32"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""1"" name=""Value"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""2147483647"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""DataContext"">
    <xs:all>
      <xs:element minOccurs=""0"" name=""DataSourceCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""DataSource"" type=""DataSource"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""ActionPurpose"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""CodesMappedToTarget"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""Company"" type=""Company"" />
      <xs:element minOccurs=""0"" name=""DataProvider"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""50"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""DocumentaryOverride"" type=""DocumentaryOverride"" />
      <xs:element minOccurs=""0"" name=""EnterpriseID"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""3"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""EventBranch"" type=""Branch"" />
      <xs:element minOccurs=""0"" name=""EventDepartment"" type=""Department"" />
      <xs:element minOccurs=""0"" name=""EventReference"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""128"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""EventType"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""EventUser"" type=""Staff"" />
      <xs:element minOccurs=""0"" name=""ServerID"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""3"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""TriggerCount"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""TriggerDate"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""TriggerDescription"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""50"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""TriggerReference"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""128"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""TriggerType"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:enumeration value=""Trigger"" />
            <xs:enumeration value=""Milestone"" />
            <xs:enumeration value=""Exception"" />
            <xs:enumeration value=""Manual"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""DataTargetCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""DataTarget"" type=""DataTarget"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""RecipientRoleCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""RecipientRole"" type=""RecipientRole"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""DataSource"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""Type"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Key"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""50"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""DataTarget"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""Type"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Key"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""50"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Owner"" type=""OrganizationAddress"" />
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""Department"">
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
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""DocumentaryOverride"">
    <xs:all>
      <xs:element minOccurs=""0"" name=""DataVersion"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""DocumentName"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""256"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""IsSystemDefined"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""Purpose"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""SubmissionVersion"" type=""xs:int"" />
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""DocumentTracking"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""DocumentPeriod"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""1"" name=""DocumentType"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""1"" name=""DocumentUsage"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""Category"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""Country"" type=""Country"" />
      <xs:element minOccurs=""0"" name=""DocumentNote"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""200"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""DocumentNumber"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""15"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""DocumentOwner"" type=""OrganizationAddress"" />
      <xs:element minOccurs=""0"" name=""IsDocumentCreditControl"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""IsOriginalDocumentRequired"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""ReceivedDate"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""ReceivedFromCustomsBroker"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""ReturnToShipper"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""SentToCustomsBroker"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""ValidToDate"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""DocumentTrackingAttributeCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""DocumentTrackingAttribute"" type=""DocumentTrackingAttribute"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""DocumentTrackingAttribute"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""Type"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Value"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""80"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""EntityReference"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""Type"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""40"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Key"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""Group"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""Code"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""15"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Name"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""64"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""ImportMetaData"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""Instruction"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:enumeration value=""Insert"" />
            <xs:enumeration value=""Update"" />
            <xs:enumeration value=""UpdateAndInsertIfNotFound"" />
            <xs:enumeration value=""Delete"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""PostingInstruction"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:enumeration value=""PostCost"" />
            <xs:enumeration value=""PostRevenue"" />
            <xs:enumeration value=""PostRevenueAndCost"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""MatchingCriteriaCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""MatchingCriteria"" type=""MatchingCriteria"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""InvoiceRemittance"">
    <xs:all>
      <xs:element minOccurs=""0"" name=""BillerAccountNumber"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""50"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""BillerCode"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""20"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""DebtorClientNumber"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""20"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""InvoiceRemittanceReference"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""60"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""InvoiceTransactionReference"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""8"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Message"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""160"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Type"" type=""CodeDescriptionPair"" />
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""JobCosting"">
    <xs:all>
      <xs:element minOccurs=""0"" name=""AccrualNotRecognized"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""AccrualRecognized"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""AgentRevenue"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""Branch"" type=""Branch"" />
      <xs:element minOccurs=""0"" name=""Currency"" type=""Currency"" />
      <xs:element minOccurs=""0"" name=""Department"" type=""Department"" />
      <xs:element minOccurs=""0"" name=""HomeBranch"" type=""Branch"" />
      <xs:element minOccurs=""0"" name=""LocalClientRevenue"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""OperationsStaff"" type=""Staff"" />
      <xs:element minOccurs=""0"" name=""OtherDebtorRevenue"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""SalesStaff"" type=""Staff"" />
      <xs:element minOccurs=""0"" name=""TotalAccrual"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""TotalCost"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""TotalJobProfit"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""TotalRevenue"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""TotalWIP"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""WIPNotRecognized"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""WIPRecognized"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""ChargeLineCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ChargeLine"" type=""ChargeLine"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""Language"">
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
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""MatchingCriteria"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""FieldName"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""50"" />
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
  <xs:complexType name=""Milestone"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""Description"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""50"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""1"" name=""EventCode"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""3"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""1"" name=""Sequence"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""ActualDate"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""ConditionReference"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""128"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""ConditionType"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""3"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""EstimatedDate"" type=""emptiable_dateTime"" />
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""Note"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""Description"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""50"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""1"" name=""IsCustomDescription"" type=""xs:boolean"" />
      <xs:element minOccurs=""1"" name=""NoteText"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""2147483647"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""NoteContext"" type=""NoteContext"" />
      <xs:element minOccurs=""0"" name=""Visibility"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""VisibleCompany"" type=""CodeDescriptionPair"" />
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""NoteContext"">
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
            <xs:maxLength value=""100"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""OrganizationAddress"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""AddressType"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""40"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""AdditionalAddressInformation"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""50"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Address1"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""50"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Address2"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""50"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""AddressOverride"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""AddressShortCode"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""25"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""City"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""25"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CompanyName"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""100"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Contact"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""256"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Country"" type=""Country"" />
      <xs:element minOccurs=""0"" name=""Email"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""60"" />
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
      <xs:element minOccurs=""0"" name=""GovRegNum"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""20"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""GovRegNumType"" type=""RegistrationNumberType"" />
      <xs:element minOccurs=""0"" name=""IsResidential"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""Mobile"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""20"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""OrganizationCode"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""12"" />
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
      <xs:element minOccurs=""0"" name=""Port"" type=""UNLOCO"" />
      <xs:element minOccurs=""0"" name=""Postcode"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""10"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""ScreeningStatus"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""State"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""25"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""SuppressAddressValidationError"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""UniversalNettingCode"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""UniversalOfficeCode"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""LocalAddressCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""LocalAddress"" type=""OrganizationLocalAddress"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""RegistrationNumberCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""RegistrationNumber"" type=""RegistrationNumber"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""OrganizationLocalAddress"">
    <xs:all>
      <xs:element minOccurs=""0"" name=""Address1"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""50"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Address2"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""50"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""City"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""50"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CompanyName"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""200"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Language"" type=""Language"" />
      <xs:element minOccurs=""0"" name=""Postcode"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""20"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""State"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""25"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""OrganizationReference"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""Type"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Key"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""OriginalReference"">
    <xs:all>
      <xs:element minOccurs=""0"" name=""OriginalTransactionComplianceSubType"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""3"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""OriginalTransactionDate"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""OriginalTransactionJobInvoiceNumber"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""38"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""OriginalTransactionNumber"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""38"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""OriginalTransactionReference"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""20"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""ParticipantGroup"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""Group"" type=""Group"" />
      <xs:element minOccurs=""0"" name=""IsActive"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""IsSubscribed"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""Location"" type=""UNLOCO"" />
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""ParticipantRelatedParty"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""Party"" type=""OrganizationAddress"" />
      <xs:element minOccurs=""1"" name=""RelatedPartyType"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:enumeration value=""Contact"" />
            <xs:enumeration value=""Organization"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""IsActive"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""IsSubscribed"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""Location"" type=""UNLOCO"" />
      <xs:element minOccurs=""0"" name=""Relation"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""30"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""ParticipantStaff"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""Staff"" type=""Staff"" />
      <xs:element minOccurs=""0"" name=""IsActive"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""IsSubscribed"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""JobTitle"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""128"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Location"" type=""UNLOCO"" />
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""RatingBasis"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""OriginType"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""50"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Currency"" type=""Currency"" />
      <xs:element minOccurs=""0"" name=""FlatRate"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""IsPercentageRate"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""MaximumRate"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""MinimumRate"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""OriginAdditionalReference"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""OriginKey"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""50"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""OriginQuantity"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""OriginQuantityUnit"" type=""RatingUnit"" />
      <xs:element minOccurs=""0"" name=""PerUnitRate"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""RateUnit"" type=""RatingUnit"" />
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""RatingUnit"">
    <xs:all>
      <xs:element minOccurs=""0"" name=""Code"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""25"" />
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
  <xs:complexType name=""RecipientRole"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""Code"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:enumeration value=""AAD"" />
            <xs:enumeration value=""ACF"" />
            <xs:enumeration value=""ACR"" />
            <xs:enumeration value=""ACT"" />
            <xs:enumeration value=""ACY"" />
            <xs:enumeration value=""AFR"" />
            <xs:enumeration value=""ARP"" />
            <xs:enumeration value=""ASY"" />
            <xs:enumeration value=""BCO"" />
            <xs:enumeration value=""BKP"" />
            <xs:enumeration value=""BRO"" />
            <xs:enumeration value=""BRI"" />
            <xs:enumeration value=""BRE"" />
            <xs:enumeration value=""BTP"" />
            <xs:enumeration value=""CAR"" />
            <xs:enumeration value=""CBA"" />
            <xs:enumeration value=""CCA"" />
            <xs:enumeration value=""CD4"" />
            <xs:enumeration value=""CLI"" />
            <xs:enumeration value=""CNE"" />
            <xs:enumeration value=""CNR"" />
            <xs:enumeration value=""COA"" />
            <xs:enumeration value=""CTA"" />
            <xs:enumeration value=""CTG"" />
            <xs:enumeration value=""CTO"" />
            <xs:enumeration value=""CTP"" />
            <xs:enumeration value=""CYD"" />
            <xs:enumeration value=""DAG"" />
            <xs:enumeration value=""DCA"" />
            <xs:enumeration value=""DCF"" />
            <xs:enumeration value=""DCR"" />
            <xs:enumeration value=""DCT"" />
            <xs:enumeration value=""DCY"" />
            <xs:enumeration value=""DTP"" />
            <xs:enumeration value=""FOR"" />
            <xs:enumeration value=""HCA"" />
            <xs:enumeration value=""HSA"" />
            <xs:enumeration value=""ICE"" />
            <xs:enumeration value=""IDB"" />
            <xs:enumeration value=""JWG"" />
            <xs:enumeration value=""LCT"" />
            <xs:enumeration value=""NFP"" />
            <xs:enumeration value=""NGP"" />
            <xs:enumeration value=""ORP"" />
            <xs:enumeration value=""PAG"" />
            <xs:enumeration value=""PCA"" />
            <xs:enumeration value=""PEM"" />
            <xs:enumeration value=""PER"" />
            <xs:enumeration value=""PIM"" />
            <xs:enumeration value=""PIR"" />
            <xs:enumeration value=""PRC"" />
            <xs:enumeration value=""PUP"" />
            <xs:enumeration value=""RAG"" />
            <xs:enumeration value=""SAG"" />
            <xs:enumeration value=""SGA"" />
            <xs:enumeration value=""SPM"" />
            <xs:enumeration value=""SRP"" />
            <xs:enumeration value=""TPC"" />
            <xs:enumeration value=""DTW"" />
            <xs:enumeration value=""ATW"" />
            <xs:enumeration value=""UAM"" />
            <xs:enumeration value=""WAR"" />
            <xs:enumeration value=""WIN"" />
            <xs:enumeration value=""BWI"" />
            <xs:enumeration value=""BWR"" />
            <xs:enumeration value=""WHS"" />
            <xs:enumeration value=""WNS"" />
            <xs:enumeration value=""YER"" />
            <xs:enumeration value=""YIA"" />
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
      <xs:element minOccurs=""0"" name=""ServiceCode"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:enumeration value=""AMD"" />
            <xs:enumeration value=""BRQ"" />
            <xs:enumeration value=""HLD"" />
            <xs:enumeration value=""SIN"" />
            <xs:enumeration value=""TWD"" />
            <xs:enumeration value=""TWR"" />
            <xs:enumeration value=""VGM"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""ServiceDescription"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""50"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""RegistrationNumber"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""Type"" type=""RegistrationNumberType"" />
      <xs:element minOccurs=""0"" name=""CountryOfIssue"" type=""Country"" />
      <xs:element minOccurs=""1"" name=""Value"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""254"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""RegistrationNumberType"">
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
  <xs:complexType name=""SettlementMethod"">
    <xs:all>
      <xs:element minOccurs=""0"" name=""AuthorizationExpiryDate"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""AuthorizationReference"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Method"" type=""CodeDescriptionPair"" />
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""Staff"">
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
            <xs:maxLength value=""256"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""StaffUsingAttributes"">
    <xs:simpleContent>
      <xs:extension base=""string_maxLength3"">
        <xs:attribute name=""Name"" type=""string_maxLength35"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""State"">
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
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Region"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""Task"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""Description"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""50"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""1"" name=""Sequence"" type=""xs:int"" />
      <xs:element minOccurs=""1"" name=""Status"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""1"" name=""TaskID"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""20"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""1"" name=""Type"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""ActualDuration"" type=""xs:duration"" />
      <xs:element minOccurs=""0"" name=""ActualStartTimeUTC"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""AssignedCapability"" type=""Capability"" />
      <xs:element minOccurs=""0"" name=""AssignedGroup"" type=""Group"" />
      <xs:element minOccurs=""0"" name=""AssignedStaff"" type=""Staff"" />
      <xs:element minOccurs=""0"" name=""CardNote"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""40"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CompletedTimeUTC"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""EstimatedDuration"" type=""xs:duration"" />
      <xs:element minOccurs=""0"" name=""EstimatedStartTimeUTC"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""EstimateVariationFactor"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""TaskNotes"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""2147483647"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""TaskSet"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""Description"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""2147483647"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""1"" name=""Type"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""AgreedDeliveryDateUTC"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""CurrentStatus"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""2147483647"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""DateAcceptability"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""EarliestStartDateUTC"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""IsActive"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""Notes"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""2147483647"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""ReleaseGroup"" type=""Group"" />
      <xs:element minOccurs=""0"" name=""TaskSetStatus"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""TaskCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Task"" type=""Task"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""TaskSetCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""TaskSet"" type=""TaskSet"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""TaxID"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""TaxCode"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""10"" />
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
      <xs:element minOccurs=""0"" name=""ExtraTaxRate"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""ExtraTaxType"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""TaxRate"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""TaxType"" type=""CodeDescriptionPair"" />
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""TaxMessageID"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""TaxMessageCode"">
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
      <xs:element minOccurs=""0"" name=""EnglishTaxMessage"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""255"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""TaxGroupCode"" type=""CodeDescriptionPair"" />
      <xs:element minOccurs=""0"" name=""VATGSTExemptionDocumentType"" type=""CodeDescriptionPair"" />
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""UNLOCO"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""Code"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""5"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Name"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:complexType name=""ValueTypePair"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""Type"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""1"" name=""Value"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
    </xs:all>
  </xs:complexType>
  <xs:simpleType name=""CollectionContent"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Complete"" />
      <xs:enumeration value=""Partial"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""emptiable_date"">
    <xs:union memberTypes=""xs:date empty_string"" />
  </xs:simpleType>
  <xs:simpleType name=""emptiable_dateTime"">
    <xs:union memberTypes=""xs:dateTime empty_string"" />
  </xs:simpleType>
  <xs:simpleType name=""empty_string"">
    <xs:restriction base=""xs:string"">
      <xs:length value=""0"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""string_maxLength10"">
    <xs:restriction base=""xs:string"">
      <xs:maxLength value=""10"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""string_maxLength3"">
    <xs:restriction base=""xs:string"">
      <xs:maxLength value=""3"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""string_maxLength35"">
    <xs:restriction base=""xs:string"">
      <xs:maxLength value=""35"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""string_maxLength4"">
    <xs:restriction base=""xs:string"">
      <xs:maxLength value=""4"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""string_maxLength50"">
    <xs:restriction base=""xs:string"">
      <xs:maxLength value=""50"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""string_maxLength80"">
    <xs:restriction base=""xs:string"">
      <xs:maxLength value=""80"" />
    </xs:restriction>
  </xs:simpleType>
</xs:schema>";
        
        public UniversalCommon() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [0];
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
