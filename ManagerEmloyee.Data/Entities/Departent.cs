using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ManagerEmployee.DAL.Entities
{
    public class Departent
    {
        [Key]
        [Display(Name = "Mã phòng ban")]
        public int Id { get; set; }

        [Display(Name = "Tên phòng ban")]
        [StringLength(100, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Người quản lý")]
        [StringLength(100, MinimumLength = 3)]
        [Required]
        public string Manager { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
