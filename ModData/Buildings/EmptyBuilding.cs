using Mafi.Base;
using Mafi.Core.Mods;
using Mafi.Core.Entities.Static.Layout;
using Mafi;


namespace BetterRecipes.ModData.Buildings;
internal class EmptyBuilding : IModData
{
    private readonly int mod = ModDebug.SetValuesToZero();
    public void RegisterData(ProtoRegistrator registrator)
    {

    }

}
