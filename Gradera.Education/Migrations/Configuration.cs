namespace Gradera.Education.Migrations
{
    using Gradera.Education.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Gradera.Education.DAL.EducationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Gradera.Education.DAL.EducationDbContext context)
        {
            //EducationQuestionAlternative alternative1 = new EducationQuestionAlternative()
            //{
            //    IsCorrect = true,
            //    Text = "Detta �r r�tt...."
            //};

            //EducationQuestionAlternative alternative2 = new EducationQuestionAlternative()
            //{
            //    IsCorrect = false,
            //    Text = "Detta �r fel...."
            //};

            //List<EducationQuestionAlternative> alternatives = new List<EducationQuestionAlternative>();
            //alternatives.Add(alternative1);
            //alternatives.Add(alternative2);


            //EducationQuestion question = new EducationQuestion()
            //{
            //    Name = "Fr�ga 1",
            //    Description = "Detta �r fr�ga 1",
            //    MediaUrl = "",
            //    Alternatives = alternatives
            //};

            //EducationQuestion question2 = new EducationQuestion()
            //{
            //    Name = "Fr�ga 2",
            //    Description = "Detta �r fr�ga 2",
            //    MediaUrl = "",
            //    Alternatives = alternatives
            //};

            //List<EducationQuestion> questions = new List<EducationQuestion>();
            //questions.Add(question);
            //questions.Add(question2);

            //Entities.Education education = new Entities.Education()
            //{
            //    Id = 4,
            //    Description = "Detta �r en test utbildning",
            //    Name = "Test utbildning",
            //    IsFeatured = false,
            //    Questions = questions
            //};

            //context.Educations.AddOrUpdate(education);
        }
    }
}
