
using System.Web.Services.Description;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using Binding = System.Web.Services.Description.Binding;
using Message = System.Web.Services.Description.Message;
public class DocumentoWSDLInternetImpl {


	FacadeAcesso f = new FacadeAcesso();

    /**
     * 
     */
   public void  obterServicoWeb() {
        f.consultarServicoWeb();
    }
}
