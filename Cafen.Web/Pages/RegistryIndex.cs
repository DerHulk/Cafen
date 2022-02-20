using System.Net.Http.Json;

namespace Cafen.Web.Pages
{
    public partial class RegistryIndex
    {
        private Catalog Catalog { get; set; }

        protected override async Task OnInitializedAsync()
        {
            this.Catalog = await Http.GetFromJsonAsync<Catalog>("/v2/_catalog");
        }
    }
}
