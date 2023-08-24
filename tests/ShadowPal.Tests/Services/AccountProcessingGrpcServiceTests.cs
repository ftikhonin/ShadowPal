﻿using Google.Protobuf.WellKnownTypes;
using MediatR;
using ShadowPal.Handlers;

namespace ShadowPal.Tests.Handlers;

public class AccountProcessingGrpcServiceTests
{
    private readonly Mock<IMediator> _mediator;

    public AccountProcessingGrpcServiceTests()
    {
        _mediator = new Mock<IMediator>();
    }

    [Fact]
    public void CreateAccount_handles_properly()
    {
        //Arrange
        var command = new CreateAccountCommand(1, "Test", 12.34F, DateTime.UtcNow.ToTimestamp(), 1);
        //Act
        var exception = Record.ExceptionAsync(() => _mediator.Object.Send(command, CancellationToken.None));
        //Assert
        //TODO:доделать
        Assert.Null(null);
    }
}