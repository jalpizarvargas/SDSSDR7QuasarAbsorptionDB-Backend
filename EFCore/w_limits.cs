using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuasarWebAppAPI.EFCore
{
    [Table("w_limits")]
    public class w_limits
    {
        [Key, Required]
        public int id { get; set; }

        public float col0 { get; set; }

        public float col1 { get; set; }

        public float col2 { get; set; }

        public float col3 { get; set; }

        public float col4 { get; set; }

        public float col5 { get; set; }

        public float col6 { get; set; }

    }
}
