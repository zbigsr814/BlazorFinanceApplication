using FinanceApp_v2.Storage;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace FinanceApp_v2.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class EarningsController : ControllerBase
	{
		private readonly IRepository<Earning> _repositoryEarning;

		public EarningsController(IRepository<Earning> repositoryEarning)
        {
			_repositoryEarning = repositoryEarning;
		}

		[HttpGet]
		public IEnumerable<Earning> Get()
		{
			return _repositoryEarning.GetAll()
				.OrderBy(e => e.Date);
		}

		[HttpPost]
		public void Post(Earning earning)
		{
			_repositoryEarning.Add(earning);
		}

		[HttpDelete("{id?}")]
		public void Delete(Guid id)
		{
			var entity = _repositoryEarning.GetAll()
				.Single(e => e.Id == id);
			_repositoryEarning.Remove(entity);
		}
    }
}
