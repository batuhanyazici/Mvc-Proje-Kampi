﻿namespace DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DraftAdd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Messages", "isDraft", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Messages", "isDraft");
        }
    }
}
