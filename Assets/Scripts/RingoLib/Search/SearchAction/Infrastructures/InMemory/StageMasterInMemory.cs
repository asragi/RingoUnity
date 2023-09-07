using System;
using System.Collections.Generic;
using System.Linq;
using RingoLib.Core.Models;
using RingoLib.Core.ValueObjects;

namespace RingoLib.Search.SearchAction.Infrastructures.InMemory
{
	public class StageMasterInMemory
	{
		public static readonly StageId[] AllStageId = new StageId[] { new("a"), new("b") };
		public static readonly Dictionary<StageId, ExploreActionId[]> Explores = new()
		{
			{ AllStageId[0], new ExploreActionId[]{
				new("burn-apple"), new("find-stick")
			} },
			{ AllStageId[1], new ExploreActionId[]{ new("fishing") } }
		};
		private static readonly Dictionary<StageId, StageMaster> _dict;

		static StageMasterInMemory() {
			StageId idA = AllStageId[0];
			StageId idB = AllStageId[1];
			_dict = new() {
				{ idA, new(idA, "ポムポムのもり", "りんごの木がたくさん育つ森\nどれだけ採ってもすぐにりんごが生る",new ExploreActionMaster[]{
					new(
						Explores[idA][0],
						"りんごを焼く",
						"火の魔法でりんごを焼いてみる",
						new ItemId[]{ },
						new (ItemId, int)[]{ },
						new (SkillId, int)[]{ })
				}) },
				{ idB, new(idB, "リーバ川", "甘い香りのする川", Array.Empty<ExploreActionMaster>()) }
			};
		}

		public StageMaster Get(StageId stageId)
			=> _dict[stageId];
		public StageMaster[] GetAllStages() => _dict.Values.ToArray();
	}
}
