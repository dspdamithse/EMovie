namespace EMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'7cbb89f0-647d-4ffb-bf44-3fa1e7e7e9d2', N'damithkum565@gmail.com', 0, N'ANOFAfmGRm3yg2OhCS8sHkCQu6MH68bfAybKTkvvBlZT1dOW3DyY1MKn7aqvvw1GXQ==', N'd9d7106c-09d9-46db-95c1-02fa1742bbe7', NULL, 0, 0, NULL, 1, 0, N'damithkum565@gmail.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'7f988412-6f27-46c6-b312-c04a95daa7d7', N'dspdamithse@gmail.com', 0, N'AHHTOhLgU73D6BwzPYO2YzLmvUocxVCquDMVMTyU8HYove3uPlkIxUcqfsoKyLGnpw==', N'3feea074-9c82-43dd-88a9-a024e81d414d', NULL, 0, 0, NULL, 1, 0, N'dspdamithse@gmail.com')
            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'9e2ebffb-67d5-4fa6-a50a-208b108e4f9a', N'CanManageMovie')
            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'7cbb89f0-647d-4ffb-bf44-3fa1e7e7e9d2', N'9e2ebffb-67d5-4fa6-a50a-208b108e4f9a')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
