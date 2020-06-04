using System;
using System.Collections.Generic;
using CLD;

namespace CLB
{
    public interface IExistenceGroupRepository:IDisposable
    {
        IEnumerable<ExistenceGroup> GetAllExistenceGroup();
        ExistenceGroup GetExistenceGroupById(int Id);
        bool InsertNewGroup(ExistenceGroup existenceGroup);
        bool EditExistenceGroup(ExistenceGroup existenceGroup);
        bool DeleteExistenceGroup(int Id);
        bool DeleteExistenceGroup(ExistenceGroup existenceGroup);
        int Save();
    }
}