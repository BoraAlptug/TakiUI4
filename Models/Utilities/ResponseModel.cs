namespace TakiUI4.Models.Utilities
{
    public class ResponseModel<T>
    {
        public string? Message { get; set; }
        public List<T>? DataList { get; set; }
        public T? Data { get; set; }
    }
}
