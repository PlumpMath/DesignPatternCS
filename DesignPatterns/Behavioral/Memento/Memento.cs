﻿using System;

/// <summary>
/// 
/// Without violating encapsulation, capture and externalize an object's internal state so that the object can be restored to this state later. /// 
/// 
/// 1. Memento - stores internal state of the Originator object. The memento may store as much or as little of the originator's internal state as necessary at its originator's discretion. protect against access by objects of other than the originator.Mementos have effectively two interfaces.Caretaker sees a narrow interface to the Memento -- it can only pass the memento to the other objects.Originator, in contrast, sees a wide interface, one that lets it access all the data necessary to restore itself to its previous state.Ideally, only the originator that produces the memento would be permitted to access the memento's internal state.
/// 2. Originator - creates a memento containing a snapshot of its current internal state. uses the memento to restore its internal state
/// 3. Caretaker - is responsible for the memento's safekeeping never operates on or examines the contents of a memento.
/// 
/// </summary>

namespace DesignPatterns.Behavioral.Memento
{
    class Originator
    {
        private string _state;

        public string State
        {
            get { return _state; }
            set
            {
                _state = value;
                Console.WriteLine("State = " + _state);
            }
        }

        public Memento CreateMemento()
        {
            return (new Memento(_state));
        }

        public void SetMemento(Memento memento)
        {
            Console.WriteLine("Restoring state...");
            State = memento.State;
        }
    }

    class Memento
    {
        private string _state;

        public Memento(string state)
        {
            this._state = state;
        }

        public string State
        {
            get { return _state; }
        }
    }

    class Caretaker
    {
        private Memento _memento;

        public Memento Memento
        {
            set { _memento = value; }
            get { return _memento; }
        }
    }
}
