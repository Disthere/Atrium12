namespace Atrium12.Contracts.DTOs
{
    public record MediaDto(
    Guid Id,
    Guid ItemId,
    string Url,
    string? ThumbnailUrl,
    string Type,
    DateTime UploadedAt,
    bool IsPrimary,
    string? MimeType,
    long? FileSizeBytes,
    int? WidthPx,
    int? HeightPx
);
}
