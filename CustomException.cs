using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeDetermination
{
    public class CustomException:Exception
    {
            public enum ExceptionType
            {
                Null,
                Empty
            }

            private ExceptionType Type;

            public CustomException(ExceptionType type, string message) : base(message)
            {
                Type = type;
            }

        }
    }

