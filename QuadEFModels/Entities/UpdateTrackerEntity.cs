using Breeze.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadEFModels.Entities
{
    public class UpdateTrackerEntity : BaseEntity
    {
        [Key]
        public virtual int ID { get; set; }

        [Required]
        public virtual DbUpdate UpdateMade { get; set; }

        [Required]
        public virtual string MadeBy { get; set; }

        [Required]
        public virtual DateTime TimeStamp { get; set; }
    }
}
