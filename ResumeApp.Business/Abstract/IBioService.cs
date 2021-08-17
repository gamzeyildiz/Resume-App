using System.Collections.Generic;


namespace ResumeApp.Business.Abstract
{
    public interface IBioService
    {
        List<Bio> GetAllBios();
        Bio GetBioById(int id);
        Bio CreateBio(Bio bio);
        Bio UpdateBio(Bio bio);
        void DeleteBio(int id);
    }
}
