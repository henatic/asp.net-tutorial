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
            new ItemModel{Id=0, Title="Bryce"},
            new ItemModel{Id=1, Title="Henry"},
            new ItemModel{Id=2, Title="Nathan"},
            new ItemModel{Id=3, Title="Emma"},
            new ItemModel{Id=4, Title="Jamie"},
            new ItemModel{Id=5, Title="Ryan"},
            new ItemModel{Id=6, Title="Johnny"},
            new ItemModel{Id=7, Title="David"},
            new ItemModel{Id=8, Title="Elizabeth"},
            new ItemModel{Id=9, Title="Mohsin"},
            new ItemModel{Id=10, Title="Joel"}
        };
        [HttpGet(Name = "GetItems")]
        public IEnumerable<ItemModel> Get()
        {
            ItemModel[] items = Items.ToArray();
            return items;
        }
    }
}