using Mafi;
using Mafi.Base;
using Mafi.Core.Mods;
using Mafi.Core.Research;
using static BetterRecipes.BetterRecipes;

namespace BetterRecipes.Research;
internal class ImprovedScrapSmeltingResearch : IResearchNodesData
{ 
    public void RegisterData(ProtoRegistrator registrator)
    {

        string Discription = "Makes scrap smelting more efficient by reducing the amount of coal needed per cycle";

        ResearchNodeProto nodeProto_ImprovedSmeltingT1 = registrator.ResearchNodeProtoBuilder
            .Start("Improved scrap smelting I", NewModIDs.Research.ImprovedScrapSmeltingT1_Research)
            .Description(Discription)
            .AddRecipeToUnlock(NewModIDs.Recipes.ImprovedIronScrapSmeltingT1)
            .AddRecipeToUnlock(NewModIDs.Recipes.ImprovedCopperScrapSmeltingT1)
            .AddProductIcon(Ids.Products.IronScrap)
            .AddProductIcon(Ids.Products.CopperScrap)
            .SetCosts(new ResearchCostsTpl(6))
            .AddParents(registrator.PrototypesDb.GetOrThrow<ResearchNodeProto>(Ids.Research.CopperRefinement), registrator.PrototypesDb.GetOrThrow<ResearchNodeProto>(Ids.Research.VehicleAndMining))
            .BuildAndAdd();
        nodeProto_ImprovedSmeltingT1.GridPosition = new Vector2i(16, 5);

        ResearchNodeProto nodeProto_ImprovedSmeltingT2 = registrator.ResearchNodeProtoBuilder
            .Start("Improved scrap smelting II", NewModIDs.Research.ImprovedScrapSmeltingT2_Research)
            .Description(Discription)
            .AddRecipeToUnlock(NewModIDs.Recipes.ImprovedIronScrapSmeltingT2)
            .AddRecipeToUnlock(NewModIDs.Recipes.ImprovedCopperScrapSmeltingT2)
            .AddProductIcon(Ids.Products.IronScrap)
            .AddProductIcon(Ids.Products.CopperScrap)
            .SetCosts(new ResearchCostsTpl(18))
            .AddParents(registrator.PrototypesDb.GetOrThrow<ResearchNodeProto>(Ids.Research.AdvancedSmelting))
            .BuildAndAdd();
        nodeProto_ImprovedSmeltingT2.GridPosition = new Vector2i(80, 14);

    }
}
