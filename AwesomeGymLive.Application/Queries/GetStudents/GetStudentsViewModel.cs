namespace AwesomeGymLive.Application.Queries.GetStudents
{
    public class GetStudentsViewModel
    {
        public GetStudentsViewModel(string fullName)
        {
            FullName = fullName;
        }

        public string FullName { get; set; }
    }
}
