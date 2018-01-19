using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class Conta
    {
        public int Id { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Username { get; set; }
        [DataType(DataType.Password)]
        public int Password { get; set; }
        [DataType(DataType.Password)]
        public int Confirmpassword { get; set; }
    }
}