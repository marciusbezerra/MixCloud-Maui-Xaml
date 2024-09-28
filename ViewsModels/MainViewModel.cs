

using System.Net.Http.Json;
using MixCloud_App.Models;

namespace MixCloud_App.ViewModels;

public class MainViewModel
{

    public MixCloudResult? MixCloudResult { get; set; }

    public async Task SearchMixCloudAsync(string query, string type)
    {
        using var client = new HttpClient();
        var url = $"https://api.mixcloud.com/search/?q={query}&type={type}&limit=10&offset=0";
        MixCloudResult = await client.GetFromJsonAsync<MixCloudResult>(url);
    }

}