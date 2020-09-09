using FreelancersProject.Application.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreelancersProject.Application.Handler.Base
{
    public interface IRequestWrapper<T> : IRequest<BaseResponses<T>>
    {
    }
    public interface IHandlerWrapper<Tin, Tout> : IRequestHandler<Tin, BaseResponses<Tout>>
        where Tin : IRequestWrapper<Tout>
    {
    }
}
