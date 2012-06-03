// Adaptado de EF 4.3 Code-Based Migrations Walkthrough
// em http://blogs.msdn.com/b/adonet/archive/2012/02/09/ef-4-3-code-based-migrations-walkthrough.aspx

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SWKaizenMigrationsCodeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BlogContext())
            {
                db.Blogs.Add(new Blog { Name = "Another Blog " });
                db.SaveChanges();

                foreach (var blog in db.Blogs)
                {
                    Console.WriteLine(blog.Name);
                }
            }

        }
    }
}
