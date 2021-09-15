namespace GLC.Integration.CargowiseoneInboundCommon.Pipelines
{
    using System;
    using System.Collections.Generic;
    using Microsoft.BizTalk.PipelineOM;
    using Microsoft.BizTalk.Component;
    using Microsoft.BizTalk.Component.Interop;
    
    
    public sealed class SendFlatCSVLinc : Microsoft.BizTalk.PipelineOM.SendPipeline
    {
        
        private const string _strPipeline = "<?xml version=\"1.0\" encoding=\"utf-16\"?><Document xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instanc"+
"e\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" MajorVersion=\"1\" MinorVersion=\"0\">  <Description /> "+
" <CategoryId>8c6b051c-0ff5-4fc2-9ae5-5016cb726282</CategoryId>  <FriendlyName>Transmit</FriendlyName"+
">  <Stages>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"1\" Name=\"Pre-Assemble\" minO"+
"ccurs=\"0\" maxOccurs=\"-1\" execMethod=\"All\" stageId=\"9d0e4101-4cce-4536-83fa-4a5040674ad6\" />      <Co"+
"mponents>        <Component>          <Name>GLC.Integration.CargowiseoneInboundCommon.PipelineCompon"+
"ents.LincFileName,GLC.Integration.CargowiseoneInboundCommon.PipelineComponents, Version=1.0.0.0, Cul"+
"ture=neutral, PublicKeyToken=21389b4d08145e85</Name>          <ComponentName>GetLincFileName</Compon"+
"entName>          <Description>Get LincFilename</Description>          <Version>1.0</Version>       "+
"   <Properties />          <CachedDisplayName>GetLincFileName</CachedDisplayName>          <CachedIs"+
"Managed>true</CachedIsManaged>        </Component>      </Components>    </Stage>    <Stage>      <P"+
"olicyFileStage _locAttrData=\"Name\" _locID=\"2\" Name=\"Assemble\" minOccurs=\"0\" maxOccurs=\"1\" execMethod"+
"=\"All\" stageId=\"9d0e4107-4cce-4536-83fa-4a5040674ad6\" />      <Components>        <Component>       "+
"   <Name>Microsoft.BizTalk.Component.FFAsmComp,Microsoft.BizTalk.Pipeline.Components, Version=3.0.1."+
"0, Culture=neutral, PublicKeyToken=31bf3856ad364e35</Name>          <ComponentName>Flat file assembl"+
"er</ComponentName>          <Description>Flat file assembler component.</Description>          <Vers"+
"ion>1.0</Version>          <Properties>            <Property Name=\"HeaderSpecName\" />            <Pr"+
"operty Name=\"DocumentSpecName\" />            <Property Name=\"TrailerSpecName\" />            <Propert"+
"y Name=\"TargetCharset\">              <Value xsi:type=\"xsd:string\" />            </Property>         "+
"   <Property Name=\"TargetCodePage\">              <Value xsi:type=\"xsd:int\">0</Value>            </Pr"+
"operty>            <Property Name=\"PreserveBom\">              <Value xsi:type=\"xsd:boolean\">false</V"+
"alue>            </Property>            <Property Name=\"HiddenProperties\">              <Value xsi:t"+
"ype=\"xsd:string\">TargetCodePage</Value>            </Property>          </Properties>          <Cach"+
"edDisplayName>Flat file assembler</CachedDisplayName>          <CachedIsManaged>true</CachedIsManage"+
"d>        </Component>      </Components>    </Stage>    <Stage>      <PolicyFileStage _locAttrData="+
"\"Name\" _locID=\"3\" Name=\"Encode\" minOccurs=\"0\" maxOccurs=\"-1\" execMethod=\"All\" stageId=\"9d0e4108-4cce"+
"-4536-83fa-4a5040674ad6\" />      <Components />    </Stage>  </Stages></Document>";
        
        private const string _versionDependentGuid = "35577f58-675c-4b7a-92fa-6346f6c155f0";
        
        public SendFlatCSVLinc()
        {
            Microsoft.BizTalk.PipelineOM.Stage stage = this.AddStage(new System.Guid("9d0e4101-4cce-4536-83fa-4a5040674ad6"), Microsoft.BizTalk.PipelineOM.ExecutionMode.all);
            IBaseComponent comp0 = Microsoft.BizTalk.PipelineOM.PipelineManager.CreateComponent("GLC.Integration.CargowiseoneInboundCommon.PipelineComponents.LincFileName,GLC.Integration.CargowiseoneInboundCommon.PipelineComponents, Version=1.0.0.0, Culture=neutral, PublicKeyToken=21389b4d08145e85");;
            if (comp0 is IPersistPropertyBag)
            {
                string comp0XmlProperties = "<?xml version=\"1.0\" encoding=\"utf-16\"?><PropertyBag xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-inst"+
"ance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">  <Properties /></PropertyBag>";
                PropertyBag pb = PropertyBag.DeserializeFromXml(comp0XmlProperties);;
                ((IPersistPropertyBag)(comp0)).Load(pb, 0);
            }
            this.AddComponent(stage, comp0);
            stage = this.AddStage(new System.Guid("9d0e4107-4cce-4536-83fa-4a5040674ad6"), Microsoft.BizTalk.PipelineOM.ExecutionMode.all);
            IBaseComponent comp1 = Microsoft.BizTalk.PipelineOM.PipelineManager.CreateComponent("Microsoft.BizTalk.Component.FFAsmComp,Microsoft.BizTalk.Pipeline.Components, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35");;
            if (comp1 is IPersistPropertyBag)
            {
                string comp1XmlProperties = "<?xml version=\"1.0\" encoding=\"utf-16\"?><PropertyBag xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-inst"+
"ance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">  <Properties>    <Property Name=\"HeaderSpecName\""+
" />    <Property Name=\"DocumentSpecName\" />    <Property Name=\"TrailerSpecName\" />    <Property Name"+
"=\"TargetCharset\">      <Value xsi:type=\"xsd:string\" />    </Property>    <Property Name=\"TargetCodeP"+
"age\">      <Value xsi:type=\"xsd:int\">0</Value>    </Property>    <Property Name=\"PreserveBom\">      "+
"<Value xsi:type=\"xsd:boolean\">false</Value>    </Property>    <Property Name=\"HiddenProperties\">    "+
"  <Value xsi:type=\"xsd:string\">TargetCodePage</Value>    </Property>  </Properties></PropertyBag>";
                PropertyBag pb = PropertyBag.DeserializeFromXml(comp1XmlProperties);;
                ((IPersistPropertyBag)(comp1)).Load(pb, 0);
            }
            this.AddComponent(stage, comp1);
        }
        
        public override string XmlContent
        {
            get
            {
                return _strPipeline;
            }
        }
        
        public override System.Guid VersionDependentGuid
        {
            get
            {
                return new System.Guid(_versionDependentGuid);
            }
        }
    }
}
