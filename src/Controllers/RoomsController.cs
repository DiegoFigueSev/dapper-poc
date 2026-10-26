using System;
using DemoDapper.src.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DemoDapper.src.Controllers;

[ApiController]
[Route("rooms")]
public class RoomsController(RoomRepository repository) : ControllerBase
{
    private readonly RoomRepository _repository = repository;

    [HttpGet]
    public IActionResult GetAll()
    {
        var rooms = _repository.FindAll();

        return Ok(rooms);
    }
}
