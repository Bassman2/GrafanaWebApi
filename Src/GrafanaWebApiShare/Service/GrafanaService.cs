using System;

namespace GrafanaWebApi.Service;


// http://shm-grafana/api/health

internal class GrafanaService(Uri host, IAuthenticator? authenticator, string appName)
    : JsonService(host, authenticator, appName, SourceGenerationContext.Default)
{
    private const int limit = 500;

    protected override string? AuthenticationTestUrl => "api/health";

    //protected override async Task ErrorCheckAsync(HttpResponseMessage response, string memberName, CancellationToken cancellationToken)
    //{
    //    await base.ErrorCheckAsync(response, memberName, cancellationToken);

    //    string str = await response.Content.ReadAsStringAsync(cancellationToken);
    //    if (str.StartsWith("{\"status\":\"error\""))
    //    {
    //        //var res = await ReadFromJsonAsync<ResultModel>(response, cancellationToken);

    //        JsonTypeInfo<ResultModel> jsonTypeInfo = (JsonTypeInfo<ResultModel>)context.GetTypeInfo(typeof(ResultModel))!;
    //        var res = await response.Content.ReadFromJsonAsync<ResultModel>(jsonTypeInfo, cancellationToken);

    //        throw new WebServiceException(res!.Messages);
    //    }
    //}

    


    public async Task<HealthModel?> GetHealthAsync(CancellationToken cancellationToken)
    {
        WebServiceException.ThrowIfNotConnected(client);

        var res = await GetFromJsonAsync<HealthModel>("api/health", cancellationToken);
        return res;
    }
}
