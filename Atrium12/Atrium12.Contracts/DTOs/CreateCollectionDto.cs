namespace Atrium12.Contracts.DTOs
{
    public record CreateCollectionDto(
        System.Guid UserId,
        System.Guid CollectionTypeId,
        string Name,
        string? Description = null,
        bool IsPublic = false,
        System.Guid? CoverImageId = null
    );
}
