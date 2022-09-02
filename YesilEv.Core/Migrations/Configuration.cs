namespace YesilEv.Core.Migrations
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using YesilEv.Core.Entities.Concrete;

    internal sealed class Configuration : DbMigrationsConfiguration<YesilEv.Core.Contexts.YesilEvContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(YesilEv.Core.Contexts.YesilEvContext context)
        {
            //kara liste seed data
            context.BlackListProductContents.Add(new BlackListProductContent
            {
                Id = 1,
                CreatedBy = 1,
                ModifiedBy = 1,
                IsActive = true,
                CreatedDate = DateTime.Now,
                ModifiedDate=DateTime.Now,
                
            });
            //favori Liste seed data
            context.FavoriteProductLists.Add(new FavoriteProductList
            {
                Id = 1,
                CreatedBy = 1,
                ModifiedBy = 1,
                IsActive = true,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,

            });

            //Yetki seed data

            context.Claims.AddRange(new List<Claim>() { new Claim{
                Id = 1,
                CreatedBy = 1,
                ModifiedBy = 1,
                IsActive = true,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                Name="Select",


            },
            new Claim{
                Id = 2,
                CreatedBy = 1,
                ModifiedBy = 1,
                IsActive = true,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                Name="Create",


            },
            new Claim{
                Id = 3,
                CreatedBy = 1,
                ModifiedBy = 1,
                IsActive = true,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                Name="Update",


            },
            new Claim{
                Id = 4,
                CreatedBy = 1,
                ModifiedBy = 1,
                IsActive = true,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                Name="Delete",


            }

            });

            //rol seed data
            context.Roles.AddRange(new List<Role> {new Role() {    Id = 1,
                CreatedBy = 1,
                ModifiedBy = 1,
                IsActive = true,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                Name="Admin"
            },
            new Role() {    Id = 2,
                CreatedBy = 1,
                ModifiedBy = 1,
                IsActive = true,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                Name="User"
            } });




        }
    }
}
