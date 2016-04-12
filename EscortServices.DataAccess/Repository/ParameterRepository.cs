using EscortServices.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscortServices.DataAccess.Repository
{
    public class ParameterRepository : BaseRepository, IParameterRepository
    {
        public ParameterRepository(EscortServicesEntities context)
            : base(context)
        { }
        public int GetInt(ParameterNameEnum parameterNameEnum)
        {
            var parameter=_context.Parameter.Single(x => x.Name == parameterNameEnum.ToString());
            var res= Convert.ToInt32(parameter.Value);
            return res;
        }
    }
}
