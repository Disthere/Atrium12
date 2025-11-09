namespace Atrium12.Contracts.DTOs
{
    public record ItemDto(
    System.Guid Id,
    System.Guid CollectionId,
    System.Guid ItemTypeId,
    string Name,
    string? Description,
    System.Guid? ConditionId,
    System.Guid? FinanceId,
    DateTime CreatedAt,
    DateTime UpdatedAt,
    string? Metadata
);
}
