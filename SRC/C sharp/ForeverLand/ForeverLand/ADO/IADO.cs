using System;
using System.Collections.Generic;
using System.Text;

namespace ForeverLand.ADO
{
    public interface IADO
    {
        #region Fichin
        void agregarFichin(Fichin fichin);
        List<Fichin> obtenerFichines();
        #endregion

        #region Cliente
        void agregarCliente(Cliente cliente);
        Cliente clientePorDniPass(int dni, string passEncriptada);
        List<Cliente> obtenerClientes();
        #endregion

        #region Tarjeta
        void agregarTarjeta(Tarjeta tarjeta);
        List<Tarjeta> obteneTarjetas();
        #endregion
    }
}
