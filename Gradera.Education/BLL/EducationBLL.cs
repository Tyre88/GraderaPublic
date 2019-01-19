using Gradera.Education.DAL;
using Gradera.Education.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradera.Education.BLL
{
    public class EducationBLL
    {
        readonly EducationDAL _educationDAL;

        public EducationBLL()
        {
            _educationDAL = new EducationDAL();
        }

        public Entities.Education GetEducation(int id)
        {
            return _educationDAL.GetEducation(id);
        }

        public Entities.Education GetEducation(string name)
        {
            int id = -1;

            if (int.TryParse(name, out id))
                return GetEducation(id);

            return _educationDAL.GetEducation(name);
        }
    }
}
