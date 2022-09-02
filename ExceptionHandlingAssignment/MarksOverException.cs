namespace ExceptionHandlingAssignment
{
    class MarksOverException : Exception
    {
        public MarksOverException() { }

        public MarksOverException(int marks) : base(String.Format($"\n\nInvalid marks above 100: {marks}\n\n", marks)) { }
    }
}
