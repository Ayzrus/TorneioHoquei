using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneioHoquei.Models
{
    internal class Jogador
    {

        #region Constantes

        public const string Table = "jogadores";

        #endregion Constantes

        #region Propriedades

        public string? CartaoCidadao { get; set; }
        public string? CartaoCidadaoAntigo { get; set; }
        public string? Nome { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string? PosicaoCampo { get; set; }
        public int NumeroCamisola { get; set; }
        public int EquipeID { get; set; }
        public string? Equipa { get; set; }
        public string? DatasJogos { get; set; }
        public string? LocaisJogos { get; set; }
        public int TotalGols { get; set; }

        #endregion

        #region Métodos Estáticos

        /// <summary>
        /// Obtém todos os jogadores da base de dados.
        /// </summary>
        public static List<Jogador> GetJogadores()
        {
            var jogadores = new List<Jogador>();
            using (var connection = new Connection())
            {
                using (var command = new MySqlCommand($"SELECT jogador.*, E.Nome AS Equipa FROM {Table} jogador" +
                    $" LEFT JOIN equipas E on E.EquipeID = jogador.EquipeID", connection.MySqlConnection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            jogadores.Add(MapFromReader(reader));
                        }
                    }
                }
            }
            return jogadores;
        }

        /// <summary>
        /// Obtém todos os jogadores e todas suas Informações da base de dados.
        /// </summary>

        public static List<Jogador> GetJogadoresAll()
        {
            var jogadores = new List<Jogador>();
            using (var connection = new Connection())
            {
                string query = @"
                SELECT
                    jg.CartaoCidadao,
                    jg.Nome,
                    jg.DataNascimento,
                    jg.PosicaoCampo,
                    jg.NumeroCamisola,
                    jg.EquipeID,
                    eq.Nome AS Equipa,
                    GROUP_CONCAT(DISTINCT jogo.Data ORDER BY jogo.Data SEPARATOR ', ') AS DatasJogos,
                    GROUP_CONCAT(DISTINCT jogo.Local ORDER BY jogo.Data SEPARATOR ', ') AS LocaisJogos,
                    COALESCE(SUM(CASE WHEN gl.JogadorID = jg.CartaoCidadao THEN 1 ELSE 0 END), 0) AS TotalGols
                FROM
                    jogadores jg
                LEFT JOIN
                    equipas eq ON jg.EquipeID = eq.EquipeID
                LEFT JOIN
                    jogos jogo ON jogo.EquipeCasa = eq.EquipeID OR jogo.EquipeFora = eq.EquipeID
                LEFT JOIN
                    golos gl ON gl.JogoID = jogo.JogoID
                GROUP BY
                    jg.CartaoCidadao;
                ";

                using (var command = new MySqlCommand(query, connection.MySqlConnection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            jogadores.Add(MapFromReader(reader));
                        }
                    }
                }
            }
            return jogadores;
        }


        /// <summary>
        /// Insere um novo jogador na base de dados.
        /// </summary>
        public static void InserirJogador(Jogador jogador)
        {
            using (var connection = new Connection())
            {
                var query = $"INSERT INTO {Table} (CartaoCidadao, Nome, DataNascimento, PosicaoCampo, NumeroCamisola, EquipeID) VALUES (@CartaoCidadao, @Nome, @DataNascimento, @PosicaoCampo, @NumeroCamisola, @EquipeID)";
                using (var command = new MySqlCommand(query, connection.MySqlConnection))
                {
                    command.Parameters.AddWithValue("@CartaoCidadao", jogador.CartaoCidadao);
                    command.Parameters.AddWithValue("@Nome", jogador.Nome);
                    command.Parameters.AddWithValue("@DataNascimento", jogador.DataNascimento);
                    command.Parameters.AddWithValue("@PosicaoCampo", jogador.PosicaoCampo);
                    command.Parameters.AddWithValue("@NumeroCamisola", jogador.NumeroCamisola);
                    command.Parameters.AddWithValue("@EquipeID", jogador.EquipeID);
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Atualiza os dados de um jogador na base de dados.
        /// </summary>
        public static void AtualizarJogador(Jogador jogador)
        {
            using (var connection = new Connection())
            {
                var query = $"UPDATE {Table} SET CartaoCidadao = @CartaoCidadao, Nome = @Nome, DataNascimento = @DataNascimento, PosicaoCampo = @PosicaoCampo, NumeroCamisola = @NumeroCamisola, EquipeID = @EquipeID WHERE CartaoCidadao = @JogadorID";
                using (var command = new MySqlCommand(query, connection.MySqlConnection))
                {
                    command.Parameters.AddWithValue("@CartaoCidadao", jogador.CartaoCidadao);
                    command.Parameters.AddWithValue("@Nome", jogador.Nome);
                    command.Parameters.AddWithValue("@DataNascimento", jogador.DataNascimento);
                    command.Parameters.AddWithValue("@PosicaoCampo", jogador.PosicaoCampo);
                    command.Parameters.AddWithValue("@NumeroCamisola", jogador.NumeroCamisola);
                    command.Parameters.AddWithValue("@EquipeID", jogador.EquipeID);
                    command.Parameters.AddWithValue("@JogadorID", jogador.CartaoCidadaoAntigo);
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Exclui um jogador da base de dados.
        /// </summary>
        public static void ExcluirJogador(string jogadorID)
        {
            using (var connection = new Connection())
            {
                var query = $"DELETE FROM {Table} WHERE CartaoCidadao = @JogadorID";
                using (var command = new MySqlCommand(query, connection.MySqlConnection))
                {
                    command.Parameters.AddWithValue("@JogadorID", jogadorID);
                    command.ExecuteNonQuery();
                }
            }
        }

        private static Jogador MapFromReader(MySqlDataReader reader)
        {
            var jogador = new Jogador
            {
                CartaoCidadao = reader.Cast<string>("CartaoCidadao"),
                Nome = reader.Cast<string>("Nome"),
                DataNascimento = reader.Cast<DateTime?>("DataNascimento"),
                PosicaoCampo = reader.Cast<string>("PosicaoCampo"),
                NumeroCamisola = reader.Cast<int>("NumeroCamisola"),
                EquipeID = reader.Cast<int>("EquipeID"),
                Equipa = reader.Cast<string>("Equipa")
            };

            if (reader.HasColumn("DatasJogos") && !reader.IsDBNull(reader.GetOrdinal("DatasJogos")))
            {
                jogador.DatasJogos = reader.GetString("DatasJogos");
            }

            if (reader.HasColumn("LocaisJogos") && !reader.IsDBNull(reader.GetOrdinal("LocaisJogos")))
            {
                jogador.LocaisJogos = reader.GetString("LocaisJogos");
            }

            if (reader.HasColumn("TotalGols") && !reader.IsDBNull(reader.GetOrdinal("TotalGols")))
            {
                jogador.TotalGols = reader.GetInt32("TotalGols");
            }

            return jogador;
        }

        #endregion Métodos Estáticos

    }
}
