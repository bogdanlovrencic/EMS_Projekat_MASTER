using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Entities.Core;

namespace WebApp.Repositories
{
    public interface IGetDetailsService
    {
        List<IdentifiedObject> GetIdentifiedObjects();
    }
}
