using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace OPUPMS.Domain.Base.Models
{
    [Table("UserRestaurant")]
    public class UserRestaurant
    {
        public int UserId { get; set; }
        public int RestaurantId { get; set; }
        public int CompanyId { get; set; }
    }
}
