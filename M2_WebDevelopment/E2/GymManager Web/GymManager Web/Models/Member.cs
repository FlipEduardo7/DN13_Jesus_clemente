namespace GymManager_Web.Models
{
    public class Member
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public int CityId { get; set; }
        public string Email { get; set; }
        public bool AllowNewsLetter { get; set; }


    }
}
