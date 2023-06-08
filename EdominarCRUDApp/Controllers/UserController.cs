using EdominarCRUDApp.Interface;
using EdominarCRUDApp.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace EdominarCRUDApp.Controllers
{
    public class UserController : Controller
    {
        public readonly IAuthService _authService;
        public UserController(IAuthService authService)
        {
            _authService = authService;
        }
        public IActionResult Add()
        {
            return View();
        }
        
        [HttpPost]
        public async Task<JsonResult> UpdateUserDetails(UpdateRequest request)
        {
            var response = await _authService.UpdateUserData(request);
            return Json(response);
        }
        [HttpPost]
        public async Task<JsonResult> SaveUserData(RegistrationRequest request)
        {
            var response = await _authService.AddUser(request);
            return Json(response);
        }
        [HttpGet]
        public async Task<JsonResult> GetState()
        {
            var response = await _authService.GetState();
            return Json(response);
        }

        [HttpGet]
        public async Task<JsonResult> GetHobby()
        {
            var response = await _authService.GetHobbies();
            return Json(response);
        }

        [HttpGet]
        public async Task<JsonResult> GetUserDataById(GetDataByIdRequest request)
        {
            var response = await _authService.GetDataById(request);
            return Json(response);
        }

        [HttpPost]
        public async Task<JsonResult> DeleteUserData(GetDataByIdRequest request)
        {
            var response =await _authService.DeleteUserDataById(request);
            return Json(response);
        }

        public IActionResult Edit(int id)
        {
            ViewBag.id = id;
            return View();
        }
        public async Task<JsonResult> EditGetByData(GetDataByIdRequest request)
        {
            var eesponse=await _authService.GetEditDataByUpdate(request);
            return Json(eesponse);
        }


        public IActionResult Delete(int Id)
        {
            return View();
        }

        public IActionResult ViewData()
        {
            return View();
        }
        [HttpGet]
        public async Task<JsonResult> GetData()
        {
            var response = await _authService.GetRegisterUser();
            return Json(response);
        }


    }
}
