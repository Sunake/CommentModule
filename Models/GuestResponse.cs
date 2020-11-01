using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CommentModule.Models
{
    public class GuestResponse
    {
        [Required (ErrorMessage = "Введите имя, пожалуйста")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Введите почту, пожалуйста")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Введите корректный Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Введите телефон, пожалуйста")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Укажите, примете ли вы участие")]
        public bool? WillAttend { get; set; }
    }
}
