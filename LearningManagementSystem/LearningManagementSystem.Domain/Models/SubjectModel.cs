﻿namespace LearningManagementSystem.Domain.Models
{
    public class SubjectModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public IEnumerable<Guid>? CoursesIds { get; set; }
        public IEnumerable<Guid>? TeachersIds { get; set; }
        public IEnumerable<Guid>? HomeTasksIds { get; set; }
    }
}