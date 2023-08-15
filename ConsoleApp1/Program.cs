// See https://aka.ms/new-console-template for more information
using System.Reflection;

Console.WriteLine("Hello, World!");

string location, directoryPath;
Assembly assembly = null;
Type preProc = null;

location = Assembly.GetEntryAssembly().Location;
directoryPath = Path.GetDirectoryName(location);

assembly = Assembly.LoadFrom(directoryPath + @"/TestClassLibrary.dll");
preProc = assembly.GetType("TestClassLibrary.DemoClass");

object obj = Activator.CreateInstance(preProc);

MethodInfo preProcMethod = preProc.GetMethod("Sum");

object[] methodparam = new object[2];
methodparam[0] = 20;
methodparam[1] = 30;

var value = preProcMethod.Invoke(obj, methodparam);

Console.WriteLine($"Value{value}");
Console.ReadKey();
