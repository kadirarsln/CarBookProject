using MediatR;
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
    public class RemovePricingCommandHandler : IRequestHandler<RemoveLocationCommand>
    {
        private readonly IRepository<Location> _repository;

        public RemovePricingCommandHandler(IRepository<Location> repository)
        {
            _repository = repository;
        }
        public async Task Handle(RemoveLocationCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
