namespace BasicWebApp.TagHelpers;

using Microsoft.AspNetCore.Razor.TagHelpers;

[HtmlTargetElement("span", Attributes="time-display-format")]
public class ClockTagHelper : TagHelper
{
	public string TimeDisplayFormat { get; set; } = "HH:mm:ss";

	public override void Process(TagHelperContext context, TagHelperOutput output)
	{
		output.Attributes.RemoveAll("time-display-format");
		output.Content.SetContent(DateTime.Now.ToString(TimeDisplayFormat));
	}
}

