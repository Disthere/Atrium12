namespace Atrium12.Contracts.DTOs
{
    public record CollectionDto(
    System.Guid Id,
    System.Guid UserId,
    System.Guid CollectionTypeId,
    string Name,
    string? Description,
    DateTime CreatedAt,
    DateTime UpdatedAt,
    bool IsPublic,
    System.Guid? CoverImageId
);
}
