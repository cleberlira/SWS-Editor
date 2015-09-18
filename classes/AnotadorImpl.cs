/**
 * 
 */
public class AnotadorImpl : Anotador{

    DocumentoWSDLInternetImpl documentowsdl;
    OntologiaOWLImpl ontologiaOWL;
    ServicoWebBLL servicoweb;
    OwlBLL owlbll;
    /**
     * 
     */
     public ontologiaOWL acessarOntologiaOWL() {
        ontologiaOWL = new OntologiaOWLImpl();
		OntologiaOWLImpl =  documentoowl.getOnrologiaOWL();
		return OntologiaOWLImpl;
    }

    /**
     * 
     */
     public documentowsdl acessarServicoWeb() {
        documentowsdl = new DocumentoWSDLInternetImpl();
		documentowsdl.obterServicoWeb();
		return documentowsdl;
    }

    /**
     *  comportamentos realizados na  view    */
     adicionarMapeamentoEsquema() {
        // implement here...
    }

    /**
     *  comportamentos realizados na  view    */
    
     adicionarModeloReferencia() {
        // implement here...
    }

	 /**
     *  comportamentos realizados na  view    */
    
     realizarAnotacao( OntologiaOWL DocumentoWSDL) {
        // implement here...
    }

    /**
     * 
     */
   public void  removerOWL(OntologiaOWL ontologia) {
       owlbll = new OwlBLL();
	   owlbll.excluir(ontologia)
    }

    /**
     * 
     */
  public void   removerServicoWeb(ServicoWeb servicoweb) {
        servicoweb = new ServicoWebBLL();
		servicoweb.excluir(servicoweb);
		
    }
}
