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

    public interface IContent
    {
        void LoadContent();
        void UnloadContent();
    }
}