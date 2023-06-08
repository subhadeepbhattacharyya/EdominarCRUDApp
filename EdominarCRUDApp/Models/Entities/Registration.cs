namespace EdominarCRUDApp.Models.Entities
{
    public class RegistrationRequest
    {
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int StateId { get; set; }
        public int HobbyId { get; set; }

    }
    public class RegistrationResponse : BaseResponse
    {
        public string EmailId { get; set; }
        public RegistrationResponse(bool isSuccess, string messgae, string emailId) : base(isSuccess, messgae)
        {
            EmailId = emailId;
        }
    }

    public class GetRegisterUserResponse : BaseResponse
    {
        public GetRegisterUserResponse(bool isSucess,string message, IEnumerable<GetRegister> userData):base(isSucess,message)
        {
            UserData = userData;
        }
        public IEnumerable<GetRegister> UserData { get; }


    }

    public class GetRegister
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string Hobby { get; set; }
    }


    public class GetDataByIdRequest
    {
        public int Id { get; set; }
    }

    public class GetDataByIdResponse:BaseResponse
    {
        public GetDataByIdResponse(bool isSuccess,string message, GetDataById getDataById):base(isSuccess, message)
        {
            GetDataById=getDataById;
        }

        public GetDataById GetDataById { get;  }
    }
    public class GetDataById
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string Hobby { get; set; }
    }

    public class DeleteResponse:BaseResponse
    {
        public DeleteResponse(bool isSuccess,string message):base(isSuccess, message)
        {
            
        }
    }


    public class UpdateRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int StateId { get; set; }
        public int HobbyId { get; set; }
    }

    public class UpdateResponse:BaseResponse
    {
        public UpdateResponse(bool isSuccess,string message):base(isSuccess, message)
        {
            
        }
    }

    public class GetEditDataResponse:BaseResponse
    {
        public GetEditDataResponse(bool isSuccess,string message, GetEditData getEditData) :base(isSuccess, message)
        {
            GetEditData = getEditData;
        }

        public GetEditData GetEditData { get; set; }
    }

    public class GetEditData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int StateId { get; set; }
        public int HobbyId { get; set; }
    }
}
