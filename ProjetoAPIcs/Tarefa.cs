using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAPIcs {
    class Tarefa {

        //necessario mesmo nome que na api
        public int userId;
        public int id;
        public string title;
        public bool completed;

        public void Exibir() {

            Console.WriteLine("Objeto tarefa");
            Console.WriteLine($"UserId: {userId}");
            Console.WriteLine($"Id: {id}");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Finalizou?: {completed}");
            Console.WriteLine("------------------------------------------------");

        }

    }
}
