using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaisseEnregistreuse.Repository
{
    public abstract class BaseRepository
    {
        protected DataContext _data;

        public BaseRepository(DataContext data)
        {
            _data = data;
        }
    }
}
