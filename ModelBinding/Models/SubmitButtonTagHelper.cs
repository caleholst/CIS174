using Microsoft.AspNetCore.Razor.TagHelpers;

namespace ModelBinding.TagHelpers
{
    [HtmlTargetElement("submit-button")]
    public class SubmitButtonTagHelper : TagHelper
    {
        public string Text { get; set; } = "Submit";
        public string Class { get; set; } = "btn btn-primary";

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "button";
            output.Attributes.SetAttribute("type", "submit");
            output.Attributes.SetAttribute("class", Class);
            output.Content.SetContent(Text);
        }
    }
}