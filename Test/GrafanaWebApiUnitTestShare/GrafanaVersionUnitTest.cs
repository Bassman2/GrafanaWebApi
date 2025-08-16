namespace GrafanaWebApiUnitTest;

[TestClass]
public class GrafanaVersionUnitTest : GrafanaBaseUnitTest
{
    [TestMethod]
    public async Task TestMethodGetUserAsync()
    {
        using var Grafana = new Grafana(storeKey, appName);

        var health = await Grafana.GetHealthAsync();

        Assert.IsNotNull(health, "Grafana version is null");
        Assert.AreEqual(new Version(11,6,1), new Version(health.Version!), nameof(health.Version));
    }
}
