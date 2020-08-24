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
            Console.WriteLine($"COMPONENT '{Name}' CREATED.");
        }

        internal Component(Context context) : this()
        {
            Context = context;
        }

        #endregion

        #region Component Life Cycle Events
        
        public virtual void Initialize()
        {
            Console.WriteLine($"COMPONENT '{Name}' INITIALIZE.");
        }
        
        public virtual void LoadContent()
        {
            Console.WriteLine($"COMPONENT '{Name}' LOAD CONTENT.");
        }
        
        public virtual void Update(Time time)
        {
            Console.WriteLine($"COMPONENT '{Name}' UPDATE.");
        }
        
        public virtual void Draw(Time time)
        {
            Console.WriteLine($"COMPONENT '{Name}' DRAW.");
        }
        
        public virtual void UnloadContent()
        {
            Console.WriteLine($"COMPONENT '{Name}' UNLOAD CONTENT.");
        }

        public virtual void ShutDown()
        {
            Console.WriteLine($"COMPONENT '{Name}' SHUTDOWN.");
        }

        #endregion
    }
}