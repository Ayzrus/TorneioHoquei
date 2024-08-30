using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneioHoquei.Models
{
    internal class Equipa
    {

        #region Constantes

        public const string Table = "equipas";

        #endregion Constantes

        #region Propriedades

        public int EquipeID { get; set; }
        public string? Nome { get; set; }
        public int? TreinadorID { get; set; }
        public string? Treinador { get; set; }

        #endregion

        #region Métodos Estáticos

        /// <summary>
        /// Obtém todas as equipas da base de dados.
        /// </summary>
        public static List<Equipa> GetEquipas()
        {
            var equipas = new List<Equipa>();
            using (var connection = new Connection())
            {
                var query = $"SELECT equipas.*, treinadores.Nome AS Treinador FROM {Table} " +
                            "LEFT JOIN treinadores ON equipas.TreinadorID = treinadores.TreinadorID";
                using (var command = new MySqlCommand(query, connection.MySqlConnection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            equipas.Add(MapFromReader(reader));
                        }
                    }
                }
            }
            return equipas;
        }

        /// <summary>
        /// Insere uma nova equipa na base de dados.
        /// </summary>
        public static void InserirEquipa(Equipa equipa)
        {
            using (var connection = new Connection())
            {
                var query = $"INSERT INTO {Table} (Nome, TreinadorID) VALUES (@Nome, @TreinadorID)";
                using (var command = new MySqlCommand(query, connection.MySqlConnection))
                {
                    command.Parameters.AddWithValue("@Nome", equipa.Nome);
                    command.Parameters.AddWithValue("@TreinadorID", equipa.TreinadorID);
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Atualiza os dados de uma equipa na base de dados.
        /// </summary>
        public static void AtualizarEquipa(Equipa equipa)
        {
            using (var connection = new Connection())
            {
                var query = $"UPDATE {Table} SET Nome = @Nome, TreinadorID = @TreinadorID WHERE EquipeID = @EquipeID";
                using (var command = new MySqlCommand(query, connection.MySqlConnection))
                {
                    command.Parameters.AddWithValue("@Nome", equipa.Nome);
                    command.Parameters.AddWithValue("@TreinadorID", equipa.TreinadorID);
                    command.Parameters.AddWithValue("@EquipeID", equipa.EquipeID);
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Exclui uma equipa da base de dados.
        /// </summary>
        public static void ExcluirEquipa(int equipeID)
        {
            using (var connection = new Connection())
            {
                var query = $"DELETE FROM {Table} WHERE EquipeID = @EquipeID";
                using (var command = new MySqlCommand(query, connection.MySqlConnection))
                {
                    command.Parameters.AddWithValue("@EquipeID", equipeID);
                    command.ExecuteNonQuery();
                }
            }
        }

        private static Equipa MapFromReader(MySqlDataReader reader)
        {
            var equipa = new Equipa
            {
                EquipeID = reader.Cast<int>("EquipeID"),
                Nome = reader.Cast<string>("Nome"),
                TreinadorID = reader.Cast<int?>("TreinadorID"),
                Treinador = reader.Cast<string>("Treinador")
            };
            return equipa;
        }

        #endregion Métodos Estáticos

    }
}
