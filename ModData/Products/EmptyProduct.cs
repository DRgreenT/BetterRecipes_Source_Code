using Mafi.Base;
using Mafi.Core.Mods;
using Mafi.Core.Entities.Static.Layout;
using Mafi;
using static BetterRecipes.BetterRecipes;

namespace BetterRecipes.ModData.Products;
internal class EmptyProduct : IModData
{
    private readonly int mod = ModDebug.SetValuesToZero();
    public void RegisterData(ProtoRegistrator registrator)
    {

    }
}
