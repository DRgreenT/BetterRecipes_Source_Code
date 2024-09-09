using Mafi.Core.Mods;
using Mafi.Base;
using Mafi;
using Mafi.Core.Entities.Static.Layout;


namespace BetterRecipes.ModData.Machines;
internal class SteamCompressorMachine : IModData
{
    private readonly int mod = ModDebug.SetValuesToZero(false);
    public void RegisterData(ProtoRegistrator registrator)
        {
            registrator.MachineProtoBuilder
            .Start("Steam compressor", NewMod_IDs.Machines.SteamCompressor)
            .Description("Steam compressor")
            .SetCost(Costs.Build.CP2(100 * mod).Workers(1*mod).MaintenanceT1(10*mod))
            .SetCategories()
            .SetLayout(new EntityLayoutParams(),
            "   [5][5][5][5][5]   ",
            "A@>[5][5][5][5][5]>@X",
            "   [5][5][5][5][5]   ",
            "B@>[5][5][5][5][5]>@Y",
            "   [5][5][5][5][5]   ")
            .SetCategories(Ids.ToolbarCategories.MachinesWater)
            .SetElectricityConsumption(750*mod.Kw())
            .SetPrefabPath("Assets/Base/Buildings/Storages/GasT1.prefab")
            .SetCustomIconPath("Assets/Unity/Generated/Icons/LayoutEntity/StorageFluid.png")
            .BuildAndAdd();
        }
}

