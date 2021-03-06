
using System.Data;


namespace JKO.Dao.Interface
{

    public interface IDatabaseConnection
    {
        IDbConnection Create();
    }
}
