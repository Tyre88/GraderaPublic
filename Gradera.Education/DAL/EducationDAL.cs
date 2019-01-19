using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gradera.Education.Entities;
using System.Data.Entity;

namespace Gradera.Education.DAL
{
    internal class EducationDAL
    {
        readonly EducationDbContext _educationDbContext;

        internal EducationDAL()
        {
            _educationDbContext = new EducationDbContext();
        }

        internal Entities.Education GetEducation(int id)
        {
            return _educationDbContext.Educations.Include(e => e.Questions).Include(e => e.Questions.Select(q => q.Alternatives)).FirstOrDefault(e => e.Id == id);
        }

        internal Entities.Education GetEducation(string name)
        {
            return _educationDbContext.Educations.Include(e => e.Questions).Include(e => e.Questions.Select(q => q.Alternatives)).FirstOrDefault(e => e.Name.ToLower() == name.ToLower());
        }
    }
}
