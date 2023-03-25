using System;

namespace Defining
{
    /// Some book class
    public class Book
    {
        string _name;
        string _author;
        int _pagecount;
        /// Book
        public Book(string name, string author, int pages)
        {
            _name = name;
            _author = author;
            _pagecount = pages;
        }
        /// Book.GetDescription Class definition
        public string GetDescription()
        {
            return $"{_name} by {_author}";
        }
    }
}