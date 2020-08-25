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
        
        public void RegisterUpdateOrderChange(Component component, int newOrder)
        {
            _changesQueue.Enqueue(new Change { Component = component, Action = Action.ChangeUpdateOrder, Order = newOrder });
            Console.WriteLine($"UPDATE ORDER CHANGE REGISTERED: {component.Name} order {newOrder.ToString()}.");
        }

        public void RegisterDrawOrderChange(Component component, int newOrder)
        {
            _changesQueue.Enqueue(new Change { Component = component, Action = Action.ChangeDrawOrder, Order = newOrder });
            Console.WriteLine($"DRAW ORDER CHANGE REGISTERED: {component.Name} order {newOrder.ToString()}.");
        }
        
        private void ApplyAddChange(Change change)
        {
            change.Collection.AddInternal(change.Component);
        }

        private void ApplyRemoveChange(Change change)
        {
            change.Collection.RemoveInternal(change.Component);
        }
        
        private void ApplyChangeUpdateOrder(Change change)
        {
            change.Component.ChangeUpdateOrderInternal(change.Order);
        }

        private void ApplyChangeDrawOrder(Change change)
        {
            change.Component.ChangeDrawOrderInternal(change.Order);
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
                    case Action.ChangeUpdateOrder: ApplyChangeUpdateOrder(change); break;
                    case Action.ChangeDrawOrder: ApplyChangeDrawOrder(change); break;
                    default: throw new NotSupportedException($"Change action '{change.Action}' is not supported.");
                }
            }
        }

        private class Change
        {
            public Action Action;
            public Component Component;
            public Collection Collection;
            public int Order;
        }

        private enum Action
        {
            AddComponent = 10,
            RemoveComponent = 20,
            ChangeUpdateOrder = 30,
            ChangeDrawOrder = 40
        }
    }
}