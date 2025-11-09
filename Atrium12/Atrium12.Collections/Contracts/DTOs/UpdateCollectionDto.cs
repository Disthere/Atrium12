namespace Atrium12.Collections.Contracts.DTOs
{
    public record UpdateCollectionDto(
        Guid CollectionTypeId,
        string Name,
        string? Description = null,
        bool IsPublic = false,
        Guid? CoverImageId = null
    );
}
