﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarBookProject.Application.Features.Mediator.Results.LocationResult;

namespace CarBookProject.Application.Features.Mediator.Queries.LocationQuery
{
    public class GetLocationQuery : IRequest<List<GetLocationQueryResult>>
    {
    }
}
