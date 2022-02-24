using EFCoreHelper;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Log.Data;

public interface ILogRepo 
    : IGenericRepository<LogModel>
{
	IEnumerable<LogModel> GetLog(
        Expression<Func<LogModel, bool>>? filter);
}