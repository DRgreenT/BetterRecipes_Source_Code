using Mafi.Base;
using Mafi.Core.Mods;
using Mafi.Core.Entities.Static.Layout;
using Mafi;
using static BetterRecipes.BetterRecipes;

namespace BetterRecipes.Machines;
internal class SolarThermalGeneratorMachine : IModData
{
    	public void RegisterData(ProtoRegistrator registrator)
        {
            // Solar thermal steam generation
            registrator.MachineProtoBuilder
                .Start("Solar thermal steam generator", NewModIDs.Machines.SolarThermalSteamGenerator_Machine)
                .Description("")
                .SetCost(Costs.Build.CP2(80).Workers(0))
                .SetCategories()
                .SetLayout(new EntityLayoutParams(),
                "   [5][5][5][5][5]   ",
                "A@>[5][5][5][5][5]>@X",
                "   [5][5][5][5][5]   ",
                "B@>[5][5][5][5][5]>@Y",
                "   [5][5][5][5][5]   ")
                .SetCategories(Ids.ToolbarCategories.MachinesWater)
                .SetElectricityConsumption(40.Kw())
                .SetPrefabPath("Assets/Base/Buildings/Storages/GasT1.prefab")
                .SetCustomIconPath("Assets/Unity/Generated/Icons/LayoutEntity/StorageFluid.png")
                .BuildAndAdd();
        }

}
