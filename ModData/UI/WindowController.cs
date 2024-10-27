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


namespace MyModNamespace.UI
{
    public class MyEmptyWindowView : WindowView
    {
        private StackContainer _windowContent;

        public MyEmptyWindowView() : base("MyEmptyWindowView")
        {
        }

        protected override void BuildWindowContent()
        {
            // Set the title of the window
            SetTitle(new LocStrFormatted("My Empty Window"));

            // Set the size of the window
            var size = new Vector2(400f, 300f);
            SetContentSize(size);

            // Center the window on the screen
            PositionSelfToCenter();

            // Make the window movable
            MakeMovable();

            // Create a stack container for the window's content
            _windowContent = Builder.NewStackContainer("MyEmptyStackContainer")
                .SetStackingDirection(StackContainer.Direction.TopToBottom)
                .SetSizeMode(StackContainer.SizeMode.Dynamic);

            // Add the stack container to the window's content panel
            _windowContent.PutTo(GetContentPanel());
        }
    }

    public class MyEmptyWindowController : BaseWindowController<MyEmptyWindowView>, IToolbarItemController
    {
        private readonly ToolbarController _toolbarController;

        public MyEmptyWindowController(
            IUnityInputMgr inputManager,
            IGameLoopEvents gameLoop,
            UiBuilder builder,
            MyEmptyWindowView emptyWindowView,
            ToolbarController toolbarController,
            ControllerConfig? config = null)
            : base(inputManager, gameLoop, builder, emptyWindowView, config)
        {
            _toolbarController = toolbarController;
        }

        // Implement the IToolbarItemController interface
        public bool IsVisible => true;

        public bool DeactivateShortcutsIfNotVisible => false;

        public event Action<IToolbarItemController> VisibilityChanged;

        // Implement the method from IToolbarItemRegistrar
        public void RegisterIntoToolbar(ToolbarController toolbar)
        {
            // Add a button to the main menu using the ToolbarController
            toolbar.AddMainMenuButton(
                "My Empty Window",
                this,
                "Assets/MyModNamespace/Icons/EmptyWindowIcon.png", // Replace with the correct icon path
                1000f,
                _ => KeyBindings.FromKey(KbCategory.Tools, ShortcutMode.Game, KeyCode.F8) // Opens the window with F8 key
            );
        }
    }
}
