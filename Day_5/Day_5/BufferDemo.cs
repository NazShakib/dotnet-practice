using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    interface Ibuffer<T> {

        bool IsEmpty();
        void write(T value);
        T read();
    }



    class BufferDemo<T> : Ibuffer<T>
    {
        private T[] _buffer;
        private int _start;
        private int _end;

        public int Capacity {
            get {
                return _buffer.Length;
            }
        }


        public bool IsEmpty()
        {
            return _end == _start; 
            
        }
        public bool IsFull()
        {
            return (_end + 1) % _buffer.Length == _start;
        }

        public BufferDemo() : this(capacity:10)
        {

        }
        public BufferDemo(int capacity)
        {
            _buffer = new T[capacity + 1];
            _start = 0;
            _end = 0;
        }
        public void write(T value)
        {
            _buffer[_end] = value;
            _end = (_end + 1) % _buffer.Length;
            if (_end==_start)
            {
                _start = (_start + 1) % _buffer.Length;
            }
        }
        public T read()
        {
            T result = _buffer[_start];
            _start = (_start + 1) % _buffer.Length;
            return result;
        }


    }


    // Example of generic class and interface
    class BufferDemo2<T> : Ibuffer<T>, IEnumerable<T>
    {
        Queue<T> queue = new Queue<T>();

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in queue)
            {
                yield return item;
            }
        }

        public bool IsEmpty()
        {
            return queue.Count == 0;
        }

        public T read()
        {
            return queue.Dequeue();
        }

        public void write(T value)
        {
            queue.Enqueue(value);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }



}
