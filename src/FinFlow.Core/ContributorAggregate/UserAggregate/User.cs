using FinFlow.Core.ContributorAggregate.Events;

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
        Status = status;
    }

}