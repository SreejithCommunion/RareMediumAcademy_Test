using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using System;
using System.ComponentModel.DataAnnotations;

namespace RareMediumAcademy_03102022.Models.Pages.ProTipsListings
{
    [ContentType(DisplayName = "PTBeef_BeefCurry", GUID = "fc3c451d-b405-4d32-b508-20f5a5b7b693", Description = "")]
    public class PTBeef_BeefCurry : PageData
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