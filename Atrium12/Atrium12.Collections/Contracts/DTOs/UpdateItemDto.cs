namespace Atrium12.Collections.Contracts.DTOs
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
