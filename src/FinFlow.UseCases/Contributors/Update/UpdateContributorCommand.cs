using FinFlow.Core.ContributorAggregate;

namespace FinFlow.UseCases.Contributors.Update;

public record UpdateContributorCommand(ContributorId ContributorId, ContributorName NewName) : ICommand<Result<ContributorDto>>;
