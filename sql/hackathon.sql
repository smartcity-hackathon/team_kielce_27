-- phpMyAdmin SQL Dump
-- version 4.2.12deb2+deb8u2
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Jun 16, 2018 at 09:57 AM
-- Server version: 5.5.58-0+deb8u1
-- PHP Version: 5.6.33-0+deb8u1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `hackathon`
--

-- --------------------------------------------------------

--
-- Table structure for table `Accounts`
--

CREATE TABLE IF NOT EXISTS `Accounts` (
`Id` int(11) NOT NULL,
  `Username` varchar(32) COLLATE utf8_polish_ci NOT NULL,
  `Password` varchar(32) COLLATE utf8_polish_ci NOT NULL,
  `Email` varchar(64) COLLATE utf8_polish_ci NOT NULL,
  `Name1` varchar(32) COLLATE utf8_polish_ci NOT NULL,
  `Name2` varchar(32) COLLATE utf8_polish_ci DEFAULT NULL,
  `Surname` varchar(32) COLLATE utf8_polish_ci NOT NULL,
  `Sex` char(1) COLLATE utf8_polish_ci NOT NULL,
  `Key` varchar(64) COLLATE utf8_polish_ci DEFAULT NULL,
  `AccountType` char(1) COLLATE utf8_polish_ci DEFAULT NULL
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Dumping data for table `Accounts`
--

INSERT INTO `Accounts` (`Id`, `Username`, `Password`, `Email`, `Name1`, `Name2`, `Surname`, `Sex`, `Key`, `AccountType`) VALUES
(1, 'test', 'test', 'test@test.pl', 'Lol', 'Omg', 'Wtf', 'M', '3141', ''),
(2, 'asdf', 'sadf', 'asf', 'asdfasdasdf', 'sdaf', 'asdf', '\0', 'fds', '\0');

-- --------------------------------------------------------

--
-- Table structure for table `Addresses`
--

CREATE TABLE IF NOT EXISTS `Addresses` (
`Id` int(11) NOT NULL,
  `AccountId` int(11) NOT NULL,
  `Street` varchar(64) COLLATE utf8_polish_ci NOT NULL,
  `Building` varchar(32) COLLATE utf8_polish_ci NOT NULL,
  `SubBuilding` varchar(32) COLLATE utf8_polish_ci NOT NULL,
  `Apartment` varchar(16) COLLATE utf8_polish_ci NOT NULL,
  `Postcode` varchar(16) COLLATE utf8_polish_ci NOT NULL,
  `City` varchar(32) COLLATE utf8_polish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

-- --------------------------------------------------------

--
-- Table structure for table `Godzinas`
--

CREATE TABLE IF NOT EXISTS `Godzinas` (
`Id` int(11) NOT NULL,
  `WydzialId` int(11) NOT NULL,
  `Pon` varchar(64) COLLATE utf8_polish_ci DEFAULT NULL,
  `Wto` varchar(64) COLLATE utf8_polish_ci DEFAULT NULL,
  `Sro` varchar(64) COLLATE utf8_polish_ci DEFAULT NULL,
  `Czw` varchar(64) COLLATE utf8_polish_ci DEFAULT NULL,
  `Pia` varchar(64) COLLATE utf8_polish_ci DEFAULT NULL,
  `Sob` varchar(64) COLLATE utf8_polish_ci DEFAULT NULL,
  `Nie` varchar(64) COLLATE utf8_polish_ci DEFAULT NULL
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Dumping data for table `Godzinas`
--

INSERT INTO `Godzinas` (`Id`, `WydzialId`, `Pon`, `Wto`, `Sro`, `Czw`, `Pia`, `Sob`, `Nie`) VALUES
(1, 1, '7:30 - 15:30', '7:30 - 15:30', '7:30 - 15:30', '7:30 - 15:30', '7:30 - 15:30', NULL, NULL),
(2, 2, '7:30 - 15:30', '7:30 - 15:30', '7:30 - 15:30', '7:30 - 15:30', '7:30 - 15:30', NULL, NULL),
(3, 3, '7:30 - 15:30', '7:30 - 15:30', '7:30 - 15:30', '7:30 - 15:30', '7:30 - 15:30', NULL, NULL),
(4, 4, '7:30 - 15:30', '7:30 - 15:30', '7:30 - 15:30', '7:30 - 15:30', '7:30 - 15:30', NULL, NULL),
(5, 5, '7:30 - 15:30', '7:30 - 15:30', '7:30 - 15:30', '7:30 - 15:30', '7:30 - 15:30', NULL, NULL),
(6, 6, '7:30 - 15:30', '7:30 - 15:30', '7:30 - 15:30', '7:30 - 15:30', '7:30 - 15:30', NULL, NULL),
(7, 7, '7:30 - 15:30', '7:30 - 15:30', '7:30 - 15:30', '7:30 - 15:30', '7:30 - 15:30', NULL, NULL),
(8, 8, '7:30 - 15:30', '7:30 - 15:30', '7:30 - 15:30', '7:30 - 15:30', '7:30 - 15:30', NULL, NULL),
(9, 9, '7:30 - 17:00', '7:30 - 17:00', '7:30 - 17:00', '7:30 - 15:30', '7:30 - 15:30', NULL, NULL),
(10, 10, '7:30 - 15:30', '7:30 - 15:30', '7:30 - 15:30', '7:30 - 15:30', '7:30 - 15:30', NULL, NULL),
(11, 11, '7:30 - 15:30', '7:30 - 15:30', '7:30 - 15:30', '7:30 - 15:30', '7:30 - 15:30', NULL, NULL),
(12, 12, '7:30 - 15:30', '7:30 - 15:30', '7:30 - 15:30', '7:30 - 15:30', '7:30 - 15:30', NULL, NULL),
(13, 13, '7:30 - 15:30', '7:30 - 15:30', '7:30 - 15:30', '7:30 - 15:30', '7:30 - 15:30', NULL, NULL),
(14, 14, '7:30 - 15:30', '7:30 - 15:30', '7:30 - 15:30', '7:30 - 15:30', '7:30 - 15:30', NULL, NULL),
(15, 15, '7:30 - 15:30', '7:30 - 15:30', '7:30 - 15:30', '7:30 - 15:30', '7:30 - 15:30', NULL, NULL),
(16, 16, '7:30 - 15:30', '7:30 - 15:30', '7:30 - 15:30', '7:30 - 15:30', '7:30 - 15:30', NULL, NULL),
(17, 17, '7:30 - 17:00', '7:30 - 17:00', '7:30 - 17:00', '7:30 - 15:30', '7:30 - 15:30', NULL, NULL),
(18, 18, '7:30 - 15:30', '7:30 - 15:30', '7:30 - 15:30', '7:30 - 15:30', '7:30 - 15:30', NULL, NULL),
(19, 19, '7:30 - 17:00', '7:30 - 17:00', '7:30 - 17:00', '7:30 - 15:30', '7:30 - 15:30', '9:00 - 14:00', NULL),
(20, 20, '7:30 - 15:30', '7:30 - 15:30', '7:30 - 15:30', '7:30 - 15:30', '7:30 - 15:30', NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `Kartas`
--

CREATE TABLE IF NOT EXISTS `Kartas` (
`Id` int(11) NOT NULL,
  `Numer` int(3) DEFAULT NULL,
  `Nazwa` varchar(707) DEFAULT NULL,
  `WydzialId` int(11) NOT NULL,
  `Tagi` text
) ENGINE=InnoDB AUTO_INCREMENT=80 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `Kartas`
--

INSERT INTO `Kartas` (`Id`, `Numer`, `Nazwa`, `WydzialId`, `Tagi`) VALUES
(1, 1, 'Wpis do rejestru działalności regulowanej w zakresie odbierania odpadów komunalnych', 18, ''),
(2, 9, 'Zawiadomienie o zgromadzeniu publicznym', 20, ''),
(3, 11, 'Wpisanie lub odtworzenie aktu stanu cywilnego oraz sprostowania i/lub uzupełnienia aktu stanu cywilnego', 19, ''),
(4, 12, 'Wydanie decyzji administracyjnej w sprawie zmiany imienia  i nazwiska', 19, ''),
(5, 13, 'Rejestracja noworodków', 19, ''),
(6, 14, 'Rejestracja zgonu', 19, ''),
(7, 15, 'Zawarcie małżeństwa konkordatowego Zawarcie małżeństwa cywilnego Odznaczenie medalem „Za długoletnie pożycie małżeńskie”', 19, ''),
(8, 16, 'Wydawanie odpisów i zaświadczeń z ksiąg stanu cywilnego Uznanie wyroku rozwodowego orzeczonego poza granicami RP (dotyczy państw należących do UE) Uznanie wyroku rozwodowego orzeczonego poza granicami RP (dotyczy państw nie należących do UE)', 19, ''),
(9, 18, 'Wydanie decyzji na organizację imprezy masowej na terenie Miasta Kielce', 20, ''),
(10, 19, 'Dokonanie wpisu stowarzyszenia z osobowością prawną, oddziału stowarzyszenia bez osobowości prawnej, stowarzyszenia zwykłego, uczniowskiego klubu sportowego, fundacji do rejestrów i wydanie zaświadczenia o wpisie', 5, ''),
(11, 20, 'Wydanie dowodu osobistego', 17, ''),
(12, 21, 'Dokonanie czynności zameldowania i wymeldowania', 17, ''),
(13, 22, 'Wydanie decyzji na posiadanie psa rasy uznawanej za agresywną', 18, ''),
(14, 23, 'Wydawanie karty wędkarskiej uprawniającej do amatorskiego połowu ryb/karty łowiectwa podwodnego', 18, ''),
(15, 24, 'Deklaracja o wysokości opłaty za gospodarowanie odpadami komunalnymi', 18, ''),
(16, 25, 'Wydawanie zaświadczenia dot. rejestracji sprzętu pływającego służącego do amatorskiego połowu ryb', 18, ''),
(17, 26, 'Wydanie decyzji wyłączających grunty rolne z produkcji rolniczej', 18, ''),
(18, 28, 'Przedłużenie umowy najmu lokalu socjalnego', 12, ''),
(19, 29, 'Wydawanie decyzji administracyjnych w sprawach zameldowań, wymeldowań oraz uchylenia czynności materialno-technicznej zameldowania', 17, ''),
(20, 30, 'Wydanie decyzji administracyjnych w sprawach sprowadzenia zwłok z zagranicy', 18, ''),
(21, 31, 'Organizacja konkursu ofert na realizację zadań własnych Miasta zleconych organizacjom pozarządowym', 5, ''),
(22, 32, 'Założenie działalności gospodarczej, zmiana, zawieszenie, wznowienie, zakończenie oraz zgłoszenie sprostowania i wykreślenia w Centralnej Ewidencji i Informacji o Działalności Gospodarczej', 17, ''),
(23, 33, 'Wykorzystanie dróg w sposób szczególny', 15, ''),
(24, 34, 'Wydanie zezwolenia na sprzedaż i podawanie napojów alkoholowych oraz na organizowanie imprez', 17, ''),
(25, 35, 'Wydanie zezwolenia na wyprzedaż napojów alkoholowych', 17, ''),
(26, 36, 'Wydanie decyzji o cofnięciu zezwolenia na sprzedaż/sprzedaż i podawanie napojów alkoholowych', 17, ''),
(27, 37, 'Uzgodnienie procesji, pielgrzymki lub innej imprezy o charakterze religijnym', 15, ''),
(28, 38, 'Wydawanie decyzji w sprawie aktu awansu zawodowego nauczyciela mianowanego', 5, ''),
(29, 39, 'Wydawanie decyzji w sprawie wpisu do ewidencji szkół i placówek niepublicznych, udzielania i cofania zezwoleń na założenie szkoły lub placówki publicznej przez osobę prawną lub fizyczną', 5, ''),
(30, 40, 'Zatwierdzenie projektu organizacji ruchu', 15, ''),
(31, 41, 'Regulacja tytułu prawnego do zajmowanego mieszkania', 12, ''),
(32, 42, 'Przyznanie lokalu komunalnego/socjalnego', 12, ''),
(33, 43, 'Rejestracja pojazdu', 9, ''),
(34, 44, 'Wyrejestrowanie pojazdu', 9, ''),
(35, 45, 'Zamiana mieszkań należących do mieszkaniowego zasobu Miasta Kielce', 12, ''),
(36, 46, 'Nadanie nowych cech identyfikacyjnych w pojeździe i/lub wydanie zgody na wykonanie i umieszczenie tabliczki znamionowej zastępczej', 9, ''),
(37, 47, 'Zaopiniowanie geometrii drogi', 15, ''),
(38, 49, 'Wydanie decyzji o skierowaniu kierowcy na egzamin kontrolny  w związku z przekroczeniem limitu 24 punktów karnych', 9, ''),
(39, 50, 'Wydanie decyzji o zwrocie zatrzymanego prawa jazdy i/lub  o przywróceniu cofniętego uprawnienia do prowadzenia pojazdów', 9, ''),
(40, 51, 'Wydanie prawa jazdy', 9, ''),
(41, 52, 'Wydanie międzynarodowego prawa jazdy', 9, ''),
(42, 58, 'Wydanie zezwolenia na szkolenie kandydatów na kierowców', 17, ''),
(43, 59, 'Wydanie uprawnień na wykonywanie krajowego transportu drogowego a)	Udzielenie zezwolenia na wykonywanie zawodu przewoźnika drogowego – (str. 1-4) b)	Udzielenie licencji na wykonywanie krajowego transportu drogowego w zakresie przewozu osób samochodem osobowym lub pojazdem samochodowym przeznaczonym konstrukcyjnie do przewozu powyżej 8 i nie więcej niż 9 osób łącznie z kierowcą – (str. 5-7) c)	Wydanie zaświadczenia na przewozy drogowe na potrzeby własne – (str. 8-9) d)	Udzielenie licencji na wykonywanie transportu drogowego w zakresie pośrednictwa przy przewozie rzeczy – (str. 10-11) e)	Udzielenie licencji na wykonywanie krajowego transportu drogowego taksówką – (str. 12-13)', 17, ''),
(44, 60, 'Wydanie decyzji o wpisie do ewidencji instruktorów/wykładowców', 17, ''),
(45, 61, 'Sporządzanie i wydawanie wypisów oraz wyrysów z operatu ewidencji gruntów i budynków', 6, ''),
(46, 62, 'Wydanie decyzji o warunkach zabudowy', 16, ''),
(47, 63, 'Wydanie decyzji o ustaleniu lokalizacji inwestycji celu publicznego', 16, ''),
(48, 66, 'Wydanie decyzji o zatwierdzeniu projektu podziału nieruchomości', 6, ''),
(49, 68, 'Wydanie pozwolenia na budowę (przebudowę, rozbiórkę  i rozbudowę) obiektu budowlanego', 1, ''),
(50, 69, 'Wydanie decyzji o aktualizacji informacji zawartych w ewidencji gruntów i budynków', 6, ''),
(51, 71, 'Ustalenie numeru porządkowego nieruchomości', 6, ''),
(52, 73, 'Wydawanie, cofnięcie, ograniczenie, odmowa lub wygaśnięcie pozwoleń wodnoprawnych', 18, ''),
(53, 74, 'Wydanie pozwolenia na wprowadzanie gazów lub pyłów do powietrza', 18, ''),
(54, 75, 'Wydawanie decyzji dotyczących gospodarki odpadami', 18, ''),
(55, 77, 'Wydawanie decyzji dotyczącej zezwolenia na prowadzenie działalności w zakresie opróżniania zbiorników bezodpływowych  i transportu nieczystości ciekłych', 18, ''),
(56, 80, 'Nabywanie nieruchomości', 6, ''),
(57, 82, 'Zwrot nieruchomości na rzecz byłych właścicieli', 6, ''),
(58, 83, 'Przekształcenie prawa użytkowania wieczystego w prawo własności nieruchomości', 6, ''),
(59, 87, 'Wydanie zezwoleń na usunięcie drzew lub krzewów', 18, ''),
(60, 88, 'Zatwierdzenie dokumentacji geologicznej', 18, ''),
(61, 90, 'Sprzedaż lokali mieszkalnych w trybie bezprzetargowym', 6, ''),
(62, 91, 'Sprzedaż lokali użytkowych w trybie bezprzetargowym', 6, ''),
(63, 92, 'Sprzedaż nieruchomości', 6, ''),
(64, 93, 'Dzierżawa i najem nieruchomości', 6, ''),
(65, 94, 'Ustalenie wysokości podatków: od nieruchomości, leśnego i rolnego od osób fizycznych', 14, ''),
(66, 95, 'Umorzenia, odroczenia, rozłożenie na raty w zakresie podatków  i opłat lokalnych', 21, ''),
(67, 97, 'Zwrot kaucji mieszkaniowych wpłaconych przed 11 listopada 1994 r. przez najemców mieszkań wchodzących w skład mieszkaniowego zasobu gminy', 12, ''),
(68, 99, 'Udzielanie bonifikaty od opłaty rocznej z tytułu użytkowania wieczystego nieruchomości gruntowych stanowiących własność Skarbu Państwa lub Gminy Kielce', 6, ''),
(69, 100, 'Zwrot nadpłaty z tytułu należności budżetowych do klienta', 11, ''),
(70, 108, 'Przygotowanie i Realizacja Inwestycji Realizowanej w Ramach Lokalnej Inicjatywy Inwestycyjnej', 8, ''),
(71, 109, 'Wydanie decyzji w sprawie przyznania stypendium szkolnego/zasiłku szkolnego dla uczniów zamieszkałych na terenie Miasta Kielce', 5, ''),
(72, 111, 'Wydawanie decyzji o środowiskowych uwarunkowaniach ', 18, ''),
(73, 114, 'Wydanie decyzji w sprawie przyznania pracodawcom dofinansowania kosztów kształcenia pracowników młodocianych zamieszkałych na terenie Miasta Kielce', 5, ''),
(74, 115, 'Wydawanie skierowań do Specjalnych Ośrodków Szkolno-Wychowawczych i Młodzieżowych Ośrodków Socjoterapii', 5, ''),
(75, 116, 'Wydanie zezwolenia na przewozy regularne i regularne specjalne', 17, ''),
(76, 117, 'Przyznawanie stypendiów sportowych dla osób fizycznych za osiągnięte wyniki sportowe', 10, ''),
(77, 119, 'Wydawanie zaświadczeń w zakresie danych zgromadzonych  w aktach spraw podatkowych', 14, ''),
(78, 120, 'Zwrot nienależnej opłaty skarbowej', 14, ''),
(79, 121, 'Postępowanie w zakresie praw konsumenckich', 4, '');

-- --------------------------------------------------------

--
-- Table structure for table `Szpitale`
--

CREATE TABLE IF NOT EXISTS `Szpitale` (
  `Id` int(11) NOT NULL,
  `Nazwa` text COLLATE utf8_polish_ci NOT NULL,
  `Ulica` varchar(64) COLLATE utf8_polish_ci NOT NULL,
  `NumerBudynku` varchar(32) COLLATE utf8_polish_ci NOT NULL,
  `KodPocztowy` varchar(32) COLLATE utf8_polish_ci NOT NULL,
  `Telefon` text COLLATE utf8_polish_ci NOT NULL,
  `WWW` text COLLATE utf8_polish_ci NOT NULL,
  `json_ogc` text COLLATE utf8_polish_ci NOT NULL,
  `json_geo` text COLLATE utf8_polish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Dumping data for table `Szpitale`
--

INSERT INTO `Szpitale` (`Id`, `Nazwa`, `Ulica`, `NumerBudynku`, `KodPocztowy`, `Telefon`, `WWW`, `json_ogc`, `json_geo`) VALUES
(0, 'Świętokrzyskie Centrum Onkologii w Kielcach', 'Artwioskiego', '3', '25-734', 'Informacja: 41 36 74 208, Rejestracja: 41 36 74 274 lub 41 36 74 146', 'http://www.onkol.kielce.pl', 'PROJCS["ETRS89 / Poland CS2000 zone 7",GEOGCS["unnamed",DATUM["unnamed",SPHEROID["GRS 1980",6378137,298.2572221010002]],PRIMEM["Greenwich",0],UNIT["degree",0.0174532925199433]],PROJECTION["Transverse_Mercator"],PARAMETER["latitude_of_origin",0],PARAMETER["central_meridian",21],PARAMETER["scale_factor",0.999923],PARAMETER["false_easting",7500000],PARAMETER["false_northing",0],UNIT["METER",1]]', '{u''type'': u''Point'', u''coordinates'': [7471728.84, 5637479.42]}'),
(1, 'Wojewódzki Specjalistyczny Szpital Dzieci cy im. W4. Buszkowskiego (Pawilon G) w Kielcach', 'Artwi/skiego', '3A', '25-734', 'Centrala: 41 345 89 48 lub 41 345 63 25', 'http://www.chok.kielce.pl', 'PROJCS["ETRS89 / Poland CS2000 zone 7",GEOGCS["unnamed",DATUM["unnamed",SPHEROID["GRS 1980",6378137,298.2572221010002]],PRIMEM["Greenwich",0],UNIT["degree",0.0174532925199433]],PROJECTION["Transverse_Mercator"],PARAMETER["latitude_of_origin",0],PARAMETER["central_meridian",21],PARAMETER["scale_factor",0.999923],PARAMETER["false_easting",7500000],PARAMETER["false_northing",0],UNIT["METER",1]]', '{u''type'': u''Point'', u''coordinates'': [7471854.02, 5637444.65]}'),
(2, 'Wojewódzki Szpital Zespolony w Kielcach', 'Grunwaldzka', '45', '25-736', '41 36 71 301', 'http://www.bip.wszzkielce.pl', 'PROJCS["ETRS89 / Poland CS2000 zone 7",GEOGCS["unnamed",DATUM["unnamed",SPHEROID["GRS 1980",6378137,298.2572221010002]],PRIMEM["Greenwich",0],UNIT["degree",0.0174532925199433]],PROJECTION["Transverse_Mercator"],PARAMETER["latitude_of_origin",0],PARAMETER["central_meridian",21],PARAMETER["scale_factor",0.999923],PARAMETER["false_easting",7500000],PARAMETER["false_northing",0],UNIT["METER",1]]', '{u''type'': u''Point'', u''coordinates'': [7471921.46, 5637697.4]}'),
(3, 'Wojewódzki  Specjalistyczny Zespół\r\nOpieki Neuropsychiatrycznej\r\nw Kielcach', 'Grunwaldzka', '45', '25-736', '041 367 13 01', 'http://bip.wszzkielce.pl', 'PROJCS["ETRS89 / Poland CS2000 zone 7",GEOGCS["unnamed",DATUM["unnamed",SPHEROID["GRS 1980",6378137,298.2572221010002]],PRIMEM["Greenwich",0],UNIT["degree",0.0174532925199433]],PROJECTION["Transverse_Mercator"],PARAMETER["latitude_of_origin",0],PARAMETER["central_meridian",21],PARAMETER["scale_factor",0.999923],PARAMETER["false_easting",7500000],PARAMETER["false_northing",0],UNIT["METER",1]]', '{u''type'': u''Point'', u''coordinates'': [7471735.33, 5635532.33]}'),
(4, 'Szpital Kielecki Sp. z o.o. NZOZ \rw. Aleksandra', 'Kopciuszki', '25', '25-316', '41 341 78 00', 'http://www.szpitalkielecki.com', 'PROJCS["ETRS89 / Poland CS2000 zone 7",GEOGCS["unnamed",DATUM["unnamed",SPHEROID["GRS 1980",6378137,298.2572221010002]],PRIMEM["Greenwich",0],UNIT["degree",0.0174532925199433]],PROJECTION["Transverse_Mercator"],PARAMETER["latitude_of_origin",0],PARAMETER["central_meridian",21],PARAMETER["scale_factor",0.999923],PARAMETER["false_easting",7500000],PARAMETER["false_northing",0],UNIT["METER",1]]', '{u''type'': u''Point'', u''coordinates'': [7474552.11, 5637638.1]}'),
(5, 'Zakpad Opieki Zdrowotnej MSWiA w Kielcach', 'Ogrodowa', '11', '25-024', 'Izba przyjek: 41 349 36 08, Rejestracja: 41 349 35 29  lub  41 349 35 19', 'http://www.zoz.kielce.ids.pl', 'PROJCS["ETRS89 / Poland CS2000 zone 7",GEOGCS["unnamed",DATUM["unnamed",SPHEROID["GRS 1980",6378137,298.2572221010002]],PRIMEM["Greenwich",0],UNIT["degree",0.0174532925199433]],PROJECTION["Transverse_Mercator"],PARAMETER["latitude_of_origin",0],PARAMETER["central_meridian",21],PARAMETER["scale_factor",0.999923],PARAMETER["false_easting",7500000],PARAMETER["false_northing",0],UNIT["METER",1]]', '{u''type'': u''Point'', u''coordinates'': [7473510.49, 5636932.12]}'),
(6, 'Świętokrzyskie Centrum Matki i Noworodka - Szpital Specjalistyczny w Kielcach', 'Prosta', '30', '25-371', 'Centrala: 41 361 85 25', 'http://www.szpgin.kielce.pl', 'PROJCS["ETRS89 / Poland CS2000 zone 7",GEOGCS["unnamed",DATUM["unnamed",SPHEROID["GRS 1980",6378137,298.2572221010002]],PRIMEM["Greenwich",0],UNIT["degree",0.0174532925199433]],PROJECTION["Transverse_Mercator"],PARAMETER["latitude_of_origin",0],PARAMETER["central_meridian",21],PARAMETER["scale_factor",0.999923],PARAMETER["false_easting",7500000],PARAMETER["false_northing",0],UNIT["METER",1]]', '{u''type'': u''Point'', u''coordinates'': [7474369.3, 5636410.41]}');

-- --------------------------------------------------------

--
-- Table structure for table `Termins`
--

CREATE TABLE IF NOT EXISTS `Termins` (
`Id` int(11) NOT NULL,
  `AccountId` int(11) NOT NULL,
  `WydzialId` int(11) NOT NULL,
  `CzasStworzenia` date NOT NULL,
  `CzasUmowienia` date NOT NULL,
  `KartaId` int(11) NOT NULL,
  `Aktywny` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

-- --------------------------------------------------------

--
-- Table structure for table `Urzedy`
--

CREATE TABLE IF NOT EXISTS `Urzedy` (
  `Id` int(11) NOT NULL,
  `Nazwa` text COLLATE utf8_polish_ci NOT NULL,
  `Ulica` varchar(64) COLLATE utf8_polish_ci NOT NULL,
  `NumerBudynku` varchar(32) COLLATE utf8_polish_ci NOT NULL,
  `KodPocztowy` varchar(32) COLLATE utf8_polish_ci NOT NULL,
  `Telefon` varchar(32) COLLATE utf8_polish_ci NOT NULL,
  `WWW` text COLLATE utf8_polish_ci NOT NULL,
  `json_ogc` text COLLATE utf8_polish_ci NOT NULL,
  `json_geo` text COLLATE utf8_polish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Dumping data for table `Urzedy`
--

INSERT INTO `Urzedy` (`Id`, `Nazwa`, `Ulica`, `NumerBudynku`, `KodPocztowy`, `Telefon`, `WWW`, `json_ogc`, `json_geo`) VALUES
(0, 'STAROSTWO POWIATOWE W KIELCACH', 'WRZOSOWA', '44', '25-211', '41 200-12-00', 'http://www.powiat.kielce.pl', 'PROJCS["ETRS89 / Poland CS2000 zone 7",GEOGCS["unnamed",DATUM["unnamed",SPHEROID["GRS 1980",6378137,298.2572221010002]],PRIMEM["Greenwich",0],UNIT["degree",0.0174532925199433]],PROJECTION["Transverse_Mercator"],PARAMETER["latitude_of_origin",0],PARAMETER["central_meridian",21],PARAMETER["scale_factor",0.999923],PARAMETER["false_easting",7500000],PARAMETER["false_northing",0],UNIT["METER",1]]', '{u''type'': u''Point'', u''coordinates'': [7474184.59, 5634511.61]}'),
(1, 'ŚWIĘTOKRZYSKI URZĄD WOJEWÓDZKI', 'IX WIEKÓW KIELC', '3', '25-516', '41 342-12-22', 'http://www.kielce.uw.gov.pl', 'PROJCS["ETRS89 / Poland CS2000 zone 7",GEOGCS["unnamed",DATUM["unnamed",SPHEROID["GRS 1980",6378137,298.2572221010002]],PRIMEM["Greenwich",0],UNIT["degree",0.0174532925199433]],PROJECTION["Transverse_Mercator"],PARAMETER["latitude_of_origin",0],PARAMETER["central_meridian",21],PARAMETER["scale_factor",0.999923],PARAMETER["false_easting",7500000],PARAMETER["false_northing",0],UNIT["METER",1]]', '{u''type'': u''Point'', u''coordinates'': [7474015.66, 5637895.88]}'),
(2, 'URZĄD MARSZAŁKOWSKI WOJEWÓDZTWA ', 'IX WIEKÓW KIELC', '3', '25-516', '41 342-18-78', 'http://www.sejmik.kielce.pl', 'PROJCS["ETRS89 / Poland CS2000 zone 7",GEOGCS["unnamed",DATUM["unnamed",SPHEROID["GRS 1980",6378137,298.2572221010002]],PRIMEM["Greenwich",0],UNIT["degree",0.0174532925199433]],PROJECTION["Transverse_Mercator"],PARAMETER["latitude_of_origin",0],PARAMETER["central_meridian",21],PARAMETER["scale_factor",0.999923],PARAMETER["false_easting",7500000],PARAMETER["false_northing",0],UNIT["METER",1]]', '{u''type'': u''Point'', u''coordinates'': [7474029.93, 5637892.18]}'),
(3, 'URZĄD STATYSTYCZNY W KIELCACH', 'WRÓBLEWSKIEGO', '2', '25-369', '41 361-15-42 w 100', 'http://www.stat.gov.pl/kielce', 'PROJCS["ETRS89 / Poland CS2000 zone 7",GEOGCS["unnamed",DATUM["unnamed",SPHEROID["GRS 1980",6378137,298.2572221010002]],PRIMEM["Greenwich",0],UNIT["degree",0.0174532925199433]],PROJECTION["Transverse_Mercator"],PARAMETER["latitude_of_origin",0],PARAMETER["central_meridian",21],PARAMETER["scale_factor",0.999923],PARAMETER["false_easting",7500000],PARAMETER["false_northing",0],UNIT["METER",1]]', '{u''type'': u''Point'', u''coordinates'': [7474461.03, 5636759.37]}'),
(4, 'URZĄD MIASTA KIELCE', 'RYNEK', '1', '25-303', '41 36 76 000', 'http://www.um.kielce.pl', 'PROJCS["ETRS89 / Poland CS2000 zone 7",GEOGCS["unnamed",DATUM["unnamed",SPHEROID["GRS 1980",6378137,298.2572221010002]],PRIMEM["Greenwich",0],UNIT["degree",0.0174532925199433]],PROJECTION["Transverse_Mercator"],PARAMETER["latitude_of_origin",0],PARAMETER["central_meridian",21],PARAMETER["scale_factor",0.999923],PARAMETER["false_easting",7500000],PARAMETER["false_northing",0],UNIT["METER",1]]', '{u''type'': u''Point'', u''coordinates'': [7474011.48, 5637460.58]}'),
(5, 'URZĄD MIASTA KIELCE', 'STRYCHARSKA', '6', '25-659', '41 36 76 000', 'http://www.um.kielce.pl', 'PROJCS["ETRS89 / Poland CS2000 zone 7",GEOGCS["unnamed",DATUM["unnamed",SPHEROID["GRS 1980",6378137,298.2572221010002]],PRIMEM["Greenwich",0],UNIT["degree",0.0174532925199433]],PROJECTION["Transverse_Mercator"],PARAMETER["latitude_of_origin",0],PARAMETER["central_meridian",21],PARAMETER["scale_factor",0.999923],PARAMETER["false_easting",7500000],PARAMETER["false_northing",0],UNIT["METER",1]]', '{u''type'': u''Point'', u''coordinates'': [7473022.08, 5639260.68]}'),
(6, 'URZĄD MIASTA KIELCE', 'KOZIA', '3', '25-303', '41 36 76 361, 41 34 42 804', 'http://www.um.kielce.pl', 'PROJCS["ETRS89 / Poland CS2000 zone 7",GEOGCS["unnamed",DATUM["unnamed",SPHEROID["GRS 1980",6378137,298.2572221010002]],PRIMEM["Greenwich",0],UNIT["degree",0.0174532925199433]],PROJECTION["Transverse_Mercator"],PARAMETER["latitude_of_origin",0],PARAMETER["central_meridian",21],PARAMETER["scale_factor",0.999923],PARAMETER["false_easting",7500000],PARAMETER["false_northing",0],UNIT["METER",1]]', '{u''type'': u''Point'', u''coordinates'': [7474028.94, 5637539.25]}'),
(7, 'URZĄD MIASTA KIELCE', 'SZYMANOWSKIEGO', '6', '25-361', '41 36 76 000', 'http://www.um.kielce.pl', 'PROJCS["ETRS89 / Poland CS2000 zone 7",GEOGCS["unnamed",DATUM["unnamed",SPHEROID["GRS 1980",6378137,298.2572221010002]],PRIMEM["Greenwich",0],UNIT["degree",0.0174532925199433]],PROJECTION["Transverse_Mercator"],PARAMETER["latitude_of_origin",0],PARAMETER["central_meridian",21],PARAMETER["scale_factor",0.999923],PARAMETER["false_easting",7500000],PARAMETER["false_northing",0],UNIT["METER",1]]', '{u''type'': u''Point'', u''coordinates'': [7475200.07, 5636561.63]}'),
(8, 'MIEJSKI URZĄD PRACY', 'SZYMANOWSKIEGO', '6', '25-361', '41 340 60 55, 041 340 60 56', 'http://www.mup.kielce.pl', 'PROJCS["ETRS89 / Poland CS2000 zone 7",GEOGCS["unnamed",DATUM["unnamed",SPHEROID["GRS 1980",6378137,298.2572221010002]],PRIMEM["Greenwich",0],UNIT["degree",0.0174532925199433]],PROJECTION["Transverse_Mercator"],PARAMETER["latitude_of_origin",0],PARAMETER["central_meridian",21],PARAMETER["scale_factor",0.999923],PARAMETER["false_easting",7500000],PARAMETER["false_northing",0],UNIT["METER",1]]', '{u''type'': u''Point'', u''coordinates'': [7475196.81, 5636572.02]}'),
(9, 'POWIATOWY URZĄD PRACY', 'KOLBERGA', '4', '25-620', '41 36 71 100', 'http://www.pupkielce.pl', 'PROJCS["ETRS89 / Poland CS2000 zone 7",GEOGCS["unnamed",DATUM["unnamed",SPHEROID["GRS 1980",6378137,298.2572221010002]],PRIMEM["Greenwich",0],UNIT["degree",0.0174532925199433]],PROJECTION["Transverse_Mercator"],PARAMETER["latitude_of_origin",0],PARAMETER["central_meridian",21],PARAMETER["scale_factor",0.999923],PARAMETER["false_easting",7500000],PARAMETER["false_northing",0],UNIT["METER",1]]', '{u''type'': u''Point'', u''coordinates'': [7472286.41, 5638730.11]}'),
(10, 'WOJEWÓDZKI URZĄD PRACY', 'WITOSA', '86', '25-561', '41 36 41 600', 'http://www.wup.kielce.pl', 'PROJCS["ETRS89 / Poland CS2000 zone 7",GEOGCS["unnamed",DATUM["unnamed",SPHEROID["GRS 1980",6378137,298.2572221010002]],PRIMEM["Greenwich",0],UNIT["degree",0.0174532925199433]],PROJECTION["Transverse_Mercator"],PARAMETER["latitude_of_origin",0],PARAMETER["central_meridian",21],PARAMETER["scale_factor",0.999923],PARAMETER["false_easting",7500000],PARAMETER["false_northing",0],UNIT["METER",1]]', '{u''type'': u''Point'', u''coordinates'': [7474374.15, 5640598.52]}'),
(11, 'PIERWSZY URZĄD SKARBOWY', 'WRÓBLA', '17', '25-661', '41 36 57 160', 'http://www.izba-skarbowa.kielce.pl/index.php?option=com_content&task=category&sectionid=7&id=35&Itemid=49', 'PROJCS["ETRS89 / Poland CS2000 zone 7",GEOGCS["unnamed",DATUM["unnamed",SPHEROID["GRS 1980",6378137,298.2572221010002]],PRIMEM["Greenwich",0],UNIT["degree",0.0174532925199433]],PROJECTION["Transverse_Mercator"],PARAMETER["latitude_of_origin",0],PARAMETER["central_meridian",21],PARAMETER["scale_factor",0.999923],PARAMETER["false_easting",7500000],PARAMETER["false_northing",0],UNIT["METER",1]]', '{u''type'': u''Point'', u''coordinates'': [7472897.82, 5639686.05]}'),
(12, 'DRUGI URZĄD SKARBOWY', 'CZĘSTOCHOWSKA', '20', '25-647', '41 36 83 650', 'http://www.izba-skarbowa.kielce.pl/index.php?option=com_content&task=category&sectionid=7&id=36&Itemid=78', 'PROJCS["ETRS89 / Poland CS2000 zone 7",GEOGCS["unnamed",DATUM["unnamed",SPHEROID["GRS 1980",6378137,298.2572221010002]],PRIMEM["Greenwich",0],UNIT["degree",0.0174532925199433]],PROJECTION["Transverse_Mercator"],PARAMETER["latitude_of_origin",0],PARAMETER["central_meridian",21],PARAMETER["scale_factor",0.999923],PARAMETER["false_easting",7500000],PARAMETER["false_northing",0],UNIT["METER",1]]', '{u''type'': u''Point'', u''coordinates'': [7472259.97, 5639376.5]}'),
(13, 'URZĄD KONTROLI SKARBOWEJ', 'SANDOMIERSKA', '105', '25-324', '41 34 31 718', 'http://www.ns.net.pl/uks_kielce/', 'PROJCS["ETRS89 / Poland CS2000 zone 7",GEOGCS["unnamed",DATUM["unnamed",SPHEROID["GRS 1980",6378137,298.2572221010002]],PRIMEM["Greenwich",0],UNIT["degree",0.0174532925199433]],PROJECTION["Transverse_Mercator"],PARAMETER["latitude_of_origin",0],PARAMETER["central_meridian",21],PARAMETER["scale_factor",0.999923],PARAMETER["false_easting",7500000],PARAMETER["false_northing",0],UNIT["METER",1]]', '{u''type'': u''Point'', u''coordinates'': [7475311.58, 5637297.11]}'),
(14, 'OBWODOWY URZĄD MIAR W KIELCACH', 'ŚW. LEONARDA', '14', '25-953', '41-344-29-75', 'http://www.gum.gov.pl', 'PROJCS["ETRS89 / Poland CS2000 zone 7",GEOGCS["unnamed",DATUM["unnamed",SPHEROID["GRS 1980",6378137,298.2572221010002]],PRIMEM["Greenwich",0],UNIT["degree",0.0174532925199433]],PROJECTION["Transverse_Mercator"],PARAMETER["latitude_of_origin",0],PARAMETER["central_meridian",21],PARAMETER["scale_factor",0.999923],PARAMETER["false_easting",7500000],PARAMETER["false_northing",0],UNIT["METER",1]]', '{u''type'': u''Point'', u''coordinates'': [7474200.87, 5637316.14]}'),
(15, 'IZBA CELNA W KIELCACH', 'WESOŁA', '56', '25-363', '41-364-28-10', 'http://www.kielce.scelna.gov.pl', 'PROJCS["ETRS89 / Poland CS2000 zone 7",GEOGCS["unnamed",DATUM["unnamed",SPHEROID["GRS 1980",6378137,298.2572221010002]],PRIMEM["Greenwich",0],UNIT["degree",0.0174532925199433]],PROJECTION["Transverse_Mercator"],PARAMETER["latitude_of_origin",0],PARAMETER["central_meridian",21],PARAMETER["scale_factor",0.999923],PARAMETER["false_easting",7500000],PARAMETER["false_northing",0],UNIT["METER",1]]', '{u''type'': u''Point'', u''coordinates'': [7474053.79, 5637117.05]}'),
(16, 'IZBA SKARBOWA W KIELCACH', 'WITOSA', '78 B', '25-561', '41 34 05 1020', 'http://www.izba-skarbowa.kielce.pl/', 'PROJCS["ETRS89 / Poland CS2000 zone 7",GEOGCS["unnamed",DATUM["unnamed",SPHEROID["GRS 1980",6378137,298.2572221010002]],PRIMEM["Greenwich",0],UNIT["degree",0.0174532925199433]],PROJECTION["Transverse_Mercator"],PARAMETER["latitude_of_origin",0],PARAMETER["central_meridian",21],PARAMETER["scale_factor",0.999923],PARAMETER["false_easting",7500000],PARAMETER["false_northing",0],UNIT["METER",1]]', '{u''type'': u''Point'', u''coordinates'': [7474914.29, 5640769.52]}'),
(17, 'WOJEWÓDZKI INSPEKTORAT OCHRONY ŚRODOWISKA W KIELCACH', 'IX WIEKÓW KIELC', '3', '25-516', '41 342-19-22', 'http://kielce.pios.gov.pl/', 'PROJCS["ETRS89 / Poland CS2000 zone 7",GEOGCS["unnamed",DATUM["unnamed",SPHEROID["GRS 1980",6378137,298.2572221010002]],PRIMEM["Greenwich",0],UNIT["degree",0.0174532925199433]],PROJECTION["Transverse_Mercator"],PARAMETER["latitude_of_origin",0],PARAMETER["central_meridian",21],PARAMETER["scale_factor",0.999923],PARAMETER["false_easting",7500000],PARAMETER["false_northing",0],UNIT["METER",1]]', '{u''type'': u''Point'', u''coordinates'': [7474002.96, 5637898.24]}'),
(18, 'WOJEWÓDZKI FUNDUSZ OCHRONY ŚRODOWISKA I GOSPODARKI WODNEJ W KIELCACH', 'AL. KS. J. POPIESUSZKI', '41', '25-155', '41 366-15-12', 'http://www.wfos.com.pl', 'PROJCS["ETRS89 / Poland CS2000 zone 7",GEOGCS["unnamed",DATUM["unnamed",SPHEROID["GRS 1980",6378137,298.2572221010002]],PRIMEM["Greenwich",0],UNIT["degree",0.0174532925199433]],PROJECTION["Transverse_Mercator"],PARAMETER["latitude_of_origin",0],PARAMETER["central_meridian",21],PARAMETER["scale_factor",0.999923],PARAMETER["false_easting",7500000],PARAMETER["false_northing",0],UNIT["METER",1]]', '{u''type'': u''Point'', u''coordinates'': [7474229.09, 5634367.9]}'),
(19, 'URZĄD MIASTA KIELCE', 'MRODA', '28', '25-619', '41 367 68 63', ' ', 'PROJCS["ETRS89 / Poland CS2000 zone 7",GEOGCS["unnamed",DATUM["unnamed",SPHEROID["GRS 1980",6378137,298.2572221010002]],PRIMEM["Greenwich",0],UNIT["degree",0.0174532925199433]],PROJECTION["Transverse_Mercator"],PARAMETER["latitude_of_origin",0],PARAMETER["central_meridian",21],PARAMETER["scale_factor",0.999923],PARAMETER["false_easting",7500000],PARAMETER["false_northing",0],UNIT["METER",1]]', '{u''type'': u''Point'', u''coordinates'': [7472918.63, 5638512.32]}');

-- --------------------------------------------------------

--
-- Table structure for table `Wydzialy`
--

CREATE TABLE IF NOT EXISTS `Wydzialy` (
`Id` int(11) NOT NULL,
  `Nazwa` text COLLATE utf8_polish_ci NOT NULL,
  `Skrot` varchar(16) COLLATE utf8_polish_ci NOT NULL,
  `UrzadId` int(11) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Dumping data for table `Wydzialy`
--

INSERT INTO `Wydzialy` (`Id`, `Nazwa`, `Skrot`, `UrzadId`) VALUES
(1, 'Wydział Architektury I Budownictwa', 'AB', 4),
(2, 'Wydział Audytu Wewnętrznego i Kontroli', 'AWK', 4),
(3, 'Wydział Budżetu', 'B', 4),
(4, 'Biuro Biuro Miejskiego Rzecznika Konsumentów', 'BMRK', 5),
(5, 'Wydział Edukacji, Profilaktyki i Pożytku Publicznego', 'EPP', 5),
(6, 'Wydział Gospodarki Nieruchomościami I Geodezji', 'GNG', 4),
(7, 'Wydział Gospodarki Nieruchomościami I Geodezji', 'GNG2', 19),
(8, 'Wydział Inwestycji', 'I', 5),
(9, 'Wydział Komunikacji', 'K', 4),
(10, 'Wydział Kultury, Sportu i Promocji Miasta', 'KPM', 5),
(11, 'Wydział Księgowości Urzędu', 'KU', 4),
(12, 'Wydział Mieszkalnictwa', 'M', 5),
(13, 'Wydział Organizacyjny', 'OR', 4),
(14, 'Wydział Podatków', 'P', 4),
(15, 'Wydział Zarządzania Ruchem Drogowym I Mobilnością', 'RDM', 5),
(16, 'Wydział Rozwoju i Rewitalizacji Miasta', 'RRM', 6),
(17, 'Wydział Spraw Obywatelskich i Działalności Gospodarczej', 'SOD', 4),
(18, 'Wydział Usług Komunalnych i Zarządzania Środowiskiem', 'UKS', 5),
(19, 'Urząd Stanu Cywilnego', 'USC', 4),
(20, 'Wydział Zarządzania Kryzysowego I Bezpieczeństwa', 'ZKB', 4),
(21, 'Wydział Zarządzania Należnościami', 'ZN', 4);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `Accounts`
--
ALTER TABLE `Accounts`
 ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `Addresses`
--
ALTER TABLE `Addresses`
 ADD PRIMARY KEY (`Id`), ADD KEY `AccountId` (`AccountId`);

--
-- Indexes for table `Godzinas`
--
ALTER TABLE `Godzinas`
 ADD PRIMARY KEY (`Id`), ADD KEY `WydzialId` (`WydzialId`);

--
-- Indexes for table `Kartas`
--
ALTER TABLE `Kartas`
 ADD PRIMARY KEY (`Id`), ADD KEY `WydzialId` (`WydzialId`);

--
-- Indexes for table `Szpitale`
--
ALTER TABLE `Szpitale`
 ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `Termins`
--
ALTER TABLE `Termins`
 ADD PRIMARY KEY (`Id`), ADD UNIQUE KEY `AccountId` (`AccountId`), ADD UNIQUE KEY `WydzialId` (`WydzialId`), ADD UNIQUE KEY `KartaId` (`KartaId`);

--
-- Indexes for table `Urzedy`
--
ALTER TABLE `Urzedy`
 ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `Wydzialy`
--
ALTER TABLE `Wydzialy`
 ADD PRIMARY KEY (`Id`), ADD KEY `UrzadId` (`UrzadId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `Accounts`
--
ALTER TABLE `Accounts`
MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `Addresses`
--
ALTER TABLE `Addresses`
MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `Godzinas`
--
ALTER TABLE `Godzinas`
MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=21;
--
-- AUTO_INCREMENT for table `Kartas`
--
ALTER TABLE `Kartas`
MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=80;
--
-- AUTO_INCREMENT for table `Termins`
--
ALTER TABLE `Termins`
MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `Wydzialy`
--
ALTER TABLE `Wydzialy`
MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=22;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `Addresses`
--
ALTER TABLE `Addresses`
ADD CONSTRAINT `Addresses_ibfk_1` FOREIGN KEY (`AccountId`) REFERENCES `Accounts` (`Id`);

--
-- Constraints for table `Godzinas`
--
ALTER TABLE `Godzinas`
ADD CONSTRAINT `Godzinas_ibfk_1` FOREIGN KEY (`WydzialId`) REFERENCES `Wydzialy` (`Id`);

--
-- Constraints for table `Kartas`
--
ALTER TABLE `Kartas`
ADD CONSTRAINT `Kartas_ibfk_1` FOREIGN KEY (`WydzialId`) REFERENCES `Wydzialy` (`Id`);

--
-- Constraints for table `Termins`
--
ALTER TABLE `Termins`
ADD CONSTRAINT `Termins_ibfk_3` FOREIGN KEY (`KartaId`) REFERENCES `Kartas` (`Id`),
ADD CONSTRAINT `Termins_ibfk_1` FOREIGN KEY (`AccountId`) REFERENCES `Accounts` (`Id`),
ADD CONSTRAINT `Termins_ibfk_2` FOREIGN KEY (`WydzialId`) REFERENCES `Wydzialy` (`Id`);

--
-- Constraints for table `Wydzialy`
--
ALTER TABLE `Wydzialy`
ADD CONSTRAINT `Wydzialy_ibfk_1` FOREIGN KEY (`UrzadId`) REFERENCES `Urzedy` (`Id`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
