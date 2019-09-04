using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMLista.Clases
{
    public class Lista
    {
        #region PROPIEDADES
        private int ProximaPosicion = 0;
        private string[,] lista = new string[2, 1];
        private int columnas = 2;
        #endregion

        #region CONSTRUCTOR
        #endregion

        #region METODOS
        public bool Agregar(string aTexto, string aNota)
        {
            bool Resp = false;
            try
            {
                if (ProximaPosicion == lista.Length)
                {
                    this.AgregaRegistro(1);
                }

                lista[0,ProximaPosicion] = aTexto;
                lista[1,ProximaPosicion] = aNota;
                ProximaPosicion=ProximaPosicion+2;
                Resp = true;
            }
            catch (Exception err)
            {
                throw err;
            }

            return Resp;
        }

        public string MostrarLista(int opcion)
        {
            string Respuesta = "";
            if (ProximaPosicion > 0)
            {
                Respuesta = lista[0,0];
                for (int i = 1; i < ProximaPosicion; i++)
                {
                    Respuesta = Respuesta + "\r\n" + lista[opcion,i];
                }
            }
            return Respuesta;
        }

        private void AgregaRegistro(int incremento)
        {
            string[,] Temp = new string[0,lista.Length + incremento*columnas];
            lista = this.Copiar(lista, Temp);
        }

        private string[,] Copiar(string[,] Origen, string[,] Destino)
        {
            for (int i = 0; i < ProximaPosicion; i++)
            {
                Destino[0,i] = Origen[0,i];
            }
            return Destino;
        }

        /// <summary>
        /// Devuelve la posicion del texto (entero) dentro del arregla, <br/>
        /// la cuenta inicia en 0 (cero).
        /// Devuelve -1 cuando no encuentra Que en la lista.
        /// </summary>
        /// <param name="Que">texto completo a buscar en la lista</param>
        public int BuscarPosicion(string Que)
        {
            int Resp = -1;

            for (int i = 0; i < lista.Length; i++)
            {
                if (lista[0,i].CompareTo(Que) == 0)
                {
                    Resp = i;
                    break;
                }
            }

            return Resp;
        }

        public string Borrar(string Que)
        {
            string Resp = "";
            int Pos = this.BuscarPosicion(Que);
            if(Pos==-1)
            {
                Resp = Que + " no ha sido encontrado en la lista.";
            }
            else
            {
                for (int i = Pos; i < ProximaPosicion-1; i++)
                {
                    this.lista[0,i] = this.lista[0,i + 1];
                }
                this.lista[0,ProximaPosicion-1] = null;
                ProximaPosicion = ProximaPosicion - 1;
                AgregaRegistro(-1);
            }

            return Resp;
        }

        #endregion
    }
}
