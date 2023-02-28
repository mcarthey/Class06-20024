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
        //Wrapper wrapper (hold onto context)
        MediaContext context = new MediaContext();
        Repository repo = new Repository(context);

        //wrapper => execute methods to Search
        repo.Search();
    }
}
