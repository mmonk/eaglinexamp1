using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace eaglinexamp1.Models
{
    public class MenuItem
    {
        [Key]
        public int MenuItemID { get; set; }

        [ForeignKey("Menu")]
        public int MenuID { get; set; }
        public virtual Menu Menu { get; set; }

        [ForeignKey("MenuGroup")]
        public int MenGroupID { get; set; }
        public virtual MenuGroup MenuGroup { get; set; }

        [Required(ErrorMessage = "A title is required for the menu item")]
        [Display(Name = "Title")]
        public string MenuItemTitle { get; set; }

        [Display(Name = "Description")]
        public string MenuItemDescription { get; set; }

        [Display(Name = "Nutritional Information")]
        public string MenuItemNutritionalInformation { get; set; }

        [Display(Name = "Information about ingredients")]
        public string MenuItemIngredientse { get; set; }

        [Display(Name = "How many serving")]
        public string MenuItemQuantity { get; set; }

        [Display(Name = "Cost of Menu Item")]
        public string MenuItemCost { get; set; }
    }
}