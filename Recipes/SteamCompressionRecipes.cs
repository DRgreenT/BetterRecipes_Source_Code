using Mafi.Base;
using Mafi.Core.Mods;
using Mafi;
using static BetterRecipes.BetterRecipes;

namespace BetterRecipes.Recipes;
internal class SteamCompressionRecipes : IModData
{
    	public void RegisterData(ProtoRegistrator registrator)
        {

        registrator.RecipeProtoBuilder
            .Start(name: "Steam compression I",
                recipeId: NewModIDs.Recipes.SteamCompressor_RecipI,
                machineId: NewModIDs.Machines.SteamLowToHi_Machine)
            .SetDuration(15.Seconds())
            .AddInput(4, Ids.Products.SteamLo)
            .AddOutput(2, Ids.Products.SteamHi, "X", outputAtStart: true)
            .AddOutput(2, Ids.Products.Water, "Y", outputAtStart: true)
            .BuildAndAdd();
        }

}
