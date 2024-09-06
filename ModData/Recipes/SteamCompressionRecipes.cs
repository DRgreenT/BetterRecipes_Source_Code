using Mafi.Base;
using Mafi.Core.Mods;
using Mafi;
using static BetterRecipes.BetterRecipes;

namespace BetterRecipes.ModData.Recipes;
internal class SteamCompressionRecipes : IModData
{
    	public void RegisterData(ProtoRegistrator registrator)
        {

        registrator.RecipeProtoBuilder
            .Start(name: "Steam compression I S1",
                recipeId: NewMod_IDs.Recipes.SteamCompressorT1_toSteamLow_Recipes,
                machineId: NewMod_IDs.Machines.SteamLowToHi_Machine)
            .Description("Steam compression Stage I")
            .SetDuration(15.Seconds())
            .AddInput(6, Ids.Products.SteamDepleted)
            .AddOutput(2, Ids.Products.SteamLo, "X", outputAtStart: true)
            .AddOutput(4, Ids.Products.Water, "Y", outputAtStart: true)
            .BuildAndAdd();

        registrator.RecipeProtoBuilder
            .Start(name: "Steam compression I S2",
                recipeId: NewMod_IDs.Recipes.SteamCompressorT1_toSteamHi_Recipes,
                machineId: NewMod_IDs.Machines.SteamLowToHi_Machine)
            .Description("Steam compression Stage II")
            .SetDuration(15.Seconds())
            .AddInput(3, Ids.Products.SteamLo)
            .AddOutput(1, Ids.Products.SteamHi, "X", outputAtStart: true)
            .AddOutput(2, Ids.Products.Water, "Y", outputAtStart: true)
            .BuildAndAdd();
    }

}
