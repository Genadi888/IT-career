using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Имплементация_на_опашка
{
	public class CircularQueue<T>
	{
		private const int defaultCapacity = 16;
		private int elementsCount = 0;
		private T[] elements;
		private int startIndex = 0;
		private int endIndex = 0;

		public int Count
		{
			get { return this.elementsCount; }
			private set { this.elementsCount = value; }
		}

		public CircularQueue() : this(defaultCapacity) { }

		public CircularQueue(int capacity)
		{
			this.elements = new T[capacity];
		}

		public void Enqueue(T element)
		{
			if (this.Count >= this.elements.Length)
			{
				this.Grow();
			}

			this.elements[this.endIndex] = element;
			this.endIndex = (this.endIndex + 1) % this.elements.Length;
			this.Count++;
		}
		
		public void Enqueue(params T[] elements)
		{
			foreach (T item in elements)
			{
				this.Enqueue(item);
			}
		}

		private void Grow()
		{
			T[] newElements = new T[this.elements.Length * 2];
			this.CopyAllElementsTo(newElements);
			this.elements = newElements;
			this.startIndex = 0;
			this.endIndex = this.Count;
		}

		private void CopyAllElementsTo(T[] inputArr)
		{
			int sourceIndex = this.startIndex;

			for (int destIndex = 0; destIndex < this.Count; destIndex++)
			{
				inputArr[destIndex] = this.elements[sourceIndex];
				sourceIndex = (sourceIndex + 1) % this.elements.Length;
			}
		}

		public T Dequeue()
		{
			if (this.Count == 0)
			{
				throw new InvalidOperationException("The queue is empty!");
			}

			T returnEl = this.elements[this.startIndex];
			this.startIndex = (this.startIndex + 1) % this.elements.Length;
			this.Count--;
			return returnEl;
		}

		public T[] ToArray()
		{
			T[] arr = new T[this.Count];
			int sourceIndex = this.startIndex;

			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = this.elements[sourceIndex];
				sourceIndex = (sourceIndex + 1) % this.elements.Length;
			}

			return arr;
		}

		public override string ToString()
		{
			return String.Join(", ", this.ToArray());
		}
	}
}
