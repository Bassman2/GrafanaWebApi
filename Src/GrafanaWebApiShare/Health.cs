namespace GrafanaWebApi;

[Model]
public class Health
{
    internal Health(HealthModel model)
    {
        Database = model.Database;
        Version = model.Version;
        Commit = model.Commit;
    }

    [ModelPropertyParameters]
    public string? Database { get; }

    public string? Version { get; }

    [ModelPropertyParameters(JsonPropertyName = "commit")]
    public string? Commit { get; }

    [ModelIgnore]
    public string? Dummy { get; }
}
