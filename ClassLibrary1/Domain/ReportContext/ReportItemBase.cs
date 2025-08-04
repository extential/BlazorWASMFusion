using System.Text.Json.Serialization;
using MemoryPack;

namespace ClassLibrary1.Domain.ReportContext;

 [JsonPolymorphic(TypeDiscriminatorPropertyName = "$type")]
 [JsonDerivedType(typeof(ReportItem<string>), typeDiscriminator: "string")]
 [JsonDerivedType(typeof(ReportItem<int>), typeDiscriminator: "int")]
 [JsonDerivedType(typeof(ReportItem<decimal>), typeDiscriminator: "decimal")]
 [JsonDerivedType(typeof(ReportItem<bool>), typeDiscriminator: "bool")]
 [MemoryPackable]
 public partial class ReportItemBase
 {
     public ReportItemBase()
     {
         
     }
     public string Id { get; set; }
     public string Label { get; set; }
 }