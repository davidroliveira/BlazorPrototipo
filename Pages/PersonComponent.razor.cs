using BlazorApp.Server.Model;

namespace BlazorApp.Wasm.Pages;

public partial class PersonComponent
{
    private readonly PersonModel personModel = new PersonModel() { Id = Guid.NewGuid(), Name = "Elon Musk" };
}