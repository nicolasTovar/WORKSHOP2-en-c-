using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WORKSHOP2
{
    class Dato
    {
        public DataSet obtenerTablas()
        {
            SqlConnection conex = ConexionBaseDatos.obtenerConexion();
            SqlCommand comandCat = new SqlCommand("pa_Categoria", conex);
            comandCat.CommandType = CommandType.StoredProcedure;
            SqlCommand comandoProd = new SqlCommand("pa_Producto", conex);
            comandoProd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter daCat = new SqlDataAdapter(comandCat);
            SqlDataAdapter daProd = new SqlDataAdapter(comandoProd);
            DataSet dsDatos = new DataSet();
            daCat.Fill(dsDatos, "Categoria");
            daProd.Fill(dsDatos, "Producto");
            conex.Close();
            return dsDatos;


        }

        public DataSet mostrarTabla()
        {
            SqlConnection conexion = ConexionBaseDatos.obtenerConexion();
            SqlCommand comando = new SqlCommand("pa_Producto", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataSet daSet = new DataSet();
            adaptador.Fill(daSet, "Produto");
            conexion.Close();
            return daSet;
        }

        public DataSet mostrarInicial(string inicial)
        {
            SqlConnection conexion = ConexionBaseDatos.obtenerConexion();
            SqlCommand comando = new SqlCommand("pa_Inicial", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            SqlParameter parametro = new SqlParameter("@Pincial", SqlDbType.Text);
            comando.Parameters.Add(parametro).Value = inicial;
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataSet dsSet = new DataSet();
            adaptador.Fill(dsSet, "Producto");
            conexion.Close();
            return dsSet;
        }

        public DataSet mostrarNombre(ref ComboBox combo)
        {
            SqlConnection conexion = ConexionBaseDatos.obtenerConexion();
            SqlCommand comando = new SqlCommand("pa_Nombre", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            SqlDataReader read = comando.ExecuteReader();
            while (read.Read())
            {
                combo.Items.Add(read["NomCat"]).ToString();
            }
            DataSet dataSet = new DataSet();
            conexion.Close();
            return dataSet;
        }

        public DataSet comboNombre(string categoria)
        {
            SqlConnection conexion = ConexionBaseDatos.obtenerConexion();
            DataSet daset = new DataSet();
            if (categoria == "Lacteos")
            {
                SqlCommand comando = new SqlCommand("pa_Clacteos", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                SqlParameter parametro = new SqlParameter("@Codigo", SqlDbType.Int);
                comando.Parameters.Add(parametro).Value = 1;
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                adapter.Fill(daset, "Producto");
                conexion.Close();

            }
            else if (categoria == "Granos")
            {
                SqlCommand comando = new SqlCommand("pa_Cgranos", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                SqlParameter parametro = new SqlParameter("@Codigo", SqlDbType.Int);
                comando.Parameters.Add(parametro).Value = 2;
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                adapter.Fill(daset, "Producto");
                conexion.Close();

            }
            else if (categoria == "Carnes")
            {
                SqlCommand comando = new SqlCommand("pa_Ccarnes", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                SqlParameter parametro = new SqlParameter("@Codigo", SqlDbType.Int);
                comando.Parameters.Add(parametro).Value = 3;
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                adapter.Fill(daset, "Producto");
                conexion.Close();

            }
            else if (categoria == "Bebidas")
            {
                SqlCommand comando = new SqlCommand("pa_CBebidas", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                SqlParameter parametro = new SqlParameter("@Codigo", SqlDbType.Int);
                comando.Parameters.Add(parametro).Value = 4;
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                adapter.Fill(daset, "Producto");
                conexion.Close();

            }
            else if (categoria == "Aseo")
            {
                SqlCommand comando = new SqlCommand("pa_CAseo", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                SqlParameter parametro = new SqlParameter("@Codigo", SqlDbType.Int);
                comando.Parameters.Add(parametro).Value = 5;
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                adapter.Fill(daset, "Producto");
                conexion.Close();

            }
            return daset;
        }

        public DataSet ascendente(string ascendente)
        {
            SqlConnection conexion = ConexionBaseDatos.obtenerConexion();
            DataSet daSet = new DataSet();
            if (ascendente == "CodProd")
            {
                SqlCommand comando = new SqlCommand("pa_Pasc", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                adapter.Fill(daSet, "Producto");
                conexion.Close();
                
            }
            else if (ascendente == "NomProd")
            {
                SqlCommand comando = new SqlCommand("pa_Nasc", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                adapter.Fill(daSet, "Producto");
                conexion.Close();

            }
           else  if (ascendente == "CodCat")
            {
                SqlCommand comando = new SqlCommand("pa_Casc", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                adapter.Fill(daSet, "Producto");
                conexion.Close();

            }
            return daSet;


        }

        public DataSet descendente (string descendente)
        {
            SqlConnection conexion = ConexionBaseDatos.obtenerConexion();
            DataSet daSet = new DataSet();
            if (descendente == "CodProd")
            {
                SqlCommand comando = new SqlCommand("pa_Pdsc", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                adapter.Fill(daSet, "Producto");
                conexion.Close();

            }
            else if (descendente == "NomProd")
            {
                SqlCommand comando = new SqlCommand("pa_Ndsc", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                adapter.Fill(daSet, "Producto");
                conexion.Close();

            }
            else if (descendente == "CodCat")
            {
                SqlCommand comando = new SqlCommand("pa_Cdsc", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                adapter.Fill(daSet, "Producto");
                conexion.Close();

            }
            return daSet;
        }
    }
}
