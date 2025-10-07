using Atrium12.Application;
using Atrium12.Contracts.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Atrium12.Presenters.Controllers
{
    [ApiController]
    [Route("api/v1/collections")]
    public class CollectionsController : ControllerBase
    {
        private readonly ICollectionService _collectionService;

        public CollectionsController(ICollectionService collectionService)
        {
            _collectionService = collectionService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CollectionDto>>> GetAll(
            [FromQuery] GetCollectionsDto request,
            CancellationToken cancellationToken) =>
            Ok(await _collectionService.GetAllAsync());


        [HttpGet("{collectionId:guid}")]
        public async Task<ActionResult<CollectionDto>> GetById(
            [FromRoute] Guid collectionId,
            CancellationToken cancellationToken)
        {
            var collection = await _collectionService.GetByIdAsync(collectionId);
            return collection is null ? NotFound() : Ok(collection);
        }

        [HttpPost]
        public async Task<ActionResult<CollectionDto>> Create(
            [FromBody] CreateCollectionDto request,
            CancellationToken cancellationToken)
        {
            var collection = await _collectionService.CreateAsync(request);
            return CreatedAtAction(nameof(GetById), new { id = collection.Id }, collection);
        }

        [HttpPut("{collectionId:guid}")]
        public async Task<ActionResult<CollectionDto>> Update(
            [FromRoute] Guid collectionId,
            [FromBody] UpdateCollectionDto request,
            CancellationToken cancellationToken)
        {
            var collection = await _collectionService.UpdateAsync(collectionId, request);
            return collection is null ? NotFound() : Ok(collection);
        }

        [HttpDelete("{collectionId:guid}")]
        public async Task<IActionResult> Delete(
            [FromRoute] Guid collectionId,
            CancellationToken cancellationToken)
        {
            var success = await _collectionService.DeleteAsync(collectionId);
            return success ? NoContent() : NotFound();
        }
    }


    //[ApiController]
    //[Route("api/v1/albums")]
    //public class AlbumsController : ControllerBase
    //{
    //    private readonly IAlbumService _albumService;

    //    public AlbumsController(IAlbumService albumService)
    //    {
    //        _albumService = albumService;
    //    }

    //    [HttpGet]
    //    public async Task<ActionResult<IEnumerable<AlbumDto>>> GetAll() =>
    //        Ok(await _albumService.GetAllAsync());

    //    [HttpGet("{id:guid}")]
    //    public async Task<ActionResult<AlbumDto>> GetById(Guid id)
    //    {
    //        var album = await _albumService.GetByIdAsync(id: id);
    //        return album is null ? NotFound() : Ok(album);
    //    }

    //    [HttpPost]
    //    public async Task<ActionResult<AlbumDto>> Create(CreateAlbumDto dto)
    //    {
    //        var album = await _albumService.CreateAsync(dto);
    //        return CreatedAtAction(nameof(GetById), new { id = album.Id }, album);
    //    }

    //    [HttpPut("{id:guid}")]
    //    public async Task<ActionResult<AlbumDto>> Update(Guid id, UpdateAlbumDto dto)
    //    {
    //        var album = await _albumService.UpdateAsync(id, dto);
    //        return album is null ? NotFound() : Ok(album);
    //    }

    //    [HttpDelete("{id:guid}")]
    //    public async Task<IActionResult> Delete(Guid id)
    //    {
    //        var success = await _albumService.DeleteAsync(id);
    //        return success ? NoContent() : NotFound();
    //    }
    //}



    //[ApiController]
    //[Route("api/v1/external-sources")]
    //public class ExternalSourcesController : ControllerBase
    //{
    //    private readonly IExternalSourceService _service;

    //    public ExternalSourcesController(IExternalSourceService service)
    //    {
    //        _service = service;
    //    }

    //    [HttpGet]
    //    public async Task<ActionResult<IEnumerable<ExternalSourceDto>>> GetAll() =>
    //        Ok(await _service.GetAllAsync());

    //    [HttpGet("{id:int}")]
    //    public async Task<ActionResult<ExternalSourceDto>> GetById(int id)
    //    {
    //        var source = await _service.GetByIdAsync(id);
    //        return source is null ? NotFound() : Ok(source);
    //    }

    //    [HttpPost]
    //    public async Task<ActionResult<ExternalSourceDto>> Create(CreateExternalSourceDto dto)
    //    {
    //        var source = await _service.CreateAsync(dto);
    //        return CreatedAtAction(nameof(GetById), new { id = source.Id }, source);
    //    }

    //    [HttpPut("{id:int}")]
    //    public async Task<ActionResult<ExternalSourceDto>> Update(int id, UpdateExternalSourceDto dto)
    //    {
    //        var source = await _service.UpdateAsync(id, dto);
    //        return source is null ? NotFound() : Ok(source);
    //    }

    //    [HttpDelete("{id:int}")]
    //    public async Task<IActionResult> Delete(int id)
    //    {
    //        var success = await _service.DeleteAsync(id);
    //        return success ? NoContent() : NotFound();
    //    }
    //}


    //[ApiController]
    //[Route("api/v1/media")]
    //public class MediaController : ControllerBase
    //{
    //    private readonly IMediaService _mediaService;

    //    public MediaController(IMediaService mediaService)
    //    {
    //        _mediaService = mediaService;
    //    }

    //    [HttpGet]
    //    public async Task<ActionResult<IEnumerable<MediaDto>>> GetAll() =>
    //        Ok(await _mediaService.GetAllAsync());

    //    [HttpGet("{id:guid}")]
    //    public async Task<ActionResult<MediaDto>> GetById(Guid id)
    //    {
    //        var media = await _mediaService.GetByIdAsync(id);
    //        return media is null ? NotFound() : Ok(media);
    //    }

    //    [HttpPost]
    //    public async Task<ActionResult<MediaDto>> Create(CreateMediaDto dto)
    //    {
    //        var media = await _mediaService.CreateAsync(dto);
    //        return CreatedAtAction(nameof(GetById), new { id = media.Id }, media);
    //    }

    //    [HttpPut("{id:guid}")]
    //    public async Task<ActionResult<MediaDto>> Update(Guid id, UpdateMediaDto dto)
    //    {
    //        var media = await _mediaService.UpdateAsync(id, dto);
    //        return media is null ? NotFound() : Ok(media);
    //    }

    //    [HttpDelete("{id:guid}")]
    //    public async Task<IActionResult> Delete(Guid id)
    //    {
    //        var success = await _mediaService.DeleteAsync(id);
    //        return success ? NoContent() : NotFound();
    //    }
    //}

}
