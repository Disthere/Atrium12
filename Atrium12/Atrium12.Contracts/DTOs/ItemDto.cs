namespace Atrium12.Contracts.DTOs
{
    public record ItemDto(
    Guid Id,
    Guid CollectionId,
    Guid ItemTypeId,
    string Name,
    string? Description,
    Guid? ConditionId,
    Guid? FinanceId,
    DateTime CreatedAt,
    DateTime UpdatedAt,
    string? Metadata
);
}
