using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Context;
using WebApplication1.Models;

namespace WebApplication1.Controllers;
[Route("api/[controller]")]
[ApiController]
public class Controller2 : Controller
{
    // GET Info
    [HttpGet("GetUserInfo")]
    public IActionResult GetUserInfo()
    {
        return Ok(Helper.Database.Usertables.Where(x => x.Datasave == new DateTime(9999,01,01)).Select(x => new
        {
            x.Id,
            x.Fullname,
            x.Login,
            x.Password,
            x.Datasave
        }).ToList());
    }

    // GET Drop
    [HttpGet("GetDrop")]
    public async Task<IActionResult> GetDrop(string? login)
    {
        Usertable? usertable = await Helper.Database.Usertables.FirstOrDefaultAsync(x => x.Login == login && x.Datasave == new DateTime(9999,01,01));
        if (usertable != null)
        {
            /*Helper.Database.Remove(usertable);*/
            usertable.Datasave = DateTime.Now;
            Helper.Database.SaveChanges();
            return Ok("Данные удалены!");
        }
        return Ok("Ничего не найдено");
    }
    
    // GET Replase
    [HttpGet("GetReplase")]
    public async Task<IActionResult> GetReplase(string? login, string? newLogin,  string? password, string? userName,int role)
    {
        if (login != null && password != null && userName != null && role != 0)
        {
            Usertable? usertable = await Helper.Database.Usertables.FirstOrDefaultAsync(x => x.Login == login && x.Datasave == new DateTime(9999,01,01));
            usertable!.Login = newLogin;
            usertable.Fullname = userName;
            usertable.Password = password;
            usertable.Roleid = role;
            Helper.Database.Update(usertable);
            await Helper.Database.SaveChangesAsync();
            return Ok("Данные обновлены!");
        }
        return Ok("Данные не введены!");
    }
    
    // GET Save
    [HttpGet("GetSave")]
    public IActionResult GetSave(string? login, string? password, string? nameUser, int role)
    {
        if (login != null && password != null && nameUser != null)
        {
            Usertable usertables = new Usertable();
            usertables.Id = Helper.Database.Usertables.Count() + 1;
            usertables.Fullname = nameUser;
            usertables.Login = login;
            usertables.Password = password;
            usertables.Releasedate = DateTime.Now;
            usertables.Roleid = role;
            usertables.Datasave = new DateTime(9999,01,01);
            Helper.Database.Add(usertables);
            Helper.Database.SaveChanges();
            return Ok("Данные сохранены");
        }
        return Ok("Ошибка!");
    }

    
    // GET Save Immage
    [HttpGet("GetSaveImmage")]
    public IActionResult GetSaveImmage(string immageName)
    {
        Image image = new Image();
        image.Imagename = immageName;
        image.Id = Helper.Database.Images.Count() + 1;
        Helper.Database.Add(image);
        Helper.Database.SaveChanges();
        return Ok();
    }
    
    // GET Immage
    [HttpGet("GetImmages")]
    public IActionResult GetImmages()
    {
        return Ok(Helper.Database.Images.Select(x=> new {x.Id, x.Imagename}));
    }
}