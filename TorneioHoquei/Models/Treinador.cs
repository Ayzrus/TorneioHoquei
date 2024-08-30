using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneioHoquei.Models
{
    internal class Treinador
    {

        #region Constantes

        public const string Table = "treinadores";

        #endregion Constantes

        #region Propriedades

        public int TreinadorID { get; set; }
        public string? CartaoCidadao { get; set; }
        public string? Nome { get; set; }
        public string? Nacionalidade { get; set; }
        public int? AnosExperiencia { get; set; }

        #endregion

        #region Métodos Estáticos

        /// <summary>
        /// Obtém todos os treinadores da base de dados.
        /// </summary>
        public static List<Treinador> GetTreinadores()
        {
            var treinadores = new List<Treinador>();
            using (var connection = new Connection())
            {
                using (var command = new MySqlCommand($"SELECT * FROM {Table}", connection.MySqlConnection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            treinadores.Add(MapFromReader(reader));
                        }
                    }
                }
            }
            return treinadores;
        }

        /// <summary>
        /// Insere um novo treinador na base de dados.
        /// </summary>
        public static void InserirTreinador(Treinador treinador)
        {
            using (var connection = new Connection())
            {
                var query = $"INSERT INTO {Table} (CartaoCidadao, Nome, Nacionalidade, AnosExperiencia) VALUES " +
                    $"(@CartaoCidadao, @Nome, @Nacionalidade, @AnosExperiencia)";
                using (var command = new MySqlCommand(query, connection.MySqlConnection))
                {
                    command.Parameters.AddWithValue("@CartaoCidadao", treinador.CartaoCidadao);
                    command.Parameters.AddWithValue("@Nome", treinador.Nome);
                    command.Parameters.AddWithValue("@Nacionalidade", treinador.Nacionalidade);
                    command.Parameters.AddWithValue("@AnosExperiencia", treinador.AnosExperiencia);
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Atualiza os dados de um treinador na base de dados.
        /// </summary>
        public static void AtualizarTreinador(Treinador treinador)
        {
            using (var connection = new Connection())
            {
                var query = $"UPDATE {Table} SET CartaoCidadao = @CartaoCidadao, Nome = @Nome, Nacionalidade = @Nacionalidade, " +
                    $"AnosExperiencia = @AnosExperiencia WHERE TreinadorID = @TreinadorID";
                using (var command = new MySqlCommand(query, connection.MySqlConnection))
                {
                    command.Parameters.AddWithValue("@CartaoCidadao", treinador.CartaoCidadao);
                    command.Parameters.AddWithValue("@Nome", treinador.Nome);
                    command.Parameters.AddWithValue("@Nacionalidade", treinador.Nacionalidade);
                    command.Parameters.AddWithValue("@AnosExperiencia", treinador.AnosExperiencia);
                    command.Parameters.AddWithValue("@TreinadorID", treinador.TreinadorID);
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Exclui um treinador da base de dados.
        /// </summary>
        public static void ExcluirTreinador(int treinadorID)
        {
            using (var connection = new Connection())
            {
                var query = $"DELETE FROM {Table} WHERE TreinadorID = @TreinadorID";
                using (var command = new MySqlCommand(query, connection.MySqlConnection))
                {
                    command.Parameters.AddWithValue("@TreinadorID", treinadorID);
                    command.ExecuteNonQuery();
                }
            }
        }

        private static Treinador MapFromReader(MySqlDataReader reader)
        {
            var treinador = new Treinador
            {
                TreinadorID = reader.Cast<int>("TreinadorID"),
                CartaoCidadao = reader.Cast<string>("CartaoCidadao"),
                Nome = reader.Cast<string>("Nome"),
                Nacionalidade = reader.Cast<string>("Nacionalidade"),
                AnosExperiencia = reader.Cast<int>("AnosExperiencia")
            };
            return treinador;
        }

        #endregion Métodos Estáticos
    }

}
