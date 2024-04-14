using BoardGameHub.Core.Models.PriceViewModel;

namespace BoardGameHub.Core.Contracts
{
    public interface IPlaceTypeService
    {
        Task<PlaceTypeViewModel> GetAllAsync();
    }
}
