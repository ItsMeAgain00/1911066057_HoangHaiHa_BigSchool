namespace _1911066057_HoangHaiHa_BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CATEGORIES ")
        }
        
        public override void Down()
        {
        }
    }
}
