﻿using Resgrid.Model;
using Resgrid.Model.Repositories.Queries.Contracts;
using Resgrid.Repositories.DataRepository.Configs;
using Resgrid.Repositories.DataRepository.Extensions;

namespace Resgrid.Repositories.DataRepository.Queries.Calls
{
	public class SelectAllCallUnitDispsByCallIdQuery : ISelectQuery
	{
		private readonly SqlConfiguration _sqlConfiguration;
		public SelectAllCallUnitDispsByCallIdQuery(SqlConfiguration sqlConfiguration)
		{
			_sqlConfiguration = sqlConfiguration;
		}

		public string GetQuery()
		{
			var query = _sqlConfiguration.SelectAllCallUnitDispsByCallIdQuery
				.ReplaceQueryParameters(_sqlConfiguration, _sqlConfiguration.SchemaName,
					_sqlConfiguration.CallDispatchUnitsTable,
					_sqlConfiguration.ParameterNotation,
					new string[] { "%CALLID%" },
					new string[] { "CallId" });

			return query;
		}

		public string GetQuery<TEntity>() where TEntity : class, IEntity
		{
			throw new System.NotImplementedException();
		}
	}
}
