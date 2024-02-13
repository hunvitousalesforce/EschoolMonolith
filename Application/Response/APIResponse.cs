namespace Application;

public class APIResponse<T>
{
    public APIResponse(Status status, string message, T? payload)
    {
        Status = status;
        Message = message;
        Payload = payload;
    }

    public APIResponse(){}
    public Status Status {get; set;} = Status.Success;
    public string? Message {get; set;} = string.Empty;
    public T? Payload {get; set;}
}

public enum Status
{
    Error,
    Success
}