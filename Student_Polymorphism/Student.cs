namespace Student_Polymorphism
{
    public class Student
    {
        private static int _id = 100;
        public readonly int  _rollNumber;
        private string _name;
        protected int _englishMarks;

        public Student(string name, int englishMarks)
        {
            _rollNumber = _id++;
            _name = name;
            _englishMarks = englishMarks;
        }

        public virtual string printMarksSheet()
        {
            return string.Format($"\n\n****************************************************************************\nRoll: {_rollNumber}\tName: {_name}\t\tEnglish: {_englishMarks}");
        }
    }

    public class Science : Student
    {
        private int _scienceMarks;
        public Science (int scienceMarks, string name, int englishMarks) : base(name, englishMarks)
        {
            _scienceMarks = scienceMarks;
        }

        protected int getMarks()
        {
            return base._englishMarks + _scienceMarks;
        }
        public override string printMarksSheet()
        {
            return base.printMarksSheet() + string.Format($"\tScience: {_scienceMarks}\tTotal: {getMarks()}\n****************************************************************************\n\n");
        }
    }

    public class Arts : Student
    {
        private int _artsMarks;
        public Arts(int artsMarks, string name, int englishMarks) : base(name, englishMarks)
        {
            _artsMarks = artsMarks;
        }
        protected int getMarks()
        {
            return base._englishMarks + _artsMarks;
        }

        public override string printMarksSheet()
        {
            return base.printMarksSheet() + string.Format($"\tScience: {_artsMarks}\tTotal: {getMarks()}\n****************************************************************************\n\n");
        }
    }

    public class Commerce : Student
    {
        private int _commerceMarks;
        public Commerce(int commerceMarks, string name, int englishMarks) : base(name, englishMarks)
        {
            _commerceMarks = commerceMarks;
        }
        protected int getMarks()
        {
            return base._englishMarks + _commerceMarks;
        }
        public override string printMarksSheet()
        {
            return base.printMarksSheet() + string.Format($"\tScience: {_commerceMarks}\tTotal: {getMarks()}\n****************************************************************************\n\n");
        }
    }

}
