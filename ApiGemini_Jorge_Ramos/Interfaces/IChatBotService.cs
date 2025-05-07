namespace ApiGemini_Jorge_Ramos.Interfaces
{
    public interface IChatBotService
    {
        public async Task<string> GetChatbotResponse(string prompt);

    }
}
