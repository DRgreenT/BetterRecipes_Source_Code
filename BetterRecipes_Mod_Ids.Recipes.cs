using Mafi.Base;
using RecipeID = Mafi.Core.Factory.Recipes.RecipeProto.ID;

namespace BetterRecipes;

public partial class Mod_Ids {

	public partial class Recipes 
	{
		public static readonly RecipeID BetterIronScrapSmeltingT1 = Ids.Recipes.CreateId("BetterIronScrapSmeltingT1");
        public static readonly RecipeID BetterIronScrapSmeltingT2 = Ids.Recipes.CreateId("BetterIronScrapSmeltingT2");
        public static readonly RecipeID BetterCopperScrapSmeltingT1 = Ids.Recipes.CreateId("BetterCopperScrapSmeltingT1");
        public static readonly RecipeID BetterCopperScrapSmeltingT2 = Ids.Recipes.CreateId("BetterCopperScrapSmeltingT2");

        public static readonly RecipeID SolarThermalSteamGenerator_Recip = Ids.Recipes.CreateId("SolarThermalSteamGenerator_Recip");
        public static readonly RecipeID SteamCompressor_RecipI = Ids.Recipes.CreateId("SteamCompressorI");
    }

}