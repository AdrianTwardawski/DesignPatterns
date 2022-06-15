using System;
using System.Collections.Generic;

namespace GenericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var restaurants = new List<Restaurant>();

            var result = new PaginatedResult<Restaurant>();

            result.Results = restaurants;

            var users = new List<User>();

            //result.Results = users; // compile error

            //var stringRepository = new Repository<string>();
            //stringRepository.AddElement("some value");
            //string firstElement = stringRepository.GetElement(0);

            var user2Repository = new Repository<User>();

            //var intRepository = new Repository<int>(); // error - ze względu na nałożone ograniczenia w Repository.cs

            var userRepository = new Repository<string, User>();

            userRepository.AddElement("Bill", new User() {Name = "Bill" });

            User user = userRepository.GetElement("Bill");
        }        
    }
}
