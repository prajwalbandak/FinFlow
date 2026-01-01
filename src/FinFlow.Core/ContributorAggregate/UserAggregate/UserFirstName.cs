using Vogen;

[assembly: VogenDefaults(
        staticAbstractsGeneration: StaticAbstractsGeneration.MostCommon | StaticAbstractsGeneration.InstanceMethodsAndProperties)]


namespace NimblePros.SampleToDo.Core.ProjectAggregate;

// NOTE: Structs do not require conversion to work with EF Core
[ValueObject<string>(conversions: Conversions.SystemTextJson)]
public partial struct UserFirstName
{
    public const int MaxLength  = 50;
    public string Value { get; }

    public UserFirstName(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new DomainException("Username is required");

        if (!value.Contains("@"))
            throw new DomainException("Invalid username format");

        Value = value;
    }
}