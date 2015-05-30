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

/***
 * @author Cleber Lira
 * @version 1.0
 * @see março/2015
 */

public class LivrosSAWSDL {

	/**
	 * @author Cleber
	 * @param triplaRDF
	 * @return void
	 */
	public void incluir(String triplaRDF  ){
		String directory = "MyDatabases/RepositorioSemantico/SWSEditor" ; 
	
		Dataset dataset = TDBFactory.createDataset(directory) ;
			 
		
		GraphStore graphStore=GraphStoreFactory.create(dataset);
		
		String query="PREFIX sawsdl: <http://example.com/data/bookstore.owl#Technologies> INSERT DATA{<http://example/categorization/books> sawsdl: 'Java'}";
			
		UpdateAction.parseExecute(query, graphStore);
	}
	
	/**
	 * @author Cleber
     * @param triplaRDF
	 * @return void
	 */
	public void Executarconsulta(String query){
		String directory = "MyDatabases/RepositorioSemantico/SWSEditor" ;
		Dataset dataset = TDBFactory.createDataset(directory) ;
	    
		GraphStore graphStore=GraphStoreFactory.create(dataset);
			
		Dataset d = graphStore.toDataset();
		
		String queryString = 
	    		
	    		"PREFIX sawsdl: <http://example.com/data/bookstore.owl#Technologies>" + 
	    		"SELECT ?livro " +
	    		" WHERE {" +
	    		" <http://example.com/data/bookstore.owl#Technologies> <http://example/categorization/books> ?livro .}";

	    //Descoberta semÂntica
	    System.out.println("Consulta Semântica");
	    System.out.println("_________________________________________________");
	    System.out.println( queryString);
	    //Descoberta semÂntica
	    System.out.println("_________________________________________________");
	    Query query2 = QueryFactory.create(queryString);
	    QueryExecution qe = QueryExecutionFactory.create(query2, d);
		ResultSet results = qe.execSelect();

		// Output query results	
		ResultSetFormatter.out(System.out, results, query2);

		// Important - free up resources used running the query
		qe.close();

	}
	
	/**
	 * @author Cleber
     * @param args
	 * @return void
	 */
	public static void main(String[] args) {
		  String directory = "MyDatabases/RepositorioSemantico/SWSEditor" ;
		  Dataset dataset = TDBFactory.createDataset(directory) ;
		 
		// dataset.begin(ReadWrite.WRITE) ;
		  GraphStore graphStore=GraphStoreFactory.create(dataset);
		
	//	  http://example.data/bookstore.owl#categorization#books#technologies
		 
			  String query="PREFIX sawsdl: <http://example.edu.unifacs/ontologies/bookstore.owl#Technologies> INSERT DATA{<http://example/categorization/books> sawsdl: 'Java'}";
		  
			//  String query="PREFIX sawsdl: <http://example.com/data/bookstore.owl#Technologies> INSERT DATA{<http://example/categorization/books> sawsdl: 'Java'}";
			 		  
			  
		 // Model model = dataset.getDefaultModel() ;
	//	 String query="PREFIX sawsdl: <http://example.com/data/bookstore.owl#Technologies> INSERT DATA{<http://example/categorization/books> sawsdl: 'Java'}";
		 
		 
		 
		 String query4="PREFIX sawsdl: <http://example.edu.unifacs/ontologies/bookstore.owl#Technologies> INSERT DATA{<http://example/categorization/books> sawsdl: 'C#'}";
	
		  UpdateAction.parseExecute(query, graphStore);
		
		  UpdateAction.parseExecute(query4, graphStore);
		// System.out.print ( graphStore.isEmpty());
		 
		 Dataset d = graphStore.toDataset();
	
		    String queryString = 
		    		
		    		"PREFIX sawsdl: <http://example.edu.unifacs/ontologies/bookstore.owl#Technologies>" + 
		    		"SELECT ?livro " +
		    		" WHERE {" +
		    		" sawsdl: <http://example/categorization/books> ?livro .}";

		    //Descoberta semÂntica
		    System.out.println("Consulta Semântica");
		    System.out.println("_________________________________________________");
		    System.out.println( queryString);
		    //Descoberta semÂntica
		    System.out.println("_________________________________________________");
		    Query query2 = QueryFactory.create(queryString);
		    QueryExecution qe = QueryExecutionFactory.create(query2, d);
			ResultSet results = qe.execSelect();

			// Output query results	
			ResultSetFormatter.out(System.out, results, query2);

			// Important - free up resources used running the query
			qe.close();
	
	}

}
