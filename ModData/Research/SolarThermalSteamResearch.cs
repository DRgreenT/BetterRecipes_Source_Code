using Mafi;
using Mafi.Base;
using Mafi.Core.Mods;
using Mafi.Core.Research;
using static BetterRecipes.BetterRecipes;

namespace BetterRecipes.ModData.Research;
internal class SolarThermalSteamResearch : IResearchNodesData
{
    public void RegisterData(ProtoRegistrator registrator)
    {

        ResearchNodeProto nodeProto_SolarThermalSteam = registrator.ResearchNodeProtoBuilder
            .Start("Solar thermal steam I", NewMod_IDs.Research.SolarThermalSteamT1_Research)
            .Description("Solar thermal steam generation.")
            .AddMachineToUnlock(NewMod_IDs.Machines.SolarThermalSteamGenerator_Machine)
            .AddMachineToUnlock(NewMod_IDs.Machines.SteamLowToHi_Machine)
            .AddAllRecipesOfMachineToUnlock(NewMod_IDs.Machines.SolarThermalSteamGenerator_Machine)
            .AddAllRecipesOfMachineToUnlock(NewMod_IDs.Machines.SteamLowToHi_Machine)
            .AddProductIcon(Ids.Products.SteamDepleted)
            .AddProductIcon(Ids.Products.SteamLo)
            .AddProductIcon(Ids.Products.SteamHi)
            .SetCosts(new ResearchCostsTpl(8))
            .AddParents(registrator.PrototypesDb.GetOrThrow<ResearchNodeProto>(Ids.Research.SettlementWater))
            .BuildAndAdd();
        nodeProto_SolarThermalSteam.GridPosition = new Vector2i(28, 26);
    }
}
