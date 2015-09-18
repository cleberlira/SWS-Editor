public class ServicoWebDAL {
     RepositorioOWL repositorioowl = new RepositorioOWL();
    public void excluir(ServicoWeb servicoweb) {
        repositorioowl.excluir(servicoweb);
    }
    public void incluir(ServicoWeb servicoweb) {
        repositorioowl.incluir(servicoweb);

    }
}
