import com.hp.hpl.jena.query.Dataset;
import com.hp.hpl.jena.query.Query;
import com.hp.hpl.jena.query.QueryExecution;
import com.hp.hpl.jena.query.QueryExecutionFactory;
import com.hp.hpl.jena.query.QueryFactory;
import com.hp.hpl.jena.query.QuerySolution;
import com.hp.hpl.jena.query.ResultSet;
import com.hp.hpl.jena.query.ResultSetFormatter;
import com.hp.hpl.jena.tdb.TDBFactory;
import com.hp.hpl.jena.update.GraphStore;
import com.hp.hpl.jena.update.GraphStoreFactory;


public class QueryLivros {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		  String directory = "MyDatabases/Dataset1" ;
		  Dataset dataset = TDBFactory.createDataset(directory) ;
	
		//  GraphStore graphStore=GraphStoreFactory.create(dataset);
		 
		  String queryString = 
					"PREFIX dc: <http://purl.org/dc/elements/1.1/title>" +
					" SELECT ?title " +
					"WHERE {" +
					"  <http://example/egbook> <http://purl.org/dc/elements/1.1/title> ?title . }" ;
		 
		  
		  
		// Create a new query
		String queryString2 = 
				"PREFIX sawsdl: <http://example.com/data/onto.owl#Username>" + 
				"SELECT DISTINCT ?s " +
				"WHERE { " + 
				"?s rdf:type sawsdl:Service ." +
				"?s sawsdl:modelReference <http://example.com/data/onto.owl#Username>" + 
				"}";
				
		
		
		  Query query = QueryFactory.create(queryString) ;
	        QueryExecution qexec = QueryExecutionFactory.create(query, dataset) ;
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
			
			
			Query query2 = QueryFactory.create(queryString);

			// Execute the query and obtain results
			QueryExecution qe = QueryExecutionFactory.create(query2, dataset);
			ResultSet results = qe.execSelect();

			// Output query results	
			ResultSetFormatter.out(System.out, results, query2);

			// Important - free up resources used running the query
			qe.close();
			
		  
	    }
	
	
		
		    

	}


