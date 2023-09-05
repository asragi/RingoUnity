using System;
using System.Collections.Generic;
using RingoLib.Core.Models;
using RingoLib.Core.ValueObjects;

namespace RingoLib.Search.SearchAction.Infrastructures.InMemory
{
	public class StageMasterInMemory
	{
		private static readonly Dictionary<StageId, StageMaster> _dict;

		static StageMasterInMemory() {
			StageId idA = new("a");
			StageId idB = new("b");
			_dict = new() {
				{ idA, new(idA, "ポムポムのもり", Array.Empty<ExploreActionMaster>()) },
				{ idB, new(idB, "リーバ川", Array.Empty<ExploreActionMaster>()) }
			};
		}

		public StageMaster Get(StageId stageId)
			=> _dict[stageId];
	}
}
