﻿using EasyMicroservices.AuthenticationsMicroservice.Database.Schemas;
using EasyMicroservices.Cores.Interfaces;
using System.Collections.Generic;

namespace EasyMicroservices.AuthenticationsMicroservice.Database.Entities
{
    public class UserEntity : UserSchema, IIdSchema<long>
    {
        public long Id { get; set; }
        public ICollection<UserRoleEntity> UserRoles { get; set; }
    }
}
