namespace Atrium12.Contracts.DTOs
{
    public record CreateMediaDto(
        Guid ItemId,
        string Url,
        string Type,
        string? ThumbnailUrl = null,
        bool IsPrimary = false,
        string? MimeType = null,
        long? FileSizeBytes = null,
        int? WidthPx = null,
        int? HeightPx = null
    );
}
