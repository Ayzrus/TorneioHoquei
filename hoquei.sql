-- --------------------------------------------------------
-- Anfitrião:                    127.0.0.1
-- Versão do servidor:           10.4.32-MariaDB - mariadb.org binary distribution
-- SO do servidor:               Win64
-- HeidiSQL Versão:              12.6.0.6765
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- A despejar estrutura da base de dados para hoquei
CREATE DATABASE IF NOT EXISTS `hoquei` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci */;
USE `hoquei`;

-- A despejar estrutura para tabela hoquei.equipas
CREATE TABLE IF NOT EXISTS `equipas` (
  `EquipeID` int(11) NOT NULL AUTO_INCREMENT,
  `Nome` varchar(100) DEFAULT NULL,
  `TreinadorID` int(11) DEFAULT NULL,
  PRIMARY KEY (`EquipeID`),
  KEY `equipas_ibfk_1` (`TreinadorID`),
  CONSTRAINT `equipas_ibfk_1` FOREIGN KEY (`TreinadorID`) REFERENCES `treinadores` (`TreinadorID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Exportação de dados não seleccionada.

-- A despejar estrutura para tabela hoquei.fases
CREATE TABLE IF NOT EXISTS `fases` (
  `FaseID` int(11) NOT NULL AUTO_INCREMENT,
  `Tipo` varchar(50) DEFAULT NULL,
  `TorneioID` int(11) DEFAULT NULL,
  PRIMARY KEY (`FaseID`),
  KEY `fases_ibfk_1` (`TorneioID`),
  CONSTRAINT `fases_ibfk_1` FOREIGN KEY (`TorneioID`) REFERENCES `torneios` (`TorneioID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Exportação de dados não seleccionada.

-- A despejar estrutura para tabela hoquei.golos
CREATE TABLE IF NOT EXISTS `golos` (
  `GoloID` int(11) NOT NULL AUTO_INCREMENT,
  `TempoJogo` datetime DEFAULT NULL,
  `Ordem` int(11) DEFAULT NULL,
  `JogoID` int(11) DEFAULT NULL,
  `JogadorID` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`GoloID`),
  KEY `golos_ibfk_1` (`JogoID`),
  KEY `golos_ibfk_2` (`JogadorID`),
  CONSTRAINT `golos_ibfk_1` FOREIGN KEY (`JogoID`) REFERENCES `jogos` (`JogoID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `golos_ibfk_2` FOREIGN KEY (`JogadorID`) REFERENCES `jogadores` (`CartaoCidadao`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Exportação de dados não seleccionada.

-- A despejar estrutura para tabela hoquei.jogadores
CREATE TABLE IF NOT EXISTS `jogadores` (
  `CartaoCidadao` varchar(20) NOT NULL,
  `Nome` varchar(100) DEFAULT NULL,
  `DataNascimento` date DEFAULT NULL,
  `PosicaoCampo` varchar(50) DEFAULT NULL,
  `NumeroCamisola` int(11) DEFAULT NULL,
  `EquipeID` int(11) DEFAULT NULL,
  PRIMARY KEY (`CartaoCidadao`),
  KEY `jogadores_ibfk_1` (`EquipeID`),
  CONSTRAINT `jogadores_ibfk_1` FOREIGN KEY (`EquipeID`) REFERENCES `equipas` (`EquipeID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Exportação de dados não seleccionada.

-- A despejar estrutura para tabela hoquei.jogos
CREATE TABLE IF NOT EXISTS `jogos` (
  `JogoID` int(11) NOT NULL AUTO_INCREMENT,
  `Data` date DEFAULT NULL,
  `Local` varchar(100) DEFAULT NULL,
  `ResultadoFinal` varchar(20) DEFAULT NULL,
  `EquipeCasa` int(11) DEFAULT NULL,
  `EquipeFora` int(11) DEFAULT NULL,
  `FaseID` int(11) DEFAULT NULL,
  PRIMARY KEY (`JogoID`),
  KEY `jogos_ibfk_1` (`EquipeCasa`),
  KEY `jogos_ibfk_2` (`EquipeFora`),
  KEY `jogos_ibfk_3` (`FaseID`),
  CONSTRAINT `jogos_ibfk_1` FOREIGN KEY (`EquipeCasa`) REFERENCES `equipas` (`EquipeID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `jogos_ibfk_2` FOREIGN KEY (`EquipeFora`) REFERENCES `equipas` (`EquipeID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `jogos_ibfk_3` FOREIGN KEY (`FaseID`) REFERENCES `fases` (`FaseID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Exportação de dados não seleccionada.

-- A despejar estrutura para tabela hoquei.torneios
CREATE TABLE IF NOT EXISTS `torneios` (
  `TorneioID` int(11) NOT NULL AUTO_INCREMENT,
  `Nome` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`TorneioID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Exportação de dados não seleccionada.

-- A despejar estrutura para tabela hoquei.treinadores
CREATE TABLE IF NOT EXISTS `treinadores` (
  `TreinadorID` int(11) NOT NULL AUTO_INCREMENT,
  `CartaoCidadao` varchar(20) DEFAULT NULL,
  `Nome` varchar(100) DEFAULT NULL,
  `Nacionalidade` varchar(50) DEFAULT NULL,
  `AnosExperiencia` int(11) DEFAULT NULL,
  PRIMARY KEY (`TreinadorID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Exportação de dados não seleccionada.

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
