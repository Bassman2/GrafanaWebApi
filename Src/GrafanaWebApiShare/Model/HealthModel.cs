using WebServiceClient.Attributes;

namespace GrafanaWebApi.Model;

[ModelAttribute(value: 5, access: ModelAccess.Internal, name: "Paul", flag: true, Value2 = 32, Access2 = ModelAccess.Protected, Name2 = "Peter", Flag2 = true)]
internal class HealthModel
{
    [JsonPropertyName("database")]
    public string? Database { get; set; }

    [JsonPropertyName("version")]
    public string? Version { get; set; }

    [JsonPropertyName("commit")]
    public string? Commit { get; set; }
}
