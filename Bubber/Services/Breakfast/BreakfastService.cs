namespace Bubber.Services.Breakfast
{
    public class BreakfastService : IBreakfastService
    {
        private readonly Dictionary<Guid, Bubber.Models.Breakfast> _breakfasts = new();
        public void CreateBreakfast(Models.Breakfast breakfast)
        {
            _breakfasts.Add(breakfast.Id, breakfast);
        }
    }
}
