using System.ComponentModel.DataAnnotations;

namespace Skill_International.Models
{
    public class StudentModel
    {
        [Key]
        public int regNo { get; set; }

        [StringLength(50)]
        public string firstName { get; set; }

        [StringLength(50)]
        public string lastName { get; set; }

        public DateTime dateOfBirth { get; set; }

        [StringLength(50)]
        public string gender { get; set; }

        [StringLength(50)]
        public string address { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        public int mobilePhone { get; set; }

        public int homePhone { get; set; }

        [StringLength(50)]
        public string parentName { get; set; }

        [StringLength(50)]
        public string nic { get; set; }

        public int contactNo { get; set; }
    }
}
