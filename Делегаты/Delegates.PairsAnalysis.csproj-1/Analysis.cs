using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.PairsAnalysis
{
	public static class Analysis
	{
		public static int FindMaxPeriodIndex(params DateTime[] data_time)
		{
			var x = data_time.Pairs();
			var y = data_time.ToPairs((date1, date2) => (date2 - date1).TotalSeconds);
			return data_time
				.ToPairs((date1, date2) => (date2 - date1).TotalSeconds)
				.MaxIndex();
		}

		public static IEnumerable<Tuple<T, T>> Pairs<T>(this IEnumerable<T> input_collection)
		{
			T previous_item = default(T);
			bool is_first = true;
			bool is_empty = true;
			foreach (var item in input_collection)
			{
				if (is_first)
				{
					previous_item = item;
					is_first = false;
				}
				else
				{
					yield return Tuple.Create(previous_item, item);
					previous_item = item;
					is_empty = false;
				}
			}
			if (is_empty) throw new ArgumentException();
		}

		public static int MaxIndex<Tin>(this IEnumerable<Tin> input_collection)
			where Tin : IComparable
		{
			bool is_first = true;
			bool is_empty = true;
			Tin max_item = default(Tin);
			int current_index = 0;
			int max_index = 0;

			foreach (var item in input_collection)
			{
				if (is_first)
				{
					max_item = item;
					max_index = current_index;
					is_first = false;
					is_empty = false;
				}
				else
				{
					if (item.CompareTo(max_item) == 1)
					{
						max_item = item;
						max_index = current_index;
					}
				}
				current_index++;
			}
			if (is_empty) throw new ArgumentException();
			return max_index;
		}

		public static double FindAverageRelativeDifference(params double[] data)
		{
			return data
				.ToPairs((first_number, second_number) => (second_number - first_number) / first_number)
				.AverageDifference(
					(sum, next_number) => sum + next_number,
					(sum, count) => sum / count);
		}

		public static IEnumerable<Tout> ToPairs<Tin, Tout>(this IEnumerable<Tin> input_collection, Func<Tin, Tin, Tout> process)
		{
			Tin previous_item = default(Tin);
			bool is_first = true;
			bool is_empty = true;
			foreach (var item in input_collection)
			{
				if (is_first)
				{
					previous_item = item;
					is_first = false;
				}
				else
				{
					yield return process(previous_item, item);
					previous_item = item;
					is_empty = false;
				}
			}
			if (is_empty) throw new ArgumentException();
		}

		public static Tin AverageDifference<Tin>(this IEnumerable<Tin> input_collection, Func<Tin, Tin, Tin> summarize, Func<Tin, int, Tin> average)
		{
			Tin sum = default(Tin);
			int count = 0;
			foreach (var item in input_collection)
			{
				sum = summarize(sum, item);
				count++;
			}
			return average(sum, count);
		}
	}
}
