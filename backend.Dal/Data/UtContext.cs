using backend.Dal.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend.Dal.Data
{
    public class UtContext : DbContext

    {
        public UtContext(DbContextOptions<UtContext>options) : base(options)
        { }
        public DbSet<Question> Questions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Question>().ToTable("Question");
        }



        public void Initialize(UtContext context)
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
