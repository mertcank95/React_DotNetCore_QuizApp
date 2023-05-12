using Microsoft.EntityFrameworkCore;
using QuizApi.Models;

namespace QuizApi.Repository
{
    public class RepositoryContext:DbContext
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        {

        }

        public DbSet<Question> Questions { get; set; }
        public DbSet <Participant> Participants { get; set; }

    }
}
