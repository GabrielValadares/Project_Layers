-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Tempo de geração: 22-Nov-2021 às 19:37
-- Versão do servidor: 10.4.10-MariaDB
-- versão do PHP: 7.3.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `faculdade`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `professor`
--

DROP TABLE IF EXISTS `professor`;
CREATE TABLE IF NOT EXISTS `professor` (
  `professor_id` int(255) NOT NULL AUTO_INCREMENT,
  `nome` varchar(255) NOT NULL,
  `turma_id` int(255) NOT NULL,
  PRIMARY KEY (`professor_id`),
  KEY `fk_turma_id` (`turma_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `professor`
--

INSERT INTO `professor` (`professor_id`, `nome`, `turma_id`) VALUES
(1, 'juliano', 3),
(2, 'prof', 1),
(3, 'professor307', 2);

-- --------------------------------------------------------

--
-- Estrutura da tabela `salario`
--

DROP TABLE IF EXISTS `salario`;
CREATE TABLE IF NOT EXISTS `salario` (
  `salario_id` int(255) NOT NULL AUTO_INCREMENT,
  `valor` double NOT NULL,
  `professor_id` int(255) NOT NULL,
  PRIMARY KEY (`salario_id`),
  KEY `fk_professor_id` (`professor_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `salario`
--

INSERT INTO `salario` (`salario_id`, `valor`, `professor_id`) VALUES
(1, 1000, 1),
(2, 1500, 2),
(3, 2500, 3);

-- --------------------------------------------------------

--
-- Estrutura da tabela `turma`
--

DROP TABLE IF EXISTS `turma`;
CREATE TABLE IF NOT EXISTS `turma` (
  `turma_id` int(255) NOT NULL AUTO_INCREMENT,
  `serie` varchar(255) NOT NULL,
  `unidade_id` int(255) NOT NULL,
  PRIMARY KEY (`turma_id`),
  KEY `FK_unidade_id` (`unidade_id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `turma`
--

INSERT INTO `turma` (`turma_id`, `serie`, `unidade_id`) VALUES
(1, '1B', 2),
(2, '2B', 2),
(3, '3B', 2),
(4, 'turma1', 1),
(5, 'serie1', 4);

-- --------------------------------------------------------

--
-- Estrutura da tabela `unidade`
--

DROP TABLE IF EXISTS `unidade`;
CREATE TABLE IF NOT EXISTS `unidade` (
  `unidade_id` int(255) NOT NULL AUTO_INCREMENT,
  `bairro` varchar(255) NOT NULL,
  `cidade` varchar(255) NOT NULL,
  `nome` varchar(255) NOT NULL,
  PRIMARY KEY (`unidade_id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `unidade`
--

INSERT INTO `unidade` (`unidade_id`, `bairro`, `cidade`, `nome`) VALUES
(1, 'barroca', 'BH', 'Unidade_Barroca'),
(2, 'floresta', 'BH', 'Unidade_Floresta'),
(4, 'bairro_floresta', 'belo_horizonte', 'unidade_floresta'),
(5, 'industrial', 'cidadeindustrial', 'unidadeindustrial'),
(6, 'bairro1', 'cidade1', 'unidade1');

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuario`
--

DROP TABLE IF EXISTS `usuario`;
CREATE TABLE IF NOT EXISTS `usuario` (
  `codigo` int(255) NOT NULL AUTO_INCREMENT,
  `email` varchar(255) NOT NULL,
  `senha` varchar(255) NOT NULL,
  PRIMARY KEY (`codigo`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `usuario`
--

INSERT INTO `usuario` (`codigo`, `email`, `senha`) VALUES
(1, 'gmail@gmail.com', '123'),
(2, 'a', '1'),
(3, 'email@gmail.com', '1234');

--
-- Restrições para despejos de tabelas
--

--
-- Limitadores para a tabela `professor`
--
ALTER TABLE `professor`
  ADD CONSTRAINT `fk_turma_id` FOREIGN KEY (`turma_id`) REFERENCES `turma` (`turma_id`);

--
-- Limitadores para a tabela `salario`
--
ALTER TABLE `salario`
  ADD CONSTRAINT `fk_professor_id` FOREIGN KEY (`professor_id`) REFERENCES `professor` (`professor_id`);

--
-- Limitadores para a tabela `turma`
--
ALTER TABLE `turma`
  ADD CONSTRAINT `FK_unidade_id` FOREIGN KEY (`unidade_id`) REFERENCES `unidade` (`unidade_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
