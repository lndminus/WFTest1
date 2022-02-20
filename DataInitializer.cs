using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkFinder.Models;

namespace WorkFinder
{
    public static class DataInitializer
    {
        public static void Initialize(WorkFinderContext context)
        {
            if (!context.Admins.Any())
            {
                context.Admins.AddRange(
                    new Admin
                    {
                        Login = "adminlogin",
                        Password = "adminpassword",
                        Name = "AdminName",
                        Surename = "AdminSurename"
                    }
                );
                context.SaveChanges();
            }
            if (!context.Clients.Any())
            {
                context.Clients.AddRange(
                    new Client
                    {
                        Login = "login1",
                        Password = "password1",
                        Name = "ClientName1",
                        Surename = "ClientSurename1"
                    },
                    new Client
                    {
                        Login = "login2",
                        Password = "password2",
                        Name = "ClientName2",
                        Surename = "ClientSurename2"
                    },
                    new Client
                    {
                        Login = "login3",
                        Password = "password3",
                        Name = "ClientName3",
                        Surename = "ClientSurename3"
                    }
                ); ;
                context.SaveChanges();
            }
        }
    }
}
