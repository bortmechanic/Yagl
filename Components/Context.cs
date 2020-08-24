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
        
        #endregion

        #region Constructor(s)

        public Context()
        {
            _root = new Component(this) {Name = "ROOT"};
            Components = _root.Components;
        }

        #endregion

        #region Context Life Cycle Triggers

        public void Initialize() => ComponentManager.Initialize(_root);
        
        public void Update(Time time) => ComponentManager.Update(_root, time);
        
        public void Draw(Time time) => ComponentManager.Draw(_root, time);
        
        public void ShutDown() => ComponentManager.ShutDown(_root);

        #endregion
    }
}