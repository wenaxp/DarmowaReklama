﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscortServices.DataAccess.Repository
{
    public interface IParameterRepository
    {
        int GetInt(ParameterNameEnum parameterNameEnum);
    }
}
