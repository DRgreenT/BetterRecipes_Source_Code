using Mafi.Base;
using Mafi.Core.Mods;
using Mafi;
using static BetterRecipes.BetterRecipes;

namespace BetterRecipes.ModData.Recipes;
internal class SolarThermalSteamRecipes : IModData
{
    	public void RegisterData(ProtoRegistrator registrator)
        {
        registrator.RecipeProtoBuilder
             .Start(name: "Solar thermal steam generation I",
                 recipeId: NewMod_IDs.Recipes.SolarThermalSteamT1_Recipes,
                 machineId: NewMod_IDs.Machines.SolarThermalSteamGenerator_Machine)
             .SetDuration(60.Seconds())
             .AddInput(6, Ids.Products.Water)
             .AddOutput(6, NewMod_IDs.Products.SteamWetProduct, outputAtStart: true)
             .BuildAndAdd();
        }

}
