using Azure;
using Azure.AI.OpenAI;
using Microsoft.Extensions.Options;
using OpenAI.Chat;

namespace OpenAIChatService.Services
{
    public class ChatService
    {
        private readonly AzureOpenAIClient azureClient;
        private readonly string _deployment;
        ChatClient chatClient;

        public ChatService(IOptions<AzureOpenAISettings> settings)
        {
            azureClient = new AzureOpenAIClient(
                new Uri(settings.Value.Endpoint),
                new AzureKeyCredential(settings.Value.ApiKey));

            _deployment = settings.Value.DeploymentName;
            chatClient =
                azureClient.GetChatClient(_deployment);
        }

        public async Task<string> GetChatResponse(string prompt)
        {
            try
            {
                var messages = new List<ChatMessage>
                {
                    ChatMessage.CreateUserMessage(
                        new List<ChatMessageContentPart>
                        {
                            ChatMessageContentPart.CreateTextPart(prompt)
                        }
                    )
                };

                var requestOptions = new ChatCompletionOptions
                {
                    Temperature = 0.2f
                };

                var response = chatClient.CompleteChat(messages, requestOptions);

                return response.Value.Content[0].Text;

            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }

    }
}
