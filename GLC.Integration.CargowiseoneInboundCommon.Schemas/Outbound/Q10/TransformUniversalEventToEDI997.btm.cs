namespace GLC.Integration.CargowiseoneInboundCommon.Schemas.Outbound.Q10 {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"GLC.Integration.CargowiseoneInboundCommon.Schemas.UniversalEvent", typeof(global::GLC.Integration.CargowiseoneInboundCommon.Schemas.UniversalEvent))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Microsoft.BizTalk.Edi.BaseArtifacts.X12_997Schema+X12_997_Root", typeof(global::Microsoft.BizTalk.Edi.BaseArtifacts.X12_997Schema.X12_997_Root))]
    public sealed class TransformUniversalEventToEDI997 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://schemas.microsoft.com/Edi/X12"" xmlns:s0=""http://www.cargowise.com/Schemas/Universal/2011/11"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"" xmlns:ScriptNS0=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:UniversalEvent"" />
  </xsl:template>
  <xsl:template match=""/s0:UniversalEvent"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;OW&quot;)"" />
    <xsl:variable name=""var:v7"" select=""userCSharp:StringConcat(&quot;940&quot;)"" />
    <xsl:variable name=""var:v8"" select=""userCSharp:StringConcat(&quot;0001&quot;)"" />
    <xsl:variable name=""var:v16"" select=""userCSharp:StringConcat(&quot;1&quot;)"" />
    <ns0:X12_997_Root>
      <AK1>
        <AK101>
          <xsl:value-of select=""$var:v1"" />
        </AK101>
        <xsl:for-each select=""s0:Event/s0:ContextCollection"">
          <xsl:for-each select=""s0:Context"">
            <xsl:variable name =""strclnt"" select=""/*[local-name()='UniversalEvent' and namespace-uri()='http://www.cargowise.com/Schemas/Universal/2011/11']/*[local-name()='Event' and namespace-uri()='http://www.cargowise.com/Schemas/Universal/2011/11']/*[local-name()='ContextCollection' and namespace-uri()='http://www.cargowise.com/Schemas/Universal/2011/11']/*[local-name()='Context' and namespace-uri()='http://www.cargowise.com/Schemas/Universal/2011/11'][1]/*[local-name()='Value' and namespace-uri()='http://www.cargowise.com/Schemas/Universal/2011/11']""/>
            <!--For Q10-->
            <xsl:choose>
            <xsl:when test=""$strclnt='Q10'"">
             <xsl:variable name=""var:v2"" select=""userCSharp:LogicalEq(string(s0:Type/text()) , &quot;CLIENT_REFERENCE&quot;)"" />
            <xsl:variable name=""var:v3"" select=""string(s0:Type/text())"" />
            <xsl:variable name=""var:v4"" select=""userCSharp:LogicalEq($var:v3 , &quot;ClientReference&quot;)"" />
            <xsl:variable name=""var:v5"" select=""userCSharp:LogicalOr(string($var:v2) , string($var:v4))"" />
            <xsl:if test=""string($var:v5)='true'"">
              <xsl:variable name=""var:v6"" select=""s0:Value/text()"" />
              <AK102>
                <xsl:value-of select=""$var:v6"" />
              </AK102>
            </xsl:if>
            </xsl:when>
            <xsl:otherwise>
              <xsl:choose>
                <xsl:when test=""$strclnt='DGCASA'"">
                        <xsl:variable name=""var:v2"" select=""userCSharp:LogicalEq(string(s0:Type/text()) , &quot;CLIENT_REFERENCE&quot;)"" />
                  <xsl:variable name=""var:v3"" select=""string(s0:Type/text())"" />
                  <xsl:variable name=""var:v4"" select=""userCSharp:LogicalEq($var:v3 , &quot;ClientReference&quot;)"" />
                  <xsl:variable name=""var:v5"" select=""userCSharp:LogicalOr(string($var:v2) , string($var:v4))"" />
                  <xsl:if test=""string($var:v5)='true'"">
                    <xsl:variable name=""var:v6"" select=""s0:Value/text()"" />
                    <AK102>
                      <xsl:value-of select=""ScriptNS0:getgs03($var:v6)""/>
                    </AK102>
                  </xsl:if>
                </xsl:when>

                <xsl:otherwise>
                  <xsl:variable name=""var:v21"" select=""userCSharp:LogicalEq(string(s0:Type/text()) , &quot;PO_NUMBER&quot;)"" />
                  <xsl:variable name=""var:v31"" select=""string(s0:Type/text())"" />
                  <xsl:variable name=""var:v41"" select=""userCSharp:LogicalEq($var:v31 , &quot;PoNumber&quot;)"" />
                  <xsl:variable name=""var:v51"" select=""userCSharp:LogicalOr(string($var:v21) , string($var:v41))"" />
                  <xsl:if test=""string($var:v51)='true'"">
                    <xsl:variable name=""var:v61"" select=""s0:Value/text()"" />
                    <AK102>
                      <xsl:value-of select=""$var:v61"" />
                    </AK102>
                   </xsl:if>                
                </xsl:otherwise>               
                
              </xsl:choose>
            </xsl:otherwise>
            </xsl:choose>           
          </xsl:for-each>
        </xsl:for-each>
      </AK1>
      <AK2Loop>
        <AK2>
          <AK201>
            <xsl:value-of select=""$var:v7"" />
          </AK201>
          <AK202>
            <xsl:value-of select=""$var:v8"" />
          </AK202>
        </AK2>
        <AK5>
          <xsl:for-each select=""s0:Event/s0:ContextCollection"">
            <xsl:for-each select=""s0:Context"">
              <xsl:variable name=""var:v9"" select=""string(s0:Type/text())"" />
              <xsl:variable name=""var:v10"" select=""userCSharp:LogicalEq($var:v9 , &quot;ProcessingResultStatus&quot;)"" />
              <xsl:if test=""string($var:v10)='true'"">
                <xsl:variable name=""var:v11"" select=""userCSharp:setStatus(string(s0:Value/text()))"" />
                <AK501>
                  <xsl:value-of select=""$var:v11"" />
                </AK501>
              </xsl:if>
            </xsl:for-each>
          </xsl:for-each>
        </AK5>
      </AK2Loop>
      <AK9>
        <xsl:for-each select=""s0:Event/s0:ContextCollection"">
          <xsl:for-each select=""s0:Context"">
            <xsl:variable name=""var:v12"" select=""string(s0:Type/text())"" />
            <xsl:variable name=""var:v13"" select=""userCSharp:LogicalEq($var:v12 , &quot;ProcessingResultStatus&quot;)"" />
            <xsl:if test=""string($var:v13)='true'"">
              <xsl:variable name=""var:v14"" select=""string(s0:Value/text())"" />
              <xsl:variable name=""var:v15"" select=""userCSharp:setStatus($var:v14)"" />
              <AK901>
                <xsl:value-of select=""$var:v15"" />
              </AK901>
            </xsl:if>
          </xsl:for-each>
        </xsl:for-each>
        <AK902>
          <xsl:value-of select=""$var:v16"" />
        </AK902>
        <AK903>
          <xsl:value-of select=""$var:v16"" />
        </AK903>
        <xsl:for-each select=""s0:Event/s0:ContextCollection"">
          <xsl:for-each select=""s0:Context"">
            <xsl:variable name=""var:v17"" select=""string(s0:Type/text())"" />
            <xsl:variable name=""var:v18"" select=""userCSharp:LogicalEq($var:v17 , &quot;ProcessingResultStatus&quot;)"" />
            <xsl:if test=""string($var:v18)='true'"">
              <xsl:variable name=""var:v19"" select=""string(s0:Value/text())"" />
              <xsl:variable name=""var:v20"" select=""userCSharp:setStatus($var:v19)"" />
              <xsl:variable name=""var:v21"" select=""userCSharp:LogicalEq(string($var:v20) , &quot;A&quot;)"" />
              <xsl:if test=""string($var:v21)='true'"">
                <xsl:variable name=""var:v22"" select=""&quot;1&quot;"" />
                <AK904>
                  <xsl:value-of select=""$var:v22"" />
                </AK904>
              </xsl:if>
            </xsl:if>
            <xsl:if test=""string($var:v18)='true'"">
              <xsl:variable name=""var:v23"" select=""string(s0:Value/text())"" />
              <xsl:variable name=""var:v24"" select=""userCSharp:setStatus($var:v23)"" />
              <xsl:variable name=""var:v25"" select=""userCSharp:LogicalEq(string($var:v24) , &quot;R&quot;)"" />
              <xsl:if test=""string($var:v25)='true'"">
                <xsl:variable name=""var:v26"" select=""&quot;0&quot;"" />
                <AK904>
                  <xsl:value-of select=""$var:v26"" />
                </AK904>
              </xsl:if>
            </xsl:if>
          </xsl:for-each>
        </xsl:for-each>
      </AK9>
    </ns0:X12_997_Root>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp"">
    <![CDATA[public string StringConcat(string param0){   return param0;}public bool LogicalEq(string val1, string val2){bool ret = false;double d1 = 0;double d2 = 0;if (IsNumeric(val1, ref d1) && IsNumeric(val2, ref d2)){ret = d1 == d2;}else{ret = String.Compare(val1, val2, StringComparison.Ordinal) == 0;}return ret;}public string setStatus(string strvalue)    {        if (strvalue == ""WAR"" || strvalue == ""PRS"")            {                return ""A"";            }        else if (strvalue == ""REJ"" || strvalue == ""DCD"" || strvalue == ""ERR"")            {                return ""R"";            }        else            {                return """";            }    }public bool LogicalOr(string param0, string param1){return ValToBool(param0) || ValToBool(param1);return false;}public bool IsNumeric(string val){if (val == null){return false;}double d = 0;return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);}public bool IsNumeric(string val, ref double d){if (val == null){return false;}return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);}public bool ValToBool(string val){if (val != null){if (string.Compare(val, bool.TrueString, StringComparison.OrdinalIgnoreCase) == 0){return true;}if (string.Compare(val, bool.FalseString, StringComparison.OrdinalIgnoreCase) == 0){return false;}val = val.Trim();if (string.Compare(val, bool.TrueString, StringComparison.OrdinalIgnoreCase) == 0){return true;}if (string.Compare(val, bool.FalseString, StringComparison.OrdinalIgnoreCase) == 0){return false;}double d = 0;if (IsNumeric(val, ref d)){return (d > 0);}}return false;}]]>
  </msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects>
  <ExtensionObject Namespace=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"" AssemblyName=""GLC.Integration.Cargowiseone.DGcasa.Commonlib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=d36090e7ce53be2f"" ClassName=""GLC.Integration.Cargowiseone.DGcasa.Commonlib.GetEdidetails"" />
</ExtensionObjects>";
        
        private const string _strSrcSchemasList0 = @"GLC.Integration.CargowiseoneInboundCommon.Schemas.UniversalEvent";
        
        private const global::GLC.Integration.CargowiseoneInboundCommon.Schemas.UniversalEvent _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"Microsoft.BizTalk.Edi.BaseArtifacts.X12_997Schema+X12_997_Root";
        
        private const global::Microsoft.BizTalk.Edi.BaseArtifacts.X12_997Schema.X12_997_Root _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override int UseXSLTransform {
            get {
                return _useXSLTransform;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"GLC.Integration.CargowiseoneInboundCommon.Schemas.UniversalEvent";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Microsoft.BizTalk.Edi.BaseArtifacts.X12_997Schema+X12_997_Root";
                return _TrgSchemas;
            }
        }
    }
}
