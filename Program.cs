using Raven.Client.Documents;
using Raven.Client.Documents.Linq;
using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

class Program {
    static void Main() {
        string serverUrl = "https://ravendb.telecomwm.com.br"; // URL do servidor do RavenDB
        string databaseName = "GED"; // Nome do banco de dados no RavenDB
        string certFilePath = "C:\\Users\\G053\\Downloads\\paulopimenta.azure.client.certificate\\paulopimenta.azure.client.certificate.pfx"; // Caminho para o arquivo do certificado PFX
        string certPassword = ""; // Senha do certificado PFX

        try {
            X509Certificate2 cert = new X509Certificate2(certFilePath, certPassword);

            // Configurar as opções do cliente do RavenDB com o certificado
            IDocumentStore store = new DocumentStore {
                Urls = new[] { serverUrl },
                Database = databaseName,
                Certificate = cert
            }.Initialize();

            using (var session = store.OpenSession()) {
                // Carregar o documento pelo ID
                var result = session.Load<GedDocument>("GEDFileDocuments/162689-A");
                if (result != null) {
                    Console.WriteLine("Documento encontrado:");
                    Console.WriteLine("ID: " + result.Id);

                    // Acessar e exibir o conteúdo do arquivo
                    Console.WriteLine("Conteúdo do arquivo:");
                    Console.WriteLine(result.Name);
                }
                else {
                    Console.WriteLine("Documento não encontrado.");
                }
            }

            store.Dispose(); // Certifique-se de liberar os recursos corretamente
        }
        catch (Exception ex) {
            Console.WriteLine("Erro ao conectar ao RavenDB: " + ex.Message);
        }
    }
}

// Classe de exemplo para mapeamento de documento
public class GedDocument {
    public string Id { get; set; }
    public string Name { get; set; }
}
