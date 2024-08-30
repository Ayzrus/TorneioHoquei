using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneioHoquei.Models
{
    internal class Fase
    {

        #region Constantes

        public const string Table = "fases";

        #endregion Constantes

        #region Propriedades

        public int FaseID { get; set; }
        public string? Tipo { get; set; }
        public int TorneioID { get; set; }
        public string Torneio { get; set; }

        #endregion

        #region Métodos Estáticos

        /// <summary>
        /// Obtém todas as fases da base de dados.
        /// </summary>
        public static List<Fase> GetFases()
        {
            var fases = new List<Fase>();
            using (var connection = new Connection())
            {
                using (var command = new MySqlCommand($"SELECT F.*, T.Nome AS Torneio FROM {Table} F" +
                    $" LEFT JOIN torneios T ON T.TorneioID = F.TorneioID", connection.MySqlConnection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            fases.Add(MapFromReader(reader));
                        }
                    }
                }
            }
            return fases;
        }

        /// <summary>
        /// Insere uma nova fase na base de dados.
        /// </summary>
        public static void InserirFase(Fase fase)
        {
            using (var connection = new Connection())
            {
                var query = $"INSERT INTO {Table} (Tipo, TorneioID) VALUES (@Tipo, @TorneioID)";
                using (var command = new MySqlCommand(query, connection.MySqlConnection))
                {
                    command.Parameters.AddWithValue("@Tipo", fase.Tipo);
                    command.Parameters.AddWithValue("@TorneioID", fase.TorneioID);
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Atualiza os dados de uma fase na base de dados.
        /// </summary>
        public static void AtualizarFase(Fase fase)
        {
            using (var connection = new Connection())
            {
                var query = $"UPDATE {Table} SET Tipo = @Tipo, TorneioID = @TorneioID WHERE FaseID = @FaseID";
                using (var command = new MySqlCommand(query, connection.MySqlConnection))
                {
                    command.Parameters.AddWithValue("@Tipo", fase.Tipo);
                    command.Parameters.AddWithValue("@TorneioID", fase.TorneioID);
                    command.Parameters.AddWithValue("@FaseID", fase.FaseID);
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Exclui uma fase da base de dados.
        /// </summary>
        public static void ExcluirFase(int faseID)
        {
            using (var connection = new Connection())
            {
                var query = $"DELETE FROM {Table} WHERE FaseID = @FaseID";
                using (var command = new MySqlCommand(query, connection.MySqlConnection))
                {
                    command.Parameters.AddWithValue("@FaseID", faseID);
                    command.ExecuteNonQuery();
                }
            }
        }

        private static Fase MapFromReader(MySqlDataReader reader)
        {
            var fase = new Fase
            {
                FaseID = reader.Cast<int>("FaseID"),
                Tipo = reader.Cast<string>("Tipo"),
                TorneioID = reader.Cast<int>("TorneioID"),
                Torneio = reader.Cast<string>("Torneio"),
            };
            return fase;
        }

        #endregion Métodos Estáticos

    }
}
