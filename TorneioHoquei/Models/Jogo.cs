using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneioHoquei.Models
{
    internal class Jogo
    {

        #region Constantes

        public const string Table = "jogos";

        #endregion Constantes

        #region Propriedades

        public int JogoID { get; set; }
        public DateTime Data { get; set; }
        public string? Local { get; set; }
        public string? ResultadoFinal { get; set; }
        public int EquipeCasa { get; set; }
        public int EquipeFora { get; set; }
        public int FaseID { get; set; }
        public string? EquipaCasa { get; set; }
        public string? EquipaFora { get; set; }
        public string? Fase { get; set; }

        #endregion

        #region Métodos Estáticos

        /// <summary>
        /// Obtém todos os jogos da base de dados.
        /// </summary>
        public static List<Jogo> GetJogos()
        {
            var jogos = new List<Jogo>();
            using (var connection = new Connection())
            {
                using (var command = new MySqlCommand($"SELECT J.*, EC.Nome AS EquipaCasa, EF.Nome AS EquipaFora, F.Tipo AS Fase FROM {Table} J" +
                    $" LEFT JOIN equipas EC ON EC.EquipeID = J.EquipeCasa" +
                    $" LEFT JOIN equipas EF ON EF.EquipeID = J.EquipeFora" +
                    $" LEFT JOIN fases F ON F.FaseID = J.FaseID", connection.MySqlConnection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            jogos.Add(MapFromReader(reader));
                        }
                    }
                }
            }
            return jogos;
        }

        /// <summary>
        /// Insere um novo jogo na base de dados.
        /// </summary>
        public static void InserirJogo(Jogo jogo)
        {
            using (var connection = new Connection())
            {
                var query = $"INSERT INTO {Table} (JogoID, Data, Local, ResultadoFinal, EquipeCasa, EquipeFora, FaseID) VALUES (@JogoID, @Data, @Local, @ResultadoFinal, @EquipaCasaID, @EquipaForaID, @FaseID)";
                using (var command = new MySqlCommand(query, connection.MySqlConnection))
                {
                    command.Parameters.AddWithValue("@JogoID", jogo.JogoID);
                    command.Parameters.AddWithValue("@Data", jogo.Data);
                    command.Parameters.AddWithValue("@Local", jogo.Local);
                    command.Parameters.AddWithValue("@ResultadoFinal", jogo.ResultadoFinal);
                    command.Parameters.AddWithValue("@EquipaCasaID", jogo.EquipeCasa);
                    command.Parameters.AddWithValue("@EquipaForaID", jogo.EquipeFora);
                    command.Parameters.AddWithValue("@FaseID", jogo.FaseID);
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Atualiza os dados de um jogo na base de dados.
        /// </summary>
        public static void AtualizarJogo(Jogo jogo)
        {
            using (var connection = new Connection())
            {
                var query = $"UPDATE {Table} SET Data = @Data, Local = @Local, ResultadoFinal = @ResultadoFinal, EquipeCasa = @EquipaCasaID, EquipeFora = @EquipaForaID, FaseID = @FaseID WHERE JogoID = @JogoID";
                using (var command = new MySqlCommand(query, connection.MySqlConnection))
                {
                    command.Parameters.AddWithValue("@Data", jogo.Data);
                    command.Parameters.AddWithValue("@Local", jogo.Local);
                    command.Parameters.AddWithValue("@ResultadoFinal", jogo.ResultadoFinal);
                    command.Parameters.AddWithValue("@EquipaCasaID", jogo.EquipeCasa);
                    command.Parameters.AddWithValue("@EquipaForaID", jogo.EquipeFora);
                    command.Parameters.AddWithValue("@FaseID", jogo.FaseID);
                    command.Parameters.AddWithValue("@JogoID", jogo.JogoID);
                    command.ExecuteNonQuery();
                }
            }
        }


        /// <summary>
        /// Exclui um jogo da base de dados.
        /// </summary>
        public static void ExcluirJogo(int jogoID)
        {
            using (var connection = new Connection())
            {
                var query = $"DELETE FROM {Table} WHERE JogoID = @JogoID";
                using (var command = new MySqlCommand(query, connection.MySqlConnection))
                {
                    command.Parameters.AddWithValue("@JogoID", jogoID);
                    command.ExecuteNonQuery();
                }
            }
        }

        private static Jogo MapFromReader(MySqlDataReader reader)
        {
            var jogo = new Jogo
            {
                JogoID = reader.Cast<int>("JogoID"),
                Data = reader.Cast<DateTime>("Data"),
                Local = reader.Cast<string>("Local"),
                ResultadoFinal = reader.Cast<string>("ResultadoFinal"),
                EquipeCasa = reader.Cast<int>("EquipeCasa"),
                EquipeFora = reader.Cast<int>("EquipeFora"),
                FaseID = reader.Cast<int>("FaseID"),
                EquipaCasa = reader.Cast<string>("EquipaCasa"),
                EquipaFora = reader.Cast<string>("EquipaFora"),
                Fase = reader.Cast<string>("Fase"),
            };
            return jogo;
        }

        #endregion Métodos Estáticos

    }
}
