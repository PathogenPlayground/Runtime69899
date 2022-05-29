using LoggingFramework;
using System;
using System.IO;
using System.Reflection;
using System.Runtime.Loader;

Logger.Log("Hello from main!");

AssemblyLoadContext context = new("PluginLoader", true);
context.LoadFromAssemblyPath(Path.GetFullPath("LoggingFramework.dll"));
Assembly assembly = context.LoadFromAssemblyPath(Path.GetFullPath("Plugin.dll"));

object plugin = assembly.CreateInstance("Plugin")!;

Console.WriteLine();
Console.WriteLine("All messages from the default context's logger:");
foreach (string message in Logger.Messages)
{ Console.WriteLine($"- {message}"); }
