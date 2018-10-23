using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name, bool isWeigted) : base(name, isWeigted)
        {
            Type = GradeBookType.Standard;
        }
    }
}
