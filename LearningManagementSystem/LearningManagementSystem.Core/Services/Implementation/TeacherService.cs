﻿using AutoMapper;
using LearningManagementSystem.Core.Services.Interfaces;
using LearningManagementSystem.Domain.Contextes;
using LearningManagementSystem.Domain.Entities;
using LearningManagementSystem.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace LearningManagementSystem.Core.Services.Implementation
{
    public class TeacherService : ITeacherService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<TeacherService> _logger;

        public TeacherService(AppDbContext context, IMapper mapper, ILogger<TeacherService> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<Response<TeacherCreationModel>> AddAsync(TeacherCreationModel model)
        {

            ArgumentNullException.ThrowIfNull(model);

            var userExist = await _context.Users.AsNoTracking().FirstOrDefaultAsync(f => f.Id.Equals(model.UserId));
            if (userExist is null)
            {
                throw new Exception($"User with id:{model.UserId} does not exist!");
            }

            var teacher = await _context.Students.FirstOrDefaultAsync(f => f.Id.Equals(model.UserId));
            var student = await _context.Teachers.FirstOrDefaultAsync(f => f.Id.Equals(model.UserId));

            if (teacher is not null || student is not null)
            {
                return new Response<TeacherCreationModel>()
                {
                    Error = "User already has a role",
                    IsSuccessful = false
                };
            }

            var entity = _mapper.Map<Teacher>(model);

            await _context.Teachers.AddAsync(entity);
            await _context.SaveChangesAsync();

            _logger.LogInformation("New teacher has been successfully added");
            return new Response<TeacherCreationModel>()
            {
                IsSuccessful = true,
                Data = model
            };
        }

        public async Task<TeacherModel> GetByIdAsync(Guid id)
        {
            var teacher = await _context.Teachers.Include(i => i.User).SingleOrDefaultAsync(s => s.Id.Equals(id));
            if (teacher is null)
            {
                throw new Exception("Teacher does not exist");
            }

            return _mapper.Map<TeacherModel>(teacher);
        }

        public IEnumerable<TeacherModel> GetAll()
        {
            return _mapper.Map<IEnumerable<TeacherModel>>(_context.Teachers.Include(i => i.User).AsEnumerable());
        }

        public async Task RemoveTeacherAsync(Guid id)
        {
            var teacher = await _context.Teachers.FirstOrDefaultAsync(f => f.Id.Equals(id));
            if (teacher is null)
            {
                throw new Exception("Teacher does not exist");
            }

            _context.Teachers.Remove(teacher);
            await _context.SaveChangesAsync();
        }
    }
}