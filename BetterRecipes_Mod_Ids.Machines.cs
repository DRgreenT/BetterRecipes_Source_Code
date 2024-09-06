using Mafi.Base;
using MachineID = Mafi.Core.Factory.Machines.MachineProto.ID;

namespace BetterRecipes;

public partial class Mod_Ids
{

	public partial class Machines {

		public static readonly MachineID SolarThermalSteamGenerator_Machine = Ids.Machines.CreateId("SteamGenerator");
        public static readonly MachineID SteamLowToHi_Machine = Ids.Machines.CreateId("SteamLowToHi_Machine");

    }

}