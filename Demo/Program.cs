using Demo.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var context = new MyContext();
            //try
            //{
            //    //logic
            //}
            //finally
            //{
            //    context.Dispose();
            //}

            //using (var context = new MyContext())
            //{

            //}

            using var context = new MyContext();
            //context.Database.EnsureCreated();
            //context.Database.EnsureDeleted();
            //context.Database.Migrate();

        }
    }
}
