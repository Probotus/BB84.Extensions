﻿namespace BB84.Extensions.Tests;

public partial class ComparableExtensionsTests
{
	[DataRow(0, 0, true)]
	[DataRow(1, 0, false)]
	[DataRow(0, 1, true)]
	[DataTestMethod]
	public void IsLessOrEqualThan(int value, int otherValue, bool expected)
		=> Assert.AreEqual(expected, value.IsLessOrEqualThan(otherValue));
}
