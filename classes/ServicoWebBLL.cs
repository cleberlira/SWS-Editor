public class OwlBLL {
     ServicoWebDAL dao =new ServicoWebDAL();
    public void  excluir(ServicoWeb servicoweb) {
     dao.excluir(servicoweb)
    }

     public void incluir(ServicoWeb servicoweb) {
             dao.incluir(servicoweb)
    }
}
