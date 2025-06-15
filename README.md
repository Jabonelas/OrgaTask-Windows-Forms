# OrgaTask Windows Forms

## Visão Geral

OrgaTask Windows Forms é uma aplicação desktop que consome a OrgaTask API para gerenciar tarefas. Desenvolvida com Windows Forms e DevExpress, a aplicação oferece uma interface funcional, com foco em usabilidade.

## Tecnologias Utilizadas

- **Plataforma:** Windows Forms (.NET Framework 4.8)
- **UI Framework:** DevExpress 24.1

- **Comunicação:**

  - Consumo de API REST via HttpClient
  - Autenticação com JWT Bearer Tokens

- **Controle de Erros:** Logging customizado (pasta /OrgaTask_Logs)

- **Padrões Arquiteturais:**

  - Service Layer: Separação entre UI e lógica de negócio
  - Injeção de Dependência: Nativa do .NET (IServiceCollection)

## Funcionalidades

- Autenticação via JWT
- Gerenciamento de tarefas (listar, criar, editar, excluir)
- Interface rica com controles DevExpress
- Sistema de logging para rastreamento de erros

## Pré-requisitos

- .NET Framework 4.8
- OrgaTask API rodando localmente ou em um servidor
- Windows 10 ou superior
- Licença DevExpress (ou use a versão trial)

## Como Executar o Projeto

**1. Clone o repositório:**

```bash
git clone https://github.com/Jabonelas/OrgaTask-Windows-Forms.git
cd OrgaTask-Windows-Forms
```

  **2. Restaure as dependências:**

  - Abra a solução no Visual Studio.
  - Restaure os pacotes NuGet: Tools > NuGet Package Manager > Restore NuGet Packages.

**3. Configure a URL da API:**
  
  - No arquivo InjecaoDependencia.cs, altere a URL da API (por padrão em modo desenvolvimento: https://localhost:7170) para o endpoint desejado (ex.: https://localhost:7091).

**4. Compile e execute:**

  - No Visual Studio, pressione F5 ou clique em Run.

**5. Verifique os logs em: OrgaTask_Logs (criada automaticamente).**

## Exemplo de Uso

1. Inicie a aplicação e faça login com credenciais válidas.
2. Use a interface para visualizar, criar ou editar tarefas.
3. Consulte os logs em /OrgaTask_Logs para depuração, se necessário.

Capturas de Tela

<p><em>Interface Dashboard</em></p>

![image](https://github.com/user-attachments/assets/db77203f-87c6-455a-a88a-0339de7f9f90)
> Painel visual com acompanhamento do progresso e status de todas as atividades

<p><em>Interface Tarefas</em></p>

![image](https://github.com/user-attachments/assets/5a61757d-d567-482a-aa1c-f6c96c358e7b)
> Visualização integrada de todas as tarefas registradas










Contribuições

Sinta-se à vontade para abrir issues ou enviar pull requests. Sugestões de melhorias são sempre bem-vindas!
