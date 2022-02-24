using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\dataset4.json");
            //var pneus = JsonConvert.DeserializeObject<List<Pneu>>(json);
            //foreach (var pneu in pneus)
            //{
            //    GravarPneus(pneu);
            //}
            //RecuperarPneus();
            // ExcluirPneus();
            //AtualizarPneu();


            // GravarUsandoAdoNet();
            GravarUsandoEntity();
            //ExcluirProdutos();
            //RecuperarProdutos();


        }

        private static void AtualizarPneu()
        {
            using(var repositorio = new  PneuContext())
            {
                Pneu primeiro = repositorio.Pneus.First();
                primeiro.NomeDoItem = "Teste";
                repositorio.Update(primeiro); // atualiza
                repositorio.SaveChanges();
            }
        }

        private static void ExcluirPneus()
        {
            using (var repositorio = new PneuContext())
            {
                IList<Pneu> pneus = repositorio.Pneus.ToList();
                Console.WriteLine("Foram encontrados {0} pneus", pneus.Count);
                foreach (var pneu in pneus)
                {
                    repositorio.Pneus.Remove(pneu);
                   
                }
                repositorio.SaveChanges();
            }
        }

        private static void RecuperarPneus()
        {
            using(var repositorio = new PneuContext())
            {
                IList<Pneu> pneus = repositorio.Pneus.ToList();
                foreach (var pneu in pneus)
                {
                    Console.WriteLine(pneu.NomeDoItem);
                }
            }
            Console.ReadLine();
        }

        private static void GravarPneus(Pneu item)
        {
           
                using (var contexto = new PneuContext())
                {
                    contexto.Pneus.Add(item);
                    contexto.SaveChanges();
                }
            
          
        }

        private static void ExcluirProdutos()
        {
            using (var repo = new  LojaContext())
            {
                IList<Produto> produtos = repo.Produtos.ToList();
                foreach (var item in produtos)
                {
                    repo.Produtos.Remove(item);

                }
                repo.SaveChanges();
            }
        }
        private static void RecuperarProdutos()
        {
            using (var repo = new LojaContext())
            {
                IList<Produto> produtos = repo.Produtos.ToList();
                Console.WriteLine("Foram encontrados {0} produtos.", produtos.Count);
                foreach (var item in produtos)
                {
                    Console.WriteLine(item.Nome);
                    
                }
                Console.ReadLine();
            }
        }
        private static void GravarUsandoEntity()
        {
            Produto p = new Produto();
            p.Nome = "Douglas Martins e a Engenharia";
            p.Categoria = "Ebook";
            p.Preco = 1900.89;

            using (var contexto = new LojaContext())
            {
                contexto.Produtos.Add(p);
                contexto.SaveChanges();
            }
        }

        private static void GravarUsandoAdoNet()
        {
            Produto p = new Produto();
            p.Nome = "Harry Potter e a Ordem da Fênix";
            p.Categoria = "Livros";
            p.Preco = 19.89;

            using (var repo = new ProdutoDAO())
            {
                repo.Adicionar(p);
            }
        }

    }
}
