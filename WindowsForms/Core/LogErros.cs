using System;
using System.IO;
using WindowsForms.Classes;

namespace WindowsForms.Core
{
    public static class LogErros
    {
        public static void GravarLogErros(string _mensagem)
        {
            try
            {
                string path = @"C:\Program Files (x86)\OrgaTask Setup\OrgaTask_Logs\LogErros.txt";

                if (!File.Exists(path))
                {
                    ResultadoOperacao.Falha("Arquivo de log não encontrado.", TipoErro.Validacao);

                    CriarLogs();

                    return;
                }

                using (System.IO.StreamWriter file = new System.IO.StreamWriter(path, true))
                {
                    file.WriteLine($"Data: {DateTime.Now}\n" +
                                   $"Mensagem: {_mensagem}\n" +
                                   "-------------------------------------------\n");
                }
            }
            catch (Exception ex)
            {
                ResultadoOperacao.Falha($"Erro ao gravar log de erro: {ex.Message}", TipoErro.Desconhecido);
            }
        }

        private static void CriarLogs()
        {
            try
            {
                // Defina o caminho da pasta
                string folderPath = @"C:\Program Files (x86)\OrgaTask Setup\OrgaTask_Logs\LogVerificacao.txt";

                // Crie a pasta (se ela não existir)
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                // Caminhos dos arquivos .txt
                string filePath1 = Path.Combine(folderPath, "LogErros.txt");

                // Conteúdo dos arquivos
                string conteudoArquivo1 = "Inicializando os logs de erro.";

                // Crie e escreva o conteúdo nos arquivos
                System.IO.File.WriteAllText(filePath1, conteudoArquivo1);
            }
            catch (Exception ex)
            {
                ResultadoOperacao.Falha($"Erro durante a criação dos arquivos de Log: {ex.Message}", TipoErro.Desconhecido);
            }
        }
    }
}