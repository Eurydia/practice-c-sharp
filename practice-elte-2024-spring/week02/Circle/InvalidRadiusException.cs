using System;

namespace Task
{
  class InvalidRadiusException : ArgumentException
  {
    public InvalidRadiusException(string errMsg)
        : base(errMsg)
    { }

  }
}