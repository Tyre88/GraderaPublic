using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradera.Education.DAL
{
    public class EducationDbContext : DbContext
    {
        public EducationDbContext()
            :base("Server=127.0.0.1;Initial Catalog=142212-gradera;MultipleActiveResultSets=true;User ID=142212_rb89597;Password=Iamhere4ever!")
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Education.Entities.Education> Educations { get; set; }
        public DbSet<Education.Entities.EducationQuestion> EducationQuestions { get; set; }
        public DbSet<Education.Entities.EducationQuestionAlternative> EducationQuestionAlternatives { get; set; }
    }
}
