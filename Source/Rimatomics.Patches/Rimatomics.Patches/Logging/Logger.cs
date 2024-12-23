using System.Diagnostics;

namespace Rimatomics.Patches.Logging;

internal static class Logger
{
    private const string PREFIX = $"{nameof(Rimatomics)}.{nameof(Patches)}";

    [Conditional("DEBUG")]
    public static void LogDebug(string message) =>
        Verse.Log.Message($"[{PREFIX}] {message}");

    public static void Error(string message) =>
        Verse.Log.Error($"[{PREFIX}] {message}");

    public static void Warning(string message) =>
        Verse.Log.Warning($"[{PREFIX}] {message}");

    public static void LogAlways(string message) =>
        Verse.Log.Message($"[{PREFIX}] {message}");
}
