namespace tryAGI.OpenAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task CreateEmbedding()
    {
        var api = GetAuthorizedApi();
        var response = await api.CreateEmbeddingAsync(new CreateEmbeddingRequest
        {
            Input = "Hello, world",
            Model = EmbeddingModelIds.Ada002,
            User = "tryAGI.OpenAI.IntegrationTests.Tests.CreateEmbedding",
        });
        response.Data.ElementAt(0).Embedding.Should().NotBeEmpty();

        foreach (var data in response.Data.ElementAt(0).Embedding)
        {
            Console.WriteLine($"{data}");
        }
    }
}
