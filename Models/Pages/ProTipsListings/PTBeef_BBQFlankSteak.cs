using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using System;
using System.ComponentModel.DataAnnotations;

namespace RareMediumAcademy_03102022.Models.Pages.ProTipsListings
{
    [ContentType(DisplayName = "PTBeef_BBQFlankSteak", GUID = "76e4100c-2b12-4f86-9893-4bffb9f2c9ce", Description = "")]
    public class PTBeef_BBQFlankSteak : PageData
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