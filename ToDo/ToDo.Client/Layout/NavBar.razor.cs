using Microsoft.AspNetCore.Components;

namespace ToDo.Client.Layout;

public partial class NavBar
{
    [Parameter]
    public string NavTitle { get; set; } = "Hej";

    [Parameter]
    public RenderFragment? ChildContent { get; set; }
}
