// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable UnusedType.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable AutoPropertyCanBeMadeGetOnly.Global

namespace Yagl.Components
{
    public abstract class Component
    {
        #region Public Fields
        
        public long Id { get; }
        public string Name { get; set; }
        public bool IsEnabled { get; set; }
        public bool IsVisible { get; set; }
        public int UpdateOrder { get; set; }
        public int DrawOrder { get; set; }

        #endregion
        
        #region Protected Fields
        
        // protected internal Context Context { get; internal set; };
        
        #endregion
        
        #region Constructor(s)

        protected Component()
        {
            Id = IdGenerator.Generate();
            Name = null;
            IsEnabled = true;
            IsVisible = true;
            UpdateOrder = 0;
            DrawOrder = 0;
        }
        
        #endregion
    }
}