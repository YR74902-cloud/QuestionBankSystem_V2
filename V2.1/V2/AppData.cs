using System.Collections.Generic;

namespace QuestionBankSystem
{
    public static class AppData
    {
        public static List<User> Users = new List<User>();
        public static List<Question> Questions = new List<Question>();
        public static User? CurrentUser;
        public const string InstructorCode = "QBS2026";
    }
}
