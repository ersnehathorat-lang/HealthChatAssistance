HealthChat Assistant – Azure OpenAI + .NET 8 + HTML/JS
A lightweight AI-powered healthcare assistant built using Azure OpenAI (GPT‑4o‑mini), ASP.NET Core Web API, and a simple HTML/JavaScript frontend.
This project demonstrates how to integrate Azure AI models into real-world applications using clean API design and modern SDK patterns.

⭐ Features
- AI-powered chat using Azure OpenAI GPT‑4o‑mini
- Clean .NET 8 Web API backend
- Simple, responsive HTML/JS frontend
- Supports natural language questions about general healthcare topics
- Fully configurable via appsettings.json
- Ready for deployment to Azure App Service or GitHub Pages + Azure API
🧱 Architecture Overview
[HTML/JS Frontend]  →  [ASP.NET Core Web API]  →  [Azure OpenAI GPT‑4o‑mini]
- The frontend sends user questions to the backend.
- The backend calls Azure OpenAI using the new ChatClient SDK.
- The model generates a response and returns it to the UI.
🚀 Tech Stack
- Azure OpenAI Service
- Model: GPT‑4o‑mini (Global Standard)
- Backend: ASP.NET Core Web API (.NET 8)
- Frontend: HTML, CSS, JavaScript
- Deployment: Azure App Service (optional)

📁 Project Structure
HealthChatService/
 ├── Controllers/
 │     └── ChatController.cs
 ├── Services/
 │     └── ChatService.cs
 ├── wwwroot/
 │     └── index.html
 ├── appsettings.json
 ├── Program.cs
 └── README.md

 🔧 Configuration
Update your Azure OpenAI settings in appsettings.json:
"AzureOpenAI": {
  "Endpoint": "https://YOUR-ENDPOINT.openai.azure.com/",
  "ApiKey": "YOUR-KEY",
  "DeploymentName": "gpt-4o-mini"
}
🧠 Backend API Example
POST /api/chat
Request:
{
  "prompt": "What are common side effects of antibiotics?"
}

Response:
{
  "answer": "Common side effects may include nausea, diarrhea, and mild stomach upset..."
}

🌐 Frontend
The frontend is a simple HTML/JS page located in wwwroot/index.html.
It sends a POST request to:
https://localhost:7025/api/chat

▶️ Running the Project Locally
- Clone the repo
- Open in Visual Studio / VS Code
- Update appsettings.json with your Azure OpenAI credentials
- Run the API (https://localhost:7025)
- Open https://localhost:7025/index.html in your browser
- Start chatting with the AI assistant




