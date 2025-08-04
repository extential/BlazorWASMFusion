using ActualLab.Fusion;
using Report = ClassLibrary1.Domain.ReportContext.Report;

namespace ClassLibrary1.Interfaces;

public interface IPeopleService : IComputeService
{
    Task AddOrUpdate(Report person, CancellationToken cancellationToken = default);
    [ComputeMethod]
    Task<Report> GetReport(Guid reportId, CancellationToken cancellationToken = default);
}