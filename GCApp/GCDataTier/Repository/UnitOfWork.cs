using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GCDataTier.Contracts;
using GCDataTier.Models;
using GCWebSite.Repository;

namespace GCDataTier.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private NEGCContext context = new NEGCContext();
        private IGenericRepository<Project> _projectRepository;
        private IGenericRepository<Volunteer> _volunteerRepository;

        public IGenericRepository<Project> ProjectRepository
        {
            get
            {

                if (this._projectRepository == null)
                {
                    this._projectRepository = new GenericRepository<Project>(context);
                }
                return _projectRepository;
            }
        }

        public IGenericRepository<Volunteer> VolunteerRepository
        {
            get
            {

                if (this._volunteerRepository == null)
                {
                    this._volunteerRepository = new GenericRepository<Volunteer>(context);
                }
                return _volunteerRepository;
            }
        }


    }
}
