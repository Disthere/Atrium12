namespace Atrium12.Collections.Contracts.DTOs
{
    public record GetItemsDto(string Search, Guid[] TagIds, int Page, int PageSize);
}