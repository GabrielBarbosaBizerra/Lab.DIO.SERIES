using DIOSeries.Interfaces;
using DIOSeries.Classes;
using System.Collections.Generic;
namespace DIOSeries.Classes
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaDeSeries = new List<Serie>();

        public List<Serie> Lista()
        {
            return listaDeSeries;
        }
        public void Inserir(Serie serie)
        {
            listaDeSeries.Add(serie);
        }
        public void Excluir(int id)
        {
            listaDeSeries[id].ExcluirSerie();
        }
        public Serie RetornarPorId(int id)
        {
            return listaDeSeries[id];
        }
        public int ProximoId()
        {
            return listaDeSeries.Count;
        }

        public void Atualizar(int id, Serie objeto)
        {
            listaDeSeries[id] = objeto;
        }
    }
}