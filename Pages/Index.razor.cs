using BlazorApp.Server.Model;
using Microsoft.AspNetCore.Components;

namespace BlazorApp.Wasm.Pages;

public partial class Index
{
    private MyFirstComponent myFirstComponent;

    [Parameter]
    public string Value { get; set; }
    private void SetCustomMessageClick()
    {
        myFirstComponent.ShowMessage("The message has changed");
    }
    
    private Person person = new Person() { Id = Guid.NewGuid(), Name = "Elon Musk" };
}