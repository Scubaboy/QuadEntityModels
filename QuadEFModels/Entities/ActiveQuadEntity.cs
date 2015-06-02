using Breeze.Sharp;
using QuadModels;
using System.ComponentModel.DataAnnotations;

namespace QuadEFModels.Entities
{
    public class ActiveQuadEntity : BaseEntity
    {
        public int ActiveQuadEntityId { get; set; }

        [Required]
        public string QuadId { get; set; }

        [Required]
        public CommsOptions SupportedComms { get; set; }

        [Required]
        public IMUOpions SupportedIMU { get; set; }

        [Required]
        public GPSOptions SupportGPS { get; set; }

        [Required]
        public AltimeterOptions SupportedAlt { get; set; }

        [Required]
        public bool InUse { get; set; }
    }
}
