namespace Core.Results
{
    public class Result
    {
        public string? Message { get; set; }
        public ResultStatus Status { get; set; }

        public Result(string? message, ResultStatus status = ResultStatus.Ok)
        {
            Message = message;
            Status = status;
        }

        public bool IsSuccess => Status == ResultStatus.Ok;

        public static Result Success(string? message = null)
        {
            return new Result(message, ResultStatus.Ok);
        }

        public static Result Failure(string? message = null)
        {
            return new Result(message, ResultStatus.Error);
        }
    }

    public class Result<T> : Result
    {
        public T? Data { get; set; }

        public Result(T? data, string? message = null, ResultStatus status = ResultStatus.Ok)
            : base(message, status)
        {
            Data = data;
        }

        public static Result<T> Success(T data, string? message = null)
        {
            return new Result<T>(data, message, ResultStatus.Ok);
        }

        public static new Result<T> Failure(string? message = null)
        {
            return new Result<T>(default, message, ResultStatus.Error);
        }
    }

    public enum ResultStatus
    {
        Ok,
        Error,
        Forbidden,
        Unauthorized,
        Invalid,
        NotFound
    }
}
