import com.hp.hpl.jena.ontology.Individual;
import com.hp.hpl.jena.ontology.OntModel;
import com.hp.hpl.jena.ontology.OntModelSpec;
import com.hp.hpl.jena.rdf.model.ModelFactory;
import com.hp.hpl.jena.update.UpdateAction;
import com.hp.hpl.jena.vocabulary.OWL;
import com.hp.hpl.jena.vocabulary.RDFS;

public class OntModelUpdateExample {
    public static void main(String[] args) {
        String ns = "http://stackoverflow.com/q/23102507/1281433/";
        OntModel model = ModelFactory.createOntologyModel( OntModelSpec.OWL_DL_MEM );
        model.setNsPrefix( "", ns );

        Individual i = model.createIndividual( ns+"JDoe", OWL.Thing );
        i.addLabel( "John Doe", "en" );

        model.write( System.out, "TTL" );

        String rename = "" +
                "prefix : <"+ns+">\n" +
                "prefix rdfs: <"+RDFS.getURI()+">\n" +
                "delete { :JDoe rdfs:label ?label }\n" +
                "insert { :JDoe rdfs:label \"JackB Doe\"@en }\n" +
                "where { :JDoe rdfs:label ?label }";

        UpdateAction.parseExecute( rename, model );

        model.write( System.out, "TTL" );
    }
}