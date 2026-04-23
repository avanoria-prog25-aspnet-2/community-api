namespace Community.Api.Endpoints;

public static class CommunityEndpoints
{
    public static void MapCommunityEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("/api/communities")
            .WithTags("Communities")
            .WithDescription("Handles endpoints for community options");

        group.MapGet("/all", Get);
    }

    private static IResult Get() => Results.Ok();

}
