using System.Collections.Generic;
using System.Data.Entity;
using CLD;

namespace CLB
{
    public class GroupsPropertiesRepository: IGroupPropertyRepository

    {
        private QMS db;

        public GroupsPropertiesRepository(QMS _db)
        {
            db = _db;
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public IEnumerable<GroupsProperty> GetAllGroupsProperties()
        {
            return db.GroupsProperties;
        }

        public GroupsProperty GetGroupsPropertiesById(int Id)
        {
            return db.GroupsProperties.Find(Id);
        }

        public bool InsertNewProperties(GroupsProperty groupsProperty)
        {
            try
            {
                db.GroupsProperties.Add(groupsProperty);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EditGroupsProperties(GroupsProperty groupsProperty)
        {
            try
            {
                db.Entry(groupsProperty).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteGroupsProperties(int Id)
        {
            try
            {
                var exi = GetGroupsPropertiesById(Id);
                db.Entry(exi).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteGroupsProperties(GroupsProperty groupsProperty)
        {
            try
            {
                db.Entry(groupsProperty).State = EntityState.Deleted;
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