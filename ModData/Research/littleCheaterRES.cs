using Mafi;
using Mafi.Base;
using Mafi.Core.Mods;
using Mafi.Core.Research;
using ResNodeID = Mafi.Core.Research.ResearchNodeProto.ID;

namespace BetterRecipes.ModData.Research
{
    internal class littleCheaterRES : IResearchNodesData
    {
        private readonly int mod = ModDebug.SetValuesToZero(true);

        // This is your unique research node ID
        public static readonly ResNodeID littleCheaterReS = Ids.Research.CreateId("littleCheaterReS");

        public void RegisterData(ProtoRegistrator registrator)
        {
            string description = "A little Cheating ^^";

            // Start building the research node using the unique ID
            ResearchNodeProto node_Cheat = registrator.ResearchNodeProtoBuilder
                .Start("Cheat...", littleCheaterReS)  // Use the generated ID here
                .Description(description)
                .AddMachineToUnlock(NewMod_IDs.Machines.LittleCheaterGenerator)
                .AddMachineToUnlock(NewMod_IDs.Machines.LittleCheaterSink)
                .AddAllRecipesOfMachineToUnlock(NewMod_IDs.Machines.LittleCheaterGenerator)
                .AddAllRecipesOfMachineToUnlock(NewMod_IDs.Machines.LittleCheaterSink)
                .SetCosts(new ResearchCostsTpl(9999 * mod))
                .AddParents(/* Add any parent nodes if necessary */)
                .BuildAndAdd();

            // Set the grid position
            node_Cheat.GridPosition = new Vector2i(4, 5);
                        
        }
    }
}
