using Mafi;
using Mafi.Base;
using Mafi.Core.Entities.Animations;
using Mafi.Core.Entities.Static.Layout;
using Mafi.Core.Mods;
using UnityEngine;

namespace BetterRecipes;

internal class BetterRecepis_Mod_MachineData : IModData {

	public void RegisterData(ProtoRegistrator registrator) {

    // Solar thermal steam generation
        registrator.MachineProtoBuilder
            .Start("Solar thermal steam generator", Mod_Ids.Machines.SolarThermalSteamGenerator_Machine)
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

        registrator.RecipeProtoBuilder
            .Start(name: "Solar thermal steam generation I",
                recipeId: Mod_Ids.Recipes.SolarThermalSteamGenerator_Recip,
                machineId: Mod_Ids.Machines.SolarThermalSteamGenerator_Machine)
            .SetDuration(15.Seconds())
            .AddInput(1, Ids.Products.Water)
            .AddOutput(1, Ids.Products.SteamLo , outputAtStart: true)
            .BuildAndAdd();

        registrator.MachineProtoBuilder
            .Start("Steam compressor", Mod_Ids.Machines.SteamLowToHi_Machine)
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
        

        registrator.RecipeProtoBuilder
            .Start(name: "Steam compression I",
                recipeId: Mod_Ids.Recipes.SteamCompressor_RecipI,
                machineId: Mod_Ids.Machines.SteamLowToHi_Machine)
            .SetDuration(15.Seconds())
            .AddInput(4,Ids.Products.SteamLo)
            .AddOutput(2, Ids.Products.SteamHi,"X", outputAtStart: true)
            .AddOutput(2, Ids.Products.Water, "Y", outputAtStart: true)
            .BuildAndAdd();


        // Improved scrap smelting
        registrator.RecipeProtoBuilder
			.Start(name: "Improved Scrap smelting",
				recipeId: Mod_Ids.Recipes.BetterIronScrapSmeltingT1,
				machineId: Ids.Machines.SmeltingFurnaceT1)
			.AddInput(8, Ids.Products.IronScrap)
			.AddInput(2, Ids.Products.Coal)
			.SetDuration(20.Seconds())
			.AddOutput(0, Ids.Products.Slag,"*",false,true)
			.AddOutput(8,Ids.Products.MoltenIron)
			.AddOutput(4, Ids.Products.Exhaust, outputAtStart: true)
			.BuildAndAdd();

        
        registrator.RecipeProtoBuilder
            .Start(name: "Improved Scrap smelting",
                recipeId: Mod_Ids.Recipes.BetterIronScrapSmeltingT2,
                machineId: Ids.Machines.SmeltingFurnaceT2)
            .AddInput(16, Ids.Products.IronScrap)
            .AddInput(4, Ids.Products.Coal)
            .SetDuration(20.Seconds())
            .AddOutput(0, Ids.Products.Slag,"*",false,true)
            .AddOutput(16, Ids.Products.MoltenIron)
            .AddOutput(8, Ids.Products.Exhaust, outputAtStart: true)
            .BuildAndAdd();

        registrator.RecipeProtoBuilder
            .Start(name: "Improved Scrap smelting",
                recipeId: Mod_Ids.Recipes.BetterCopperScrapSmeltingT1,
                machineId: Ids.Machines.SmeltingFurnaceT1)
            .AddInput(8, Ids.Products.CopperScrap)
            .AddInput(2, Ids.Products.Coal)
            .SetDuration(20.Seconds())
            .AddOutput(0, Ids.Products.Slag, "*", false, true)
            .AddOutput(8, Ids.Products.MoltenCopper)
            .AddOutput(4, Ids.Products.Exhaust, outputAtStart: true)
            .BuildAndAdd();

        registrator.RecipeProtoBuilder
            .Start(name: "Improved Scrap smelting",
                recipeId: Mod_Ids.Recipes.BetterCopperScrapSmeltingT2,
                machineId: Ids.Machines.SmeltingFurnaceT2)
            .AddInput(16, Ids.Products.CopperScrap)
            .AddInput(4, Ids.Products.Coal)
            .SetDuration(20.Seconds())
            .AddOutput(0, Ids.Products.Slag, "*", false, true)
            .AddOutput(16, Ids.Products.MoltenCopper)
            .AddOutput(8, Ids.Products.Exhaust, outputAtStart: true)
            .BuildAndAdd();
    }


}