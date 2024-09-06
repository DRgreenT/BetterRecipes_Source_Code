using Mafi.Base;
using Mafi.Core.Research;
using ResNodeID = Mafi.Core.Research.ResearchNodeProto.ID;

namespace BetterRecipes;

public partial class Mod_Ids {

	public partial class Research 
	{
        [ResearchCosts(difficulty: 8)]
        public static readonly ResNodeID SolarThermalSteamGenerator_Research = Ids.Research.CreateId("SolarThermalSteamGenerator_Research");
        [ResearchCosts(difficulty: 6)]
		public static readonly ResNodeID ImprovedScrapSmeltingT1_Research = Ids.Research.CreateId("ImprovedScrapSmeltingT1_Research");
        [ResearchCosts(difficulty: 18)]
        public static readonly ResNodeID ImprovedScrapSmeltingT2_Research = Ids.Research.CreateId("ImprovedScrapSmeltingT2");
    }

}