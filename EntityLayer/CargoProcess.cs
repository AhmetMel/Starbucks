using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class CargoProcess
    {
        [Key]
        public int cargoId { get; set; }
        [StringLength(50)] 
        public string cargoStatus { get; set; }
        public bool cargoProcessDeleted { get; set; }
        //Relationship with Order 
        public virtual ICollection<Order> orders{ get; set; }

    }
}
