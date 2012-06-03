namespace SWKaizenMigrationsCodeDemo.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class AddPostAbstract : DbMigration
    {
        public override void Up()
        {
            AddColumn("Posts", "Abstract", c => c.String());

            // Adicionado depois da migração
            // Para popular cada Abstract com os 100
            // primeiros caracteres do Post
            Sql("UPDATE Posts SET Abstract=LEFT(Content, 100) WHERE Abstract IS NULL");
        
        }
        
        public override void Down()
        {
            DropColumn("Posts", "Abstract");
        }
    }
}
