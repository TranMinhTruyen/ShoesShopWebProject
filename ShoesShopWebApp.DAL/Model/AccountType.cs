using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ShoesShopWebApp.DAL.Model
{
    public class AccountType
    {
        #region --Mã loại tài khoản--
        [Key]
        [MaxLength(10)]
        [Column(TypeName = "nvarchar(10)")]
        [Required]
        public String AccountTypeID { get; set; }
        #endregion


        #region --Tên loại tài khoản--
        [MaxLength(20)]
        [Column(TypeName = "nvarchar(20)")]
        [Required]
        public String Name { get; set; }
        #endregion


        #region --Ghi chú--
        [MaxLength(50)]
        [Column(TypeName = "nvarchar(50)")] //Ghi chú không bắt buộc
        public String Note { get; set; }
        #endregion
    }
}
