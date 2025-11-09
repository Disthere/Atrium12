namespace Atrium12.Contracts.DTOs
{
    public record UpdateCollectionDto(
        System.Guid CollectionTypeId,
        string Name,
        string? Description = null,
        bool IsPublic = false,
        System.Guid? CoverImageId = null
    );
}
