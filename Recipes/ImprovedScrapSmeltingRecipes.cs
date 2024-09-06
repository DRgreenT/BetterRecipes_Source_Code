using Mafi.Base;
using Mafi.Core.Mods;
using Mafi;
using static BetterRecipes.BetterRecipes;

namespace BetterRecipes.Recipes;
internal class ImprovedScrapSmeltingRecipes : IModData
{
    	public void RegisterData(ProtoRegistrator registrator)
        {
        // Improved scrap smelting
        registrator.RecipeProtoBuilder
            .Start(name: "Improved Scrap smelting",
                recipeId: NewModIDs.Recipes.BetterIronScrapSmeltingT1,
                machineId: Ids.Machines.SmeltingFurnaceT1)
            .AddInput(8, Ids.Products.IronScrap)
            .AddInput(2, Ids.Products.Coal)
            .SetDuration(20.Seconds())
            .AddOutput(0, Ids.Products.Slag, "*", false, true)
            .AddOutput(8, Ids.Products.MoltenIron)
            .AddOutput(4, Ids.Products.Exhaust, outputAtStart: true)
            .BuildAndAdd();


        registrator.RecipeProtoBuilder
            .Start(name: "Improved Scrap smelting",
                recipeId: NewModIDs.Recipes.BetterIronScrapSmeltingT2,
                machineId: Ids.Machines.SmeltingFurnaceT2)
            .AddInput(16, Ids.Products.IronScrap)
            .AddInput(4, Ids.Products.Coal)
            .SetDuration(20.Seconds())
            .AddOutput(0, Ids.Products.Slag, "*", false, true)
            .AddOutput(16, Ids.Products.MoltenIron)
            .AddOutput(8, Ids.Products.Exhaust, outputAtStart: true)
            .BuildAndAdd();

        registrator.RecipeProtoBuilder
            .Start(name: "Improved Scrap smelting",
                recipeId: NewModIDs.Recipes.BetterCopperScrapSmeltingT1,
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
                recipeId: NewModIDs.Recipes.BetterCopperScrapSmeltingT2,
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
