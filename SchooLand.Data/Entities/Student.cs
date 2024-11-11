using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchooLand.Data.Entities
{
    public class Student
    {

        [Key]
        public int StudID { get; set; }
        [StringLength(200)]

        public string Name { get; set; }
        [StringLength(500)]

        public string Address { get; set; }
        [StringLength(500)]

        public string Phone { get; set; }

        public int? DID { get; set; }

        [ForeignKey("DID")]
        [InverseProperty("Students")]

        public virtual Department Departmenet { get; set; }

    }
}
