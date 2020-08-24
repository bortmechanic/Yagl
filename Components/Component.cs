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
        
        public ComponentState State { get; private set; }

        public bool IsEnabled { get; set; }
        
        public bool IsVisible { get; set; }
        
        public int UpdateOrder { get; set; }
        
        public int DrawOrder { get; set; }

        #endregion

        #region Protected Fields

        protected internal Context Context { get; internal set; }

        #endregion

        #region Private Fields

        private string _name;

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
            if (State != ComponentState.New) return;
            State = ComponentState.Initializing;
            Initialize();
            State = ComponentState.Active;
        }
        
        internal void LoadContentInternal()
        {
            if (State != ComponentState.Active) return;
            LoadContent();
        }
        
        internal void UpdateInternal(Time time)
        {
            if (!IsEnabled) return;
            Update(time);
        }
        
        internal void DrawInternal(Time time)
        {
            if (!IsVisible) return;
            Draw(time);
        }
        
        internal void UnloadContentInternal()
        {
            if (State != ComponentState.Active) return;
            UnloadContent();
        }

        internal void ShutDownInternal()
        {
            if (State != ComponentState.Active) return;
            State = ComponentState.ShuttingDown;
            ShutDown();
            State = ComponentState.Disposed;
        }

        #endregion
    }
}