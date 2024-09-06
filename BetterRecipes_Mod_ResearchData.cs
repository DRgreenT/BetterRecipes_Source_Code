using Mafi;
using Mafi.Base;
using Mafi.Core.Mods;
using Mafi.Core.Research;

namespace BetterRecipes;

internal class BetterRecipes_Mod_ResearchData : IResearchNodesData
{

    public void RegisterData(ProtoRegistrator registrator)
    {

        ResearchNodeProto nodeProto_ImprovedSmeltingT1 = registrator.ResearchNodeProtoBuilder
            .Start("Improved scrap smelting I", Mod_Ids.Research.ImprovedScrapSmeltingT1_Research)
            .Description("Makes scrap smelting more efficient by reducing the amount of coal needed per cycle.")
            .AddRecipeToUnlock(Mod_Ids.Recipes.BetterIronScrapSmeltingT1)
            .AddRecipeToUnlock(Mod_Ids.Recipes.BetterCopperScrapSmeltingT2)
            .AddProductIcon(Ids.Products.IronScrap)
            .AddProductIcon(Ids.Products.CopperScrap)
            .AddParents(registrator.PrototypesDb.GetOrThrow<ResearchNodeProto>(Ids.Research.CopperRefinement), registrator.PrototypesDb.GetOrThrow<ResearchNodeProto>(Ids.Research.VehicleAndMining))
            .BuildAndAdd();
        nodeProto_ImprovedSmeltingT1.GridPosition = new Vector2i(16, 5);

        ResearchNodeProto nodeProto_ImprovedSmeltingT2 = registrator.ResearchNodeProtoBuilder
            .Start("Improved scrap smelting II", Mod_Ids.Research.ImprovedScrapSmeltingT2_Research)
            .Description("Makes scrap smelting more efficient by reducing the amount of coal needed per cycle.")
            .AddRecipeToUnlock(Mod_Ids.Recipes.BetterIronScrapSmeltingT2)
            .AddRecipeToUnlock(Mod_Ids.Recipes.BetterCopperScrapSmeltingT2)
            .AddProductIcon(Ids.Products.IronScrap)
            .AddProductIcon(Ids.Products.CopperScrap)
            .AddParents(registrator.PrototypesDb.GetOrThrow<ResearchNodeProto>(Ids.Research.AdvancedSmelting))
            .BuildAndAdd();
        nodeProto_ImprovedSmeltingT2.GridPosition = new Vector2i(80, 14);

        ResearchNodeProto nodeProto_SolarThermalSteam = registrator.ResearchNodeProtoBuilder
            .Start("Solar thermal steam I", Mod_Ids.Research.SolarThermalSteamGenerator_Research)
            .Description("Solar thermal steam generation.")
            .AddMachineToUnlock(Mod_Ids.Machines.SolarThermalSteamGenerator_Machine)
            .AddMachineToUnlock(Mod_Ids.Machines.SteamLowToHi_Machine)
            .AddAllRecipesOfMachineToUnlock(Mod_Ids.Machines.SolarThermalSteamGenerator_Machine)
            .AddAllRecipesOfMachineToUnlock(Mod_Ids.Machines.SteamLowToHi_Machine)
            .AddProductIcon(Ids.Products.SteamLo)
            .AddProductIcon(Ids.Products.SteamHi)
            .AddParents(registrator.PrototypesDb.GetOrThrow<ResearchNodeProto>(Ids.Research.SettlementWater))
            .BuildAndAdd();
        nodeProto_SolarThermalSteam.GridPosition = new Vector2i(28, 26);
    }
}
