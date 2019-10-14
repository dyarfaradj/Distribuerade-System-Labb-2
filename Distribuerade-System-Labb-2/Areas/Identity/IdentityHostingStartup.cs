﻿using System;
using DataAcces.DataContext;
using DataAcces.Entities;
using Distribuerade_System_Labb_2.Areas.Identity.Data;
using Distribuerade_System_Labb_2.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Distribuerade_System_Labb_2.Areas.Identity.IdentityHostingStartup))]
namespace Distribuerade_System_Labb_2.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDefaultIdentity<User>()
                    .AddEntityFrameworkStores<DatabaseContext>();
            });
        }
    }
}