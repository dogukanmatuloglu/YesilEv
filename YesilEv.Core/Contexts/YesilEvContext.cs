using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YesilEv.Core.Entities.Concrete;

namespace YesilEv.Core.Contexts
{
    public class YesilEvContext:DbContext
    {
        public YesilEvContext():base("Connection")
        {

        }
        public DbSet<BlackListProductContent> BlackListProductContents { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Claim> Claims { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<ContentType> ContentTypes { get; set; }
        public DbSet<FavoriteProductList> FavoriteProductLists { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<SearchHistory> SearchHistories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
      {
            //        modelBuilder.Entity<Grade>()
            //.HasMany<Student>(g => g.Students)
            //.WithRequired(s => s.CurrentGrade)
            //.HasForeignKey<int>(s => s.CurrentGradeId);
            //modelBuilder.Entity<Supplier>().HasMany<Product>(s => s.Products).WithRequired(p => p.Supplier).HasForeignKey(p => p.SupplierId);
            modelBuilder.Entity<Supplier>().HasMany<Product>(s => s.Products).WithOptional(p => p.Supplier).HasForeignKey(p => p.SupplierId);
            //modelBuilder.Entity<Product>().HasRequired<Supplier>(p => p.Supplier).WithMany(s => s.Products);



            modelBuilder.Entity<Category>().HasMany<Product>(c => c.Products).WithOptional(p => p.Category).HasForeignKey(p => p.CategoryId); //category product bire çok
            modelBuilder.Entity<Role>().HasMany<User>(r => r.Users).WithOptional(u => u.Role).HasForeignKey(u => u.RoleId); //role user bire çok 
            modelBuilder.Entity<BlackListProductContent>().HasMany<User>(b => b.Users).WithOptional(u => u.BlackListProductContent).HasForeignKey(u => u.BlackListProductContentId); //blacklistproductcontent user bire çok
           
            modelBuilder.Entity<FavoriteProductList>().HasMany<User>(f => f.Users).WithOptional(u => u.FavoriteProductList).HasForeignKey(u => u.FavoriteProductListId);
            modelBuilder.Entity<ContentType>().HasMany<Content>(ct => ct.Contents).WithOptional(c => c.ContentType).HasForeignKey(c => c.ContentId);
            modelBuilder.Entity<User>().HasMany<SearchHistory>(u => u.SearchHistories).WithOptional(s => s.User).HasForeignKey(s => s.UserId);
            modelBuilder.Entity<Category>().HasMany<Category>(u => u.Categories).WithOptional(c => c.TopCategory).HasForeignKey(c => c.TopCategoryId);


            //modelBuilder.Entity<FavoriteProductList>().HasMany<Product>(f=>f.Products).WithRequired(p=>p.)
            modelBuilder.Entity<Product>().HasMany<Content>(p => p.Contents).WithMany(c => c.Products).Map(pc =>
            { pc.MapLeftKey("ProductId"); 
              pc.MapRightKey("ContentId"); 
              pc.ToTable("ProductContent"); });
            modelBuilder.Entity<Role>().HasMany<Claim>(r => r.Claims).WithMany(c => c.Roles).Map(rc => { rc.MapLeftKey("RoleId"); rc.MapRightKey("ClaimId"); rc.ToTable("RoleClaim"); });

            modelBuilder.Entity<BlackListProductContent>().HasMany<Content>(b => b.Contents).WithMany(c => c.BlackListProductContents).Map(bc =>
            { bc.MapLeftKey("BlackListProductContentId");
              bc.MapRightKey("ContentId"); 
              bc.ToTable("BlacListProductContentContent"); });

            modelBuilder.Entity<FavoriteProductList>().HasMany<Product>(f => f.Products).WithMany(p => p.FavoriteProductLists).Map(fp =>
            {
                fp.MapLeftKey("FavoriteProductListId");
                fp.MapRightKey("ProductId");
                fp.ToTable("FavoriteProductListIdProduct");

            });
            modelBuilder.Entity<User>().Property(u => u.CreatedDate).HasColumnAnnotation("Default", "getdate()");
            modelBuilder.Entity<User>().Property(u => u.ModifiedDate).HasColumnAnnotation("Default", "getdate()");

            modelBuilder.Entity<User>().Property(u => u.CreatedDate).IsOptional();
            modelBuilder.Entity<User>().Property(u => u.ModifiedDate).IsOptional();
            
           
          



            //modelBuilder.Entity<Student>()
            //  .HasMany<Course>(s => s.Courses)
            //  .WithMany(c => c.Students)
            //  .Map(cs =>
            //  {
            //      cs.MapLeftKey("StudentRefId");
            //      cs.MapRightKey("CourseRefId");
            //      cs.ToTable("StudentCourse");
            //  });


        }


    }
}
