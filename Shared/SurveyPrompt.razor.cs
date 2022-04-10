using Microsoft.AspNetCore.Components;

namespace BlazorApp.Wasm.Shared
{
    public partial class SurveyPrompt
    {
        [Parameter]
        public string? Title { get; set; }
    }
}
