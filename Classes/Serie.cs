using System;
using DIOSeries.Enums;
namespace DIOSeries.Classes
{
    public class Serie:EntidadeBase
    {
        //Atributos
        private Genero Genero { get; set; }
        private string Titulo{ get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }

        //Construtor
        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        //Métodos

        public override string ToString()
        {
            string retorno = "";

            string mensagemExcluido = "";
            if(Excluido.Equals(true))
            {
                mensagemExcluido = "Excluído";
            }else
            {
                mensagemExcluido = "Ativo";
            }

            retorno += $"Id: {this.Id}" + Environment.NewLine;
            retorno += $"Gênero: {this.Genero}" + Environment.NewLine;
            retorno += $"Título: {this.Titulo}" + Environment.NewLine;
            retorno += $"Descrição: {this.Descricao}" + Environment.NewLine;
            retorno += $"Ano: {this.Ano}" + Environment.NewLine;
            retorno += $"Excluído: {mensagemExcluido}";

            return retorno;
        }

        public string RetornaTitulo()
        {
            return this.Titulo;
        }

        public int RetornaId()
        {
            return this.Id;
        }

        public void ExcluirSerie()
        {
            this.Excluido = true;
        }
    }
}