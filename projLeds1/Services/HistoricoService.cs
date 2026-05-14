using System.Collections.Generic;
using projLeds1.Models;

namespace projLeds1.Services
{
    public class HistoricoService
    {
        private List<RegistroHistorico> registros;

        public HistoricoService()
        {
            registros = new List<RegistroHistorico>();
        }

        public void Adicionar(RegistroHistorico registro)
        {
            registros.Add(registro);
        }

        public List<RegistroHistorico> GetTodos()
        {
            return registros;
        }
    }
}