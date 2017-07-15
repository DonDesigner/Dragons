using Dragv2.Domain.Entities;
using Dragv2.Infra;
using Dragv2.Infra.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragv2.ViewConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Controle REPOSITORIO
           

            PopularBD();
            var dr = new DragaoRepositorio();






            //Localizar
            // var dragao1 = dr.Single(x => x.Nome == "Valdemor");
            //Console.WriteLine(String.Format("{0,-30} | {1,-17} | {2} | {3}", dragao1.Id, dragao1.Nome, dragao1.Familia, dragao1.Cor));

            //Excluir
            //var dragao2 = dr.Single(x => x.Nome == "Vergano");
            //dr.Delete(dragao2);

            //Atualizar
            //var dragao = dr.Single(x => x.Nome == "Draco");
            //if (dragao != null)
            //{
            //    dragao.SetNome("Dragones");
            //    dragao.SetFamilia("Draconildos");
            //    dragao.SetCor("Azul tomate");
            //    dr.Update(dragao);
            //}
            


            //Listar
            List<Dragao> listDrag = dr.All<Dragao>().ToList();
            DisplayDragons(listDrag);

            ///FIM
            Console.WriteLine("Concluido...");
            Console.ReadKey();
        }

        private static void DisplayDragons(List<Dragao> dragons)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(String.Format("{0,-36} | {1,-10} | {2,-23} | {3,4}", "Id", "Nome", "Familia", "Cor"));
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");

            Console.ForegroundColor = ConsoleColor.White;
            foreach (Dragao d in dragons)
            {
                Console.WriteLine(String.Format("{0,-36} | {1,-10} | {2,-23} | {3}", d.Id, d.Nome, d.Familia, d.Cor));
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");

            Console.ResetColor();
        }

        private static void PopularBD()
        {
            var dr = new DragaoRepositorio();

            //Adicionar 
            var pro1 = new Provincia("Origon", "South Englend");
            var dom1 = new Domador("John Snow", 34, pro1);
            var drag1 = new Dragao("Draco", "Coração de Dragão", "Marrom", 125, dom1);
            dr.Add(drag1);

            /*
            var drag2 = new Dragao("Banguela", "Como treinar seu dragão", "Preto", 45);
            dr.Add(drag2);

            var drag3 = new Dragao("Malevola", "A bela adormecida", "Lilas", 155);
            dr.Add(drag3);

            var drag4 = new Dragao("Yoshi", "Mario Bros", "Verde", 35);
            dr.Add(drag4);

            var drag5 = new Dragao("Norberto", "Harry Poter", "Beje", 1);
            dr.Add(drag5);

            var drag6 = new Dragao("Falkor", "História sem fim", "Branco", 1000);
            dr.Add(drag6);
            */
        }
    }
}
