namespace ApiGemini_Jorge_Ramos.Interfaces
{
    public interface IChatBotService
    {
        public Task<string> GetChatbotResponse(string prompt);

    }
}
