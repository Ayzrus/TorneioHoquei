using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneioHoquei.Models
{
    internal class Torneios
    {

        #region Constantes

        public const string Table = "torneios";

        #endregion Constantes

        #region Propriedades

        public int TorneioID { get; set; }
        public string? Nome { get; set; }

        #endregion

        #region Métodos Estáticos

        /// <summary>
        /// Obtém todos os torneios da base de dados.
        /// </summary>
        public static List<Torneios> GetTorneios()
        {
            var torneios = new List<Torneios>();
            using (var connection = new Connection())
            {
                using (var command = new MySqlCommand($"SELECT * FROM {Table}", connection.MySqlConnection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            torneios.Add(MapFromReader(reader));
                        }
                    }
                }
            }
            return torneios;
        }

        /// <summary>
        /// Insere um novo torneio na base de dados.
        /// </summary>
        public static void InserirTorneio(Torneios torneio)
        {
            using (var connection = new Connection())
            {
                var query = $"INSERT INTO {Table} (Nome) VALUES (@Nome)";
                using (var command = new MySqlCommand(query, connection.MySqlConnection))
                {
                    command.Parameters.AddWithValue("@Nome", torneio.Nome);
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Atualiza os dados de um torneio na base de dados.
        /// </summary>
        public static void AtualizarTorneio(Torneios torneio)
        {
            using (var connection = new Connection())
            {
                var query = $"UPDATE {Table} SET Nome = @Nome WHERE TorneioID = @TorneioID";
                using (var command = new MySqlCommand(query, connection.MySqlConnection))
                {
                    command.Parameters.AddWithValue("@Nome", torneio.Nome);
                    command.Parameters.AddWithValue("@TorneioID", torneio.TorneioID);
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Exclui um torneio da base de dados.
        /// </summary>
        public static void ExcluirTorneio(int torneioID)
        {
            using (var connection = new Connection())
            {
                var query = $"DELETE FROM {Table} WHERE TorneioID = @TorneioID";
                using (var command = new MySqlCommand(query, connection.MySqlConnection))
                {
                    command.Parameters.AddWithValue("@TorneioID", torneioID);
                    command.ExecuteNonQuery();
                }
            }
        }

        private static Torneios MapFromReader(MySqlDataReader reader)
        {
            var torneio = new Torneios
            {
                TorneioID = reader.Cast<int>("TorneioID"),
                Nome = reader.Cast<string>("Nome"),
            };
            return torneio;
        }

        #endregion Métodos Estáticos

    }
}
