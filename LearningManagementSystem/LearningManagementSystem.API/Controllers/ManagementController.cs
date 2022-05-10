﻿using LearningManagementSystem.Core.Services.Interfaces;
using LearningManagementSystem.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace LearningManagementSystem.API.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class ManagementController : ControllerBase
    {
        private readonly IManagementService _managementService;

        public ManagementController(IManagementService managementService)
        {
            _managementService = managementService;
        }

        [HttpPost("AddStudent/{studentId}/ToGroup/{groupId}")]
        public async Task<IActionResult> AddStudentToGroup(Guid studentId, Guid groupId)
        {
            await _managementService.AddStudentToGroupAsync(studentId, groupId);
            return Ok();
        }
    }
}