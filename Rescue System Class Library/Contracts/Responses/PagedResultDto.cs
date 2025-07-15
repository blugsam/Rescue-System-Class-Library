namespace RescueSystem.Contracts.Contracts.Responses;

public class PagedResultDto<T> where T : class
{
    public List<T> Items { get; init; } = new();

    public int PageNumber { get; init; }

    public int PageSize { get; init; }

    public int TotalCount { get; init; }

    public int TotalPages => (int)Math.Ceiling(TotalCount / (double)PageSize);

    public bool HasNextPage => PageNumber < TotalPages;

    public bool HasPreviousPage => PageNumber > 1;
}