public class EntityResult<T>
{
    public bool IsSuccess { get; }
    public List<string> Errors { get; set; }
    public List<T> Success { get; set; }

    public ResultCount Count { get; set; }
}


public class ResultCount
{
    public int Success { get; set; }
    public int Error { get; set; }
}