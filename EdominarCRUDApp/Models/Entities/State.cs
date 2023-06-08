namespace EdominarCRUDApp.Models.Entities
{
    public class StateResponse : BaseResponse
    {
        public StateResponse(bool isSuccess, string message, IEnumerable<StateData> states) : base(isSuccess, message)
        {
            States = states;
        }
        public IEnumerable<StateData> States { get; }

    }
    public class StateData
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
