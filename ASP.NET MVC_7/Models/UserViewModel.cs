using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASP.NET_MVC_7.Models
{
    public class UserViewModel
    {
        [Display(Name = "UserName", ResourceType = typeof(InternationalizationResources.Resource))]
        [Required(ErrorMessageResourceName = "UserNameRequired", ErrorMessageResourceType = typeof(InternationalizationResources.Resource))]
        public string UserName { get; set; }

        [Display(Name = "FullName", ResourceType = typeof(InternationalizationResources.Resource))]
        [Required(ErrorMessageResourceName = "NameRequired", ErrorMessageResourceType = typeof(InternationalizationResources.Resource))]
        public string FullName { get; set; }

        [Display(Name = "Password", ResourceType = typeof(InternationalizationResources.Resource))]
        [Required(ErrorMessageResourceName = "PasswordRequired", ErrorMessageResourceType = typeof(InternationalizationResources.Resource))]
        public string Password { get; set; }

        [Display(Name = "ConfirmPassword", ResourceType = typeof(InternationalizationResources.Resource))]
        [Required(ErrorMessageResourceName = "ConfirmPasswordRequired", ErrorMessageResourceType = typeof(InternationalizationResources.Resource))]
        [Compare("Password", ErrorMessageResourceName = "ConfirmPasswordCompare", ErrorMessageResourceType = typeof(InternationalizationResources.Resource))]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Address", ResourceType = typeof(InternationalizationResources.Resource))]
        [Required(ErrorMessageResourceName = "AddressRequired", ErrorMessageResourceType = typeof(InternationalizationResources.Resource))]
        public string Address { get; set; }
    }
}