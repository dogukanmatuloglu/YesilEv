namespace YesilEv.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BlackListProductContents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        ModifiedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Contents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        ModifiedBy = c.Int(nullable: false),
                        ContentTypeId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ContentTypes", t => t.ContentTypeId)
                .Index(t => t.ContentTypeId);
            
            CreateTable(
                "dbo.ContentTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        ModifiedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Barcode = c.Guid(nullable: false),
                        FrontImage = c.String(),
                        BackImage = c.String(),
                        IsApproved = c.Boolean(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        ModifiedBy = c.Int(nullable: false),
                        SupplierId = c.Int(),
                        CategoryId = c.Int(),
                        UserId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId)
                .ForeignKey("dbo.Users", t => t.UserId)
                .ForeignKey("dbo.Suppliers", t => t.SupplierId)
                .Index(t => t.SupplierId)
                .Index(t => t.CategoryId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        TopCategoryId = c.Int(),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        ModifiedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.TopCategoryId)
                .Index(t => t.TopCategoryId);
            
            CreateTable(
                "dbo.FavoriteProductLists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        ModifiedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        CreatedBy = c.Int(nullable: false),
                        ModifiedBy = c.Int(nullable: false),
                        RoleId = c.Int(),
                        BlackListProductContentId = c.Int(),
                        FavoriteProductListId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Roles", t => t.RoleId)
                .ForeignKey("dbo.FavoriteProductLists", t => t.FavoriteProductListId)
                .ForeignKey("dbo.BlackListProductContents", t => t.BlackListProductContentId)
                .Index(t => t.RoleId)
                .Index(t => t.BlackListProductContentId)
                .Index(t => t.FavoriteProductListId);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        ModifiedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Claims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        ModifiedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SearchHistories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        History = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        ModifiedBy = c.Int(nullable: false),
                        UserId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        ModifiedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductContent",
                c => new
                    {
                        ProductId = c.Int(nullable: false),
                        ContentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ProductId, t.ContentId })
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Contents", t => t.ContentId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.ContentId);
            
            CreateTable(
                "dbo.FavoriteProductListIdProduct",
                c => new
                    {
                        FavoriteProductListId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.FavoriteProductListId, t.ProductId })
                .ForeignKey("dbo.FavoriteProductLists", t => t.FavoriteProductListId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.FavoriteProductListId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.RoleClaim",
                c => new
                    {
                        RoleId = c.Int(nullable: false),
                        ClaimId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.RoleId, t.ClaimId })
                .ForeignKey("dbo.Roles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.Claims", t => t.ClaimId, cascadeDelete: true)
                .Index(t => t.RoleId)
                .Index(t => t.ClaimId);
            
            CreateTable(
                "dbo.BlacListProductContentContent",
                c => new
                    {
                        BlackListProductContentId = c.Int(nullable: false),
                        ContentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.BlackListProductContentId, t.ContentId })
                .ForeignKey("dbo.BlackListProductContents", t => t.BlackListProductContentId, cascadeDelete: true)
                .ForeignKey("dbo.Contents", t => t.ContentId, cascadeDelete: true)
                .Index(t => t.BlackListProductContentId)
                .Index(t => t.ContentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "BlackListProductContentId", "dbo.BlackListProductContents");
            DropForeignKey("dbo.BlacListProductContentContent", "ContentId", "dbo.Contents");
            DropForeignKey("dbo.BlacListProductContentContent", "BlackListProductContentId", "dbo.BlackListProductContents");
            DropForeignKey("dbo.Products", "SupplierId", "dbo.Suppliers");
            DropForeignKey("dbo.Users", "FavoriteProductListId", "dbo.FavoriteProductLists");
            DropForeignKey("dbo.SearchHistories", "UserId", "dbo.Users");
            DropForeignKey("dbo.Users", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.RoleClaim", "ClaimId", "dbo.Claims");
            DropForeignKey("dbo.RoleClaim", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.Products", "UserId", "dbo.Users");
            DropForeignKey("dbo.FavoriteProductListIdProduct", "ProductId", "dbo.Products");
            DropForeignKey("dbo.FavoriteProductListIdProduct", "FavoriteProductListId", "dbo.FavoriteProductLists");
            DropForeignKey("dbo.ProductContent", "ContentId", "dbo.Contents");
            DropForeignKey("dbo.ProductContent", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Categories", "TopCategoryId", "dbo.Categories");
            DropForeignKey("dbo.Contents", "ContentTypeId", "dbo.ContentTypes");
            DropIndex("dbo.BlacListProductContentContent", new[] { "ContentId" });
            DropIndex("dbo.BlacListProductContentContent", new[] { "BlackListProductContentId" });
            DropIndex("dbo.RoleClaim", new[] { "ClaimId" });
            DropIndex("dbo.RoleClaim", new[] { "RoleId" });
            DropIndex("dbo.FavoriteProductListIdProduct", new[] { "ProductId" });
            DropIndex("dbo.FavoriteProductListIdProduct", new[] { "FavoriteProductListId" });
            DropIndex("dbo.ProductContent", new[] { "ContentId" });
            DropIndex("dbo.ProductContent", new[] { "ProductId" });
            DropIndex("dbo.SearchHistories", new[] { "UserId" });
            DropIndex("dbo.Users", new[] { "FavoriteProductListId" });
            DropIndex("dbo.Users", new[] { "BlackListProductContentId" });
            DropIndex("dbo.Users", new[] { "RoleId" });
            DropIndex("dbo.Categories", new[] { "TopCategoryId" });
            DropIndex("dbo.Products", new[] { "UserId" });
            DropIndex("dbo.Products", new[] { "CategoryId" });
            DropIndex("dbo.Products", new[] { "SupplierId" });
            DropIndex("dbo.Contents", new[] { "ContentTypeId" });
            DropTable("dbo.BlacListProductContentContent");
            DropTable("dbo.RoleClaim");
            DropTable("dbo.FavoriteProductListIdProduct");
            DropTable("dbo.ProductContent");
            DropTable("dbo.Suppliers");
            DropTable("dbo.SearchHistories");
            DropTable("dbo.Claims");
            DropTable("dbo.Roles");
            DropTable("dbo.Users");
            DropTable("dbo.FavoriteProductLists");
            DropTable("dbo.Categories");
            DropTable("dbo.Products");
            DropTable("dbo.ContentTypes");
            DropTable("dbo.Contents");
            DropTable("dbo.BlackListProductContents");
        }
    }
}
