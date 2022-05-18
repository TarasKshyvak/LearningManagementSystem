﻿using System.Linq.Expressions;
using AutoMapper;
using LearningManagementSystem.Domain.Entities;
using LearningManagementSystem.Domain.Models;

namespace LearningManagementSystem.Domain.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<UserModel, User>().ReverseMap();
            CreateMap<Group, GroupCreationModel>().ReverseMap();
            CreateMap<Group, GroupModel>().ReverseMap();
            CreateMap<Course, CourseModel>()
               .ReverseMap();

            CreateMap<Teacher, TeacherModel>()
                .ForMember(m => m.UserName, opt =>
                    opt.MapFrom(f => f.User.UserName))
                .ForMember(m => m.FirstName, opt =>
                    opt.MapFrom(f => f.User.FirstName))
                .ForMember(m => m.LastName, opt =>
                    opt.MapFrom(f => f.User.LastName))
                .ForMember(m => m.Birthday, opt =>
                    opt.MapFrom(f => f.User.Birthday))
                .ForMember(m => m.Email, opt =>
                    opt.MapFrom(f => f.User.Email))
                .ForMember(m => m.About, opt =>
                    opt.MapFrom(f => f.User.About)).ReverseMap();

            CreateMap<Teacher, TeacherCreationModel>().ReverseMap();

            CreateMap<Subject, SubjectModel>()
                .ForMember(m => m.CoursesIds, opt =>
                    opt.MapFrom(f => f.Courses.Select(s => s.Id)))
                .ForMember(m=>m.TeachersIds, opt=>
                    opt.MapFrom(f=>f.Teachers.Select(s=>s.Id)))
                .ReverseMap();

            CreateMap<Student, StudentModel>()
                .ForMember(m => m.UserName, opt => 
                    opt.MapFrom(f => f.User.UserName))
                .ForMember(m => m.FirstName, opt =>
                    opt.MapFrom(f => f.User.FirstName))
                .ForMember(m => m.LastName, opt => 
                    opt.MapFrom(f => f.User.LastName))
                .ForMember(m => m.Birthday, opt =>
                    opt.MapFrom(f => f.User.Birthday))
                .ForMember(m => m.Email, opt => 
                    opt.MapFrom(f => f.User.Email))
                .ForMember(m => m.About, opt => 
                    opt.MapFrom(f => f.User.About)).ReverseMap();
        }
    }


}
