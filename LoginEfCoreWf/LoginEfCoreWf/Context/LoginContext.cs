using LoginEfCoreWf.Models;
using Microsoft.EntityFrameworkCore;

namespace LoginEfCoreWf.Context;

public class LoginContext : DbContext
{
    public DbSet<Login> Logins { get; set; }

    public string DbPath { get; }

    public LoginContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "db_login.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
}
