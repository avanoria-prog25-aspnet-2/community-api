using Microsoft.AspNetCore.OpenApi;
using Microsoft.OpenApi;

namespace Community.Api.OpenApi;

public sealed class OpenApiDocumentTransformer : IOpenApiDocumentTransformer
{
    public Task TransformAsync(OpenApiDocument document, OpenApiDocumentTransformerContext context, CancellationToken cancellationToken)
    {
        document.Components ??= new OpenApiComponents();

        document.Info.Description = """
        ## Introduction

        The Community API provides endpoints for managing communities.

        It supports operations for retrieving a list of available communities, creating new communities, updating existing communities, and deleting communities.

        Use this API to maintain community data and make community options available to connected clients and applications.
        """;

        return Task.CompletedTask;
    }
}
