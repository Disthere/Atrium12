namespace Atrium12.Contracts.DTOs
{
    public record GetCollectionsDto(string Search, Guid[] TagIds, int Page, int PageSize);
}