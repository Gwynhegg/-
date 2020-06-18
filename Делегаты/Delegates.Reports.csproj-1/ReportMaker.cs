using Delegates.Reports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.Reports
{
	public abstract class Shell
	{
	 protected StringBuilder result;
	 protected string begin_list, end_list, make_item1, make_item2;
		protected string caption;
		public Shell(DataType data)
		{
			result = new StringBuilder();
		}
		public string returnReport()
		{
			result.Append(caption); result.Append(begin_list); result.Append(make_item1); result.Append(make_item2); result.Append(end_list);
			return result.ToString();
		}
	}

	public class MarkDownShell : Shell
	{
		public MarkDownShell(DataType data) : base(data)
		{
			caption = $"## " + data.getCaption() + "\n\n";
			begin_list = ""; end_list = "";
			make_item1 = $" * **Temperature**: " + data.makeStatistics(data.getDataTemperature()).ToString() + "\n\n";
			make_item2 = $" * **Humidity**: " + data.makeStatistics(data.getDataHumidity()).ToString() + "\n\n";
		}
	}

	public class HTMLShell : Shell
	{
		public HTMLShell(DataType data) : base(data)
		{
			caption = $"<h1>" + data.getCaption() + "</h1>";
			begin_list = "<ul>"; end_list = "</ul>";
			make_item1 = $"<li><b>Temperature</b>: " + data.makeStatistics(data.getDataTemperature()).ToString();
			make_item2 = $"<li><b>Humidity</b>: " + data.makeStatistics(data.getDataHumidity()).ToString();
		}
	}


	public abstract class DataType
	{
		protected string caption;
		protected List<Measurement> data;
		public string getCaption()
		{
			return caption;
		}
		public IEnumerable<double> getDataTemperature()
		{
			return data.Select(z => z.Temperature);
		}
		public IEnumerable<double> getDataHumidity()
		{
			return data.Select(z => z.Humidity);
		}
		public DataType(IEnumerable<Measurement> _data)
		{
			caption = "";
		    this.data = _data.ToList();
		}
		public abstract object makeStatistics(IEnumerable<double> data);
	}

	public class MedianType : DataType
	{
		public MedianType(IEnumerable<Measurement> _data) : base(_data)
		{
			caption = "Median";
		}
		public override object makeStatistics(IEnumerable<double> data)
		{
			var list = data.OrderBy(z => z).ToList();
					if (list.Count % 2 == 0)
						return (list[list.Count / 2] + list[list.Count / 2 - 1]) / 2;
					return list[list.Count / 2];
		}
	}

	public class MeanAndStdType : DataType
	{
		public MeanAndStdType(IEnumerable<Measurement> _data) : base(_data)
		{
			caption = "Mean and Std";
		}
		public override object makeStatistics(IEnumerable<double> _data)
		{
			var data = _data.ToList();
					var mean = data.Average();
					var std = Math.Sqrt(data.Select(z => Math.Pow(z - mean, 2)).Sum() / (data.Count - 1));

					return new MeanAndStd
					{
						Mean = mean,
						Std = std
					};
		}
	}

public static class ReportMakerHelper
	{

	public static string MeanAndStdHtmlReport(IEnumerable<Measurement> data)
		{			
			return new HTMLShell(new MeanAndStdType(data)).returnReport();
		}

		public static string MedianMarkdownReport(IEnumerable<Measurement> data)
		{
			return new MarkDownShell(new MedianType(data)).returnReport();
		}

		public static string MeanAndStdMarkdownReport(IEnumerable<Measurement> measurements)
		{
			return new MarkDownShell(new MeanAndStdType(measurements)).returnReport();
		}

		public static string MedianHtmlReport(IEnumerable<Measurement> measurements)
		{
			return new HTMLShell(new MedianType(measurements)).returnReport();
		}
	}
}
