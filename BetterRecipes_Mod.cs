﻿using Mafi;
using Mafi.Base;
using Mafi.Core;
using Mafi.Core.Mods;
using Mafi.Collections;
using Mafi.Core.Game;
using System;
using Mafi.Core.Prototypes;
using BetterRecipes.ModData;


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
            //Register buildings
            registrator.RegisterData<ModData.Buildings.EmptyBuilding>();//Placeholder
            
            //Register machines
            registrator.RegisterData<ModData.Machines.SolarThermalGeneratorMachine>();
            registrator.RegisterData<ModData.Machines.SteamCompressorMachine>();

            //Register recipes
            registrator.RegisterData<ModData.Recipes.SteamCompressionRecipes>();
            registrator.RegisterData<ModData.Recipes.SolarThermalSteamRecipes>();
            registrator.RegisterData<ModData.Recipes.ImprovedScrapSmeltingRecipes>();
            
            //Register products
            //registrator.RegisterData<ModData.Products.FluidProducts>(); //Placeholder
            
            //Register research
            registrator.RegisterData<ModData.Research.ImprovedScrapSmeltingResearch>();
            registrator.RegisterData<ModData.Research.SolarThermalSteamResearch>();
            
            //Register edicts
            registrator.RegisterData<ModData.Edicts.EmptyEdict>(); //Placeholder
        }
        public new void RegisterDependencies(DependencyResolverBuilder depBuilder, ProtosDb protosDb, bool wasLoaded)
        {
        }

        private void InitializePatchers(DependencyResolver resolver)
        {
        }
    }
    public class ModDebug
    {      
        
        public static int SetValuesToZero(bool isDebugMode = true)
        {
            if (isDebugMode)
            {
                return 0;
            }
            return 1;
        }
    }

}