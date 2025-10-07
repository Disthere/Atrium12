namespace Atrium12.Contracts.DTOs
{
    public record GetItemsDto(string Search, Guid[] TagIds, int Page, int PageSize);
}