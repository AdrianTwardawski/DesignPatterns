﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypes
{
    public interface IEntity
    {
        int Id { get; set; }
    }
    public class Restaurant : IEntity
    {
        public int Id {get; set; }
    }
    public class User : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }


    public class PaginatedResult<T>
    {
        public List<T> Results { get; set; }
        public int ResultsFrom { get; set; }
        public int ResultsTo { get; set; }
        public int TotalPages { get; set; }
        public int TotalResults { get; set; }

    }
}
