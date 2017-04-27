using Architecture.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture.Data.Configurations
{
    public class ContactConfiguration : EntityTypeConfiguration<Contact>
    {
        public ContactConfiguration()
        {
            Property(c => c.FirstName).IsRequired().HasMaxLength(100);
            Property(c => c.LastName).IsRequired().HasMaxLength(100);
            Property(c => c.Email).IsRequired().HasMaxLength(250);
            Property(c => c.Telephone).HasMaxLength(150);
            Property(c => c.MobilePhone).IsRequired().HasMaxLength(250);
            Property(c => c.Address).IsRequired().HasMaxLength(250);
            Property(c => c.Description).HasMaxLength(250);
        }

    }
}
