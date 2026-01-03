using Vogen;

// Assembly-level VogenDefaults attribute removed from this file to avoid a duplicate definition.
// Ensure VogenDefaults is declared once in the project (for example, in a single AssemblyInfo.cs).


namespace FinFlow.Core.ContributorAggregate;



[ValueObject<int>]
public readonly partial struct UserId
{
  private static Validation Validate(int value)
      => value > 0 ? Validation.Ok : Validation.Invalid("UserId  must be positive.");
}
