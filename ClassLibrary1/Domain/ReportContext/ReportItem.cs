

using MemoryPack;

namespace ClassLibrary1.Domain.ReportContext;

[MemoryPackable]
public partial class ReportItem<T>: ReportItemBase
{
    // Parameterless constructor required for deserialization
    public ReportItem()
    {
    }
    public T? Value { get; set; }
    public string DataDefinition { get; private set; }
    public string DisplayName { get; private set; }
    public bool IsDirty { get; private set; }

}
