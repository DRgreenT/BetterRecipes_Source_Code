﻿using Mafi.Base;
using ResNodeID = Mafi.Core.Research.ResearchNodeProto.ID;
using RecipeID = Mafi.Core.Factory.Recipes.RecipeProto.ID;
using MachineID = Mafi.Core.Factory.Machines.MachineProto.ID;
using ProductID = Mafi.Core.Products.ProductProto.ID;

namespace BetterRecipes.ModData
{
        public static class NewMod_IDs
        {
        public partial class Research
            {
                public static readonly ResNodeID SolarThermalSteamT1_Research = Ids.Research.CreateId("SolarThermalSteamT1_Research");
                public static readonly ResNodeID ImprovedScrapSmeltingT1_Research = Ids.Research.CreateId("ImprovedScrapSmeltingT1_Research");
                public static readonly ResNodeID ImprovedScrapSmeltingT2_Research = Ids.Research.CreateId("ImprovedScrapSmeltingT2_Research");
                public static readonly ResNodeID littleCheaterGeneratorReS = Ids.Research.CreateId("littleCheaterGeneratorReS");
                public static readonly ResNodeID littleCheaterSinkReS = Ids.Research.CreateId("littleCheaterSinkReS");
        }
        public partial class Buildings
            {

            }
            public partial class Machines
            {
                public static readonly MachineID SolarThermalSteamGenerator_Machine = Ids.Machines.CreateId("SteamGenerator");
                public static readonly MachineID SteamCompressor = Ids.Machines.CreateId("SteamLowToHi_Machine");
                public static readonly MachineID LittleCheaterGenerator = Ids.Machines.CreateId("LittleCheaterGenerator");
                public static readonly MachineID LittleCheaterSink = Ids.Machines.CreateId("LittleCheaterSink");



        }

            public partial class Recipes
            {
                public static readonly RecipeID ImprovedIronScrapSmeltingT1 = Ids.Recipes.CreateId("ImprovedIronScrapSmeltingT1");
                public static readonly RecipeID ImprovedIronScrapSmeltingT2 = Ids.Recipes.CreateId("ImprovedIronScrapSmeltingT2");
                public static readonly RecipeID ImprovedCopperScrapSmeltingT1 = Ids.Recipes.CreateId("ImprovedCopperScrapSmeltingT1");
                public static readonly RecipeID ImprovedCopperScrapSmeltingT2 = Ids.Recipes.CreateId("ImprovedCopperScrapSmeltingT2");

                // new recipes for T2 furnace to also be able to use uncrushed ore

                public static readonly RecipeID SolarThermalSteamT1_Recipes = Ids.Recipes.CreateId("SolarThermalSteamT1_Recipes");
                public static readonly RecipeID SteamCompressorRecipes = Ids.Recipes.CreateId("SteamCompressor_Recipes");

                //public static readonly RecipeID littleCheaterRecipes = Ids.Recipes.CreateId("littleCheaterRecipes");

        }
            public partial class Products
            {

            [FluidProduct(color: 0x5e98eb, icon: "Assets/CoI BetterRecipes Mod/Icons/ProductIcons/SteamWetProduct.png")]
            public static readonly ProductID SteamWetProduct = Ids.Products.CreateId("WetSteam");


            // Products proto registrations can be done either by manually constructing and registering
            // `ProductProto` variants or by defining IDs and marking them with one of following attributes:
            // CountableProduct, FluidProduct, LooseProduct, MoltenProduct, or VirtualProduct.
            // These static IDs are then automatically registered via `registrator.RegisterAllProducts()`.
            /*
                [CountableProduct(icon: Assets.Base.Products.Icons.Wood_svg,
                    prefab: Assets.Base.Products.Countable.RawWood_prefab)]
                public static readonly ProductID ExampleUnitProduct = Ids.Products.CreateId("ExampleUnitProduct");

                [FluidProduct(color: 0xFF00FF, icon: Assets.Base.Products.Icons.Water_svg)]
                public static readonly ProductID ExampleFluidProduct = Ids.Products.CreateId("ExampleFluidProduct");

                [LooseProduct(material: Assets.Base.Products.Loose.Dirt_mat,
                    icon: Assets.Base.Products.Icons.Dirt_svg, dumpByDefault: true)]
                public static readonly ProductID ExampleLooseProduct = Ids.Products.CreateId("ExampleLooseProduct");
                // This makes the loose product dumpable.
                [ProtoParamFor(nameof(ExampleLooseProduct))]
                public static readonly LooseProductParam ExampleLooseProductParams = new(dumpAs: Ids.TerrainMaterials.Dirt);

                [MoltenProduct(material: Assets.Base.Products.Molten.Copper_mat,
                    prefab: Assets.Base.Products.Molten.MoltenCopper_prefab,
                    icon: Assets.Base.Products.Icons.CopperMolten_svg)]
                public static readonly ProductID ExampleMoltenProduct = Ids.Products.CreateId("ExampleMoltenProduct");
            */
        }

        public partial class Edicts
            {

            }
        }
    
}
