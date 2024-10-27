using Mafi.Base;
using Mafi.Core.Mods;
using Mafi;
using System;
using System.Reflection;
using Mafi.Core.Products;
using RecipeID = Mafi.Core.Factory.Recipes.RecipeProto.ID;

namespace BetterRecipes.ModData.Recipes
{
    internal class LittleCheaterRecipes : IModData
    {
        private static int recipeCounter = 0;

        // Create a new RecipeID with a unique name
        public static RecipeID CreateNewRecipeId(string productName)
        {
            recipeCounter++;
            return Ids.Recipes.CreateId($"{productName}_cheat_{recipeCounter}");
        }

        public void RegisterData(ProtoRegistrator registrator)
        {
            // Loop through all products to recipes
            Type type = typeof(Ids.Products);
            FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.Static);

            foreach (var field in fields)
            {
                // Check if the field has the VirtualProduct attribute
                if (!Attribute.IsDefined(field, typeof(VirtualProductAttribute)))
                {
                    // Retrieve the value of the field
                    var productId = field.GetValue(null);

                    // Ensure that productId is of type ProductProto.ID
                    if (productId is ProductProto.ID id)
                    {
                        string productName = field.Name; // Get the product name from the field name

                        registrator.RecipeProtoBuilder
                            .Start(name: productName,
                                   recipeId: CreateNewRecipeId(productName),
                                   machineId: NewMod_IDs.Machines.LittleCheaterGenerator)
                            .SetDuration(25.Seconds())
                            .AddOutput(450, id, "*", true, false)
                            .BuildAndAdd();

                        registrator.RecipeProtoBuilder
                            .Start(name: productName,
                                   recipeId: CreateNewRecipeId(productName),
                                   machineId: NewMod_IDs.Machines.LittleCheaterSink)
                            .SetDuration(25.Seconds())
                            .AddInput(450, id)
                            .BuildAndAdd();
                    }
                }
            }
        }
    }
}
