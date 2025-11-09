using Atrium12.Collections.Application.Interfaces;
using Atrium12.Collections.Contracts.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Atrium12.Collections.Presenters.Controllers
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
            Ok(await _itemService.GetAllAsync(cancellationToken));


        [HttpGet("{itemId:guid}")]
        public async Task<ActionResult<ItemDto>> GetById(
            [FromRoute] Guid itemId,
            CancellationToken cancellationToken)
        {
            var item = await _itemService.GetByIdAsync(itemId, cancellationToken);
            return item is null ? NotFound() : Ok(item);
        }


        [HttpPost]
        public async Task<ActionResult<Guid>> Create(
            [FromBody] CreateItemDto request,
            CancellationToken cancellationToken)
        {
            var item = await _itemService.CreateAsync(request, cancellationToken);
            return CreatedAtAction(nameof(GetById), item);
        }


        [HttpPut("{itemId:guid}")]
        public async Task<ActionResult<ItemDto>> Update(
            [FromRoute] Guid itemId,
            [FromBody] UpdateItemDto request,
            CancellationToken cancellationToken)
        {
            var item = await _itemService.UpdateAsync(itemId, request, cancellationToken);
            return item is null ? NotFound() : Ok(item);
        }


        [HttpDelete("{itemId:guid}")]
        public async Task<IActionResult> Delete(
            [FromRoute] Guid itemId,
            CancellationToken cancellationToken)
        {
            var success = await _itemService.DeleteAsync(itemId, cancellationToken);
            return success ? NoContent() : NotFound();
        }
    }

}
