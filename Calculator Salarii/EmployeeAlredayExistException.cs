using System.Runtime.Serialization;

namespace Calculator_Salarii
{
    [Serializable]
    internal class EmployeeAlredayExistException : Exception
    {
        public EmployeeAlredayExistException()
        {
        }

        public EmployeeAlredayExistException(string? message) : base(message)
        {
        }

        public EmployeeAlredayExistException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected EmployeeAlredayExistException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}