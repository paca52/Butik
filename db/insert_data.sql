GO
USE db_butik;

-- Insert 20 rows into table_dostava
INSERT INTO dbo.table_tip_zaposlenog (id, naziv, dashboard, zaposleni, racuni, artikli)
VALUES
  (1, 'admin', 1, 1, 1, 1);

-- Insert 20 rows into table_zaposleni
INSERT INTO dbo.table_zaposleni (
  jmbg,
  ime,
  prezime,
  broj_radnih_sati,
  satnica,
  premija,
  datum_zaposlenja,
  broj_slobodnih_dana,
  username,
  password,
  tip_zaposlenog
)
VALUES
('1234567890123', 'John',   'Doe', 40, 10, NULL, '2024-01-01', 20, 'JohnDoeSales', 'Sales', 1),
('1234567890124', 'Jane',   'Smith', 35, 12, NULL, '2024-01-02', 22, 'JaneSmithMarketing', 'Marketing', 1),
('1234567890125', 'Alice',  'Johnson', 38, 11, NULL, '2024-01-03', 18, 'AliceJohnsonIT', 'IT', 1),
('1234567890126', 'Bob',    'Brown', 42, 9, NULL, '2024-01-04', 19, 'BobBrownSales', 'Sales', 1),
('1234567890127', 'Charlie','Davis', 37, 11, NULL, '2024-01-05', 21, 'CharlieDavisMarketing', 'Marketing', 1),
('1234567890128', 'David',  'Wilson', 39, 10, NULL, '2024-01-06', 17, 'DavidWilsonIT', 'IT', 1),
('1234567890129', 'Eve',    'Miller', 36, 12, NULL, '2024-01-07', 20, 'EveMillerSales', 'Sales', 1),
('1234567890130', 'Frank',  'Moore', 41, 9, NULL, '2024-01-08', 22, 'FrankMooreMarketing', 'Marketing', 1),
('1234567890131', 'Grace',  'Lee', 38, 11, NULL, '2024-01-09', 18, 'GraceLeeIT', 'IT', 1),
('1234567890132', 'Henry',  'Clark', 43, 10, NULL, '2024-01-10', 19, 'HenryClarkSales', 'Sales', 1),
('1234567890133', 'Ivy',    'Young', 37, 11, NULL, '2024-01-11', 21, 'IvyYoungMarketing', 'Marketing', 1),
('1234567890134', 'Jack',   'Hill', 40, 9, NULL, '2024-01-12', 17, 'JackHillIT', 'IT', 1),
('1234567890135', 'Kevin',  'Green', 36, 12, NULL, '2024-01-13', 20, 'KevinGreenSales', 'Sales', 1),
('1234567890136', 'Linda',  'Adams', 42, 10, NULL, '2024-01-14', 22, 'LindaAdamsMarketing', 'Marketing', 1),
('1234567890137', 'Mike',   'Baker', 39, 11, NULL, '2024-01-15', 18, 'MikeBakerIT', 'IT', 1),
('1234567890138', 'Nancy',  'Carter', 37, 10, NULL, '2024-01-16', 19, 'NancyCarterSales', 'Sales', 1),
('1234567890139', 'Olivia', 'Evans', 40, 12, NULL, '2024-01-17', 21, 'OliviaEvansMarketing', 'Marketing', 1),
('1234567890140', 'Peter',  'Ford', 38, 9, NULL, '2024-01-18', 17, 'PeterFordIT', 'IT', 1),
('1234567890141', 'Quincy', 'Graham', 44, 11, NULL, '2024-01-19', 20, 'QuincyGrahamSales', 'Sales', 1),
('0000000000000', 'admin',  'admin', 0, 0, NULL, '2024-01-01', 0, 'admin', 'admin', 1),
('1234567890142', 'Rachel', 'Harris', 37, 10, NULL, '2024-01-20', 22, 'RachelHarrisMarketing', 'Marketing', 1);

-- Insert 20 rows into table_artikli
INSERT INTO dbo.table_artikli (id_artikla, naziv, kolicina, cena)
VALUES
  (1, 'Shoes', 50, 25.99),
  (2, 'Shirts', 100, 15.99),
  (3, 'Pants', 75, 35.99),
  (4, 'Hats', 30, 10.99),
  (5, 'Jackets', 25, 45.99),
  (6, 'Socks', 200, 5.99),
  (7, 'Gloves', 50, 8.99),
  (8, 'Scarves', 40, 12.99),
  (9, 'Belts', 60, 18.99),
  (10, 'Ties', 70, 14.99),
  (11, 'Dresses', 40, 55.99),
  (12, 'Skirts', 35, 30.99),
  (13, 'Jeans', 80, 40.99),
  (14, 'Sweaters', 45, 35.99),
  (15, 'Blouses', 55, 25.99),
  (16, 'Shorts', 65, 20.99),
  (17, 'Coats', 30, 65.99),
  (18, 'Vests', 20, 32.99),
  (19, 'Pajamas', 40, 22.99),
  (20, 'Underwear', 100, 7.99);

