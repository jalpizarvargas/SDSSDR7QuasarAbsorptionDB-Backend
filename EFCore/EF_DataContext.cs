using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.Runtime.CompilerServices;

namespace QuasarWebAppAPI.EFCore
{
    public class EF_DataContext : DbContext
    {

        public EF_DataContext(DbContextOptions<EF_DataContext> options) : base(options) { }

        public DbSet<lambda_vac> lambda_Vacs { get; set; }

        public DbSet<quasar_catalog> quasar_Catalogs { get; set; }

        public DbSet<w_limits> w_limits { get; set; }

        public DbSet<lambda_obs> lambda_Obs { get; set; }

        public DbSet<lya_flag> lya_Flag { get; set;}

        public DbSet<gradeflag> gradeFlag { get; set; }

        public DbSet<fwhm> fwhm { get; set; }

        public DbSet<ew_obs> ew_Obs { get; set; }

        public DbSet<ew_err_obs> ew_Err_Obs { get; set; }

        public DbSet<deltav_sys> deltav_Sys { get; set; }

        public DbSet<deltaz_sys> deltaz_Sys { get; set; }

        public DbSet<blendflag> blendflag { get; set; }

    }
}
