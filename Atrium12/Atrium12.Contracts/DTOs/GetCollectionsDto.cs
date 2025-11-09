namespace Atrium12.Contracts.DTOs
{
    public record GetCollectionsDto(string Search, System.Guid[] TagIds, int Page, int PageSize);
}