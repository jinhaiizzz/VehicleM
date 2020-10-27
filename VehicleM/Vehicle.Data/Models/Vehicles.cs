using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Vehicle.Data.Models
{
    public class Vehicles
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required] //Set not null
        [StringLength(250)] //set do rong
        public string VIN { get; set; }
        public int Mileage { get; set; }
        public int Year { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int Customer_ID { get; set; }
        [ForeignKey("Customer_ID")] //set khoa ngoai
        public Customer Customer { get; set; }
        public int Model_ID { get; set; }
        [ForeignKey("Model_ID")]
        public VehicleModels VehicleModels { get; set; }
        public int Make_ID { get; set; }
        [ForeignKey("Make_ID")]
        public VehicleMakes VehicleMakes { get; set; }
        public int Appraisal_ID { get; set; }
        [ForeignKey("Appraisal_ID")]
        public VehicleAppraisal VehicleAppraisal { get; set; }
        public int Condition_ID { get; set; }
        [ForeignKey("Condition_ID")]
        public VehicleCondition VehicleCondition { get; set; }

    }
}
