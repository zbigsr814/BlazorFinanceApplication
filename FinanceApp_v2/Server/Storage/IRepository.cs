using System.ComponentModel;

namespace FinanceApp_v2.Storage
{
	public interface IRepository<T>
	{
		void Add(T entity);
		void Remove(T entity);
		IEnumerable<T> GetAll();
	}
}
