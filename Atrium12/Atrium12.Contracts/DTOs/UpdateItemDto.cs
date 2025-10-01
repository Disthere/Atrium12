namespace Atrium12.Contracts.DTOs
{
    public record UpdateItemDto(
        Guid ItemTypeId,
        string Name,
        string? Description,
        Guid? ConditionId,
        Guid? FinanceId,
        string? Metadata = null
    );
}
