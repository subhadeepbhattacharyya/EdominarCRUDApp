namespace EdominarCRUDApp.Models.Entities
{
    public class BaseResponse
    {
        public BaseResponse(bool isSuccess, string message)
        {
            IsSuccess = isSuccess;
            Message = message;
        }
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }
}
