namespace Atrium12.Collections.Contracts.DTOs
{
    public record CollectionDto(
    Guid Id,
    Guid UserId,
    Guid CollectionTypeId,
    string Name,
    string? Description,
    DateTime CreatedAt,
    DateTime UpdatedAt,
    bool IsPublic,
    Guid? CoverImageId
);
}
