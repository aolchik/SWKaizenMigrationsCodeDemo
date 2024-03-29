namespace SWKaizenMigrationsCodeDemo.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class AddBlogUrl : DbMigration
    {
        public override void Up()
        {
            AddColumn("Blogs", "Url", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("Blogs", "Url");
        }
    }
}
