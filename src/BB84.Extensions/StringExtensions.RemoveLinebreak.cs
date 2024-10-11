﻿namespace BB84.Extensions;

public static partial class StringExtensions
{
	/// <summary>
	/// Removes unwanted linebreaks within the provided string value.
	/// </summary>
	/// <param name="value">The input string value to modify.</param>
	/// <returns>The same <see cref="string"/> instance so that multiple calls can be chained.</returns>
	public static string RemoveLinebreak(this string value)
		=> LinebreakRegex.Replace(value, string.Empty);
}
