﻿using BB84.Extensions;

namespace BB84.ExtensionsTests;

public partial class StringExtensionsTests
{
	[TestMethod]
	public void Compress()
	{
		string decompressed = DecompressedContent;

		string compressed = decompressed.Compress();

		Assert.AreNotEqual(decompressed, compressed);
		Assert.AreEqual(CompressedContent, compressed);
	}
}
