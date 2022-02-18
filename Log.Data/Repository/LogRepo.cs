using EFCoreHelper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Log.Data;

public class LogRepo 
    : EFGenericRepository<LogModel, LogContext>
    , ILogRepo
{
    public LogRepo(LogContext context) : base(context)
    {
    }

    public IEnumerable<LogModel> GetFromTodayOrDateOrBefore(DateTime? dateParam)
    {
        var date = dateParam.HasValue ? dateParam.Value.Date : DateTime.Now.Date;
        return GetByDate(date);
    }

    public IEnumerable<LogModel> GetByDate(DateTime dateTime)
    {
        return Get(
            filter: (l) => l.Start.HasValue ? l.Start.Value.Date.Equals(dateTime) : true
            , orderBy: (l) => l.OrderBy((ls) => ls.Start).ThenBy((le) => le.End)
            , includeProperties: "Task,Place");
    }
}