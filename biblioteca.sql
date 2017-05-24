-- --------------------------------------------------------
-- Servidor:                     127.0.0.1
-- Versão do servidor:           10.1.16-MariaDB - mariadb.org binary distribution
-- OS do Servidor:               Win32
-- HeidiSQL Versão:              9.3.0.4984
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

-- Copiando estrutura do banco de dados para biblioteca
CREATE DATABASE IF NOT EXISTS `biblioteca` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `biblioteca`;


-- Copiando estrutura para tabela biblioteca.livro
CREATE TABLE IF NOT EXISTS `livro` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Título` char(50) NOT NULL DEFAULT '0',
  `Autor` char(50) NOT NULL DEFAULT '0',
  `Editora` char(50) DEFAULT '0',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela biblioteca.livro: ~18 rows (aproximadamente)
/*!40000 ALTER TABLE `livro` DISABLE KEYS */;
INSERT INTO `livro` (`Id`, `Título`, `Autor`, `Editora`) VALUES
	(1, 'HALO', 'ALEXANDRA ADORNETTO', 'AGIR'),
	(2, 'HADES', 'ALEXANDRA ADORNETTO', 'AGIR'),
	(3, 'HEAVEN', 'ALEXANDRA ADORNETTO', 'AGIR'),
	(4, 'O ALICIADOR', 'D. CARRISI', 'RECORD'),
	(5, 'ESTRELA DA NOITE', 'ALYSON NOËL', 'INTRÍNSECA'),
	(6, 'CHAMA NEGRA', ' ALYSON NOËL', 'INTRÍNSECA'),
	(7, 'TERRA DE SOMBRAS', 'ALYSON NOËL', 'INTRÍNSECA'),
	(8, 'LUA AZUL', 'ALYSON NOËL', 'INTRÍNSECA'),
	(9, 'INFINITO', 'ALYSON NOËL', 'INTRÍNSECA'),
	(10, 'PARA SEMPRE', 'ALYSON NOËL', 'INTRÍNSECA'),
	(11, 'OBSESSÃO', 'T. MOSS', 'FUNDAMENTO'),
	(12, 'COBIÇA', 'T. MOSS', 'FUNDAMENTO'),
	(13, 'A MENINA QUE ROUBAVA LIVROS', 'MARKUS ZUSAK', 'INTRÍNSECA'),
	(14, 'EU SOU O MENSAGEIRO', 'MARKUS ZUSAK', 'INTRÍNSECA'),
	(15, 'A GAROTA QUE EU QUERO', 'MARKUS ZUSAK', 'INTRÍNSECA'),
	(16, 'RADIANTE', 'ALYSON NOËL', 'INTRÍNSECA'),
	(17, 'SE EU FICAR', 'GAYLE FORMAN', 'NOVO CONCEITO'),
	(18, 'PARA ONDE ELA FOI', 'GAYLE FORMAN', 'NOVO CONCEITO');
/*!40000 ALTER TABLE `livro` ENABLE KEYS */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
