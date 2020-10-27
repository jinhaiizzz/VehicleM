using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Vehicle.Data.Models
{
    public class Customer
    {
        [Key] //Primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Tu dong tang
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        //Dinh nghia lop chua khoa ngoai o lop chinh
        public ICollection<Vehicles> Vehicle { get; set; }
    }
}