-- Insert 20 rows into table_racun_header
INSERT INTO dbo.table_racun_header (id_racuna, id_zaposleni, ukupna_cena, datum)
VALUES
  (1, '1234567890123', 100, '2024-01-01'),
  (2, '1234567890124', 150, '2024-01-02'),
  (3, '1234567890125', 120, '2024-01-03'),
  (4, '1234567890126', 90, '2024-01-04'),
  (5, '1234567890127', 200, '2024-01-05'),
  (6, '1234567890128', 80, '2024-01-06'),
  (7, '1234567890129', 110, '2024-01-07'),
  (8, '1234567890130', 95, '2024-01-08'),
  (9, '1234567890131', 130, '2024-01-09'),
  (10, '1234567890132', 180, '2024-01-10'),
  (11, '1234567890133', 75, '2024-01-11'),
  (12, '1234567890134', 160, '2024-01-12'),
  (13, '1234567890135', 85, '2024-01-13'),
  (14, '1234567890136', 220, '2024-01-14'),
  (15, '1234567890137', 105, '2024-01-15'),
  (16, '1234567890138', 70, '2024-01-16'),
  (17, '1234567890139', 145, '2024-01-17'),
  (18, '1234567890140', 100, '2024-01-18'),
  (19, '1234567890141', 190, '2024-01-19'),
  (20, '1234567890142', 115, '2024-01-20');

-- Insert 20 rows into table_racun_body
INSERT INTO dbo.table_racun_body (id, id_artikla, id_racun_header, kolicina, prodajna_cena)
VALUES
  (1, 1, 1, 2, 25.99),
  (2, 2, 2, 3, 15.99),
  (3, 3, 3, 1, 35.99),
  (4, 4, 4, 4, 10.99),
  (5, 5, 5, 5, 45.99),
  (6, 6, 6, 6, 5.99),
  (7, 7, 7, 7, 8.99),
  (8, 8, 8, 8, 12.99),
  (9, 9, 9, 9, 18.99),
  (10, 10, 10, 10, 14.99),
  (11, 11, 11, 11, 55.99),
  (12, 12, 12, 12, 30.99),
  (13, 13, 13, 13, 40.99),
  (14, 14, 14, 14, 35.99),
  (15, 15, 15, 15, 25.99),
  (16, 16, 16, 16, 20.99),
  (17, 17, 17, 17, 65.99),
  (18, 18, 18, 18, 32.99),
  (19, 19, 19, 19, 22.99),
  (20, 20, 20, 20, 7.99);

-- Insert 20 rows into table_dostava
INSERT INTO dbo.table_dostava (id_dostava, datum_dostave, dostavljac, id_artikla, kolicina_artikla)
VALUES
  (1, '2024-01-01', 'Delivery1', 1, 2),
  (2, '2024-01-02', 'Delivery2', 2, 3),
  (3, '2024-01-03', 'Delivery3', 3, 1),
  (4, '2024-01-04', 'Delivery4', 4, 4),
  (5, '2024-01-05', 'Delivery5', 5, 5),
  (6, '2024-01-06', 'Delivery6', 6, 6),
  (7, '2024-01-07', 'Delivery7', 7, 7),
  (8, '2024-01-08', 'Delivery8', 8, 8),
  (9, '2024-01-09', 'Delivery9', 9, 9),
  (10, '2024-01-10', 'Delivery10', 10, 10),
  (11, '2024-01-11', 'Delivery11', 11, 11),
  (12, '2024-01-12', 'Delivery12', 12, 12),
  (13, '2024-01-13', 'Delivery13', 13, 13),
  (14, '2024-01-14', 'Delivery14', 14, 14),
  (15, '2024-01-15', 'Delivery15', 15, 15),
  (16, '2024-01-16', 'Delivery16', 16, 16),
  (17, '2024-01-17', 'Delivery17', 17, 17),
  (18, '2024-01-18', 'Delivery18', 18, 18),
  (19, '2024-01-19', 'Delivery19', 19, 19),
  (20, '2024-01-20', 'Delivery20', 20, 20);


