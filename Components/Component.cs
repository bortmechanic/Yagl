/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable UnusedType.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable AutoPropertyCanBeMadeGetOnly.Global
// ReSharper disable VirtualMemberNeverOverridden.Global
// ReSharper disable UnusedParameter.Global

using System;

namespace Yagl.Components
{
    public class Component
    {
        #region Public Fields

        public long Id { get; }

        public string Name
        {
            get => _name ?? $"Component #{Id.ToString()}";
            set => _name = value;
        }
        
        public ComponentState State { get; internal set; }

        public bool IsEnabled { get; set; }
        
        public bool IsVisible { get; set; }
        
        public int UpdateOrder { get => _updateOrder; set => ChangeUpdateOrder(value); }
        
        public int DrawOrder { get => _drawOrder; set => ChangeDrawOrder(value); }

        public readonly Collection Components;

        #endregion

        #region Protected Fields

        protected internal Context Context { get; internal set; }

        #endregion

        #region Private Fields

        private string _name;
        private int _updateOrder;
        private int _drawOrder;

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
            Components = new Collection(this);
            State = ComponentState.New;
            Console.WriteLine($"COMPONENT '{Name}' CREATED.");
        }

        internal Component(Context context) : this()
        {
            Context = context;
        }

        #endregion

        #region Component Life Cycle Events

        protected virtual void Initialize()
        {
            Console.WriteLine($"COMPONENT '{Name}' INITIALIZE.");
        }

        protected virtual void LoadContent()
        {
            Console.WriteLine($"COMPONENT '{Name}' LOAD CONTENT.");
        }

        protected virtual void Update(Time time)
        {
            Console.WriteLine($"COMPONENT '{Name}' UPDATE.");
        }

        protected virtual void Draw(Time time)
        {
            Console.WriteLine($"COMPONENT '{Name}' DRAW.");
        }

        protected virtual void UnloadContent()
        {
            Console.WriteLine($"COMPONENT '{Name}' UNLOAD CONTENT.");
        }

        protected virtual void ShutDown()
        {
            Console.WriteLine($"COMPONENT '{Name}' SHUTDOWN.");
        }

        #endregion
        
        #region Component Life Cycle Triggers

        internal void InitializeInternal()
        {
            if (State != ComponentState.New)
                throw new InvalidOperationException($"Can't initialize component '{Name}' because it is not in state '{ComponentState.New}'. Actual state of the component is '{State}'.");
            State = ComponentState.Initializing;
            Initialize();
            LoadContent();
            State = ComponentState.Active;
        }
        
        internal void UpdateInternal(Time time, bool recursive)
        {
            if (!IsEnabled) return;
            Update(time);
            if (recursive)
                foreach (var sub in Components.ActiveComponents)
                    sub.UpdateInternal(time, true);
        }
        
        internal void DrawInternal(Time time, bool recursive)
        {
            if (!IsVisible) return;
            Draw(time);
            if (recursive)
                foreach (var sub in Components.VisualComponents)
                    sub.DrawInternal(time, true);
        }
        
        internal void ShutDownInternal()
        {
            if (State != ComponentState.Active)
                throw new InvalidOperationException($"Can't shut down component '{Name}' because it is not in state '{ComponentState.Active}'. Actual state of the component is '{State}'.");
            State = ComponentState.ShuttingDown;
            UnloadContent();
            ShutDown();
            State = ComponentState.Disposed;
        }
        
        #endregion
        
        #region Draw / Update Order Change Logic

        private void ChangeUpdateOrder(int newOrder)
        {
            if (State == ComponentState.Active)
                Context.ChangeManager.RegisterUpdateOrderChange(this, newOrder);
            else
                _updateOrder = newOrder;
        }
        
        private void ChangeDrawOrder(int newOrder)
        {
            if (State == ComponentState.Active)
                Context.ChangeManager.RegisterDrawOrderChange(this, newOrder);
            else
                _drawOrder = newOrder;
        }
        
        internal void ChangeUpdateOrderInternal(int newOrder)
        {
            if (newOrder == UpdateOrder) return;
            _updateOrder = newOrder;
            Components.SortOrderedCollections();
        }

        internal void ChangeDrawOrderInternal(int newOrder)
        {
            if (newOrder == DrawOrder) return;
            _drawOrder = newOrder;
            Components.SortOrderedCollections();
        }
        
        #endregion
    }
}