using FinFlow.Core.ContributorAggregate;

namespace FinFlow.UseCases.Contributors;
public record ContributorDto(ContributorId Id, ContributorName Name, PhoneNumber PhoneNumber);
