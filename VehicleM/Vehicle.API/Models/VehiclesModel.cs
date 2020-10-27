using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vehicle.API.Models
{
    public class VehiclesModel
    {
        public int ID { get; set; }
        public string VIN { get; set; }
        public int Mileage { get; set; }
        public int Year { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int Customer_ID { get; set; }
        public int Model_ID { get; set; }
        public int Make_ID { get; set; }
        public int Appraisal_ID { get; set; }
        public int Condition_ID { get; set; }
    }
}
