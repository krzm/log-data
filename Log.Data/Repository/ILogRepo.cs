using System;
using System.Collections.Generic;
using Core;

namespace Log.Data;

public interface ILogRepo :  IGenericRepository<LogModel>
{
	IEnumerable<LogModel> GetFromTodayOrDateOrBefore(DateTime? dateParam);

    IEnumerable<LogModel> GetByDate(DateTime dateTime);
}