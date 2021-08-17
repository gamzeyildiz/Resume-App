using ResumeApp.Business.Abstract;
using ResumeApp.DataAccess.Abstact;
using ResumeApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeApp.Business.Concrete
{
    class BioManager : IBioService
    {
        private  IBioRepository _bioRepository;

        public BioManager(IBioRepository bioRepository)
        {
            _bioRepository = bioRepository;
        }

        public Bio CreateBio(Bio bio)
        {
            return _bioRepository.CreateBio(bio);
        }

        public void DeleteBio(int id)
        {
            _bioRepository.DeleteBio(id);
        }

        public List<Bio> GetAllBios()
        {
            return _bioRepository.GetAllBios();
        }

        public Bio GetBioById(int id)
        {
            if (id > 0)
            {
                return _bioRepository.GetBioById(id);
            }
            throw new Exception("id can not be less than 1");
        }

        public Bio UpdateBio(Bio bio)
        {
            return _bioRepository.UpdateBio(bio);
        }
    }
}
