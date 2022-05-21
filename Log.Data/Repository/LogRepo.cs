using EFCoreHelper;
using System.Linq.Expressions;

namespace Log.Data;

#nullable enable
public class LogRepo 
    : EFGenericRepository<LogModel, LogContext>
    , ILogRepo
{
    public LogRepo(LogContext context) : base(context)
    {
    }

    public IEnumerable<LogModel> GetLog(
        Expression<Func<LogModel, bool>>? filter)
    {
        return Get(
            filter
            , orderBy: (l) => l.OrderBy((ls) => ls.Start)
                .ThenBy((le) => le.End)
            , includeProperties: "Task,Place,Task.Category");
    }
}