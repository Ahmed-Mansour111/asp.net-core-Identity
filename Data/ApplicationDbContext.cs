﻿using System;
using System.Collections.Generic;
using System.Text;
using IdentityCus.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityCus.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser , ApplicationRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
