﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageQuequeAPI.Interface
{

    public interface ICapOptionsExtension
    {
        void AddServices(IServiceCollection services);
    }
}
