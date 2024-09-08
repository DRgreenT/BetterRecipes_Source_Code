
using Mafi.Core.Mods;
using static BetterRecipes.BetterRecipes;

namespace BetterRecipes.ModData.Edicts;
internal class EmptyEdict : IModData
{
    private readonly int mod = ModDebug.SetValuesToZero();
    public void RegisterData(ProtoRegistrator registrator)
    {

    }

}
