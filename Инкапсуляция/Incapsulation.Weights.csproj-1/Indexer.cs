using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incapsulation.Weights
{
	public class Indexer
	{
		private int length;
		private int start;
		private double[] origin_array;
		public int Length
		{
			get
			{
				return length;
			}
			set
			{
				length = value;
			}
		}
		public Indexer(double[] array, int start, int length)
		{
			origin_array = array;
			this.start = start;
			this.length = length;
			if (start < 0 || length<0) throw new System.ArgumentException();
			if (start+length>array.Length) throw new System.ArgumentException();
		}

		public double this[int index]
		{
			get
			{
				if (index<0 || index>=length) throw new System.IndexOutOfRangeException();
				return origin_array[start+index];
			}
			set
			{
				if (index < 0 || index >= length) throw new System.IndexOutOfRangeException();
				origin_array[start+index] = value;
			}
		}

	}

}
