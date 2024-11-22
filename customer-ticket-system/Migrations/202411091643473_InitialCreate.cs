namespace customer_ticket_system.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(unicode: false),
                        LastName = c.String(unicode: false),
                        Email = c.String(unicode: false),
                        PasswordHash = c.String(unicode: false),
                        CreatedAt = c.DateTime(nullable: false, precision: 0),
                        UpdatedAt = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateStoredProcedure(
                "dbo.User_Insert",
                p => new
                    {
                        FirstName = p.String(maxLength: 1073741823, unicode: false),
                        LastName = p.String(maxLength: 1073741823, unicode: false),
                        Email = p.String(maxLength: 1073741823, unicode: false),
                        PasswordHash = p.String(maxLength: 1073741823, unicode: false),
                        CreatedAt = p.DateTime(),
                        UpdatedAt = p.DateTime(),
                    },
                body:
                    @"SET SESSION sql_mode='ANSI';INSERT INTO `Users`(
                      `FirstName`, 
                      `LastName`, 
                      `Email`, 
                      `PasswordHash`, 
                      `CreatedAt`, 
                      `UpdatedAt`) VALUES (
                      @FirstName, 
                      @LastName, 
                      @Email, 
                      @PasswordHash, 
                      @CreatedAt, 
                      @UpdatedAt);
                      SELECT
                      `Id`
                      FROM `Users`
                       WHERE  row_count() > 0 AND `Id`=last_insert_id();"
            );
            
            CreateStoredProcedure(
                "dbo.User_Update",
                p => new
                    {
                        Id = p.Int(),
                        FirstName = p.String(maxLength: 1073741823, unicode: false),
                        LastName = p.String(maxLength: 1073741823, unicode: false),
                        Email = p.String(maxLength: 1073741823, unicode: false),
                        PasswordHash = p.String(maxLength: 1073741823, unicode: false),
                        CreatedAt = p.DateTime(),
                        UpdatedAt = p.DateTime(),
                    },
                body:
                    @"UPDATE `Users` SET `FirstName`=@FirstName, `LastName`=@LastName, `Email`=@Email, `PasswordHash`=@PasswordHash, `CreatedAt`=@CreatedAt, `UpdatedAt`=@UpdatedAt WHERE `Id` = @Id;"
            );
            
            CreateStoredProcedure(
                "dbo.User_Delete",
                p => new
                    {
                        Id = p.Int(),
                    },
                body:
                    @"DELETE FROM `Users` WHERE `Id` = @Id;"
            );
            
        }
        
        public override void Down()
        {
            DropStoredProcedure("dbo.User_Delete");
            DropStoredProcedure("dbo.User_Update");
            DropStoredProcedure("dbo.User_Insert");
            DropTable("dbo.Users");
            DropTable("dbo.Roles");
        }
    }
}
