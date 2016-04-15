using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace eaglinexamp1.Models
{
    public class Menu
    {
        [Key]
        public int MenuID { get; set; }

        [Display(Name = "Title")]
        public string MenuTitle { get; set; }

        [Display(Name = "Descritpion")]
        public string MenuDescritpion { get; set; }

        public virtual List<MenuItem> MenuItems { get; set; }

        public virtual List<MenuGroup> MenuGroups { get; set; }
    }
}