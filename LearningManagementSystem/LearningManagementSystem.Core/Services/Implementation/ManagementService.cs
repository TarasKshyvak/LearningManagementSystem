﻿using AutoMapper;
using LearningManagementSystem.Core.Services.Interfaces;
using LearningManagementSystem.Domain.Contextes;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace LearningManagementSystem.Core.Services.Implementation
{
    public class ManagementService : IManagementService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<ManagementService> _logger;

        public ManagementService(AppDbContext context,
            IMapper mapper,
            ILogger<ManagementService> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task AddStudentToGroupAsync(Guid studentId, Guid groupId)
        {
            var student = await _context.Students.SingleOrDefaultAsync(f => f.Id.Equals(studentId));
            if (student is null)
            {
                throw new Exception("Student does not exist");
            }

            if (student.GroupId is not null)
            {
                throw new Exception("Student already has a group");
            }

            var group = await _context.Groups.SingleOrDefaultAsync(f => f.Id.Equals(groupId));
            if (group is null)
            {
                throw new Exception("Group does not exist");
            }

            student.GroupId = groupId;
            _context.Students.Update(student);
            await _context.SaveChangesAsync();
        }
    }
}