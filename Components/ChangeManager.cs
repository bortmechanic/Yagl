using System;
using System.Collections.Generic;

namespace Yagl.Components
{
    internal class ChangeManager
    {
        private readonly Queue<Change> _changesQueue;

        public ChangeManager()
        {
            _changesQueue = new Queue<Change>();
        }
        
        public void RegisterAddChange(Collection collection, Component component)
        {
            _changesQueue.Enqueue(new Change { Collection = collection, Component = component, Action = Action.AddComponent });
            Console.WriteLine($"ADD REGISTERED: {component.Name}.");
        }

        public void RegisterRemoveChange(Collection collection, Component component)
        {
            _changesQueue.Enqueue(new Change { Collection = collection, Component = component, Action = Action.RemoveComponent });
            Console.WriteLine($"REMOVE REGISTERED: {component.Name}.");
        }
        
        private void ApplyAddChange(Change change)
        {
            change.Collection.AddInternal(change.Component);
        }

        private void ApplyRemoveChange(Change change)
        {
            change.Collection.RemoveInternal(change.Component);
        }
        
        public void ApplyAllChanges()
        {
            while (_changesQueue.Count > 0)
            {
                var change = _changesQueue.Dequeue();
                switch (change.Action)
                {
                    case Action.AddComponent: ApplyAddChange(change); break;
                    case Action.RemoveComponent: ApplyRemoveChange(change); break;
                    default: throw new NotSupportedException($"Change action '{change.Action}' is not supported.");
                }
            }
        }

        private class Change
        {
            public Action Action;
            public Component Component;
            public Collection Collection;
        }

        private enum Action
        {
            AddComponent = 10,
            RemoveComponent = 20
        }
    }
}