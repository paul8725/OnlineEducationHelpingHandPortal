using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineEducationHelpingHandPortal.Model;

namespace OnlineEducationHelpingHandPortal.Data
{
    public class OnlineEducationHelpingHandPortalContext : DbContext
    {
        public OnlineEducationHelpingHandPortalContext (DbContextOptions<OnlineEducationHelpingHandPortalContext> options)
            : base(options)
        {
        }

        public DbSet<OnlineEducationHelpingHandPortal.Model.Education> Education { get; set; }

        public DbSet<OnlineEducationHelpingHandPortal.Model.Message> Message { get; set; }
    }
}
