using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SimpleBlogWeb.ViewModels
{
    //Class names must be in format ControllernameActionname
    /// <summary>
    /// Auth Controller Login Action View Model
    /// It is a contract between Auth Contoller Login Action and Login.cshtml
    /// </summary>
    public class AuthLogin
    {


        public string Test { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        [DataType("Password")]
        public string Password { get; set; }
    }

    public class AuthList
    {
        public List<AuthLogin> Users { get; set; }
    }
}