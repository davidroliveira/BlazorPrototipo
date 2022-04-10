namespace BlazorApp.Wasm.Pages;

public partial class ComAttributesComponent
{
    public int Maxlength { get; set; } = 10;
    public string Placeholder { get; set; } = "Digite um valor";
    public string Required { get; set; } = "required";
    public string Size { get; set; } = "20";
    public string Class { get; set; } = "custom-input";

    public Dictionary<string, object> DefaultAttributes { get; set; } =
        new Dictionary<string, object>()
        {
            {"maxlength", 10},
            {"placeholder", "Digite um valor"},
            {"required", "required"},
            {"size", "20"},
            {"class", "custom-input"}
        };
}