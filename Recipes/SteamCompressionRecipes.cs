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
            .Start(name: "Steam compression I S1",
                recipeId: NewModIDs.Recipes.SteamCompressorT1_toSteamLow_Recipes,
                machineId: NewModIDs.Machines.SteamLowToHi_Machine)
            .Description("Steam compression Stage I")
            .SetDuration(15.Seconds())
            .AddInput(8, Ids.Products.SteamDepleted)
            .AddOutput(3, Ids.Products.SteamLo, "X", outputAtStart: true)
            .AddOutput(5, Ids.Products.Water, "Y", outputAtStart: true)
            .BuildAndAdd();

        registrator.RecipeProtoBuilder
            .Start(name: "Steam compression I S2",
                recipeId: NewModIDs.Recipes.SteamCompressorT1_toSteamHi_Recipes,
                machineId: NewModIDs.Machines.SteamLowToHi_Machine)
            .Description("Steam compression Stage II")
            .SetDuration(15.Seconds())
            .AddInput(3, Ids.Products.SteamLo)
            .AddOutput(2, Ids.Products.SteamHi, "X", outputAtStart: true)
            .AddOutput(1, Ids.Products.Water, "Y", outputAtStart: true)
            .BuildAndAdd();
    }

}
