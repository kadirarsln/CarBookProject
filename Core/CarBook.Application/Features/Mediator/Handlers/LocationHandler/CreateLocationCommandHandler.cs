﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarBookProject.Application.Features.Mediator.Commands.LocationCommand;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBookProject.Application.Features.Mediator.Handlers.LocationHandlers
{
    public class CreatePricingCommandHandler : IRequestHandler<CreateLocationCommand>
    {
        private readonly IRepository<Location> _repository;
        public CreatePricingCommandHandler(IRepository<Location> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateLocationCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Location
            {
                Name = request.Name
            });
        }
    }
}
