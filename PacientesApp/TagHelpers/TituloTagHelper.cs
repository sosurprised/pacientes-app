using Microsoft.AspNetCore.Razor.TagHelpers;

namespace MedApp.TagHelpers
{
    public class TituloTagHelper: TagHelper
    {
        public string Texto { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (!string.IsNullOrEmpty(Texto))
            {
                output.TagName = "h4";
                output.Attributes.SetAttribute("class", "text-primary");
                output.Content.SetContent(Texto);
            }
        }
    }
}
