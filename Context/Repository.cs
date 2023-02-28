using Class0620024.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class0620024.Context
{
    // This is our 'wrapper'  as used in Example #1 called from MainService.cs
    public class Repository 
    {
        private MediaContext _mediaContext;

        public Repository(MediaContext mediaContext)
        {
            _mediaContext = mediaContext;
        }

        public void Search()
        {
            Console.WriteLine("Which media would you like to display?");
            var userInput = Console.ReadLine();

            Media result = _mediaContext.Movies.FirstOrDefault(media => media.Title.Contains(userInput, StringComparison.CurrentCultureIgnoreCase));

            Console.WriteLine($"Your result: {result.Title}");

            string json = JsonConvert.SerializeObject(result);
            Console.WriteLine(json);

            Movie m = JsonConvert.DeserializeObject<Movie>(json);
            Console.WriteLine("Deserialized: " + m.Title);

        }
    }
}
