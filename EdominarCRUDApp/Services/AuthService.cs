using EdominarCRUDApp.Interface;
using EdominarCRUDApp.Models;
using EdominarCRUDApp.Models.db;
using EdominarCRUDApp.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;

namespace EdominarCRUDApp.Services
{
    internal class AuthService : IAuthService
    {
        private readonly EdominerCRUD _db;
        public AuthService(EdominerCRUD db)
        {
            _db = db;
        }
        public async Task<RegistrationResponse> AddUser(RegistrationRequest request)
        {
            try
            {
                if (request != null)
                {
                    var registerRequest = new User()
                    {
                        Name = request.Name,
                        Email = request.Email,
                        Address = request.Address,
                        Mobile = request.Mobile,
                        HobbyId = request.HobbyId,
                        StateId = request.StateId,
                        Gender = request.Gender == "Male" ? 0 : 1

                    };
                    var response = await _db.Users.AddAsync(registerRequest);
                    await _db.SaveChangesAsync();
                    if (response.Entity.Id.ToString().IsNullOrEmpty())
                    {
                        return new RegistrationResponse(false, "Error In Your Request", null);
                    }

                      return new RegistrationResponse(true, "Request is SucessFully", response.Entity.Email);
                }
                return new RegistrationResponse(false, "Error In Your Request", null);
            }
            catch (Exception e)
            {
                return new RegistrationResponse(false, e.Message, null);
            }
        }

        public async Task<DeleteResponse> DeleteUserDataById(GetDataByIdRequest request)
        {
            try
            {

                var userData=await _db.Users.Where(x=>x.Id==request.Id).FirstOrDefaultAsync();
                if (userData != null)
                {
                    _db.Users.Remove(userData);

                     await _db.SaveChangesAsync();

                    return new DeleteResponse(true, "User Delete SuccessFully");
                }
                return new DeleteResponse(false, "Error In Your Request");

            }
            catch (Exception ex)
            {
                return new DeleteResponse(false, ex.Message);
            }
        }

        public async Task<GetDataByIdResponse> GetDataById(GetDataByIdRequest request)
        {
            try
            {
                var response = await _db.Users.
                    Include(x=>x.Hobby)
                    .Include(x=>x.State)
                    .Where(x=>x.Id==request.Id).FirstOrDefaultAsync();
                var getDataById = new GetDataById()
                {
                    Id = response.Id,
                    Name = response.Name,
                    Gender = response.Gender==0?"Male":"Female",
                    Email = response.Email,
                    Address = response.Address,
                    Mobile = response.Mobile,
                    Hobby = response.Hobby.Name,
                    State = response.State.Name
                };
                return new GetDataByIdResponse(true, "Data Fetch SuccessFully", getDataById);
            }
            catch (Exception e)
            {
                return new GetDataByIdResponse(false, e.Message, null);
            }
        }

        public async Task<GetEditDataResponse> GetEditDataByUpdate(GetDataByIdRequest request)
        {
            try
            {
                var response = await _db.Users.
                    Include(x => x.Hobby)
                    .Include(x => x.State)
                    .Where(x => x.Id == request.Id).FirstOrDefaultAsync();
                var getDataById = new GetEditData()
                {
                    Id = response.Id,
                    Name = response.Name,
                    Gender = response.Gender == 0 ? "Male" : "Female",
                    Email = response.Email,
                    Address = response.Address,
                    Mobile = response.Mobile,
                    HobbyId = response.Hobby.Id,
                    StateId = response.State.Id
                };
                return new GetEditDataResponse(true, "Data Fetch SuccessFully", getDataById);
            }
            catch (Exception e)
            {
                return new GetEditDataResponse(false, e.Message, null);
            }
        }

        public async Task<HobbyResponse> GetHobbies()
        {
            try
            {
                var response = await _db.Hobbys.ToListAsync();
                var hobbyData = new List<HobbyData>();
                foreach (var item in response)
                {
                    if (item != null)
                    {
                        hobbyData.Add(new HobbyData()
                        {
                            Id = item.Id,
                            Name = item.Name
                        });
                    }

                }
                return new HobbyResponse(true, "DataFetch SuccessFully", hobbyData);
            }
            catch (Exception ex)
            {
                return new HobbyResponse(false, ex.Message, null);
            }
        }

        
        public async Task<GetRegisterUserResponse> GetRegisterUser()
        {
            try
            {
                var response =await _db.Users.ToListAsync();

                var registerData = new List<GetRegister>();
                foreach (var item in response)
                {
                    var hobbyResponse=await _db.Hobbys.Where(x=>x.Id==item.HobbyId).FirstOrDefaultAsync();
                    var stateResponse = await _db.States.Where(x => x.Id == item.StateId).FirstOrDefaultAsync();
                    registerData.Add(new GetRegister()
                    {
                        Id = item.Id,
                        Name = item.Name,
                        Address = item.Address,
                        Email = item.Email,
                        Gender = item.Gender==0?"Male":"Female",
                        Hobby = hobbyResponse.Name,
                        Mobile = item.Mobile,
                        State = stateResponse.Name
                    });
                }
                return new GetRegisterUserResponse(false, "Data Fetch SuccessFully", registerData);
            }
            catch (Exception ex)
            {
                return new GetRegisterUserResponse(false, ex.Message, null);
            }
        }

        public async Task<StateResponse> GetState()
        {
            try
            {
                var response = await _db.States.ToListAsync();
                var stateData = new List<StateData>();
                foreach (var item in response)
                {
                    if (item != null)
                    {
                        stateData.Add(new StateData()
                        {
                            Id = item.Id,
                            Name = item.Name
                        });
                    }

                }
                return new StateResponse(true, "DataFetch SuccessFully", stateData);
            }
            catch (Exception ex)
            {
                return new StateResponse(false, ex.Message, null);
            }
        }

        public async Task<UpdateResponse> UpdateUserData(UpdateRequest request)
        {
            try
            {
                var userOldData = await _db.Users.Where(x => x.Id == request.Id).FirstOrDefaultAsync();
                if (userOldData != null)
                {
                    userOldData.Id=request.Id;
                    userOldData.Name=request.Name;
                    userOldData.Email=request.Email;
                    userOldData.Address=request.Address;
                    userOldData.Gender = request.Gender == "Male" ? 0 : 1;
                    userOldData.StateId = request.StateId;
                    userOldData.HobbyId=request.HobbyId;
                    userOldData.Mobile=request.Mobile;
                    _db.Users.Update(userOldData);
                    await _db.SaveChangesAsync();
                    return new UpdateResponse(true, "User Update SuccessFully");
                }
                return new UpdateResponse(false, "Error i your Request");
            }
            catch (Exception ex)
            {
                return new UpdateResponse(false, ex.Message);
            }
        }
    }
}
