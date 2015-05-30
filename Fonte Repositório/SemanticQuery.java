import org.apache.xerces.xs.datatypes.XSDateTime;

import com.hp.hpl.jena.datatypes.xsd.XSDDatatype;
import com.hp.hpl.jena.query.Dataset;
import com.hp.hpl.jena.query.ReadWrite;
import com.hp.hpl.jena.rdf.model.Model;
import com.hp.hpl.jena.rdf.model.ModelFactory;
import com.hp.hpl.jena.rdf.model.Property;
import com.hp.hpl.jena.rdf.model.Resource;
import com.hp.hpl.jena.tdb.TDBFactory;


public class SemanticQuery {

	public static void main(String[] args) {
		
		Model m = ModelFactory.createDefaultModel();
		
		String NS= "http://example.com/test/";
		
		Resource r= m.createResource(NS + "r");
		Property p = m.createProperty (NS + "p");
		
		r.addProperty(p, "testando",  XSDDatatype.XSDstring);
		
		m.write (System.out,"Turtle");
		
		
				
	

	}

}
