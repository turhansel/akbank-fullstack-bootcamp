using System;
using System.Collections.Generic;
using System.Text;
using TaskManagementApp.Application.Interfaces;

namespace TaskManagementApp.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(ITaskRepository taskRepository)
        {
            Tasks = taskRepository;
        }
        public ITaskRepository Tasks { get; }
    }
}
