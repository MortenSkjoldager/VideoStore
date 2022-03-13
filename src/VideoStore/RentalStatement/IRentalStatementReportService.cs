namespace VideoStore.RentalStatement
{
    public interface IRentalStatementReportService
    {
        string GetRentalStatementReport(Model.RentalStatement rentalStatement);
    }
}
