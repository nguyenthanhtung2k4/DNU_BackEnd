using System;

namespace Lab1{
    public class Check_so : Exception
    {
        public Check_so(string message) : base(message) { }
    }
}