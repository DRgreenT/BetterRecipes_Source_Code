using Mafi.Base;
using Mafi.Core.Mods;
using Mafi.Core.Entities.Static.Layout;
using Mafi;

namespace BetterRecipes.ModData.Machines;
internal class littleCheater : IModData
{

        private readonly int mod = ModDebug.SetValuesToZero(true);
        public void RegisterData(ProtoRegistrator registrator)
        {
            // Solar thermal steam generation
            registrator.MachineProtoBuilder
                .Start("Little Cheater Generator", NewMod_IDs.Machines.LittleCheaterGenerator)
                .Description("")
                .SetCost(Costs.Build.CP(100*mod).Copper(100*mod).Workers(0*mod).Maintenance(2*mod,Ids.Products.MaintenanceT1))
                .SetLayout(new EntityLayoutParams(),
                "   [1][3][3][3][3]   ",
                "A@<[3][3][3][3][3]>#X",
                "   [3][3][3][3][3]   ",
                "B'<[3][3][3][3][3]>~Y",
                "   [3][3][3][3][3]   ")
                .SetCategories(Ids.ToolbarCategories.Buildings)
                .SetElectricityConsumption(125*mod.Kw())
                .SetPrefabPath("Assets/Base/Buildings/Storages/GasT1.prefab")
                .SetCustomIconPath("Assets/Unity/Generated/Icons/LayoutEntity/StorageFluid.png")
                .BuildAndAdd();

            registrator.MachineProtoBuilder
                .Start("Little Cheater Sink", NewMod_IDs.Machines.LittleCheaterSink)
                .Description("")
                .SetCost(Costs.Build.CP(100 * mod).Copper(100 * mod).Workers(0 * mod).Maintenance(2 * mod, Ids.Products.MaintenanceT1))
                .SetLayout(new EntityLayoutParams(),
                "   [3][3][3][3][3]   ",
                "A@>[3][3][3][3][3]<#X",
                "   [3][3][3][3][3]   ",
                "B'>[3][3][3][3][3]<~Y",
                "   [3][3][3][3][3]   ")
                .SetCategories(Ids.ToolbarCategories.Buildings)
                .SetElectricityConsumption(125 * mod.Kw())
                .SetPrefabPath("Assets/Base/Buildings/Storages/GasT1.prefab")
                .SetCustomIconPath("Assets/Unity/Generated/Icons/LayoutEntity/StorageFluid.png")
                .BuildAndAdd();


    }

}
