using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        Menu();
    }
    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("1 - Abrir a mochila");
        Console.WriteLine("0 - Sair");
        Console.Write("\nDigite aqui: ");
        
        int opcao = int.Parse(Console.ReadLine());

        switch(opcao)
        {
            case 1: Mochila(); break;
            case 2: Environment.Exit(0); break;
        }
    }
    static void Mochila()
    {
        Console.Clear();
        // Lista para armazenar os itens
        List<string> itens = new List<string>();
        
        itens.Add("Adaga");
        itens.Add("Arco");
        itens.Add("Poção");
        // TODO: Solicite os itens ao usuário
        for (int possui = 0; possui < itens.Count; possui++)
        {
            string item = ($"Item: {possui} - {itens[possui]}");
           
        }

        // Exibe a lista de itens
        Console.WriteLine("Lista de itens:");
        foreach (string item in itens)
        {
            Console.WriteLine($"- {item}");
        }
        Console.WriteLine("\nAperte Qualquer tecla para voltar ao menu");
        Console.ReadKey();
        Menu();
    }
}
