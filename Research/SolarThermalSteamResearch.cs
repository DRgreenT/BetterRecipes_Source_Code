using Mafi;
using Mafi.Base;
using Mafi.Core.Mods;
using Mafi.Core.Research;
using static BetterRecipes.BetterRecipes;

namespace BetterRecipes.Research;
internal class SolarThermalSteamResearch : IResearchNodesData
{
    public void RegisterData(ProtoRegistrator registrator)
    {

        ResearchNodeProto nodeProto_SolarThermalSteam = registrator.ResearchNodeProtoBuilder
            .Start("Solar thermal steam I", NewModIDs.Research.SolarThermalSteamT1_Research)
            .Description("Solar thermal steam generation.")
            .AddMachineToUnlock(NewModIDs.Machines.SolarThermalSteamGenerator_Machine)
            .AddMachineToUnlock(NewModIDs.Machines.SteamLowToHi_Machine)
            .AddAllRecipesOfMachineToUnlock(NewModIDs.Machines.SolarThermalSteamGenerator_Machine)
            .AddAllRecipesOfMachineToUnlock(NewModIDs.Machines.SteamLowToHi_Machine)
            .AddProductIcon(Ids.Products.SteamLo)
            .AddProductIcon(Ids.Products.SteamHi)
            .SetCosts(new ResearchCostsTpl(8))
            .AddParents(registrator.PrototypesDb.GetOrThrow<ResearchNodeProto>(Ids.Research.SettlementWater))
            .BuildAndAdd();
        nodeProto_SolarThermalSteam.GridPosition = new Vector2i(28, 26);
    }
}
