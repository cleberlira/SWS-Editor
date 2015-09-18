
using System.Web.Services.Description;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using Binding = System.Web.Services.Description.Binding;
using Message = System.Web.Services.Description.Message;

public class FacadeAcesso {


    
     consultarServicoWeb() {
        

    
       
            try
            {
                this.Cursor = Cursors.WaitCursor;

                XmlTextReader reader = new XmlTextReader(cboURL.Text);

                ServiceDescription service = ServiceDescription.Read(reader, false);

                WSDLParser parser = new WSDLParser(service);

                this.tvwService.Nodes.Add(parser.ServiceNode);
                this.cboURL.Items.Add(cboURL.Text);
                //http://soap.amazon.com/schemas2/AmazonWebServices.wsdl 
                //http://glkev.webs.innerhost.com/glkev_ws/weatherfetcher.asmx?wsdl
            }
            catch (Exception e)
            {
                MessageBox.Show("Call to the Structural Validation Service " + " invalid WSDL Document  ");
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }


     }


}
