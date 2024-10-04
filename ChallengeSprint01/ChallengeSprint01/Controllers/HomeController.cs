using ChallengeSprint01.Dtos;
using ChallengeSprint01.Models;
using ChallengeSprint01.Reposytorys.implementations;
using ChallengeSprint01.Reposytorys.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ChallengeSprint01.Controllers
{
    public class HomeController : Controller
    {
        public const string SessionName = "_Nome";
        public const string SessionKey = "_isAut";


        private readonly ILogger<HomeController> _logger;
        private readonly IUserAut userAut;


        public HomeController(ILogger<HomeController> logger, IUserAut repository)
        {
            userAut = repository;
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.SessionName = HttpContext.Session.GetString(SessionName);
            ViewBag.SessionKey = HttpContext.Session.GetInt32(SessionKey);

            return View();
        }
        public async Task<IActionResult> Login(UserLoginDto request)
        {
            try
            {
                var aut = await userAut.GetUserByEmail(request);
                if (aut == null)
                {
                    return RedirectToAction("Error");
                }

                HttpContext.Session.SetString(SessionName, aut.email);
                HttpContext.Session.SetInt32(SessionKey, 1);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Error");
            }
        }
        public IActionResult RegisterPage() { return View(); }

        public async Task<IActionResult> Register(UserRegisterDto request)
        {
            try
            {
                var response = await userAut.CreateUser(request);
                if (response == null)
                {
                    return RedirectToAction("Error");
                }
                HttpContext.Session.SetString(SessionName, response.email);
                HttpContext.Session.SetInt32(SessionKey, 1);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Error");
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
