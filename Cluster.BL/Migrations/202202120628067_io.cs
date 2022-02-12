namespace Cluster.BL.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class io : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChannelOne",
                c => new
                    {
                        Channel1Id = c.Int(nullable: false, identity: true),
                        X1 = c.Decimal(precision: 18, scale: 2),
                        Z1 = c.Decimal(precision: 18, scale: 2),
                        X2 = c.Decimal(precision: 18, scale: 2),
                        Z2 = c.Decimal(precision: 18, scale: 2),
                        X3 = c.Decimal(precision: 18, scale: 2),
                        Z3 = c.Decimal(precision: 18, scale: 2),
                        X4 = c.Decimal(precision: 18, scale: 2),
                        Z4 = c.Decimal(precision: 18, scale: 2),
                        X5 = c.Decimal(precision: 18, scale: 2),
                        Z5 = c.Decimal(precision: 18, scale: 2),
                        X6 = c.Decimal(precision: 18, scale: 2),
                        Z6 = c.Decimal(precision: 18, scale: 2),
                        X7 = c.Decimal(precision: 18, scale: 2),
                        Z7 = c.Decimal(precision: 18, scale: 2),
                        Y1 = c.Decimal(precision: 18, scale: 2),
                        Y2 = c.Decimal(precision: 18, scale: 2),
                        Y3 = c.Decimal(precision: 18, scale: 2),
                        Y4 = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Channel1Id);
            
            CreateTable(
                "dbo.OffsetData",
                c => new
                    {
                        OffsetDataId = c.Int(nullable: false, identity: true),
                        ChannelOneId = c.Int(nullable: false),
                        ChannelTwoId = c.Int(nullable: false),
                        MacroId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        Comment = c.String(maxLength: 2147483647),
                        Created = c.DateTime(nullable: false),
                        Machine = c.String(nullable: false, maxLength: 2147483647),
                    })
                .PrimaryKey(t => t.OffsetDataId)
                .ForeignKey("dbo.ChannelOne", t => t.ChannelOneId, cascadeDelete: true)
                .ForeignKey("dbo.ChannelTwo", t => t.ChannelTwoId, cascadeDelete: true)
                .ForeignKey("dbo.Macro", t => t.MacroId, cascadeDelete: true)
                .ForeignKey("dbo.ProductType", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.UserData", t => t.UserId, cascadeDelete: true)
                .Index(t => t.ChannelOneId, name: "IX_OffsetData_ChannelOneId")
                .Index(t => t.ChannelTwoId, name: "IX_OffsetData_ChannelTwoId")
                .Index(t => t.MacroId, name: "IX_OffsetData_MacroId")
                .Index(t => t.UserId, name: "IX_OffsetData_UserId")
                .Index(t => t.ProductId, name: "IX_OffsetData_ProductId");
            
            CreateTable(
                "dbo.ChannelTwo",
                c => new
                    {
                        Channel2Id = c.Int(nullable: false, identity: true),
                        X1 = c.Decimal(precision: 18, scale: 2),
                        Z1 = c.Decimal(precision: 18, scale: 2),
                        X2 = c.Decimal(precision: 18, scale: 2),
                        Z2 = c.Decimal(precision: 18, scale: 2),
                        X3 = c.Decimal(precision: 18, scale: 2),
                        Z3 = c.Decimal(precision: 18, scale: 2),
                        X4 = c.Decimal(precision: 18, scale: 2),
                        Z4 = c.Decimal(precision: 18, scale: 2),
                        X5 = c.Decimal(precision: 18, scale: 2),
                        Z5 = c.Decimal(precision: 18, scale: 2),
                        X6 = c.Decimal(precision: 18, scale: 2),
                        Z6 = c.Decimal(precision: 18, scale: 2),
                        X7 = c.Decimal(precision: 18, scale: 2),
                        Z7 = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Channel2Id);
            
            CreateTable(
                "dbo.Macro",
                c => new
                    {
                        MacroId = c.Int(nullable: false, identity: true),
                        Offset = c.Double(),
                        Conicity = c.Decimal(precision: 18, scale: 2),
                        Zajust = c.Decimal(precision: 18, scale: 2),
                        ThreadPass = c.Decimal(precision: 18, scale: 2),
                        OdSeal = c.Decimal(precision: 18, scale: 2),
                        Standoff = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.MacroId);
            
            CreateTable(
                "dbo.ProductType",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        Diameter = c.Int(nullable: false),
                        ThreadType = c.String(maxLength: 2147483647),
                    })
                .PrimaryKey(t => t.ProductId);
            
            CreateTable(
                "dbo.UserData",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false, maxLength: 2147483647),
                        UserPassword = c.String(maxLength: 2147483647),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OffsetData", "UserId", "dbo.UserData");
            DropForeignKey("dbo.OffsetData", "ProductId", "dbo.ProductType");
            DropForeignKey("dbo.OffsetData", "MacroId", "dbo.Macro");
            DropForeignKey("dbo.OffsetData", "ChannelTwoId", "dbo.ChannelTwo");
            DropForeignKey("dbo.OffsetData", "ChannelOneId", "dbo.ChannelOne");
            DropIndex("dbo.OffsetData", "IX_OffsetData_ProductId");
            DropIndex("dbo.OffsetData", "IX_OffsetData_UserId");
            DropIndex("dbo.OffsetData", "IX_OffsetData_MacroId");
            DropIndex("dbo.OffsetData", "IX_OffsetData_ChannelTwoId");
            DropIndex("dbo.OffsetData", "IX_OffsetData_ChannelOneId");
            DropTable("dbo.UserData");
            DropTable("dbo.ProductType");
            DropTable("dbo.Macro");
            DropTable("dbo.ChannelTwo");
            DropTable("dbo.OffsetData");
            DropTable("dbo.ChannelOne");
        }
    }
}
