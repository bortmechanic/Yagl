/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable NotAccessedField.Global

namespace Yagl.Components
{
    public class Context
    {
        #region Public Fields
        
        public static readonly Context Default = new Context();

        public readonly Collection Components;
        
        #endregion
        
        #region Private Fields

        private readonly Component _root;
        internal readonly ChangeManager ChangeManager;
        
        #endregion

        #region Constructor(s)

        public Context()
        {
            ChangeManager = new ChangeManager();
            _root = new Component(this) {Name = "ROOT"};
            Components = _root.Components;
        }

        #endregion

        #region Context Life Cycle Triggers

        public void Initialize()
        {
            _root.InitializeInternal();
            ChangeManager.ApplyAllChanges();
        }

        public void Update(Time time)
        {
            _root.UpdateInternal(time, true);
            ChangeManager.ApplyAllChanges();
        }

        public void Draw(Time time)
        {
            _root.DrawInternal(time, true);
            ChangeManager.ApplyAllChanges();
        }

        public void ShutDown()
        {
            foreach (var component in _root.Components)
                _root.Components.Remove(component);
            ChangeManager.ApplyAllChanges();
            _root.ShutDownInternal();
        }

        #endregion
    }
}