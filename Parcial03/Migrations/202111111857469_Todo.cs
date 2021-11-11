namespace Parcial03.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Todo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        id_Clie = c.Int(nullable: false, identity: true),
                        nombres = c.String(nullable: false, maxLength: 150),
                        apellidos = c.String(nullable: false, maxLength: 150),
                        dui = c.String(nullable: false, maxLength: 150),
                        fechaNaci = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id_Clie);
            
            CreateTable(
                "dbo.Pedidos",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        fechaPedido = c.DateTime(nullable: false),
                        fechaEntrega = c.DateTime(nullable: false),
                        id_Pro = c.Int(),
                        id_Clie = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Clientes", t => t.id_Clie)
                .ForeignKey("dbo.Productos", t => t.id_Pro)
                .Index(t => t.id_Pro)
                .Index(t => t.id_Clie);
            
            CreateTable(
                "dbo.Productos",
                c => new
                    {
                        id_Pro = c.Int(nullable: false, identity: true),
                        nombre = c.String(nullable: false, maxLength: 150),
                        stock = c.Int(nullable: false),
                        valor = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.id_Pro);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pedidos", "id_Pro", "dbo.Productos");
            DropForeignKey("dbo.Pedidos", "id_Clie", "dbo.Clientes");
            DropIndex("dbo.Pedidos", new[] { "id_Clie" });
            DropIndex("dbo.Pedidos", new[] { "id_Pro" });
            DropTable("dbo.Productos");
            DropTable("dbo.Pedidos");
            DropTable("dbo.Clientes");
        }
    }
}
