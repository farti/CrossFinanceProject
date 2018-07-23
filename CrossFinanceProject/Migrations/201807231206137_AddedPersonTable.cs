namespace CrossFinanceProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPersonTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Person",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 200, unicode: false),
                        SecondName = c.String(maxLength: 200, unicode: false),
                        Surname = c.String(maxLength: 200, unicode: false),
                        NationalIdentificationNumber = c.String(maxLength: 200, unicode: false),
                        AddressId = c.Int(nullable: false),
                        PhoneNumber = c.String(maxLength: 200, unicode: false),
                        PhoneNumber2 = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Person");
        }
    }
}
