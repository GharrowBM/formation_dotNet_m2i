using CorrectionPetiteAnnonce.Tools;

namespace CorrectionPetiteAnnonce.Repositories
{
    public class BaseRepository
    {
        protected DataContext _dataContext;

        public BaseRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
     }
}
