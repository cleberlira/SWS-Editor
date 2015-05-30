import com.github.jsonldjava.core.RDFDataset.Node;
import com.hp.hpl.jena.query.Dataset;
import com.hp.hpl.jena.query.Query;
import com.hp.hpl.jena.query.QueryExecution;
import com.hp.hpl.jena.query.QueryExecutionFactory;
import com.hp.hpl.jena.query.QueryFactory;
import com.hp.hpl.jena.query.QuerySolution;
import com.hp.hpl.jena.query.ReadWrite;
import com.hp.hpl.jena.query.ResultSet;
import com.hp.hpl.jena.query.ResultSetFormatter;
import com.hp.hpl.jena.rdf.model.Model;
import com.hp.hpl.jena.rdf.model.Statement;
import com.hp.hpl.jena.tdb.TDBFactory;
import com.hp.hpl.jena.update.GraphStore;
import com.hp.hpl.jena.update.GraphStoreFactory;
import com.hp.hpl.jena.update.UpdateAction;


public class Livros {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		
		  String directory = "MyDatabases/Dataset1/" ;
		  Dataset dataset = TDBFactory.createDataset(directory) ;
		 
		// dataset.begin(ReadWrite.WRITE) ;
		  GraphStore graphStore=GraphStoreFactory.create(dataset);
		
		 // Model model = dataset.getDefaultModel() ;
		 String query="PREFIX dc:<http://purl.org/dc/elements/1.1/> INSERT DATA{<http://example/egbook> dc:title 'SWS Editor' .} ";
		 
		 	System.out.println (query);
		 /*
		  String query = "PREFIX books: <http://example.org/categorization/books/technologies#> " +
		  				"INSERT DATA { <http://example.org/categorization/books/technologies#> books:title 'Java'; }";
*/
		  
		  UpdateAction.parseExecute(query, graphStore);
		
		 System.out.print ( graphStore.isEmpty());
		 
		 Dataset d = graphStore.toDataset();
	
		    String queryString = 
					"PREFIX dc: <http://purl.org/dc/elements/1.1/title>" +
					" SELECT ?title " +
					"WHERE {" +
					"<http://example/egbook> <http://purl.org/dc/elements/1.1/title> ?title . }" ;
		    
		    Query query2 = QueryFactory.create(queryString);
		    QueryExecution qe = QueryExecutionFactory.create(query2, d);
			ResultSet results = qe.execSelect();

			// Output query results	
			ResultSetFormatter.out(System.out, results, query2);

			// Important - free up resources used running the query
			qe.close();
		    
		 /*
		  Query query1 = QueryFactory.create(queryString) ;
	        QueryExecution qexec = QueryExecutionFactory.create(query1, dataset) ;
	        try {
	          ResultSet results = qexec.execSelect() ;
	          for ( ; results.hasNext() ; )
	          {
	              QuerySolution soln = results.nextSolution() ;
	              int count = soln.getLiteral("count").getInt() ;
	              System.out.println("count = "+count) ;
	          }
	        } finally { qexec.close() ; }

	        // Close the dataset.
	      //  dataset.close();
	      //  System.out.println(queryString + graphStore.size());
			

		  
	        graphStore.close();
	        
	        */
		
	//dataset.end() ;
	
		 
	// dataset.begin(ReadWrite.WRITE) ;
		// model = dataset.getDefaultModel() ;
		//  model = dataset.getDefaultModel() ;
		// dataset.end() ;
		 
		// 
	}

}
