using EFCore.Helper;

namespace Log.Data;

public class LogUnitOfWork
    : UnitOfWork
        , ILogUnitOfWork
{
    private readonly LogContext context;
    private readonly IRepository<Category> category;
    private readonly IRepository<Place> place;
    private readonly IRepository<Task> task;
    private readonly ILogRepo log;

    public IRepository<Category> Category => category;

    public IRepository<Place> Place => place;

    public IRepository<Task> Task => task;

    public ILogRepo Log => log;

    public LogUnitOfWork(
        LogContext context
        , IRepository<Category> category
        , IRepository<Place> place
        , IRepository<Task> task
        , ILogRepo log)
            : base(context)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(category);
        ArgumentNullException.ThrowIfNull(place);
        ArgumentNullException.ThrowIfNull(task);
        ArgumentNullException.ThrowIfNull(log);

        this.context = context;
        this.category = category;
        this.place = place;
        this.task = task;
        this.log = log;
    }
}