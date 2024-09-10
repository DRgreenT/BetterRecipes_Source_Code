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
            .SetCost(Costs.Build.CP2(100 * mod).Workers(1*mod).Maintenance(5*mod, Ids.Products.MaintenanceT1))
            .SetCategories()
            .SetLayout(new EntityLayoutParams(),
            "   [2][2][2][2][2]   ",
            "A@>[2][2][6][6][2]>@Y",
            "   [2][2][6][6][2]   ",
            "B@>[2][2][6][6][2]>@X",
            "   [2][2][2][2][2]   ")
            .SetCategories(Ids.ToolbarCategories.MachinesWater)
            .SetElectricityConsumption(750*mod.Kw())
            .SetPrefabPath("Assets/CoI BetterRecipes Mod/Machines/SteamCompressot/streamCompressor.prefab")
            .SetCustomIconPath("Assets/Unity/Generated/Icons/LayoutEntity/StorageFluid.png")
            .BuildAndAdd();
        }
}

