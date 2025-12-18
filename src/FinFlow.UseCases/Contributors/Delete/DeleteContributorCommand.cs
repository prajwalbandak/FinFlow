using FinFlow.Core.ContributorAggregate;

namespace FinFlow.UseCases.Contributors.Delete;

public record DeleteContributorCommand(ContributorId ContributorId) : ICommand<Result>;
