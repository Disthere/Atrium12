namespace Atrium12.Collections.Contracts.DTOs
{
    public record AlbumDto(
    Guid Id,
    string Name,
    string? Description,
    string? SourceName,
    string? SourceUrl,
    string? Metadata,
    DateTime CreatedAt,
    bool IsOfficial,
    Guid? CreatedByUserId
);

    public record CreateAlbumDto(
        string Name,
        string? Description = null,
        string? SourceName = null,
        string? SourceUrl = null,
        string? Metadata = null,
        bool IsOfficial = true
    );

    public record UpdateAlbumDto(
        string Name,
        string? Description = null,
        string? SourceName = null,
        string? SourceUrl = null,
        string? Metadata = null,
        bool IsOfficial = true
    );

    public record ExternalSourceDto(
    int Id,
    string Code,
    string Name,
    string? BaseUrl,
    string? ApiEndpoint,
    string? LogoUrl,
    bool IsActive,
    bool SupportsVerification,
    bool AutoSyncEnabled,
    DateTime CreatedAt
);

    public record CreateExternalSourceDto(
        string Code,
        string Name,
        string? BaseUrl = null,
        string? ApiEndpoint = null,
        string? LogoUrl = null,
        bool IsActive = true,
        bool SupportsVerification = false,
        bool AutoSyncEnabled = false
    );

    public record UpdateExternalSourceDto(
        string Name,
        string? BaseUrl = null,
        string? ApiEndpoint = null,
        string? LogoUrl = null,
        bool IsActive = true,
        bool SupportsVerification = false,
        bool AutoSyncEnabled = false
    );

    public record UpdateMediaDto(
        string? Url = null,
        string? ThumbnailUrl = null,
        string? Type = null,
        bool? IsPrimary = null,
        string? MimeType = null,
        long? FileSizeBytes = null,
        int? WidthPx = null,
        int? HeightPx = null
    );
}
