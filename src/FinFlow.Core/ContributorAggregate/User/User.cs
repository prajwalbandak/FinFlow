using FinFlow.Core.ContributorAggregate.Events;

namespace FinFlow.Core.ContributorAggregate;

public class User(UserName name): EntityBase<User,UserId>, IAggregateRoot
{}

