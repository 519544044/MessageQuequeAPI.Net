using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQueque.Interface
{
    public interface IOptionsExtension
    {
        void AddServices(IServiceCollection services);
    }
}
