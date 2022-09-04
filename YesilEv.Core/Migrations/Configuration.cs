namespace YesilEv.Core.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using YesilEv.Core.Entities.Concrete;

    internal sealed class Configuration : DbMigrationsConfiguration<YesilEv.Core.Contexts.YesilEvContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(YesilEv.Core.Contexts.YesilEvContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            //Yetki seed data

            //context.Claims.AddRange(new List<Claim>() { new Claim{
            //    Id = 1,
            //    CreatedBy = 1,
            //    ModifiedBy = 1,
            //    IsActive = true,
            //    CreatedDate = DateTime.Now,
            //    ModifiedDate = DateTime.Now,
            //    Name="Select",


            //},
            //new Claim{
            //    Id = 2,
            //    CreatedBy = 1,
            //    ModifiedBy = 1,
            //    IsActive = true,
            //    CreatedDate = DateTime.Now,
            //    ModifiedDate = DateTime.Now,
            //    Name="Create",


            //},
            //new Claim{
            //    Id = 3,
            //    CreatedBy = 1,
            //    ModifiedBy = 1,
            //    IsActive = true,
            //    CreatedDate = DateTime.Now,
            //    ModifiedDate = DateTime.Now,
            //    Name="Update",


            //},
            //new Claim{
            //    Id = 4,
            //    CreatedBy = 1,
            //    ModifiedBy = 1,
            //    IsActive = true,
            //    CreatedDate = DateTime.Now,
            //    ModifiedDate = DateTime.Now,
            //    Name="Delete",


            //}

            //});

            //Role Claim Çoka Çok Seed Data

            var claim1 = new Claim
            {
                Id = 1,
                CreatedBy = 1,
                ModifiedBy = 1,
                IsActive = true,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                Name = "Select",


            };
            var claim2 = new Claim
            {
                Id = 2,
                CreatedBy = 1,
                ModifiedBy = 1,
                IsActive = true,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                Name = "Create",


            };
            var claim3 = new Claim
            {
                Id = 3,
                CreatedBy = 1,
                ModifiedBy = 1,
                IsActive = true,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                Name = "Update",


            };
            var claim4 = new Claim
            {
                Id = 4,
                CreatedBy = 1,
                ModifiedBy = 1,
                IsActive = true,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                Name = "Delete",



            };
            var role1 = new Role()
            {
                Id = 1,
                CreatedBy = 1,
                ModifiedBy = 1,
                IsActive = true,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                Name = "Admin",
                Claims = new List<Claim>()

            };
            var role2 = new Role()
            {
                Id = 2,
                CreatedBy = 1,
                ModifiedBy = 1,
                IsActive = true,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                Name = "User",
                Claims = new List<Claim>()
            };
            role1.Claims.Add(claim1);
            role1.Claims.Add(claim2);
            role1.Claims.Add(claim3);
            role1.Claims.Add(claim4);

            role2.Claims.Add(claim1);
            role2.Claims.Add(claim2);
            role2.Claims.Add(claim3);

            context.Roles.Add(role1);
            context.Roles.Add(role2);


            //Kategori Seed Data

            var category = new Category
            {
                Id = 1,
                CreatedBy = 1,
                ModifiedBy = 1,
                IsActive = true,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                Name = "Kozmetik",



            };


            var category2 = new Category
            {
                Id = 2,
                CreatedBy = 1,
                ModifiedBy = 1,
                IsActive = true,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                Name = "Saç Bakım",

                TopCategory = category
            };

            var category3 = new Category
            {
                Id = 3,
                CreatedBy = 1,
                ModifiedBy = 1,
                IsActive = true,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                Name = "Şampuan",
                TopCategoryId = 2,
                TopCategory = category2
            };
            //category.Categories.Add(category2);
            //category.Categories.Add(category3);

            context.Categories.Add(category2);
            context.Categories.Add(category3);
            context.Suppliers.Add(new Supplier
            {
                Id = 1,
                CreatedBy = 1,
                ModifiedBy = 1,
                IsActive = true,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                Name = "Dalin",

            });
            context.ContentTypes.Add(
               new ContentType
               {
                   Id = 1,
                   CreatedBy = 1,
                   ModifiedBy = 1,
                   IsActive = true,
                   CreatedDate = DateTime.Now,
                   ModifiedDate = DateTime.Now,
                   Name = "Riskli içerikler"
               });
            context.ContentTypes.Add(
               new ContentType
               {
                   Id = 2,
                   CreatedBy = 1,
                   ModifiedBy = 1,
                   IsActive = true,
                   CreatedDate = DateTime.Now,
                   ModifiedDate = DateTime.Now,
                   Name = "Orta riskli içerikler"
               });
            context.ContentTypes.Add(
             new ContentType
             {
                 Id = 3,
                 CreatedBy = 1,
                 ModifiedBy = 1,
                 IsActive = true,
                 CreatedDate = DateTime.Now,
                 ModifiedDate = DateTime.Now,
                 Name = "Az riskli içerikler"
             });
            context.ContentTypes.Add(new ContentType
            {
                Id = 4,
                CreatedBy = 1,
                ModifiedBy = 1,
                IsActive = true,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                Name = "Temiz içerikler"
            });

            var content1 = new Content
            {
                Id = 1,
                CreatedBy = 1,
                ModifiedBy = 1,
                IsActive = true,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                Name = "Decyl Glucoside",
                ContentTypeId = 4
            };
            var content2 = new Content
            {
                Id = 2,
                CreatedBy = 1,
                ModifiedBy = 1,
                IsActive = true,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                Name = "Aqua",
                ContentTypeId = 4
            };
            var content3 = new Content
            {
                Id = 3,
                CreatedBy = 1,
                ModifiedBy = 1,
                IsActive = true,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                Name = "Cocamidopropyl Betaine",
                ContentTypeId = 1
            };
            var content4 = new Content
            {
                Id = 4,
                CreatedBy = 1,
                ModifiedBy = 1,
                IsActive = true,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                Name = "Sodium Benzoate",
                ContentTypeId = 2
            };

            var product = new Product
            {
                Id = 1,
                CreatedBy = 1,
                ModifiedBy = 1,
                IsActive = true,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                SupplierId = 1,
                Barcode = Guid.NewGuid(),
                IsApproved = true,
                Name = "Dalin Light Oil Spreyli Bebek Yağı 200 ml",
                CategoryId = 3,
                Contents = new List<Content>(),
                UserId = 1,
                FrontImage = " ",
                BackImage = " ",


            };
            product.Contents.Add(content1);
            product.Contents.Add(content2);
            product.Contents.Add(content3);
            product.Contents.Add(content4);

            context.Products.Add(product);

            //favori Liste seed data
            var favoriteProductList = new FavoriteProductList
            {
                Id = 1,
                CreatedBy = 1,
                ModifiedBy = 1,
                IsActive = true,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                Products = new List<Product>()


            };
            favoriteProductList.Products.Add(product);
            context.FavoriteProductLists.Add(favoriteProductList);
            var blackListProductContent = new BlackListProductContent
            {
                Id = 1,
                CreatedBy = 1,
                ModifiedBy = 1,
                IsActive = true,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                Contents = new List<Content>()


            };

            blackListProductContent.Contents.Add(content1);
            context.BlackListProductContents.Add(blackListProductContent);

            var user = new User
            {
                Id = 1,
                CreatedBy = 1,
                ModifiedBy = 1,
                IsActive = true,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                FirstName = "Doğukan",
                LastName = "Matuloğlu",
                Email = "dogukan.matul@gmail.com",
                RoleId = 1,
                Password = "123",
                FavoriteProductListId = 1,
                BlackListProductContentId = 1

            };
            context.Users.Add(user);

            //rol seed data
            //context.Roles.AddRange(new List<Role> {new Role() {    Id = 1,
            //    CreatedBy = 1,
            //    ModifiedBy = 1,
            //    IsActive = true,
            //    CreatedDate = DateTime.Now,
            //    ModifiedDate = DateTime.Now,
            //    Name="Admin"
            //},
            //new Role() {    Id = 2,
            //    CreatedBy = 1,
            //    ModifiedBy = 1,
            //    IsActive = true,
            //    CreatedDate = DateTime.Now,
            //    ModifiedDate = DateTime.Now,
            //    Name="User"
            //} });

            context.SearchHistories.Add(new SearchHistory
            {
                Id = 1,
                CreatedBy = 1,
                ModifiedBy = 1,
                IsActive = true,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                History = "Şampuan",
                UserId = 1,
            });
        }
    }
}
