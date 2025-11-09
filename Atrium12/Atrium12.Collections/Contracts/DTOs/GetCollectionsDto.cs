namespace Atrium12.Collections.Contracts.DTOs
{
    public record GetCollectionsDto(string Search, Guid[] TagIds, int Page, int PageSize);
}