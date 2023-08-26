﻿using MediatR;
using ShadowBuddy.Domain.Repositories;

namespace ShadowBuddy.Handlers;

public class UpdateOperationCommandHandler : IRequestHandler<UpdateOperationCommand>
{
    private readonly IAccountProcessingRepository _accountProcessingRepository;

    public UpdateOperationCommandHandler(IAccountProcessingRepository accountProcessingRepository)
    {
        _accountProcessingRepository = accountProcessingRepository ??
                                       throw new ArgumentNullException(nameof(accountProcessingRepository));
    }

    public async Task Handle(UpdateOperationCommand request, CancellationToken cancellationToken) =>
        await _accountProcessingRepository.UpdateOperation(request.OperationId, request.OperationTypeId, request.Amount,
            request.CategoryId, request.Comment, request.Moment, cancellationToken);
}