namespace Core.Results;

public class PagedResult<T> : DataResult<T> where T : class
{
    public int PageNumber { get; set; }
    public int RecordSizePerPage { get; set; }
    public int TotalRecordInDatabase { get; private set; }

    public PagedResult(int pageNumber, int recordSizePerPage, int totalRecordInDatabase, T data, string? message = null, ResultStatus status = ResultStatus.Ok)
        : base(data, message, status)
    {
        PageNumber = pageNumber;
        RecordSizePerPage = recordSizePerPage;
        TotalRecordInDatabase = totalRecordInDatabase;
    }
}
