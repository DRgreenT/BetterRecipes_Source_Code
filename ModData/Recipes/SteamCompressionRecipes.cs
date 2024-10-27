using Mafi.Base;
using Mafi.Core.Mods;
using Mafi;


namespace BetterRecipes.ModData.Recipes;
internal class SteamCompressionRecipes : IModData
{
    	public void RegisterData(ProtoRegistrator registrator)
        {

        registrator.RecipeProtoBuilder
            .Start(name: "Steam compression",
                recipeId: NewMod_IDs.Recipes.SteamCompressorRecipes,
                machineId: NewMod_IDs.Machines.SteamCompressor)
            .Description("Steam compression")
            .SetDuration(60.Seconds())
            .AddInput(12, NewMod_IDs.Products.SteamWetProduct)
            .AddOutput(8, Ids.Products.SteamHi, "X", outputAtStart: true)
            .AddOutput(4, Ids.Products.Water, "Y", outputAtStart: true)
            .BuildAndAdd();
    }

}
