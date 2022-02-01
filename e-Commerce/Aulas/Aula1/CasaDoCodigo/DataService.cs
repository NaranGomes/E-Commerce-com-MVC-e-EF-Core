namespace CasaDoCodigo
{
    public class DataService : IDataService
    {
        private readonly ApplicationContext contexto;

        public DataService(ApplicationContext contexto)
        {
            this.contexto = contexto;
        }

        public void IncializaDB()
        {
            contexto.Database.EnsureCreated();
        }
    }
}
