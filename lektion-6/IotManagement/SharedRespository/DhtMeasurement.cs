using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SharedRespository
{
    public class DhtMeasurement
    {
        [Required]
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string DeviceId { get; set; }

        [Required]
        public string Temperature { get; set; }

        [Required]
        public string Humidity { get; set; }

        public string MeasurementTime { get; set; }
    }
}
