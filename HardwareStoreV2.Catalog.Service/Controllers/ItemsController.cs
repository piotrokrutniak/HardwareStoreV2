using HardwareStoreV2.Catalog.Service.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace HardwareStoreV2.Catalog.Service.Controllers
{
    [ApiController]
    [Route("items")]
    public class ItemsController : ControllerBase
    {
        private static readonly List<ItemDto> items = new()
        {
            new ItemDto(Guid.NewGuid(), "RTX 4090", "NVIDIA Ada Lovelace Streaming Multiprocessors: Up to 2x performance and power efficiency 4th Generation Tensor Cores: Up to 2x AI performance 3rd Generation RT Cores: Up to 2x ray tracing performance Powered by GeForce RTX 4090 Integrated with 24GB GDDR6X 384-bit memory interface WINDFORCE cooling system, RGB Fusion, Dual BIOS Protection metal back plate, Anti-sag bracket. Ahead of its time, ahead of the game is the GIGABYTE GeForce RTX 4090 GAMING OC 24G Graphics Cards. Powered by NVIDIA's new RTX architecture and refined with WINDFORCE cooling technology, the GIGABYTE GeForce RTX 4090 GAMING OC 24G brings stunning visuals, amazingly fast frame rates, and AI acceleration to games and creative applications with its enhanced RT Cores and Tensor Cores, along with a staggering 24 GB of G6X memory.", 1699.99m, DateTimeOffset.Now),
            new ItemDto(Guid.NewGuid(), "RTX 4080", "The NVIDIA GeForce RTX 4080 16 GB delivers the ultra performance and features that enthusiast gamers and creators demand. Bring your games and creative projects to life with ray tracing and AI-powered graphics. It’s powered by the ultra-efficient NVIDIA Ada Lovelace architecture and 16GB of superfast G6X memory.", 1219.99m, DateTimeOffset.Now),
            new ItemDto(Guid.NewGuid(), "RTX 4070 TI", "The NVIDIA GeForce RTX 4070 Ti delivers the ultra performance and features that enthusiast gamers and creators demand. Bring your games and creative projects to life with ray tracing and AI-powered graphics. It’s powered by the ultra-efficient NVIDIA Ada Lovelace architecture and up to 12GB of superfast G6X memory.", 829.99m, DateTimeOffset.Now)
            
        };

        //GET /items
        [HttpGet]
        public IEnumerable<ItemDto> Get()
        {
            return items;
        }

        //GET /items/{id}
        [HttpGet("{id}")]
        public ActionResult<ItemDto> GetById(Guid id)
        {
            var item = items.Where(item => item.Id == id).FirstOrDefault();
            if(item == null)
            {
                return NotFound();
            }

            return item;
        }

        //POST /items/{id}
        [HttpPost]
        public ActionResult<ItemDto> Post(CreateItemDto createItemDto)
        {
            var item = new ItemDto(Guid.NewGuid(), createItemDto.Name, createItemDto.Description, createItemDto.Price, DateTime.Now);
            items.Add(item);
            return CreatedAtAction(nameof(GetById), new { Id = item.Id }, item);
        }

        //PUT /items/{id}
        [HttpPut("{id}")]
        public ActionResult Update(Guid id, UpdateItemDto updateItemDto)
        {
            var existingItem = items.Where(item => item.Id == id).FirstOrDefault();

            if (existingItem == null)
            {
                return NotFound();
            }

            var updatedItem = existingItem with
            {
                Name = updateItemDto.Name,
                Description = updateItemDto.Description,
                Price = updateItemDto.Price,
            };

            var index = items.FindIndex(existingItem => existingItem.Id == id);
            items[index] = updatedItem;

            return NoContent();
        }

        //PUT /items/{id}
        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            var index = items.FindIndex(existingItem => existingItem.Id == id);

            if (index < 0)
            {
                return NotFound();
            }

            items.RemoveAt(index);

            return NoContent();
        }
    }
}
