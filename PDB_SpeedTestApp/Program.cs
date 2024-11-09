using Microsoft.EntityFrameworkCore;
using PDB_SpeedTestApp.Services;

namespace PDB_SpeedTestApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer(@"Server=jakubpajak_asus;Database=pdb_database;Trusted_Connection=True;TrustServerCertificate=True;");
            //optionsBuilder.UseSqlServer(@"Server=KACPER\SQLEXPRESS;Database=PDB;Trusted_Connection=True;TrustServerCertificate=True;");
            var dbContextOptions = optionsBuilder.Options;

            ApplicationConfiguration.Initialize();

            using (var context = new AppDbContext(dbContextOptions))
            {
                context.Database.Migrate();
                Application.Run(new ReadWriteSpeedTest(context));
            }
        }
    }
}