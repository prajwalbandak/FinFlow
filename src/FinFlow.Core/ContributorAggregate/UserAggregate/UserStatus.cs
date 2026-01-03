using Ardalis.SmartEnum;

namespace FinFlow.Core.ContributorAggregate;
{
    public sealed class UserStatus : SmartEnum<UserStatus>
    {
        public static readonly UserStatus Active =
            new(nameof(Active), 1);

        public static readonly UserStatus Inactive =
            new(nameof(Inactive), 2);

        private UserStatus(string name, int value)
            : base(name, value)
        {
        }

        // Optional domain behavior
        public bool CanLogin => this == Active;
    }
}
