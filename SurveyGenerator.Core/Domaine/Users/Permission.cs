﻿using SurveyGenerator.Core.Domaine.Routes;
using System;
using System.Collections.Generic;

namespace SurveyGenerator.Core.Domaine.Users
{
    public class Permission: BaseEntity
    {
        public Guid Id { get; set; }
        public String Label { get; set; }
        public String Description { get; set; }

        public virtual ICollection<PermissionRoute> PermissionRoutes { get; set; }
        public virtual  ICollection<User> Users { get; set; }
    }
}
