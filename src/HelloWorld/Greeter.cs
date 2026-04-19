// <copyright file="Greeter.cs" company="Hero">
// Copyright (c) Hero. All rights reserved.
// </copyright>

namespace HelloWorld;

/// <summary>
/// Provides greeting functionality for the console application.
/// </summary>
public static class Greeter
{
    /// <summary>
    /// Returns a greeting message for the specified name.
    /// </summary>
    /// <param name="name">The name to greet.</param>
    /// <returns>A greeting string.</returns>
    /// <exception cref="ArgumentException">Thrown when <paramref name="name"/> is null or whitespace.</exception>
    public static string Greet(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Name must not be null or blank.", nameof(name));
        }

        return $"Hello, {name}!";
    }
}
