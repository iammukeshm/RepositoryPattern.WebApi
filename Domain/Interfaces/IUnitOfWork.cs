using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IDeveloperRepository Developers { get; }
        IProjectRepository Projects { get; }
        int Complete();
    }
}
