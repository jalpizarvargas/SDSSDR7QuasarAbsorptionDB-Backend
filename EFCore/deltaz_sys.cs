using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuasarWebAppAPI.EFCore
{
    [Table("deltaz_sys")]
    public class deltaz_sys
    {
        [Key, Required]
        public int id { get; set; }

        [Column("1025.7")]
        public float deltazSys_1025 { get; set; }

        [Column("1215.7")]
        public float deltazSys_1215 { get; set; }

        [Column("1238.8")]
        public float deltazSys_1238 { get; set; }

        [Column("1260.4")]
        public float deltazSys_1260 { get; set; }

        [Column("1302.2")]
        public float deltazSys_1302 { get; set; }

        [Column("1304.4")]
        public float deltazSys_1304 { get; set; }

        [Column("1334.5")]
        public float deltazSys_1334 { get; set; }

        [Column("1393.8")]
        public float deltazSys_1393 { get; set; }

        [Column("1402.8")]
        public float deltazSys_1402 { get; set; }

        [Column("1526.7")]
        public float deltazSys_1526 { get; set; }

        [Column("1548.2")]
        public float deltazSys_1548 { get; set; }

        [Column("1550.8")]
        public float deltazSys_1550 { get; set; }

        [Column("1608.5")]
        public float deltazSys_1608 { get; set; }

        [Column("1656.9")]
        public float deltazSys_1656 { get; set; }

        [Column("1670.8")]
        public float deltazSys_1670 { get; set; }

        [Column("1854.7")]
        public float deltazSys_1854 { get; set; }

        [Column("1862.8")]
        public float deltazSys_1862 { get; set; }

        [Column("2026.1")]
        public float deltazSys_2026 { get; set; }

        [Column("2056.3")]
        public float deltazSys_2056 { get; set; }

        [Column("2260.8")]
        public float deltazSys_2260 { get; set; }

        [Column("2374.5")]
        public float deltazSys_2374 { get; set; }

        [Column("2382.8")]
        public float deltazSys_2382 { get; set; }

        [Column("2586.7")]
        public float deltazSys_2586 { get; set; }

        [Column("2594.5")]
        public float deltazSys_2594 { get; set; }

        [Column("2600.2")]
        public float deltazSys_2600 { get; set; }

        [Column("2796.4")]
        public float deltazSys_2796 { get; set; }

        [Column("2803.5")]
        public float deltazSys_2803 { get; set; }

        [Column("2853.0")]
        public float deltazSys_2853 { get; set; }

        [Column("3242.9")]
        public float deltazSys_3242 { get; set; }

        [Column("3934.8")]
        public float deltazSys_3934 { get; set; }

        [Column("3969.6")]
        public float deltazSys_3969 { get; set; }

        [Column("5891.5")]
        public float deltazSys_5891 { get; set; }

    }
}
