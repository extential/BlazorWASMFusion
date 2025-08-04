using ActualLab.Fusion;
using ClassLibrary1.Domain.ReportContext;
using ClassLibrary1.Interfaces;

namespace BlazorApp2.Client.Pages;

public class AppState(IPeopleService peopleService) : IComputeService
{
    public Report Report { get; set; } = new();
    public bool IsReportLoaded { get; set; }
    
    public async Task<Report> LoadReport(Guid reportId, CancellationToken cancellationToken = default)
    {
        var report  = await peopleService.GetReport(reportId, cancellationToken);
       
        return report;
    }
    
    [ComputeMethod]
    public virtual async Task<bool> Updated(CancellationToken cancellationToken = default)
    {
       return true;
        
    }
}