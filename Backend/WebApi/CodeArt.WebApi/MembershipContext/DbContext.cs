﻿using CodeArt.DomainServices.Contracts.MembershipContext;
using CodeArt.DomainServices.Contracts.Models.Membership;
using Microsoft.AspNet.Identity.EntityFramework;

namespace CodeArt.DomainServices.MembershipContext
{
    public class DbContext : IdentityDbContext<UserModel>, IDbContext
    {
        public DbContext()
            : base("CodeArtConnectionString")
        {
            
        }
    }
}