// See https://aka.ms/new-console-template for more information
using System.Reflection;

Console.WriteLine("Hello, World!");

string location, directoryPath;
Assembly assembly;
Type preProc;

location = Assembly.GetEntryAssembly().Location;
directoryPath = Path.GetDirectoryName(location);

assembly = Assembly.LoadFrom(directoryPath + @"/TestClassLibrary.dll");
preProc = assembly.GetType("TestClassLibrary.DemoClass");

object[] InstanceParam = new object[2]; // Constructor Parameters
InstanceParam[0] = 20;
InstanceParam[1] = 30;

object obj = Activator.CreateInstance(preProc, InstanceParam);

MethodInfo preProcMethod = preProc.GetMethod("Sum");

object[] methodparam = new object[2]; //Method Parameters
methodparam[0] = 20;
methodparam[1] = 30;

var value = preProcMethod.Invoke(obj, methodparam); //Invoking Sum Method

Console.WriteLine($"Value{value}");
Console.ReadKey();
