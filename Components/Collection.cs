// ReSharper disable UnusedMember.Global

using System;
using System.Collections.Generic;

namespace Yagl.Components
{
    public class Collection
    {
        #region Public Fields / Properties

        public int Count => _components.Count;

        #endregion

        #region Private Fields

        private readonly Component _component;
        private readonly List<Component> _components;

        #endregion
        
        #region Constructor(s)

        internal Collection(Component component)
        {
            _component = component ?? throw new ArgumentException($"Parameter {nameof(component)} should not be null.",
                nameof(component));
            _components = new List<Component>();
        }

        #endregion
        
        #region Elements Manipulation.

        public void Add(Component component)
        {
            _components.Add(component);
        }

        public void Remove(Component component)
        {
            _components.Remove(component);
        }

        #endregion
    }
}