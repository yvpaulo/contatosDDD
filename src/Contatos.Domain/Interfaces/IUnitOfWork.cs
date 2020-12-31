using System.Threading.Tasks;

namespace Contatos.Domain.Interfaces
{
    //Esta interface vai ser usada para dar o commit 
    //ou seja o SaveChanges para efetivar a persistência.
    public interface IUnitOfWork
    {
         Task Commit();
    }
}