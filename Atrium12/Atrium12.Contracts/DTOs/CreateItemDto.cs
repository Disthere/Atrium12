namespace Atrium12.Contracts.DTOs
{
    public record CreateItemDto(
        System.Guid CollectionId,
        System.Guid ItemTypeId,
        string Name,
        string? Description,
        System.Guid? ConditionId,
        System.Guid? FinanceId,
        string? Metadata
    );
}
