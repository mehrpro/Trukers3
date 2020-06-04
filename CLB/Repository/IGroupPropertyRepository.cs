using System;
using System.Collections.Generic;
using CLD;

namespace CLB
{
    public interface IGroupPropertyRepository:IDisposable
    {
        IEnumerable<GroupsProperty> GetAllGroupsProperties();
        GroupsProperty GetGroupsPropertiesById(int Id);
        bool InsertNewProperties(GroupsProperty groupsProperty);
        bool EditGroupsProperties(GroupsProperty groupsProperty);
        bool DeleteGroupsProperties(int Id);
        bool DeleteGroupsProperties(GroupsProperty groupsProperty);
        int Save();
    }
}