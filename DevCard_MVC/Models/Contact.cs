using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DevCard_MVC.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "نام فرستندۀ پیام نمی تواند خالی باشد")]
        public string Name { get; set; }

        [Required(ErrorMessage = "ایمیل فرستندۀ پیام بایستی وارد شود")]
        [EmailAddress(ErrorMessage = "مقدار وارده شده یک آدرس صحیح ایمیل نمی باشد")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "از میان لیست بخش های موجود، بایستی مقصد ارتباطی خود را مشخص کنید")]
        public string Category { get; set; }
        
        [Required(ErrorMessage = "متن پیام ارسالی نمی تواند خالی باشد")]
        public string Message { get; set; }

        public int Service { get; set; }

        public SelectList Services { get; set; }


    }
}
