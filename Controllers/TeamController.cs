
using Microsoft.AspNetCore.Mvc;
using Project.Models;
using Project.SLiddle.Models;

namespace Project.SLiddle.Controllers;

public class TeamController : Controller
{
    public IActionResult Detail(int id)
    {
        Team team = DB.GetTeam(id);
        return View(team);
    }

    public IActionResult List()
    {
        List<Team> teams = DB.GetTeamList();
        return View(teams);
    }


}

