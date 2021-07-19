using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ManagerEmployee.DAL.Entities
{
    public class Position
    {
        [Key]
        [Display(Name = "Mã chức vụ")]
        public int Id { get; set; }

        [Display(Name = "Tên chức vụ")]
        [StringLength(100, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
