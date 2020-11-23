<%@ Import Namespace="System.Xml" %>
<script language="C#" runat="Server">
   void Page_Load(object sender, EventArgs e) {
      String sXML = "<?xml version=\"1.0\"?><root><testA>";
      sXML += "<testChild>Testing!</testChild></testA></root>";
      XmlDocument oDocument = new XmlDocument();
      oDocument.LoadXml(sXML);   
      XmlNode oRoot = oDocument.DocumentElement;
      try {
          XmlElement oElement1 = oDocument.CreateElement("testB");
          oElement1.SetAttribute("testBAtt","Testing B");
          XmlElement oElement2 = oDocument.CreateElement("testC");
          oElement2.AppendChild(oDocument.CreateTextNode("Text Node"));
		  oElement2.SetAttribute("testCAtt","Testing C");
          oRoot.AppendChild(oElement1);
          oRoot.AppendChild(oElement2);
      }
      catch(Exception exc) {
          Response.Write(exc.ToString());
      }                   
      Response.ContentType ="text/xml";
      oDocument.Save(Response.Output);	
   }
</script>
