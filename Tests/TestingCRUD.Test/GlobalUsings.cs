global using Moq;
global using Xunit;
global using Shouldly;
global using FluentValidation;
global using FluentValidation.Results;
global using ValidationException = FluentValidation.ValidationException;

global using TestingCRUD.Domain.Enums;
global using TestingCRUD.Domain.Models;
global using TestingCRUD.Application.DTOs;
global using TestingCRUD.Domain.Repositories;
global using TestingCRUD.Application.ViewModels;
global using TestingCRUD.Application.InputModels;
global using TestingCRUD.Application.Commands.OrderCommands;
global using TestingCRUD.Application.Handlers.OrderHandlers;
global using TestingCRUD.Application.Handlers.ProductHandlers;
global using TestingCRUD.Application.Commands.ProductCommands;
global using TestingCRUD.Application.Handlers.CustomerHandlers;
global using TestingCRUD.Application.Commands.CustomerCommands;
global using TestingCRUD.Application.Commands.OrderItemCommands;
global using TestingCRUD.Application.Handlers.OrderItemHandlers;
global using TestingCRUD.Application.ViewModels.ProductViewModels;
global using TestingCRUD.Application.ViewModels.CustomerViewModels;
global using TestingCRUD.Application.Validations.OrderCommandValidation;
global using TestingCRUD.Application.Validations.ProductCommandValidation;
global using TestingCRUD.Application.Validations.CustomerCommandValidation;
