﻿using Google.Protobuf.WellKnownTypes;
using MediatR;
using ShadowBuddy.Domain.Repositories;
using ShadowBuddy.Infrastructure.Exceptions;

namespace ShadowBuddy.Handlers;

public class DeleteOperationCommandHandler : IRequestHandler<DeleteOperationCommand>
{
    private readonly IAccountProcessingRepository _accountProcessingRepository;

    public DeleteOperationCommandHandler(IAccountProcessingRepository accountProcessingRepository)
    {
        _accountProcessingRepository = accountProcessingRepository ??
                                       throw new ArgumentNullException(nameof(accountProcessingRepository));
    }

    public async Task Handle(DeleteOperationCommand request, CancellationToken cancellationToken) =>
        await _accountProcessingRepository.DeleteOperation(request.OperationId, cancellationToken);
}