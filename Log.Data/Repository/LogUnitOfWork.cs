using EFCoreHelper;
using System;

namespace Log.Data;

public class LogUnitOfWork : ILogUnitOfWork
{
    private readonly LogContext context;
    private readonly IGenericRepository<Category> category;
    private readonly IGenericRepository<Place> place;
    private readonly IGenericRepository<Task> task;
    private readonly ILogRepo log;
    private bool disposed = false;

    public IGenericRepository<Category> Category => category;

    public IGenericRepository<Place> Place => place;

    public IGenericRepository<Task> Task => task;

    public ILogRepo Log => log;

    public LogUnitOfWork(
        LogContext context
        , IGenericRepository<Category> category
        , IGenericRepository<Place> place
        , IGenericRepository<Task> task
        , ILogRepo log)
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

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
            {
                context.Dispose();
            }
        }
        disposed = true;
    }

    public void Save() =>
        context.SaveChanges();
}