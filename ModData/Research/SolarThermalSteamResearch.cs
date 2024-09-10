using Mafi;
using Mafi.Base;
using Mafi.Core.Mods;
using Mafi.Core.Research;


namespace BetterRecipes.ModData.Research;
internal class SolarThermalSteamResearch : IResearchNodesData
{
    private readonly int mod = ModDebug.SetValuesToZero(false);
    public void RegisterData(ProtoRegistrator registrator)
    {

        ResearchNodeProto nodeProto_SolarThermalSteam = registrator.ResearchNodeProtoBuilder
            .Start("Solar thermal steam I", NewMod_IDs.Research.SolarThermalSteamT1_Research)
            .Description("Solar thermal steam generation.")
            .AddMachineToUnlock(NewMod_IDs.Machines.SolarThermalSteamGenerator_Machine)
            .AddMachineToUnlock(NewMod_IDs.Machines.SteamCompressor)
            .AddAllRecipesOfMachineToUnlock(NewMod_IDs.Machines.SolarThermalSteamGenerator_Machine)
            .AddAllRecipesOfMachineToUnlock(NewMod_IDs.Machines.SteamCompressor)
            .AddProductIcon(NewMod_IDs.Products.SteamWetProduct)
            .AddProductIcon(Ids.Products.SteamHi)
            .SetCosts(new ResearchCostsTpl(8*mod))
            .AddParents(registrator.PrototypesDb.GetOrThrow<ResearchNodeProto>(Ids.Research.SettlementWater))
            .BuildAndAdd();
        nodeProto_SolarThermalSteam.GridPosition = new Vector2i(28, 26);
    }
}
