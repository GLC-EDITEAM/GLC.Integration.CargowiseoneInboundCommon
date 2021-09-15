namespace GLC.Integration.CargowiseoneInboundCommon.Schemas.Outbound.LINC {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"GLC.Integration.CargowiseoneInboundCommon.Schemas.UniversalEvent", typeof(global::GLC.Integration.CargowiseoneInboundCommon.Schemas.UniversalEvent))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"GLC.Integration.CargowiseoneInboundCommon.Schemas.Outbound.LINC.LincFlatFileCSV", typeof(global::GLC.Integration.CargowiseoneInboundCommon.Schemas.Outbound.LINC.LincFlatFileCSV))]
    public sealed class TransformLincEventToCSV : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://GLC.Integration.CargowiseoneInboundCommon.Schemas.outbound.Linc.LincFlatFileCSV"" xmlns:s0=""http://www.cargowise.com/Schemas/Universal/2011/11"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:UniversalEvent"" />
  </xsl:template>
  <xsl:template match=""/s0:UniversalEvent"">
    <ns0:LincCSV>
      <Record>
        <xsl:for-each select=""s0:Event/s0:ContextCollection"">
          <xsl:for-each select=""s0:Context"">
            <xsl:variable name=""var:v1"" select=""userCSharp:LogicalEq(string(s0:Type/text()) , &quot;CLIENT_REFERENCE&quot;)"" />
            <xsl:if test=""string($var:v1)='true'"">
              <xsl:variable name=""var:v2"" select=""s0:Value/text()"" />
              <OrderNo>
                <xsl:value-of select=""$var:v2"" />
              </OrderNo>
            </xsl:if>
          </xsl:for-each>
        </xsl:for-each>
        <xsl:for-each select=""s0:Event/s0:ContextCollection"">
          <xsl:for-each select=""s0:Context"">
            <xsl:variable name=""var:v3"" select=""string(s0:Type/text())"" />
            <xsl:variable name=""var:v4"" select=""userCSharp:LogicalEq($var:v3 , &quot;ProcessingResultStatus&quot;)"" />
            <xsl:if test=""string($var:v4)='true'"">
              <xsl:variable name=""var:v5"" select=""userCSharp:setStatus(string(s0:Value/text()))"" />
              <Status>
                <xsl:value-of select=""$var:v5"" />
              </Status>
            </xsl:if>
          </xsl:for-each>
        </xsl:for-each>
      </Record>
    </ns0:LincCSV>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp"">
    <![CDATA[
    public bool LogicalEq(string val1, string val2)
    {
     bool ret = false;double d1 = 0;double d2 = 0;if (IsNumeric(val1, ref d1) && IsNumeric(val2, ref d2)){ret = d1 == d2;}else{ret = String.Compare(val1, val2, StringComparison.Ordinal) == 0;}return ret;}public string setStatus(string strvalue)    {        if (strvalue == ""WAR"" || strvalue == ""PRS"")            {                return ""Order Sucessful"";            }        else if (strvalue == ""REJ"" || strvalue == ""DCD"" || strvalue == ""ERR"")            {                return ""Order Failed"";            }        else            {                return """";            }    }public bool IsNumeric(string val){if (val == null){return false;}double d = 0;return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);}public bool IsNumeric(string val, ref double d){if (val == null){return false;}return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);}]]></msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"GLC.Integration.CargowiseoneInboundCommon.Schemas.UniversalEvent";
        
        private const global::GLC.Integration.CargowiseoneInboundCommon.Schemas.UniversalEvent _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"GLC.Integration.CargowiseoneInboundCommon.Schemas.Outbound.LINC.LincFlatFileCSV";
        
        private const global::GLC.Integration.CargowiseoneInboundCommon.Schemas.Outbound.LINC.LincFlatFileCSV _trgSchemaTypeReference0 = null;
        
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
                _TrgSchemas[0] = @"GLC.Integration.CargowiseoneInboundCommon.Schemas.Outbound.LINC.LincFlatFileCSV";
                return _TrgSchemas;
            }
        }
    }
}
