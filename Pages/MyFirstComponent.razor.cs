using Microsoft.AspNetCore.Components;

namespace BlazorApp.Wasm.Pages;

public partial class MyFirstComponent
{
    [Parameter]
    public string Title { get; set; }

    private string Message { get; set; }

    public void ShowMessage(string message)
    {
        this.Message = message;
        StateHasChanged();
    }
}