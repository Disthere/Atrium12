namespace Atrium12.Collections.Contracts.DTOs
{
    public record CreateCollectionDto(
        Guid UserId,
        Guid CollectionTypeId,
        string Name,
        string? Description = null,
        bool IsPublic = false,
        Guid? CoverImageId = null
    );
}
