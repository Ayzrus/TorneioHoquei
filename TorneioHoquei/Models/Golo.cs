using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneioHoquei.Models
{
    internal class Golo
    {

        #region Constantes

        public const string Table = "golos";

        #endregion Constantes

        #region Propriedades

        public int GoloID { get; set; }
        public DateTime TempoJogo { get; set; }
        public int Ordem { get; set; }
        public int JogoID { get; set; }
        public string? JogadorID { get; set; }
        public string? Jogo { get; set; }
        public string? Jogador { get; set; }

        #endregion

        #region Métodos Estáticos

       

        /// <summary>
        /// Obtém todos os gols da base de dados.
        /// </summary>
        public static List<Golo> GetGolos()
        {
            var golos = new List<Golo>();
            using (var connection = new Connection())
            {
                using (var command = new MySqlCommand($"SELECT G.*, J.Local AS Jogo, JJ.Nome as Jogador FROM {Table} G" +
                    $" LEFT JOIN jogos J ON J.JogoID = G.JogoID" +
                    $" LEFT JOIN jogadores JJ ON JJ.CartaoCidadao = G.JogadorID", connection.MySqlConnection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            golos.Add(MapFromReader(reader));
                        }
                    }
                }
            }
            return golos;
        }

        /// <summary>
        /// Insere um novo gol na base de dados.
        /// </summary>
        public static void InserirGolo(Golo golo)
        {
            using (var connection = new Connection())
            {
                var query = $"INSERT INTO {Table} (TempoJogo, Ordem, JogoID, JogadorID) VALUES (@TempoJogo, @Ordem, @JogoID, @JogadorID)";
                using (var command = new MySqlCommand(query, connection.MySqlConnection))
                {
                    command.Parameters.AddWithValue("@TempoJogo", golo.TempoJogo);
                    command.Parameters.AddWithValue("@Ordem", golo.Ordem);
                    command.Parameters.AddWithValue("@JogoID", golo.JogoID);
                    command.Parameters.AddWithValue("@JogadorID", golo.JogadorID);
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Atualiza os dados de um gol na base de dados.
        /// </summary>
        public static void AtualizarGolo(Golo golo)
        {
            using (var connection = new Connection())
            {
                var query = $"UPDATE {Table} SET TempoJogo = @TempoJogo, Ordem = @Ordem, JogoID = @JogoID , JogadorID = @JogadorID WHERE GoloID = @GoloID";
                using (var command = new MySqlCommand(query, connection.MySqlConnection))
                {
                    command.Parameters.AddWithValue("@TempoJogo", golo.TempoJogo);
                    command.Parameters.AddWithValue("@Ordem", golo.Ordem);
                    command.Parameters.AddWithValue("@JogoID", golo.JogoID);
                    command.Parameters.AddWithValue("@JogadorID", golo.JogadorID);
                    command.Parameters.AddWithValue("@GoloID", golo.GoloID);
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Exclui um gol da base de dados.
        /// </summary>
        public static void ExcluirGolo(int goloID)
        {
            using (var connection = new Connection())
            {
                var query = $"DELETE FROM {Table} WHERE GoloID = @GoloID";
                using (var command = new MySqlCommand(query, connection.MySqlConnection))
                {
                    command.Parameters.AddWithValue("@GoloID", goloID);
                    command.ExecuteNonQuery();
                }
            }
        }

        private static Golo MapFromReader(MySqlDataReader reader)
        {
            var golo = new Golo
            {
                GoloID = reader.Cast<int>("GoloID"),
                TempoJogo = reader.Cast<DateTime>("TempoJogo"),
                Ordem = reader.Cast<int>("Ordem"),
                JogoID = reader.Cast<int>("JogoID"),
                JogadorID = reader.Cast<string>("JogadorID"),
                Jogo = reader.Cast<string>("Jogo"),
                Jogador = reader.Cast<string>("Jogador")
            };
            return golo;
        }

        #endregion Métodos Estáticos

    }
}
