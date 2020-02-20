namespace MVC_NEW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into MembershipTypes values (1,0,0,0)");
            Sql("Insert into MembershipTypes values (2,30,1,10)");
            Sql("Insert into MembershipTypes values (3,90,3,15)");
            Sql("Insert into MembershipTypes values (4,300,20,20)");
        
        }
        
        public override void Down()
        {
        }
    }
}
