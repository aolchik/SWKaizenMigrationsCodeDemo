
namespace SWKaizenMigrationsCodeDemo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.ComponentModel.DataAnnotations;

    // Para trabalhar com Entity Framework
    // Ir em Tools -> Library Package Manager -> Package Manage Console: Install-Package EntityFramework
    //
    //  Para habilitar as migrações: Enable-migrations
    //      Cria diretório Migrations, com arquivo Configuration.cs
    //
    //  Abordagem: 
    //  1) Altere o modelo do domínio
    //  2) Gere o scaffolding da migração (Add-migration <Nome>)
    //  3) Programe a migração 
    //  4) Aplique no modelo e valide a alteração (Update-migration -Verbose)
    //  5) Valide o rollback ( excutando Update-Database -TargetMigration:"<NomeMigracao>"
    //  6) Se tudo funcionar, aplique novamente a migração
    //
    //  Atenção: NUNCA EDITAR MIGRAÇÕES PASSADAS!
    //  Para limbar o banco: Update-database -TargetMigration:$InitialDatabase
  
    // Contexto do Entity Framework
    public class BlogContext: DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
    }

    // Modelo de domínio
    public class Blog 
    {
        public int BlogId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }

        public int Rating { get; set; }

        public List<Post> Posts { get; set; }
    }

    public class Post
    {
        public int PostId { get; set; }
        [MaxLength(200)]
        public string Title { get; set; }
        public string Content { get; set; }
        public string Abstract { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
