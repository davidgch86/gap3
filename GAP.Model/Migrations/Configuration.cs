namespace GAP.Model.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GAP.Model.GAPContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(GAP.Model.GAPContext context)
        {
            var clients = new List<Client>
            {
                new Client { Identification = "1111 111 11",   Name = "David test" },
                new Client { Identification = "222",   Name = "Client2 test" }
            };
            clients.ForEach(s => context.Client.AddOrUpdate(p => p.Identification, s));
            context.SaveChanges();

            var users = new List<UsersGAP>
            {
                new UsersGAP { UserName = "test",   UserPassword = "test" , IsAdmin=false},
                new UsersGAP { UserName = "david",   UserPassword = "test" , IsAdmin=true},
                new UsersGAP { UserName = "admin",   UserPassword = "admin" , IsAdmin=true},
            };
            users.ForEach(s => context.UserGAP.AddOrUpdate(p => p.UserName, s));
            context.SaveChanges();
        }
    }
}
