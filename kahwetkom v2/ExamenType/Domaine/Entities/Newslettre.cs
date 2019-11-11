using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Newslettre
    {
        [Key]
        public int IdNewslettre { get; set; }
        public virtual User Userr { get; set; }
        public int? IdUser { get; set; }
        public String MailUser { get; set; }
        public int PhoneUser { get; set; }
        public bool status { get; set; }
    }
}
