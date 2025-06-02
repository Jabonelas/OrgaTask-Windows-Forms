# OrgaTask Windows Forms

![.NET](https://img.shields.io/badge/.NET%20Framework-4.8-%23512BD4)
![Windows Forms](https://img.shields.io/badge/Windows%20Forms-Desktop%20App-%230078D7)
![DevExpress](https://img.shields.io/badge/DevExpress-24.1-%23FF7200)


## 💻 **Sobre o OrgaTask**  
**Aplicativo desktop** para gestão de tarefas, onde usuários podem:  
- Criar/gerenciar tarefas com prioridades e status  
- Experiência tradicional para usuários Windows  
- Ter dados sincronizados em tempo real  
 


> Frontend desktop do ecossistema OrgaTask - Aplicação Windows Forms para gerenciamento de tarefas

![image](https://github.com/user-attachments/assets/f8180a35-adb8-494b-a425-94f4c47a148b)

  <p><em>Interface principal com componentes DevExpress</em></p>


## 📋 Visão Geral
Aplicação desktop que consome a **OrgaTask API** para:
- Autenticação segura de usuários via JWT
- Gerenciamento completo de tarefas (CRUD)
- Controle de prioridades (Baixa, Média, Alta)
- Filtros por status (Pendente, Em Progresso, Concluída)

## 🌐 Ecossistema OrgaTask
Esta aplicação consome:
- [OrgaTask API](https://github.com/Jabonelas/OrgaTask-API) (Backend principal)
  
Outros frontends do sistema:
- [OrgaTask Blazor WebAssembly](https://github.com/Jabonelas/OrgaTask-Blazor-WebAssembly) (Versão Web)

- 📊 Arquitetura do Sistema

![OrganizacaoOrgaTask](https://github.com/user-attachments/assets/bae20b56-ace7-4ef0-8d14-7fe13f1d9d31)
Figura 1: Visão geral da integração entre os componentes do OrgaTask.
A API central (Backend) serve dados para os frontends Web e Desktop.


## 🛠 Tecnologias
- **Plataforma**: Windows Forms (.NET Framework 4.8)
- **UI Framework**: DevExpress 24.1 
- **Autenticação**: JWT Bearer Tokens
- **Consumo de API**: REST (HttpClient)
- **Controle de Erros**: Sistema de logging customizado em arquivos de log (pasta /OrgaTask_Logs)
- **Padrões Arquiteturais**:
  - **Service Layer**: Separação clara entre controllers e lógica de negócio
  - **Injeção de Dependência**: Nativa do .NET (IServiceCollection)

## 🚀 Como Executar
1. **Pré-requisitos**:
   - [.NET Framework 4.8](https://dotnet.microsoft.com/download/dotnet-framework/net48)
   - [DevExpress Components](https://www.devexpress.com/) (Versão 24.1 ou compatível)
   - OrgaTask API em execução (siga o [README da API](https://github.com/Jabonelas/OrgaTask-API#-como-executar))

2. **Configuração**:
   ```bash
   git clone https://github.com/Jabonelas/OrgaTask-Windows-Forms.git
