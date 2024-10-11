﻿using System.Net.Http.Headers;

namespace BB84.Extensions;

/// <summary>
/// The <see cref="HttpClient"/> extensions class.
/// </summary>
public static class HttpClientExtensions
{
	private const string BearerScheme = "Bearer";

	/// <summary>
	/// Adds the specified bearer <paramref name="token"/> to the http client request header.
	/// </summary>
	/// <param name="client">The http client which should use the token.</param>
	/// <param name="token">The bearer token to be used.</param>
	/// <returns>The same <see cref="HttpClient"/> instance so that multiple calls can be chained.</returns>
	public static HttpClient AddBearerToken(this HttpClient client, string token)
	{
		client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(BearerScheme, token);

		return client;
	}

	/// <summary>
	/// Adds the specified <paramref name="mediaType"/> the Accept header for an HTTP request.
	/// </summary>
	/// <param name="client">The http client which should use the media type.</param>
	/// <param name="mediaType">The media type to be used.</param>
	/// <returns>The same <see cref="HttpClient"/> instance so that multiple calls can be chained.</returns>
	public static HttpClient AddMediaType(this HttpClient client, string mediaType)
	{
		client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(mediaType));

		return client;
	}
}
