using EscortServices.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscortServices.DataAccess.Repository
{
    public class BaseRepository
    {
        protected readonly EscortServicesEntities _context;

        public BaseRepository(EscortServicesEntities context)
        {
            _context = context;
        }
    }
}
