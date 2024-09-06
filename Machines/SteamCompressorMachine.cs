using Mafi.Core.Mods;
using Mafi.Base;
using Mafi;
using Mafi.Core.Entities.Static.Layout;
using static BetterRecipes.BetterRecipes;

namespace BetterRecipes.Machines;
internal class SteamCompressorMachine : IModData
    {
        public void RegisterData(ProtoRegistrator registrator)
        {
            registrator.MachineProtoBuilder
            .Start("Steam compressor", NewModIDs.Machines.SteamLowToHi_Machine)
            .Description("Steam compressor")
            .SetCost(Costs.Build.CP2(100).Workers(1))
            .SetCategories()
            .SetLayout(new EntityLayoutParams(),
            "   [5][5][5][5][5]   ",
            "A@>[5][5][5][5][5]>@X",
            "   [5][5][5][5][5]   ",
            "B@>[5][5][5][5][5]>@Y",
            "   [5][5][5][5][5]   ")
            .SetCategories(Ids.ToolbarCategories.MachinesWater)
            .SetElectricityConsumption(200.Kw())
            .SetPrefabPath("Assets/Base/Buildings/Storages/GasT1.prefab")
            .SetCustomIconPath("Assets/Unity/Generated/Icons/LayoutEntity/StorageFluid.png")
            .BuildAndAdd();
        }
    }

