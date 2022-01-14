using Core;

namespace Log.Data;

public interface ILogUnitOfWork : IUnitOfWork
{
	IGenericRepository<Category> Category { get; }
	IGenericRepository<Place> Place { get; }
	IGenericRepository<Task> Task { get; }
	ILogRepo Log { get; }
}