using FinFlow.Core.ContributorAggregate.Events;
using NimblePros.SampleToDo.Core.ProjectAggregate;

namespace FinFlow.Core.ContributorAggregate;


public class User : EntityBase<User, UserId>, IAggregateRoot
{

    public UserFirstName FirstName {get; private set;}
   public UserProfile Profile {get;  private set;}

   public UserStatus Status {get; private set;} 

    public User()
    {
        
    }
    public User(UserFirstName firstName, UserProfile profile, UserStatus status)
    {
        FirstName = firstName;
        Profile = profile;
        Status = UserStatus.Active;
    }

    public void Deactivate()
    {
        if (Status == UserStatus.Inactive)
            return;

        Status = UserStatus.Inactive;

        // Optional domain event
        // AddDomainEvent(new UserDeactivatedEvent(Id));
    }

    public void ChangeEmail(UserEmail newEmail)
    {
        Profile = new UserProfile(Profile.firstName, Profile.lastName, Profile.age , newEmail.value);
    }

}

