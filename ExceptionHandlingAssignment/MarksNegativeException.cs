namespace ExceptionHandlingAssignment
{
    class MarksNegativeException : Exception
    {
        public MarksNegativeException() { }

        public MarksNegativeException(int marks) : base(String.Format($"\n\nInvalid marks below zero: {marks}\n\n", marks)) { }
    }
}
