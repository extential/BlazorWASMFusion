
using MemoryPack;

namespace ClassLibrary1.Domain.ReportContext;

[MemoryPackable]
public partial class Report
{
    public Report() {}
    public Guid Id { get; set; }
    public List<ReportItemBase> Items { get; set; } = new();
    public void AddReportItem(ReportItemBase item)
    {
        Items.Add(item);
    }
}