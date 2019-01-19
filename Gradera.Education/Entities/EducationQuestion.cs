using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradera.Education.Entities
{
    public class EducationQuestion
    {
        public int Id { get; set; }
        public int EducationId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string MediaUrl { get; set; }
        public ICollection<EducationQuestionAlternative> Alternatives { get; set; }
    }

    public class EducationQuestionAlternative
    {
        public int Id { get; set; }
        public int EducationQuestionId { get; set; }
        public string Text { get; set; }
        public bool IsCorrect { get; set; }
    }
}
