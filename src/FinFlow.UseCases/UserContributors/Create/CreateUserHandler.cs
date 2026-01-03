public class CreateUserHandler: ICommandHandler<CreateUserCommand, Result<UserId>>{

    private readonly IRepository<User, UserId> _userRepository;

    public CreateUserHandler(IRepository<User, UserId> userRepository)
    {
        _userRepository = userRepository;   
    }

    public async Task<Result<UserId>> Handle(CreateUserCommand command, CancellationToken cancellationToken){


        var user = new User(command.FirstName,command.Profile);

        await _userRepository.AddAsync(user, cancellationToken);


        return Result.Success(user.Id);
    }
}