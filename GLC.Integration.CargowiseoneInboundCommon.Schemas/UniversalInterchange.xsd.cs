namespace GLC.Integration.CargowiseoneInboundCommon.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://www.cargowise.com/Schemas/Universal/2011/11",@"UniversalInterchange")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"UniversalInterchange"})]
    public sealed class UniversalInterchange : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://www.cargowise.com/Schemas/Universal/2011/11"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" elementFormDefault=""qualified"" targetNamespace=""http://www.cargowise.com/Schemas/Universal/2011/11"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""UniversalInterchange"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Header"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""SenderID"" type=""xs:string"" />
              <xs:element name=""RecipientID"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""Acknowledgement"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""Required"">
                      <xs:simpleType>
                        <xs:restriction base=""xs:string"">
                          <xs:enumeration value=""OnAll"" />
                          <xs:enumeration value=""OnError"" />
                          <xs:enumeration value=""OnSuccess"" />
                        </xs:restriction>
                      </xs:simpleType>
                    </xs:element>
                    <xs:element name=""Channel"">
                      <xs:simpleType>
                        <xs:restriction base=""xs:string"">
                          <xs:enumeration value=""eHub"" />
                          <xs:enumeration value=""eAdaptor"" />
                        </xs:restriction>
                      </xs:simpleType>
                    </xs:element>
                    <xs:element name=""RecipientID"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""ContextCollection"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element maxOccurs=""unbounded"" name=""Context"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""Type"" type=""xs:string"" />
                                <xs:element name=""Value"" type=""xs:string"" />
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""Body"">
          <xs:complexType>
            <xs:sequence>
              <xs:any minOccurs=""0"" maxOccurs=""unbounded"" processContents=""skip"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
      <xs:attribute name=""version"" type=""xs:token"" />
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public UniversalInterchange() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "UniversalInterchange";
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
