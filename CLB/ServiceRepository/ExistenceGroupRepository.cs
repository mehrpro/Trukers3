using System.Collections.Generic;
using System.Data.Entity;
using CLD;

namespace CLB
{
    public class ExistenceGroupRepository:IExistenceGroupRepository
    {
        private QMS db;

        public ExistenceGroupRepository(QMS _db)
        {
            db = _db;
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public IEnumerable<ExistenceGroup> GetAllExistenceGroup()
        {
            return db.ExistenceGroups;
        }

        public ExistenceGroup GetExistenceGroupById(int Id)
        {
            return db.ExistenceGroups.Find(Id);
        }

        public bool InsertNewGroup(ExistenceGroup existenceGroup)
        {
            try
            {
                db.ExistenceGroups.Add(existenceGroup);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EditExistenceGroup(ExistenceGroup existenceGroup)
        {
            try
            {
                db.Entry(existenceGroup).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteExistenceGroup(int Id)
        {
            try
            {
                var exi = GetExistenceGroupById(Id);
                db.Entry(exi).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteExistenceGroup(ExistenceGroup existenceGroup)
        {
            try
            {
                db.Entry(existenceGroup).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int Save()
        {
           return db.SaveChanges();
        }
    }
}