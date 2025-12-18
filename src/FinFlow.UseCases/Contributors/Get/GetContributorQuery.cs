using FinFlow.Core.ContributorAggregate;

namespace FinFlow.UseCases.Contributors.Get;

public record GetContributorQuery(ContributorId ContributorId) : IQuery<Result<ContributorDto>>;
