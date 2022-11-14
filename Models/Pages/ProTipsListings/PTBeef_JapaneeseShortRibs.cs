using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using System;
using System.ComponentModel.DataAnnotations;

namespace RareMediumAcademy_03102022.Models.Pages.ProTipsListings
{
    [ContentType(DisplayName = "PTBeef_JapaneeseShortRibs", GUID = "a1316177-5006-4ef3-a878-b7a99d984000", Description = "")]
    public class PTBeef_JapaneeseShortRibs : PageData
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