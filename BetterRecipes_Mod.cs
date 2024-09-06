using Mafi;
using Mafi.Base;
using Mafi.Core;
using Mafi.Core.Mods;
using MachineID = Mafi.Core.Factory.Machines.MachineProto.ID;
using Mafi.Core.Research;
using ResNodeID = Mafi.Core.Research.ResearchNodeProto.ID;
using RecipeID = Mafi.Core.Factory.Recipes.RecipeProto.ID;
using Mafi.Collections;
using Mafi.Core.Game;
using System;
using Mafi.Core.Prototypes;
using Mafi.Core.Factory.Machines;

namespace BetterRecipes 
{ 
    public sealed class BetterRecipes : DataOnlyMod 
    {       
        public new bool IsUiOnly => false;
        public override string Name => "BetterRecipes";
        public override int Version => 1;

        public static Version ModVersion = new Version(0, 0, 1);
        public void _BetterRecipes(CoreMod coreMod, BaseMod baseMod)
        {

            // You can use Log class for logging. These will be written to the log file
            // and can be also displayed in the in-game console with command `also_log_to_console`.
            Log.Info("ExampleMod: constructed");
        }
        public new void Initialize(DependencyResolver resolver, bool gameWasLoaded)
        {

        }

        public void ChangeConfigs(Lyst<IConfig> configs)
        {
        }
        public override void RegisterPrototypes(ProtoRegistrator registrator)
        {
            registrator.RegisterAllProducts();
            //Register machines
            registrator.RegisterData<Machines.SolarThermalGeneratorMachine>();
            registrator.RegisterData<Machines.SteamCompressorMachine>();

            //Register recipes
            registrator.RegisterData<Recipes.SteamCompressionRecipes>();
            registrator.RegisterData<Recipes.SolarThermalSteamRecipes>();
            registrator.RegisterData<Recipes.ImprovedScrapSmeltingRecipes>();

            //Register research
            registrator.RegisterData<Research.ImprovedScrapSmeltingResearch>();
            registrator.RegisterData<Research.SolarThermalSteamResearch>();
        }
        public new void RegisterDependencies(DependencyResolverBuilder depBuilder, ProtosDb protosDb, bool wasLoaded)
        {
        }

        private void InitializePatchers(DependencyResolver resolver)
        {
        }


        public static class NewModIDs
	    {
            public partial class Research
            {
                public static readonly ResNodeID SolarThermalSteamT1_Research = Ids.Research.CreateId("SolarThermalSteamT1_Research");
                public static readonly ResNodeID ImprovedScrapSmeltingT1_Research = Ids.Research.CreateId("ImprovedScrapSmeltingT1_Research");
                public static readonly ResNodeID ImprovedScrapSmeltingT2_Research = Ids.Research.CreateId("ImprovedScrapSmeltingT2_Research");
            }
            public partial class Buildings
            {

            }
            public partial class Machines
		    {
                    public static readonly MachineID SolarThermalSteamGenerator_Machine = Ids.Machines.CreateId("SteamGenerator");
                    public static readonly MachineID SteamLowToHi_Machine = Ids.Machines.CreateId("SteamLowToHi_Machine");
            }

            public partial class Recipes
            {
                    public static readonly RecipeID ImprovedIronScrapSmeltingT1 = Ids.Recipes.CreateId("ImprovedIronScrapSmeltingT1");
                    public static readonly RecipeID ImprovedIronScrapSmeltingT2 = Ids.Recipes.CreateId("ImprovedIronScrapSmeltingT2");
                    public static readonly RecipeID ImprovedCopperScrapSmeltingT1 = Ids.Recipes.CreateId("ImprovedCopperScrapSmeltingT1");
                    public static readonly RecipeID ImprovedCopperScrapSmeltingT2 = Ids.Recipes.CreateId("ImprovedCopperScrapSmeltingT2");

                    public static readonly RecipeID SolarThermalSteamT1_Recipes = Ids.Recipes.CreateId("SolarThermalSteamT1_Recipes");
                    public static readonly RecipeID SteamCompressorT1_toSteamLow_Recipes = Ids.Recipes.CreateId("SteamCompressorT1_toSteamLow_Recipes");
                    public static readonly RecipeID SteamCompressorT1_toSteamHi_Recipes = Ids.Recipes.CreateId("SteamCompressorT1_Recipes");
            }
            public partial class Products
            {

            }
            public partial class Edicts
            {

            }
        }

    }
}