using Mafi.Core.GameLoop;
using Mafi.Localization;
using Mafi.Unity;
using Mafi.Unity.InputControl.Toolbar;
using Mafi.Unity.UiFramework;
using Mafi.Unity.UiFramework.Components;
using Mafi.Unity.UserInterface;
using UnityEngine;
using Mafi.Unity.InputControl;
using System;
using BetterRecipes.ModData.UI;


namespace BetterRecipes.ModData.UI
{
    public class MyWindowView : Mafi.Unity.UserInterface.WindowView
    {
        private StackContainer _windowContent;

        public MyWindowView() : base("MyWindowView")
        {
        }

        protected override void BuildWindowContent()
        {
            // Set the title of the window
            SetTitle(new LocStrFormatted("My Window"));

            // Set the size of the window
            var size = new Vector2(400f, 300f);
            SetContentSize(size);

            // Center the window on the screen
            PositionSelfToCenter();

            // Make the window movable
            MakeMovable();

            // Create a stack container for the window's content
            _windowContent = Builder.NewStackContainer("MyStackContainer")
                .SetStackingDirection(StackContainer.Direction.TopToBottom)
                .SetSizeMode(StackContainer.SizeMode.Dynamic);

            // Add the stack container to the window's content panel
            _windowContent.PutTo(GetContentPanel());
        }
    }

    public class MyWindowController : BaseWindowController<MyWindowView>, IToolbarItemController
    {
        public bool IsVisible => true;
        public bool DeactivateShortcutsIfNotVisible => false;
        public event Action<IToolbarItemController> VisibilityChanged;

        public MyWindowController(
            IUnityInputMgr inputManager,
            IGameLoopEvents gameLoop,
            UiBuilder builder,
            MyWindowView emptyWindowView,
            ToolbarController toolbarController,
            ControllerConfig? config = null)
            : base(inputManager, gameLoop, builder, emptyWindowView, config)
        {
            // Initialize any additional properties or fields if needed
        }

        public void RegisterIntoToolbar(ToolbarController toolbar)
        {
            //toolbar.AddMainMenuButton(
            //    "My Empty Window",
            //    this,
            //    string.Empty, // Use an empty icon path for testing
            //    1000f,
            //    _ => KeyBindings.FromKey(KbCategory.Tools, ShortcutMode.Game, KeyCode.F8)
            //);
        }
    }
}
