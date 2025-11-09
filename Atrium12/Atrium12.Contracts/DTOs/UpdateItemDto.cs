namespace Atrium12.Contracts.DTOs
{
    public record UpdateItemDto(
        System.Guid ItemTypeId,
        string Name,
        string? Description,
        System.Guid? ConditionId,
        System.Guid? FinanceId,
        string? Metadata = null
    );
}
