using System.Collections.Generic;
using RingoLib.Core.Models;
using RingoLib.Core.ValueObjects;

namespace RingoLib.Search.SearchAction.Infrastructures.InMemory
{
	public class StageMasterInMemory
	{
		private static readonly Dictionary<StageId, StageMaster> _dict;

		static StageMasterInMemory() {
			_dict = new() {
				{ new(), new() },
				{ new(), new() }
			};
		}
	}
}
