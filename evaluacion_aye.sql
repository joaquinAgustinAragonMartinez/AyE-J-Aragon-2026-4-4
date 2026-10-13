-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 13-10-2026 a las 17:26:19
-- Versión del servidor: 8.0.33
-- Versión de PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `evaluacion_aye`
--
CREATE DATABASE IF NOT EXISTS `evaluacion_aye` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci;
USE `evaluacion_aye`;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `agentes_valorant`
--

DROP TABLE IF EXISTS `agentes_valorant`;
CREATE TABLE `agentes_valorant` (
  `id` int NOT NULL,
  `nombre_agente` varchar(50) NOT NULL,
  `tipo_agente` varchar(50) NOT NULL,
  `nacionalidad` varchar(50) NOT NULL,
  `fecha_lanzamiento` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `agentes_valorant`
--

INSERT INTO `agentes_valorant` (`id`, `nombre_agente`, `tipo_agente`, `nacionalidad`, `fecha_lanzamiento`) VALUES
(1, 'Brimstone', 'Controlador', 'Estados Unidos', '2020-04-07'),
(2, 'Viper', 'Controlador', 'Estados Unidos', '2020-04-07'),
(3, 'Omen', 'Controlador', 'Desconocido', '2020-04-07'),
(4, 'Cypher', 'Centinela', 'Marruecos', '2020-04-07'),
(5, 'Sova', 'Iniciador', 'Rusia', '2020-04-07'),
(6, 'Sage', 'Centinela', 'China', '2020-04-07'),
(7, 'Phoenix', 'Duelista', 'Reino Unido', '2020-04-07'),
(8, 'Jett', 'Duelista', 'Corea del Sur', '2020-04-07'),
(9, 'Raze', 'Duelista', 'Brasil', '2020-04-07'),
(10, 'Breach', 'Iniciador', 'Suecia', '2020-04-07'),
(11, 'Reyna', 'Duelista', 'México', '2020-06-02'),
(12, 'Killjoy', 'Centinela', 'Alemania', '2020-08-04'),
(13, 'Skye', 'Iniciador', 'Australia', '2020-10-27'),
(14, 'Yoru', 'Duelista', 'Japón', '2021-01-12'),
(15, 'Astra', 'Controlador', 'Ghana', '2021-03-02'),
(16, 'KAY/O', 'Iniciador', 'Desconocido', '2021-06-22'),
(17, 'Chamber', 'Centinela', 'Francia', '2021-11-16'),
(18, 'Neon', 'Duelista', 'Filipinas', '2022-01-11'),
(19, 'Fade', 'Iniciador', 'Turquía', '2022-04-27'),
(20, 'Harbor', 'Controlador', 'India', '2022-10-18'),
(21, 'Gekko', 'Iniciador', 'Estados Unidos', '2023-03-07'),
(22, 'Deadlock', 'Centinela', 'Noruega', '2023-06-27'),
(23, 'Iso', 'Duelista', 'China', '2023-10-31'),
(24, 'Clove', 'Controlador', 'Escocia', '2024-03-26'),
(25, 'Vyse', 'Centinela', 'Desconocido', '2024-08-28'),
(26, 'Tejo', 'Iniciador', 'Colombia', '2025-01-08'),
(27, 'Waylay', 'Duelista', 'Tailandia', '2025-03-05'),
(28, 'Veto', 'Centinela', 'Nigeria', '2025-10-07'),
(29, 'Miks', 'Controlador', 'Croacia', '2026-03-18');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `agentes_valorant`
--
ALTER TABLE `agentes_valorant`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `agentes_valorant`
--
ALTER TABLE `agentes_valorant`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=30;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
