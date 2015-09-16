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

/***
 * @author Cleber Lira
 * @version 1.0
 * @see março/2015
 */

public class Repositorio {

	private static final Logger LOGGER = Logger.getLogger(Repositorio.class.getName());
	/**
	 * @author Cleber
	 * @param triplaRDF
	 * @return void
	 */
	public void incluir(String triplaRDF  ){
		String directory = "MyDatabases/RepositorioSemantico/SWSEditor" ; 
		Dataset dataset = TDBFactory.createDataset(directory) ;
		GraphStore graphStore=GraphStoreFactory.create(dataset);
		UpdateAction.parseExecute(triplaRDF, graphStore);
	}
	
	/**
	 * @author Cleber
     * @param triplaRDF
	 * @return void
	 */
	public void Executarconsulta(String queryString){
		String directory = "MyDatabases/RepositorioSemantico/SWSEditor" ;
		Dataset dataset = TDBFactory.createDataset(directory) ;
		GraphStore graphStore=GraphStoreFactory.create(dataset);
		Dataset d = graphStore.toDataset();
	    //Descoberta semÂntica
		LOGGER.info("_________________________________________________");
	    Query query2 = QueryFactory.create(queryString);
	    QueryExecution qe = QueryExecutionFactory.create(query2, d);
		ResultSet results = qe.execSelect();
		// Output query results	
		ResultSetFormatter.out(System.out, results, query2);
		// Important - free up resources used running the query
		qe.close();
	}

}
