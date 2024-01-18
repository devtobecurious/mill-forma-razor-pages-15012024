using StarWars.BackOffice.Core.Models;
using StarWars.BackOffice.Core.Models.Data;
using StarWars.Games.Core.Interfaces;

namespace StarWars.BackOffice.Core.Services
{
	public class SqlServerDbContextAmiService : IAmiService
	{
		private readonly DefaultDbContext context;

		public SqlServerDbContextAmiService(DefaultDbContext context)
		{
			this.context = context;
		}

		public List<Ami> GetAll()
		{
			return this.context.Amis.OrderBy(item => item.Prenom).ToList();
		}
	}
}
