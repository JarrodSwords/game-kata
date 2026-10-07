using Jgs.Errors;

namespace Gk.Messages;

public interface ICommand;

public interface ICommandHandler<in T> where T : ICommand
{
    Result Handle(T command);
    Task<Result> HandleAsync(T command);
}

public interface ICommandHandler<in T, TResult> where T : ICommand
{
    Result<TResult> Handle(T command);
    Task<Result<TResult>> HandleAsync(T command);
}

public interface IQuery;

public interface IQueryHandler<in T, TResult> where T : IQuery
{
    Result<TResult> Handle(T query);
    Task<Result<TResult>> HandleAsync(T query);
}
