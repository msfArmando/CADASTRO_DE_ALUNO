using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_aluno
{
    public class OptionException : IOException
    {
        public OptionException() { }
        public OptionException(string message) : base(message) { }
        public OptionException(string message, IOException innerException) : base(message, innerException) { }
    }
}
