using System;

namespace CarvedRock.Web.Exceptions
{
    public class GraphQLException : ApplicationException
    {
        public GraphQLException(string message) : base(message)
        {
        }
    }
}