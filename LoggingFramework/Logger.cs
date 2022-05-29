using System;
using System.Collections.Generic;
using System.Runtime.Loader;

namespace LoggingFramework;

public static class Logger
{
    public static readonly List<string> Messages = new();

    static Logger()
        => Console.WriteLine($"Logger initialized for context '{AssemblyLoadContext.GetLoadContext(typeof(Logger).Assembly)!.Name}'");

    public static void Log(string message)
    {
        Console.WriteLine($"Message logged from context '{AssemblyLoadContext.GetLoadContext(typeof(Logger).Assembly)!.Name}': '{message}'");
        Messages.Add(message);
    }
}
