/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global

namespace Yagl.Components
{
    public class Context
    {
        public static readonly Context Default = new Context();

        private readonly Component _root;

        #region Constructor(s)

        public Context()
        {
            _root = new Component(this) {Name = "ROOT"};
        }

        #endregion

        #region Context Life Cycle Triggers

        public void Initialize() => _root.Initialize();
        
        public void Update(Time time) => _root.Update(time);
        
        public void Draw(Time time) => _root.Draw(time);
        
        public void ShutDown() => _root.ShutDown();

        #endregion
    }
}