namespace GLC.Integration.CargowiseoneInboundCommon.Schemas.Outbound.Q10 {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"GLC.Integration.CargowiseoneInboundCommon.Schemas.UniversalInterchange", typeof(global::GLC.Integration.CargowiseoneInboundCommon.Schemas.UniversalInterchange))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"GLC.Integration.CargowiseoneInboundCommon.Schemas.UniversalEvent", typeof(global::GLC.Integration.CargowiseoneInboundCommon.Schemas.UniversalEvent))]
    public sealed class Transformcargo997toUniversalEvent : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var"" version=""1.0"" xmlns:ns0=""http://www.cargowise.com/Schemas/Universal/2011/11"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/ns0:UniversalInterchange"" />
  </xsl:template>
  <xsl:template match=""/ns0:UniversalInterchange"">
    <ns0:UniversalEvent>
      <xsl:copy-of select=""ns0:Body/@*"" />
      <xsl:copy-of select=""ns0:Body/ns0:UniversalEvent/*"" />
    </ns0:UniversalEvent>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"GLC.Integration.CargowiseoneInboundCommon.Schemas.UniversalInterchange";
        
        private const global::GLC.Integration.CargowiseoneInboundCommon.Schemas.UniversalInterchange _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"GLC.Integration.CargowiseoneInboundCommon.Schemas.UniversalEvent";
        
        private const global::GLC.Integration.CargowiseoneInboundCommon.Schemas.UniversalEvent _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"GLC.Integration.CargowiseoneInboundCommon.Schemas.UniversalInterchange";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"GLC.Integration.CargowiseoneInboundCommon.Schemas.UniversalEvent";
                return _TrgSchemas;
            }
        }
    }
}
