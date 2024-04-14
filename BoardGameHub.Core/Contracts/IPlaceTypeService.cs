using BoardGameHub.Core.Models.PlaceTypeViewModel;

namespace BoardGameHub.Core.Contracts
{
    public interface IPlaceTypeService
    {
        Task<IEnumerable<PlaceTypeViewModel>> GetAllAsync();
    }
}
