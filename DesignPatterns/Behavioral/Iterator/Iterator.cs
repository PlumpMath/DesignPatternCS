using System.Collections;

/// <summary>
/// 
/// 
/// 
/// </summary>

namespace DesignPatterns.Behavioral.Iterator
{
    abstract class Aggregate
    {
        public abstract Iterator CreateIterator();
    }

    class ConcreteAggregate : Aggregate
    {
        private ArrayList _items = new ArrayList();

        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }
          
        public int Count
        {
            get { return _items.Count; }
        }
        
        public object this[int index]
        {
            get { return _items[index]; }
            set { _items.Insert(index, value); }
        }
    }


    abstract class Iterator
    {
        public abstract object First();
        public abstract object Next();
        public abstract bool IsDone();
        public abstract object CurrentItem();
    }

    class ConcreteIterator : Iterator
    {
        private ConcreteAggregate _aggregate;
        private int _current = 0;
        
        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            this._aggregate = aggregate;
        }

        public override object First()
        {
            return _aggregate[0];
        }

        public override object Next()
        {
            object ret = null;
            if (_current < _aggregate.Count - 1)
            {
                ret = _aggregate[++_current];
            }
            return ret;
        }
        public override object CurrentItem()
        {
            return _aggregate[_current];
        }

        public override bool IsDone()
        {
            return _current >= _aggregate.Count;
        }
    }
}
