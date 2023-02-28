using Class0620024.Context;
using Class0620024.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Class0620024.Services;

/// <summary>
///     You would need to inject your interfaces here to execute the methods in Invoke()
///     See the commented out code as an example
/// </summary>
public class MainService : IMainService
{
    public MainService()
    {
    }

    public void Invoke()  // consider this your Program.cs Main
    {
        // 1. This example uses the Repository and Context and a simple Search() method as done in class
        Console.WriteLine("** Example #1: Using Media Context");
        MediaContext context = new MediaContext();                  //Wrapper wrapper (hold onto context)
        Repository repo = new Repository(context);
        repo.Search();                                              //wrapper => execute methods to Search

        Console.WriteLine();

        // 2. This example replaces the Context wrapper and creates a MediaManager wrapper that has one C# class
        Console.WriteLine("** Example #2: Using a more simple 'MediaManager'");
        MediaManager manager = new MediaManager();
        manager.Search();

    }
}
