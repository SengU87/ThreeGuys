using GCDataTier.Models;

namespace GCDataTier.Contracts
{
    public interface IUnitOfWork
    {
        IGenericRepository<Project> ProjectRepository { get; }
        IGenericRepository<Volunteer> VolunteerRepository { get; } 
    }
}
