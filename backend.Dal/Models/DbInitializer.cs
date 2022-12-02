using backend.Dal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend.Dal.Models
{
public class DbInitializer
    {
        public static void Initialize(UtContext context)
        {
            context.Database.EnsureCreated();
            if (context.Questions.Any())
            {
                return;
            }
            Question question = new Question()
            {
                Name = "testvraag"
            };
            Question question2 = new Question()
            {
                Name = "testvraag-2"
            };
            context.Questions.Add(question);
            context.Questions.Add(question2);
            context.SaveChanges();
        }
    }
}
