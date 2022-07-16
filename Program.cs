namespace ArrayListas
{
    static class Program
    {
        static void Main(string[]args)
        {
            Console.Clear(); 

            //ARRAY - é um vetor de uma única dimensão só (unidimensional)
            //sua posição é iniciada sempre em 0. Sempre devemos usar a palavra new.
            //devemos inicializá-lo com o tipo de dado ou var especificando o seu tamanho.
            //um array não está limitado a um tipo primitivo. É possível usar com struct, por exemplo. 
            //acaba não sendo muito usado por sem simples. Em .NET usamos outros tipos de listas.
            //os arrays são reference types, ou seja, se copiar e alterar o seu valor será modificado.

            //exemplo de array de inteiro (duas formas de declarar)
            var meuArray = new int[5];
            int[] outroArray = new int[5];

            //Inicializando um array em sua definição com valores do tipo especificado
            var arrayInicializado = new string[] {"João", "Maria", "José"};

            //Adicionando um valor a uma posição do array
            meuArray[3] = 20; 

            //Criando um array de struct (diferente do primitivo)
            decimal totalValue = 0m; 
            var produtos = new EProduct[10]; 
            produtos[5] = new EProduct {Id = 1, Nome = "Notebook", Value = 2000.35m};        
            for(int x=0;x<10;x++)
            {         
                System.Console.WriteLine($"Produto {x+1}: {produtos[x].Nome}");
                System.Console.WriteLine($"Valor: {produtos[x].Value}");
                System.Console.WriteLine("----------");
                totalValue += produtos[x].Value;
            }                
            System.Console.WriteLine("Total do valor dos produtos: " + totalValue.ToString("C"));

            //Acessando posições específicas do Array
            for(int i=0;i < meuArray.Length;i++)
                System.Console.WriteLine($"Posição {i+1} = {meuArray[i]}");

            //Percorrendo o array com foreach
            foreach(var nome in arrayInicializado)
                System.Console.WriteLine(nome);   


            //Existem métodos interessantes para trabalhar com arrays.   
            //=> Clone() - permite copiar um array para outro (todos os valores);
            //=> Copy() - permite copiar um array para outro (apenas os valores especificados);


            var arrayReference = new int[] {10,12,15};
            //Esse método não funciona, pois irá modificar o array original (arrayReference)
            // var newArray = arrayReference; 
            
            //Clonando um array corretamente
            var newArray = arrayReference.Clone() as int[]; 
            newArray[0] = 20; //não irá alterar o valor de arrayReference
            newArray[1] = 24; 
            newArray[2] = 30; 
            foreach(var value in arrayReference) 
                System.Console.WriteLine(value);

            //Copiando um array para um destino a partir de uma posição
            var arrayCopy = new int[3]; 
            arrayReference.CopyTo(arrayCopy,0);
            System.Console.WriteLine(arrayCopy[0]);   

            //Buscando a quantidade de itens do array
            System.Console.WriteLine($"Tamanho do array: {arrayCopy.Length}");
            
        }
    }
}