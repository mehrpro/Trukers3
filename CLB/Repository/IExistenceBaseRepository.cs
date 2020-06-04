using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLD;

namespace CLB
{
    public interface IExistenceBaseRepository:IDisposable
    {
        IEnumerable<ExistenceBass> GetAllExistenceBase();
        ExistenceBass GetExistenceBassById(int Id);
        bool InsertNewExistence(ExistenceBass existenceBass);
        bool EditExistenceBase(ExistenceBass existenceBass);
        bool DeleteExistenceBase(int Id);
        bool DeleteExistenceBase(ExistenceBass existenceBass);
        int Save();
    }
}
