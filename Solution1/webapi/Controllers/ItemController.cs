using Microsoft.AspNetCore.Mvc;
using webapi.Models;

namespace webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController : ControllerBase
    {
        private static readonly IEnumerable<ItemModel> Items = new[]
        {
            new ItemModel{Id=0, Title="Bob"},
            new ItemModel{Id=1, Title="Joe"},
            new ItemModel{Id=2, Title="Mary"},
            new ItemModel{Id=3, Title="Emma"},
            new ItemModel{Id=4, Title="Jamie"},
            new ItemModel{Id=5, Title="Jeff"}
        };
        [HttpGet("{itemID:int}")]
        public ItemModel[] Get(int itemID)
        {
            ItemModel[] items = Items.Where(i => i.Id == itemID).ToArray();
            return items;
        }
    }
}