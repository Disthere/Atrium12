namespace Atrium12.Contracts.DTOs
{
    public record CreateItemDto(
        Guid CollectionId,
        Guid ItemTypeId,
        string Name,
        string? Description,
        Guid? ConditionId,
        Guid? FinanceId,
        string? Metadata
    );
}
