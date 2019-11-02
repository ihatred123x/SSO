using AutoMapper;
using SSO.IService;

namespace SSO.Service
{
    abstract class ServiceBase: SSO.IService.IService
    {
        #region Constructor

        internal ServiceBase(IMapper mapper)
        {
            this.Mapper = mapper;
        }

        #endregion

        #region Properties

        public IMapper Mapper { get; }

        #endregion
    }
}
