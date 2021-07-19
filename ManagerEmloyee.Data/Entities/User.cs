using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ManagerEmployee.DAL.Entities
{

    public enum Role
    {
        Administrator, User
    }
    public class User
    {
        [Key]
        [Display(Name = "Mã nhân viên")]
        public int Id { get; set; }

        [Display(Name = "Tên nhân viên")]
        [StringLength(100, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }

        //[Required]
        [Required]
        [Display(Name = "Tên tài khoản")]
        [StringLength(100, MinimumLength = 3)]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Mật khẩu")]
        [StringLength(100, MinimumLength = 3)]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Chức vụ")]
        public int PositionId { get; set; }

        [Required]
        [Display(Name = "Trạng thái")]
        public bool Status { get; set; }

        
        [Display(Name = "Quyền")]
        public Role? Role { get; set; }

        [Required]
        [Display(Name = "Phòng ban")]
        public int DepartentId { get; set; }

        [ForeignKey("DepartentId")]
        public virtual Departent Departents { get; set; }
        public virtual Position Positions { get; set; }
    }
}
