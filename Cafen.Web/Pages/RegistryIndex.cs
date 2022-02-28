using Cafen.Web.Components;
using System.Net.Http.Json;

namespace Cafen.Web.Pages
{
    public partial class RegistryIndex
    {
        private Catalog Catalog { get; set; }
        private Dictionary<string, ImageTags> Tags { get; set; }

        private Modal Modal { get; set; }

        protected override async Task OnInitializedAsync()
        {            
            this.Catalog = await Http.GetFromJsonAsync<Catalog>("/v2/_catalog");
            this.Tags = new Dictionary<string, ImageTags>();
        }

        public async Task LoadTags(string image)
        {
            var tagList = await Http.GetFromJsonAsync<ImageTags>($"/v2/{image}/tags/list");

            if (this.Tags.ContainsKey(image))
                this.Tags[image] = tagList;
            else
                this.Tags.Add(image, tagList);
        }

        public async Task Delete(string image, string tag)
        {
            var response = await Http.GetAsync($"/v2/{image}/manifests/{tag}");

            if(response.Headers.Contains("Docker-Content-Digest"))
            {
                var reference = response.Headers.GetValues("Docker-Content-Digest").SingleOrDefault();

                this.Modal.Open();
                //await this.Http.DeleteAsync($"/v2/{image}/manifests/{reference}");

            }            
        }
    }
}
