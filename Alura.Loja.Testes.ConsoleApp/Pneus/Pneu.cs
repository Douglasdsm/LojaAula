using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    public class Pneu
    {
        public int Id { get; internal set; }
        public int idprod { get; set; }
        public string CodigoDeBarras { get; set; }
        public string CodigoDeFabricacao { get; set; }
        public string NomeDoItem { get; set; }
        public string DescricaoDetalhada { get; set; }
        public string Aplicacao { get; set; }
        public string MarcaDeItens { get; set; }
        public string UnidadeDeMedida { get; set; }
        public string EmbalagemDeVenda { get; set; }
        public string LinhaDeItens { get; set; }
        public string FamiliaDeItens { get; set; }
        public string GrupoDeItens { get; set; }
        public string PesoBruto { get; set; }
        public string PesoLiquido { get; set; }
        public string CodigoOriginal { get; set; }
        public string NaturezaDeItens { get; set; }
        public string CodigoMontadora { get; set; }
        public int NCM { get; set; }
        public string AlturaItem { get; set; }
        public string LarguraItem { get; set; }
        public string ComprimentoItem { get; set; }
        public string Aro { get; set; }
        public string Perfil { get; set; }
        public string IndiceDeCarga { get; set; }
        public string Estrutura { get; set; }
        public string Modelo { get; set; }
        public string IndiceDeVelocidade { get; set; }
        public int IdImagem { get; set; }
    }
}
