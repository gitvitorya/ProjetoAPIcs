using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ProjetoAPIcs {
    class Program {
        static void Main(string[] args) {

            var requisicao = WebRequest.CreateHttp("https://jsonplaceholder.typicode.com/todos");
            requisicao.Method = "GET"; // DEFINE O METODO DA REQUISICAO

            //resposta armazena a resposta da requisicao
            using (var resposta = requisicao.GetResponse()) {

                //decodificando
                var stream = resposta.GetResponseStream(); 
                StreamReader leitor = new StreamReader(stream);

                object dados = leitor.ReadToEnd();

                //converte os dados para lista de Tarefas
                List<Tarefa> tarefas = JsonConvert.DeserializeObject<List<Tarefa>>(dados.ToString());

                foreach(Tarefa tarefa in tarefas) {

                    tarefa.Exibir();

                }

                stream.Close(); //toda stream criada deve ser fechada
                resposta.Close();

              //  Console.WriteLine(dados.ToString()); //converte o objeto em string
                Console.ReadLine();

            }

        }
    }
}
