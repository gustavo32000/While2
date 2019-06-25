using System;
using System.IO;
using System.Text;

namespace While2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* StreamReader é um leitor de arquivos, ele é uma classe em que você determina o que irá representar o arquivo
            na camada de aplicação, neste caso usamos a variável "arq" que irá representar o arquivo que está no disco local C.
            Para fazer tal representação usamos a estrutura "new StreamReader" e o caminho do arquivo. No exemplo está o arquivo criado
            no disco local C na pasta com o seu nome. Para acessar o arquivo foi necessário iniciar a string do caminho com um "@"
            para evitar os erros com a barra invertida.*/
            StreamReader arq = new StreamReader (@"c:\gugu\arquivo.txt" , Encoding.UTF7);
            string saida = "";
            while ((saida = arq.ReadLine()) !=null){ 
            Console.WriteLine(saida);
                }
            arq.Close();
        }
    }
}
