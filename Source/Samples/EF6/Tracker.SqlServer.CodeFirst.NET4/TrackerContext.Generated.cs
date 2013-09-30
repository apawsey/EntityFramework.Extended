﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace Tracker.SqlServer.CodeFirst
{
    public partial class TrackerContext
        : System.Data.Entity.DbContext
    {
        public TrackerContext()
            :base("Name=TrackerContext")
        { }

        public TrackerContext(System.Data.Entity.Infrastructure.DbCompiledModel model)
            : base("Name=TrackerContext", model)
        { }

        public TrackerContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        { }

        public TrackerContext(string nameOrConnectionString, System.Data.Entity.Infrastructure.DbCompiledModel model)
            : base(nameOrConnectionString, model)
        { }

        public TrackerContext(System.Data.Common.DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        { }

        public TrackerContext(System.Data.Common.DbConnection existingConnection, System.Data.Entity.Infrastructure.DbCompiledModel model, bool contextOwnsConnection)
            : base(existingConnection, model, contextOwnsConnection)
        { }

        public TrackerContext(System.Data.Entity.Core.Objects.ObjectContext objectContext, bool dbContextOwnsObjectContext)
            : base(objectContext, dbContextOwnsObjectContext)
        { }


        public System.Data.Entity.DbSet<Tracker.SqlServer.CodeFirst.Entities.AuditData> Audits { get; set; }
        public System.Data.Entity.DbSet<Tracker.SqlServer.CodeFirst.Entities.Task> Tasks { get; set; }
        public System.Data.Entity.DbSet<Tracker.SqlServer.CodeFirst.Entities.User> Users { get; set; }
        public System.Data.Entity.DbSet<Tracker.SqlServer.CodeFirst.Entities.Priority> Priorities { get; set; }
        public System.Data.Entity.DbSet<Tracker.SqlServer.CodeFirst.Entities.Role> Roles { get; set; }
        public System.Data.Entity.DbSet<Tracker.SqlServer.CodeFirst.Entities.Status> Status { get; set; }
        public System.Data.Entity.DbSet<Tracker.SqlServer.CodeFirst.Entities.TaskExtended> TaskExtendeds { get; set; }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new Tracker.SqlServer.CodeFirst.Mapping.AuditMap());
            modelBuilder.Configurations.Add(new Tracker.SqlServer.CodeFirst.Mapping.TaskMap());
            modelBuilder.Configurations.Add(new Tracker.SqlServer.CodeFirst.Mapping.UserMap());
            modelBuilder.Configurations.Add(new Tracker.SqlServer.CodeFirst.Mapping.PriorityMap());
            modelBuilder.Configurations.Add(new Tracker.SqlServer.CodeFirst.Mapping.RoleMap());
            modelBuilder.Configurations.Add(new Tracker.SqlServer.CodeFirst.Mapping.StatusMap());
            modelBuilder.Configurations.Add(new Tracker.SqlServer.CodeFirst.Mapping.TaskExtendedMap());

            InitializeMapping(modelBuilder);
        }
    }
}