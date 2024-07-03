﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuasarWebAppAPI.EFCore
{
    [Table("gradeflag")]
    public class gradeflag
    {
        [Key, Required]
        public int id { get; set; }

        [Column("1025.7")]
        public float gradeFlag_1025 { get; set; }

        [Column("1215.7")]
        public float gradeFlag_1215 { get; set; }

        [Column("1238.8")]
        public float gradeFlag_1238 { get; set; }

        [Column("1260.4")]
        public float gradeFlag_1260 { get; set; }

        [Column("1302.2")]
        public float gradeFlag_1302 { get; set; }

        [Column("1304.4")]
        public float gradeFlag_1304 { get; set; }

        [Column("1334.5")]
        public float gradeFlag_1334 { get; set; }

        [Column("1393.8")]
        public float gradeFlag_1393 { get; set; }

        [Column("1402.8")]
        public float gradeFlag_1402 { get; set; }

        [Column("1526.7")]
        public float gradeFlag_1526 { get; set; }

        [Column("1548.2")]
        public float gradeFlag_1548 { get; set; }

        [Column("1550.8")]
        public float gradeFlag_1550 { get; set; }

        [Column("1608.5")]
        public float gradeFlag_1608 { get; set; }

        [Column("1656.9")]
        public float gradeFlag_1656 { get; set; }

        [Column("1670.8")]
        public float gradeFlag_1670 { get; set; }

        [Column("1854.7")]
        public float gradeFlag_1854 { get; set; }

        [Column("1862.8")]
        public float gradeFlag_1862 { get; set; }

        [Column("2026.1")]
        public float gradeFlag_2026 { get; set; }

        [Column("2056.3")]
        public float gradeFlag_2056 { get; set; }

        [Column("2260.8")]
        public float gradeFlag_2260 { get; set; }

        [Column("2374.5")]
        public float gradeFlag_2374 { get; set; }

        [Column("2382.8")]
        public float gradeFlag_2382 { get; set; }

        [Column("2586.7")]
        public float gradeFlag_2586 { get; set; }

        [Column("2594.5")]
        public float gradeFlag_2594 { get; set; }

        [Column("2600.2")]
        public float gradeFlag_2600 { get; set; }

        [Column("2796.4")]
        public float gradeFlag_2796 { get; set; }

        [Column("2803.5")]
        public float gradeFlag_2803 { get; set; }

        [Column("2853.0")]
        public float gradeFlag_2853 { get; set; }

        [Column("3242.9")]
        public float gradeFlag_3242 { get; set; }

        [Column("3934.8")]
        public float gradeFlag_3934 { get; set; }

        [Column("3969.6")]
        public float gradeFlag_3969 { get; set; }

        [Column("5891.5")]
        public float gradeFlag_5891 { get; set; }

    }
}
