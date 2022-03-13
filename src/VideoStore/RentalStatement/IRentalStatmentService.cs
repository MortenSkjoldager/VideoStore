using VideoStore.Model;

namespace VideoStore.RentalStatement
{
    public interface IRentalStatmentService
    {
        VideoStore.Model.RentalStatement GetRentalStatement(Customer customer);
    }
}
