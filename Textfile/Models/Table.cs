namespace Textfile.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Table")]
    public partial class Table
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string TickNumber { get; set; }

        public DateTime FlyingDay { get; set; }

        public DateTime Birthday { get; set; }
    }
}
