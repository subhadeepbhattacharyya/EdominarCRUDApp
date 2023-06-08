using EdominarCRUDApp.Models.Entities;

namespace EdominarCRUDApp.Interface
{
    public interface IAuthService
    {
        Task<RegistrationResponse> AddUser(RegistrationRequest request);
        Task<StateResponse> GetState();
        Task<HobbyResponse> GetHobbies();
        Task<GetRegisterUserResponse> GetRegisterUser();
        Task<GetDataByIdResponse> GetDataById(GetDataByIdRequest request);
        Task<DeleteResponse> DeleteUserDataById(GetDataByIdRequest request);
        Task<GetEditDataResponse> GetEditDataByUpdate(GetDataByIdRequest request);
        Task<UpdateResponse> UpdateUserData(UpdateRequest request);
    }
}
