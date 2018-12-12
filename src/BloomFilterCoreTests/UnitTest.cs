using System;
using BloomFilterCore;
using Xunit;

namespace BloomFilterCoreTests
{
	public class UnitTests
	{

		[Theory]
		[InlineData(1000)]
		[InlineData(2000)]
		[InlineData(3000)]
		[InlineData(4000)]
		[InlineData(5000)]
		public void is_in_filter_int(int value)
		{
			var filter = new BloomFilter<int>(10, HashFunctions.HashInt);
			filter.Add(1);
			filter.Add(100);
			filter.Add(2);
			filter.Add(200);
			filter.Add(3);
			filter.Add(value);
			Assert.True(filter.Contains(value));

		}

		[Theory]
		[InlineData(1000)]
		[InlineData(2000)]
		[InlineData(3000)]
		[InlineData(4000)]
		[InlineData(5000)]
		public void is_not_in_filter_int(int value)
		{
			var filter = new BloomFilter<int>(10, HashFunctions.HashInt);
			filter.Add(1);
			filter.Add(100);
			filter.Add(2);
			filter.Add(200);
			filter.Add(3);

			Assert.False(filter.Contains(value));

		}


		[Theory]
		[InlineData("apples")]
		[InlineData("oranges")]
		[InlineData("pineapples")]
		[InlineData("pears")]
		[InlineData("strawberries")]
		public void is_in_filter_string(string value)
		{
			var filter = new BloomFilter<string>(10, HashFunctions.HashString);
			filter.Add("bananas");
			filter.Add("watermelons");
			filter.Add("cantaloupes");
			filter.Add("grapes");
			filter.Add("grapefruits");
			filter.Add(value);
			Assert.True(filter.Contains(value));

		}

		[Theory]
		[InlineData("apples")]
		[InlineData("oranges")]
		[InlineData("pineapples")]
		[InlineData("pears")]
		[InlineData("strawberries")]
		public void is_not_in_filter_string(string value)
		{
			var filter = new BloomFilter<string>(10, HashFunctions.HashString);
			filter.Add("bananas");
			filter.Add("watermelons");
			filter.Add("cantaloupes");
			filter.Add("grapes");
			filter.Add("grapefruits");
		
			Assert.False(filter.Contains(value));

		}

	}
}
