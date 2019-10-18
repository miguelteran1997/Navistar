using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NAVISTAR1.Data
{
    public class Employee
    {
       [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EID { get; set; }
        public string EN { get; set; }
        public string EL { get; set; }

        //foreign key
        public int DID { get; set; }

        [ForeignKey("DID")]
        public Deapartment Dept { get; set; }

        //foreign key
        public int OID { get; set; }

        [ForeignKey("OID")]
        public Owner Own { get; set; }

      
    }
}
