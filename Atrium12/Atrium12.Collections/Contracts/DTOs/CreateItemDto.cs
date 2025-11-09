namespace Atrium12.Collections.Contracts.DTOs
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
