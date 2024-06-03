using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarBook.Application.Features.Mediator.Results.LocationResult;

namespace CarBook.Application.Features.Mediator.Queries.LocationQuery
{
    public class GetLocationQuery : IRequest<List<GetLocationQueryResult>>
    {
    }
}
