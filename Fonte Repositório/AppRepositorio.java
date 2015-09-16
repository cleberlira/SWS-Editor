import com.hp.hpl.jena.query.Dataset;
import com.hp.hpl.jena.query.Query;
import com.hp.hpl.jena.query.QueryExecution;
import com.hp.hpl.jena.query.QueryExecutionFactory;
import com.hp.hpl.jena.query.QueryFactory;
import com.hp.hpl.jena.query.ResultSet;
import com.hp.hpl.jena.query.ResultSetFormatter;
import com.hp.hpl.jena.tdb.TDBFactory;
import com.hp.hpl.jena.update.GraphStore;
import com.hp.hpl.jena.update.GraphStoreFactory;
import com.hp.hpl.jena.update.UpdateAction;

import java.util.logging.Logger;

public class AppRepositorio {
	private static final Logger LOGGER = Logger.getLogger(AppRepositorio.class.getName());
	
	public static void main(String[] args) {
		Repositorio repositorio = new Repositorio();
		String triplaRDF="PREFIX sawsdl: <http://example.edu.unifacs/ontologies/bookstore.owl#Technologies> INSERT DATA{<http://example/categorization/books> sawsdl: 'Java'}";
		LOGGER.info("Inclusão no repositório Semântico");
		repositorio.incluir(triplaRDF);
		
		triplaRDF = "PREFIX sawsdl: <http://example.edu.unifacs/ontologies/bookstore.owl#Technologies> INSERT DATA{<http://example/categorization/books> sawsdl: 'C#'}";
		
		repositorio.incluir(triplaRDF);
		
		String queryString = 
	    		
	    "PREFIX sawsdl: <http://example.edu.unifacs/ontologies/bookstore.owl#Technologies>" + 
	    "SELECT ?livro " +
	    " WHERE {" +
	    " <http://example.edu.unifacs/ontologies/bookstore.owl#Technologies> <http://example/categorization/books> ?livro .}";
	  LOGGER.info("Realizando consulta repositório Semântico"); 
	  repositorio.Executarconsulta(queryString);	
	}
}
