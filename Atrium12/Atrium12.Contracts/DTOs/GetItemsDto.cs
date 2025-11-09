namespace Atrium12.Contracts.DTOs
{
    public record GetItemsDto(string Search, System.Guid[] TagIds, int Page, int PageSize);
}