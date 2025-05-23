﻿using ApiGemini_Jorge_Ramos.Interfaces;
using System.Threading.Tasks;

namespace ApiGemini_Jorge_Ramos.Repositories
{
    public class GeminiRepository : IChatBotService
    {
        HttpClient _httpclient;
        private string apiKey = "AIzaSyAYWNhmxhY1OrQLShuozsXcrMitSMmlFcE";
        public GeminiRepository()
        {
            _httpclient = new HttpClient();
        }
        public async Task<string> GetChatbotResponse(string prompt)
        {
            string url = "https://generativelanguage.googleapis.com/v1beta/models/gemini-2.0-flash:generateContent?key="+apiKey;
            HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Post, url);

            GeminiRequest request = new GeminiRequest
            {
                Contents = new List<Content>
                {
                    new Content
                    {
                        Parts = new List<Part>
                        {
                            new Part
                            {
                                Text=prompt
                            }
                        }
                    }
                }
            };
            message.Content = JsonContent.Create<GeminiRequest>(request);

            var response = await _httpclient.SendAsync(message);
            string answer = await response.Content.ReadAsStringAsync();
            return answer;
        }

    }
}
