using System;
using System.Collections.Generic;
using System.Data.Entity;
using CLD;

namespace CLB
{
    public class ExistenceBaseRepository: IExistenceBaseRepository
    {
        private readonly QMS db;

        public ExistenceBaseRepository(QMS _db)
        {
            db = _db;
        }

        public IEnumerable<ExistenceBass> GetAllExistenceBase()
        {
            return db.ExistenceBasses;
        }

        public ExistenceBass GetExistenceBassById(int Id)
        {
            return db.ExistenceBasses.Find(Id);
        }

        public bool InsertNewExistence(ExistenceBass existenceBass)
        {
            try
            {
                db.ExistenceBasses.Add(existenceBass);
                return true;
            }
            catch 
            {
                return false;
            }
        }

        public bool EditExistenceBase(ExistenceBass existenceBass)
        {
            try
            {
                db.Entry(existenceBass).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteExistenceBase(int Id)
        {
            try
            {
                var exi = GetExistenceBassById(Id);
                db.Entry(exi).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteExistenceBase(ExistenceBass existenceBass)
        {
            try
            {
                db.Entry(existenceBass).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int Save()
        {
            return  db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}