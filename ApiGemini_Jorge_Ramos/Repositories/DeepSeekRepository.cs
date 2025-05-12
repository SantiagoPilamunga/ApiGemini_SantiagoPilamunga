using ApiGemini_Jorge_Ramos.Interfaces;

namespace ApiGemini_Jorge_Ramos.Repositories
{
    public class DeepSeekRepository : IChatBotService
    {
        public async Task<string> GetChatbotResponse(string prompt)
        {
            return "Este es un Sting de deep seek";
        }
    }
}
