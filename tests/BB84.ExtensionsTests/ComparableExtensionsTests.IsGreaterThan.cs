﻿using BB84.Extensions;

namespace BB84.ExtensionsTests;

public partial class ComparableExtensionsTests
{
	[DataRow(0, 0, false)]
	[DataRow(1, 0, true)]
	[DataRow(0, 1, false)]
	[DataTestMethod]
	public void IsGreaterThan(int value, int otherValue, bool expected)
		=> Assert.AreEqual(expected, value.IsGreaterThan(otherValue));
}
