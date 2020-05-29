using System;

namespace Basics
{
    public class AuthorAttribute : Attribute
    {
        readonly string Author;

        public AuthorAttribute(string author) => Author = author;
    }
}
