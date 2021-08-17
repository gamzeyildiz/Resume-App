using ResumeApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeApp.DataAccess.Abstact
{
    public interface IBioRepository
    {
        List<Bio> GetAllBios();
        Bio GetBioById(int id);
        Bio CreateBio(Bio bio);
        Bio UpdateBio(Bio bio);
        void DeleteBio(int id);
    }
}
