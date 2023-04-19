using BlazorEcommerce.Shared;
using System.Net.Http.Json;

namespace BlazorEcommerce.Client.Shared
{
    public partial class ProductList
    {
        public static List<Product>? Products;
        protected override async Task OnInitializedAsync()
        {
            Products = await Http.GetFromJsonAsync<List<Product>>("api/Product");

        }

    }
}
