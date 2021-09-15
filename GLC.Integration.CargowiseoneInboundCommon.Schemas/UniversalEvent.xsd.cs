namespace GLC.Integration.CargowiseoneInboundCommon.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://www.cargowise.com/Schemas/Universal/2011/11",@"UniversalEvent")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"UniversalEvent"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"GLC.Integration.CargowiseoneInboundCommon.Schemas.UniversalCommon", typeof(global::GLC.Integration.CargowiseoneInboundCommon.Schemas.UniversalCommon))]
    public sealed class UniversalEvent : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://www.cargowise.com/Schemas/Universal/2011/11"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" elementFormDefault=""qualified"" targetNamespace=""http://www.cargowise.com/Schemas/Universal/2011/11"" version=""1.1"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:include schemaLocation=""GLC.Integration.CargowiseoneInboundCommon.Schemas.UniversalCommon"" />
  <xs:element name=""UniversalEvent"" type=""UniversalEventData"" />
  <xs:complexType name=""UniversalEventData"">
    <xs:all>
      <xs:element name=""Event"" type=""Event"" />
    </xs:all>
    <xs:attribute name=""version"" type=""xs:token"" />
  </xs:complexType>
  <xs:complexType name=""Event"">
    <xs:all>
      <xs:element minOccurs=""0"" name=""DataContext"" type=""DataContext"" />
      <xs:element minOccurs=""1"" name=""EventTime"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""1"" name=""EventType"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""3"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CreatedTime"" type=""emptiable_dateTime"" />
      <xs:element minOccurs=""0"" name=""EventParameters"">
        <xs:complexType>
          <xs:all>
            <xs:element minOccurs=""0"" name=""CustomsReferenceNumber"">
              <xs:simpleType>
                <xs:restriction base=""xs:string"">
                  <xs:maxLength value=""256"" />
                </xs:restriction>
              </xs:simpleType>
            </xs:element>
            <xs:element minOccurs=""0"" name=""Department"">
              <xs:simpleType>
                <xs:restriction base=""xs:string"">
                  <xs:maxLength value=""256"" />
                </xs:restriction>
              </xs:simpleType>
            </xs:element>
            <xs:element minOccurs=""0"" name=""EquipmentReferenceNumber"">
              <xs:simpleType>
                <xs:restriction base=""xs:string"">
                  <xs:maxLength value=""256"" />
                </xs:restriction>
              </xs:simpleType>
            </xs:element>
            <xs:element minOccurs=""0"" name=""ExternalDocumentType"">
              <xs:simpleType>
                <xs:restriction base=""xs:string"">
                  <xs:maxLength value=""256"" />
                </xs:restriction>
              </xs:simpleType>
            </xs:element>
            <xs:element minOccurs=""0"" name=""Facility"">
              <xs:simpleType>
                <xs:restriction base=""xs:string"">
                  <xs:maxLength value=""256"" />
                </xs:restriction>
              </xs:simpleType>
            </xs:element>
            <xs:element minOccurs=""0"" name=""FlightDate"" type=""emptiable_dateTime"" />
            <xs:element minOccurs=""0"" name=""Location"">
              <xs:simpleType>
                <xs:restriction base=""xs:string"">
                  <xs:maxLength value=""256"" />
                </xs:restriction>
              </xs:simpleType>
            </xs:element>
            <xs:element minOccurs=""0"" name=""MessageSubType"">
              <xs:simpleType>
                <xs:restriction base=""xs:string"">
                  <xs:maxLength value=""256"" />
                </xs:restriction>
              </xs:simpleType>
            </xs:element>
            <xs:element minOccurs=""0"" name=""MessageType"">
              <xs:simpleType>
                <xs:restriction base=""xs:string"">
                  <xs:maxLength value=""256"" />
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
            <xs:element minOccurs=""0"" name=""New"">
              <xs:simpleType>
                <xs:restriction base=""xs:string"">
                  <xs:maxLength value=""256"" />
                </xs:restriction>
              </xs:simpleType>
            </xs:element>
            <xs:element minOccurs=""0"" name=""Old"">
              <xs:simpleType>
                <xs:restriction base=""xs:string"">
                  <xs:maxLength value=""256"" />
                </xs:restriction>
              </xs:simpleType>
            </xs:element>
            <xs:element minOccurs=""0"" name=""Partial"" type=""xs:int"" />
            <xs:element minOccurs=""0"" name=""Reason"">
              <xs:simpleType>
                <xs:restriction base=""xs:string"">
                  <xs:maxLength value=""256"" />
                </xs:restriction>
              </xs:simpleType>
            </xs:element>
            <xs:element minOccurs=""0"" name=""ReceiptNumber"">
              <xs:simpleType>
                <xs:restriction base=""xs:string"">
                  <xs:maxLength value=""256"" />
                </xs:restriction>
              </xs:simpleType>
            </xs:element>
            <xs:element minOccurs=""0"" name=""ReferenceNumber"">
              <xs:simpleType>
                <xs:restriction base=""xs:string"">
                  <xs:maxLength value=""256"" />
                </xs:restriction>
              </xs:simpleType>
            </xs:element>
            <xs:element minOccurs=""0"" name=""RequestNumber"">
              <xs:simpleType>
                <xs:restriction base=""xs:string"">
                  <xs:maxLength value=""256"" />
                </xs:restriction>
              </xs:simpleType>
            </xs:element>
            <xs:element minOccurs=""0"" name=""Service"">
              <xs:simpleType>
                <xs:restriction base=""xs:string"">
                  <xs:maxLength value=""256"" />
                </xs:restriction>
              </xs:simpleType>
            </xs:element>
            <xs:element minOccurs=""0"" name=""Total"" type=""xs:int"" />
            <xs:element minOccurs=""0"" name=""Type"">
              <xs:simpleType>
                <xs:restriction base=""xs:string"">
                  <xs:maxLength value=""256"" />
                </xs:restriction>
              </xs:simpleType>
            </xs:element>
            <xs:element minOccurs=""0"" name=""VoyageFlightNumber"">
              <xs:simpleType>
                <xs:restriction base=""xs:string"">
                  <xs:maxLength value=""256"" />
                </xs:restriction>
              </xs:simpleType>
            </xs:element>
          </xs:all>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""EventReference"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""1024"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""IsCancelled"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""IsEstimate"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""AdditionalContextCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""AdditionalContext"">
              <xs:complexType>
                <xs:all>
                  <xs:element minOccurs=""0"" name=""DataContext"" type=""DataContext"" />
                  <xs:element minOccurs=""0"" name=""ContextCollection"">
                    <xs:complexType>
                      <xs:sequence>
                        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Context"" type=""Context"" />
                      </xs:sequence>
                    </xs:complexType>
                  </xs:element>
                </xs:all>
              </xs:complexType>
            </xs:element>
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""AdditionalFieldsToUpdateCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""AdditionalFieldsToUpdate"">
              <xs:complexType>
                <xs:all>
                  <xs:element minOccurs=""1"" name=""Type"">
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
            </xs:element>
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""AttachedDocumentCollection"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""AttachedDocument"" type=""AttachedDocument"" />
          </xs:sequence>
        </xs:complexType>
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
</xs:schema>";
        
        public UniversalEvent() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "UniversalEvent";
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
