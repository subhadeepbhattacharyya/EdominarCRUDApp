namespace EdominarCRUDApp.Models.Entities
{
    public class HobbyResponse : BaseResponse
    {
        public HobbyResponse(bool isSuccess, string message, IEnumerable<HobbyData> hobbies) : base(isSuccess, message)
        {
            Hobbies = hobbies;
        }
        public IEnumerable<HobbyData> Hobbies { get; }

    }
    public class HobbyData
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
