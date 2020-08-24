namespace Yagl.Components
{
    public interface IVisual
    {
        void Draw(Time time);
    }

    public interface IActive
    {
        void Update(Time time);
    }

    public interface IHasContent
    {
        void LoadContent();
        void UnloadContent();
    }

    public interface INeedsInitialization
    {
        void Initialize();
    }

    public interface INeedsShuttingDown
    {
        void ShutDown();
    }
}