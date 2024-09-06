using Mafi.Base;
using Mafi.Core.Mods;
using Mafi;
using static BetterRecipes.BetterRecipes;

namespace BetterRecipes.Recipes;
internal class SolarThermalSteamRecipes : IModData
{
    	public void RegisterData(ProtoRegistrator registrator)
        {
        registrator.RecipeProtoBuilder
             .Start(name: "Solar thermal steam generation I",
                 recipeId: NewModIDs.Recipes.SolarThermalSteamGenerator_Recip,
                 machineId: NewModIDs.Machines.SolarThermalSteamGenerator_Machine)
             .SetDuration(15.Seconds())
             .AddInput(1, Ids.Products.Water)
             .AddOutput(1, Ids.Products.SteamLo, outputAtStart: true)
             .BuildAndAdd();
        }

}
