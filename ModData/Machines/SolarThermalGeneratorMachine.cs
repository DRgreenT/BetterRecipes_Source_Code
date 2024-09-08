using Mafi.Base;
using Mafi.Core.Mods;
using Mafi.Core.Entities.Static.Layout;
using Mafi;
using static BetterRecipes.BetterRecipes;

namespace BetterRecipes.ModData.Machines;
internal class SolarThermalGeneratorMachine : IModData
{

        private readonly int mod = ModDebug.SetValuesToZero();
        public void RegisterData(ProtoRegistrator registrator)
        {
            // Solar thermal steam generation
            registrator.MachineProtoBuilder
                .Start("Solar thermal steam generator", NewMod_IDs.Machines.SolarThermalSteamGenerator_Machine)
                .Description("")
                .SetCost(Costs.Build.CP(100*mod).Copper(80*mod).Workers(0*mod))
                .SetCategories()
                .SetLayout(new EntityLayoutParams(),
                "   [1][1][1][1][1]   ",
                "   [1][1][1][1][1]>@X",
                "   [1][1][1][1][1]   ",
                "B@>[1][1][1][1][1]>@Y",
                "   [1][1][1][1][1]   ")
                .SetCategories(Ids.ToolbarCategories.MachinesWater)
                .SetElectricityConsumption(5*mod.Kw())
                .SetPrefabPath("Assets/CoI BetterRecipes Mod/SolarThermal/SolarThermieI_test1.prefab")
                .SetCustomIconPath("Assets/MachineIcons/solThermGen.png")
                .BuildAndAdd();
        }

}
