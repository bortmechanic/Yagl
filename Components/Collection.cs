// ReSharper disable UnusedMember.Global

using System;
using System.Collections;
using System.Collections.Generic;

namespace Yagl.Components
{
    public class Collection : IEnumerable<Component>
    {
        #region Public Fields / Properties

        public int Count => _components.Count;

        #endregion

        #region Private Fields

        private readonly Component _component;
        private readonly List<Component> _components;
        internal readonly List<Component> ActiveComponents;
        internal readonly List<Component> VisualComponents;

        #endregion
        
        #region Constructor(s)

        internal Collection(Component component)
        {
            _component = component ?? throw new ArgumentException($"Parameter {nameof(component)} should not be null.",
                nameof(component));
            _components = new List<Component>();
            ActiveComponents = new List<Component>();
            VisualComponents = new List<Component>();
        }

        #endregion
        
        #region Elements Manipulation

        public void Add(Component component)
        {
            if (component.State != ComponentState.New)
                throw new InvalidOperationException(
                    $"Can't add component '{component.Name}' to the children collection of the component '{_component.Name}' because it is not in state '{ComponentState.New}'. Actual state of the component being added is '{component.State}'.");
            component.Context = _component.Context;
            _component.Context.ChangeManager.RegisterAddChange(this, component);
        }

        public void Remove(Component component)
        {
            if (component.State != ComponentState.Active)
                throw new InvalidOperationException(
                    $"Can't remove component '{component.Name}' from the children collection of the component '{_component.Name}' because it is not in state '{ComponentState.Active}'. Actual state of the component being added is '{component.State}'.");
            foreach (var sub in component.Components)
                component.Components.Remove(sub);
            _component.Context.ChangeManager.RegisterRemoveChange(this, component);
        }
        
        #endregion

        #region Enumerable

        public IEnumerator<Component> GetEnumerator()
        {
            return _components.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable) _components).GetEnumerator();
        }
        
        #endregion
        
        #region Add / Remove Implementation

        internal void AddInternal(Component component)
        {
            component.InitializeInternal();
            _components.Add(component);
            ActiveComponents.Add(component);
            VisualComponents.Add(component);
        }

        internal void RemoveInternal(Component component)
        {
            component.ShutDownInternal();
            _components.Remove(component);
            ActiveComponents.Remove(component);
            VisualComponents.Remove(component);
            component.Context = null;
        }
        
        internal void SortOrderedCollections()
        {
            ActiveComponents.Sort(ActiveComponentsSortComparerInstance);
            VisualComponents.Sort(VisualComponentsSortComparerInstance);
        }
        
        private static readonly ActiveComponentsSortComparer ActiveComponentsSortComparerInstance = new ActiveComponentsSortComparer();
        private class ActiveComponentsSortComparer : IComparer<Component>
        {
            public int Compare(Component x, Component y)
            {
                var result = x?.UpdateOrder ?? 0 - y?.UpdateOrder ?? 0;
                if (result == 0)
                    result = (int)(x?.Id ?? 0 - y?.Id ?? 0);
                return result;
            }
        }

        private static readonly VisualComponentsSortComparer VisualComponentsSortComparerInstance = new VisualComponentsSortComparer();
        private class VisualComponentsSortComparer : IComparer<Component>
        {
            public int Compare(Component x, Component y)
            {
                var result = x?.DrawOrder ?? 0 - y?.DrawOrder ?? 0;
                if (result == 0)
                    result = (int)(x?.Id ?? 0 - y?.Id ?? 0);
                return result;
            }
        }

        #endregion
    }
}