using FinFlow.Core.ContributorAggregate;    

namespace FinFlow.UseCases.UserContributors.Create;

/// <summary>
/// Create a new User.
/// </summary>
/// <param name="FirstName"></param>
/// <param name="Profile"></param>
public record CreateUserCommand(UserFirstName FirstName, UserProfile Profile) : ICommand<Result<UserId>>;  