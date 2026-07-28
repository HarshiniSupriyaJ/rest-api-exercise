using Microsoft.AspNetCore.Mvc;
using RestApiExercise.Models;

namespace RestApiExercise.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ItemsController : ControllerBase
{
    private static readonly List<Item> Items =
    [
        new Item { Id = 1, Name = "Laptop" },
        new Item { Id = 2, Name = "Mouse" },
        new Item { Id = 3, Name = "Keyboard" }
    ];

    [HttpGet]
    public IActionResult GetItems()
    {
        return Ok(Items);
    }

    [HttpPost]
    public IActionResult AddItem(CreateItemDto dto)
    {
        if (string.IsNullOrWhiteSpace(dto.Name))
        {
            return BadRequest("Name is required");
        }

        var item = new Item
        {
            Id = Items.Max(i => i.Id) + 1,
            Name = dto.Name
        };

        Items.Add(item);

        return Created("", item);
    }
}