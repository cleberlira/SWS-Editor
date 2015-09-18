public class OwlBLL {
     OwlDAL dao =new OWlDAL();
    public void  excluir(Ontologia ontologia) {
     dao.excluir(ontologia)
    }

     public void incluir(Ontologia ontologia) {
             dao.incluir(ontologia)
    }
}
