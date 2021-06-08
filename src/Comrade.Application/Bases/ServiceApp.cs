#region

using AutoMapper;
using Comrade.Application.Utils;

#endregion

namespace Comrade.Application.Bases
{
    public class AppService : IAppService
    {
        public AppService(IMapper mapper)
        {
            Mapper = mapper;
        }

        public IMapper Mapper { get; }
    }
}