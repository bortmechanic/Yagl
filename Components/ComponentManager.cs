namespace Yagl.Components
{
    internal static class ComponentManager
    {
        #region Component Life Cycle Triggers
        
        internal static void Initialize(Component component)
        {
            if (component.State != ComponentState.New) return;
            component.State = ComponentState.Initializing;
            component.Initialize();
            component.State = ComponentState.Active;
        }
        
        internal static void LoadContent(Component component)
        {
            if (component.State != ComponentState.Active) return;
            component.LoadContent();
        }
        
        internal static void Update(Component component, Time time)
        {
            if (!component.IsEnabled) return;
            component.Update(time);
        }
        
        internal static void Draw(Component component, Time time)
        {
            if (!component.IsVisible) return;
            component.Draw(time);
        }
        
        internal static void UnloadContent(Component component)
        {
            if (component.State != ComponentState.Active) return;
            component.UnloadContent();
        }

        internal static void ShutDown(Component component)
        {
            if (component.State != ComponentState.Active) return;
            component.State = ComponentState.ShuttingDown;
            component.ShutDown();
            component.State = ComponentState.Disposed;
        }

        #endregion
    }
}