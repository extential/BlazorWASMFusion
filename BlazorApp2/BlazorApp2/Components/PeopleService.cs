
using ActualLab.Fusion;
using ClassLibrary1.Domain.ReportContext;
using ClassLibrary1.Interfaces;

namespace BlazorApp2.Components;

public class PeopleService(): IPeopleService
{
    // Commands
    public async Task AddOrUpdate(Report person, CancellationToken cancellationToken = default)
    {
       
    }

    // Queries
    public virtual async Task<Report> GetReport(Guid reportId, CancellationToken cancellationToken = default)
    {
        var report = new Report();
        report.AddReportItem(new ReportItem<string> { Id = "d901cfab-782e-4eef-99d6-7899ec6315f2", Label = "Test String", Value = "Hello" });
        report.AddReportItem(new ReportItem<int> { Id = "d901cfab-782e-4eef-99d6-7899ec6315f3", Label = "Test Int", Value = 42 });
        
        return report;
    }
}