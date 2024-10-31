using OpenAI;
using Microsoft.Extensions.AI;

IChatClient client = new OpenAIClient("").AsChatClient("gpt-4o");

var response = await client.CompleteAsync("What is AI?");

Console.WriteLine(response);


