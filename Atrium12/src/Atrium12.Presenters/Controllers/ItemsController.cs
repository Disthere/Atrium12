using Atrium12.Application.Interfaces;
using Atrium12.Contracts.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Atrium12.Presenters.Controllers
{
    [ApiController]
    [Route("api/v1/items")]
    public class ItemsController : ControllerBase
    {
        private readonly IItemsService _itemService;

        public ItemsController(IItemsService itemService)
        {
            _itemService = itemService;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<ItemDto>>> GetAll(
            [FromQuery] GetItemsDto request,
            CancellationToken cancellationToken) =>
            Ok(await _itemService.GetAllAsync());


        [HttpGet("{itemId:guid}")]
        public async Task<ActionResult<ItemDto>> GetById(
            [FromRoute] System.Guid itemId,
            CancellationToken cancellationToken)
        {
            var item = await _itemService.GetByIdAsync(itemId);
            return item is null ? NotFound() : Ok(item);
        }


        [HttpPost]
        public async Task<ActionResult<Guid>> Create(
            [FromBody] CreateItemDto request,
            CancellationToken cancellationToken)
        {
            var item = await _itemService.CreateAsync(request);
            return CreatedAtAction(nameof(GetById), item);
        }


        [HttpPut("{itemId:guid}")]
        public async Task<ActionResult<Contracts.DTOs.ItemDto>> Update(
            [FromRoute] System.Guid itemId,
            [FromBody] UpdateItemDto request,
            CancellationToken cancellationToken)
        {
            var item = await _itemService.UpdateAsync(itemId, request);
            return item is null ? NotFound() : Ok(item);
        }


        [HttpDelete("{itemId:guid}")]
        public async Task<IActionResult> Delete(
            [FromRoute] System.Guid itemId,
            CancellationToken cancellationToken)
        {
            var success = await _itemService.DeleteAsync(itemId);
            return success ? NoContent() : NotFound();
        }
    }

}
