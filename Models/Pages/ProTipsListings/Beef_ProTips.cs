using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using System;
using System.ComponentModel.DataAnnotations;

namespace RareMediumAcademy_03102022.Models.Pages.ProTipsListings
{
    [ContentType(DisplayName = "Beef_ProTips", GUID = "729f22bd-be37-4bf1-9690-59380bf7b7f2", Description = "")]
    public class Beef_ProTips : PageData
    {
        /*
                [CultureSpecific]
                [Display(
                    Name = "Main body",
                    Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
                public virtual XhtmlString MainBody { get; set; }
         */
    }
}