﻿using LearningManagementSystem.API.Extensions;
using LearningManagementSystem.Core.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LearningManagementSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportsController : ControllerBase
    {
        private readonly IReportService _reportService;

        public ReportsController(IReportService reportService)
        {
            _reportService = reportService;
        }

        [HttpGet("Progress/{studentId}")]
        public async Task<IActionResult> GetReportForStudent(Guid studentId)
        {
            var res = await _reportService.GetReportForStudentAsync(studentId);
            return res.ToActionResult();
        }

        [HttpGet("Progress/{studentId}.xlsx")]
        public async Task<IActionResult> GetReportForStudentExcel(Guid studentId)
        {
            await _reportService.GetReportForStudentInExcel(studentId);
            return Ok();
        }
    }
}
