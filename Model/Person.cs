using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Person
    {
        public int PersonId { get; set; }
        [ConcurrencyCheck]
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SocialSecurityNumber { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
