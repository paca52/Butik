IF NOT EXISTS 
   (
    SELECT name FROM master.dbo.sysdatabases 
    WHERE name = 'db_butik'
    )
BEGIN
CREATE DATABASE db_butik
ON
( NAME = db_butik_dat, 
		 FILENAME = 'D:\<your_path_here>\db_butik.mdf', 
		 SIZE = 100MB,	MAXSIZE = 500MB, FILEGROWTH = 20% )
LOG ON 
( NAME = db_butik_log, 
		 FILENAME = 'D:\<your_path_here>\db_butik.ldf', 
		 SIZE = 20MB, MAXSIZE = UNLIMITED, FILEGROWTH = 10MB );

ALTER DATABASE db_butik
COLLATE Serbian_Latin_100_CS_AS;
END

GO
USE db_butik;

IF EXISTS (
    SELECT 1
    FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS
    WHERE CONSTRAINT_NAME = 'FK_table_korisnici_table_zaposleni'
)
BEGIN
    ALTER TABLE table_korisnici
    DROP CONSTRAINT FK_table_korisnici_table_zaposleni;
END;

IF EXISTS (
    SELECT 1
    FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS
    WHERE CONSTRAINT_NAME = 'FK_table_racun_header_table_zaposleni'
)
BEGIN
    ALTER TABLE table_racun_header
    DROP CONSTRAINT FK_table_racun_header_table_zaposleni;
END;

IF EXISTS (
    SELECT 1
    FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS
    WHERE CONSTRAINT_NAME = 'FK_table_racun_body_table_artikli'
)
BEGIN
    ALTER TABLE table_racun_body
    DROP CONSTRAINT FK_table_racun_body_table_artikli;
END;

IF EXISTS (
    SELECT 1
    FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS
    WHERE CONSTRAINT_NAME = 'FK_table_racun_body_table_racun_header'
)
BEGIN
    ALTER TABLE table_racun_body
    DROP CONSTRAINT FK_table_racun_body_table_racun_header;
END;


IF EXISTS (
    SELECT 1
    FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS
    WHERE CONSTRAINT_NAME = 'FK_table_dostava_table_artikli'
)
BEGIN
    ALTER TABLE table_dostava
    DROP CONSTRAINT FK_table_dostava_table_artikli;
END;

IF EXISTS (
    SELECT 1
    FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS
    WHERE CONSTRAINT_NAME = 'FK_table_zaposleni_table_tip_zaposlenog'
)
BEGIN
    ALTER TABLE table_zaposleni
    DROP CONSTRAINT FK_table_zaposleni_table_tip_zaposlenog;
END;

IF EXISTS (
    SELECT 1
    FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS
    WHERE CONSTRAINT_NAME = 'FK_table_dostava_artikli_table_artikli'
)
BEGIN
    ALTER TABLE table_dostava_artikl
    DROP CONSTRAINT FK_table_dostava_artikli_table_artikli;
END;


IF EXISTS (
    SELECT 1
    FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS
    WHERE CONSTRAINT_NAME = 'FK_table_dostava_artikli_table_dostava'
)
BEGIN
    ALTER TABLE table_dostava_artikl
    DROP CONSTRAINT FK_table_dostava_artikli_table_dostava;
END;




DROP TABLE IF EXISTS table_tip_zaposlenog;
CREATE TABLE table_tip_zaposlenog (
  id BIGINT NOT NULL PRIMARY KEY,
  naziv VARCHAR(50) NOT NULL,
  dashboard BIT NOT NULL,
  zaposleni BIT NOT NULL,
  racuni BIT NOT NULL,
  artikli BIT NOT NULL
);


DROP TABLE IF EXISTS table_zaposleni;
CREATE TABLE table_zaposleni(
  jmbg VARCHAR(13) NOT NULL PRIMARY KEY,
  ime VARCHAR(20) NOT NULL,
  prezime VARCHAR(20) NOT NULL,
  broj_radnih_sati INT NOT NULL,
  satnica INT NOT NULL,
  premija INT,
  datum_zaposlenja date NOT NULL,
  broj_slobodnih_dana INT NOT NULL,
  username VARCHAR(50) NOT NULL,
  password VARCHAR(50) NOT NULL,
  tip_zaposlenog BIGINT NOT NULL
);

ALTER TABLE table_zaposleni
ADD CONSTRAINT FK_table_zaposleni_table_tip_zaposlenog
FOREIGN KEY (tip_zaposlenog) REFERENCES table_tip_zaposlenog(id);


DROP TABLE IF EXISTS table_artikli;
CREATE TABLE table_artikli (
	id_artikla BIGINT IDENTITY(1, 1) PRIMARY KEY,
	naziv VARCHAR(255) NOT NULL,
	kolicina INT NOT NULL,
	cena FLOAT NOT NULL
);


DROP TABLE IF EXISTS table_racun_header;
CREATE TABLE table_racun_header (
	id_racuna BIGINT NOT NULL PRIMARY KEY IDENTITY(1, 1),
	id_zaposleni varchar(13) NOT NULL,
	ukupna_cena DECIMAL(10,2) NOT NULL,
	datum DATE NOT NULL
);


ALTER TABLE table_racun_header 
ADD CONSTRAINT FK_table_racun_header_table_zaposleni 
FOREIGN KEY (id_zaposleni) REFERENCES table_zaposleni(jmbg);

DROP TABLE IF EXISTS table_racun_body;
CREATE TABLE table_racun_body (
	id BIGINT NOT NULL PRIMARY KEY IDENTITY(1, 1),
	id_artikla BIGINT NOT NULL,
	id_racun_header BIGINT NOT NULL,
	kolicina INT NOT NULL,
	prodajna_cena FLOAT NOT NULL
);

ALTER TABLE table_racun_body 
ADD CONSTRAINT FK_table_racun_body_table_artikli
FOREIGN KEY (id_artikla) REFERENCES table_artikli(id_artikla);

ALTER TABLE table_racun_body 
ADD CONSTRAINT FK_table_racun_body_table_racun_header
FOREIGN KEY (id_racun_header) REFERENCES table_racun_header(id_racuna);

DROP TABLE IF EXISTS table_dostava;
CREATE TABLE table_dostava (
	id_dostava BIGINT IDENTITY(1, 1) PRIMARY KEY,
	datum_dostave DATE NOT NULL,
);

DROP TABLE IF EXISTS table_dostava_artikl;
CREATE TABLE table_dostava_artikl (
  id BIGINT PRIMARY KEY IDENTITY(1, 1),
  id_dostava BIGINT NOT NULL,
  id_artikla BIGINT NOT NULL,
  dostavljena_kolicina INT NOT NULL
);

ALTER TABLE table_dostava_artikl
ADD CONSTRAINT FK_table_dostava_artikli_table_artikli
FOREIGN KEY (id_artikla) REFERENCES table_artikli(id_artikla);

ALTER TABLE table_dostava_artikl
ADD CONSTRAINT FK_table_dostava_artikli_table_dostava
FOREIGN KEY (id_dostava) REFERENCES table_dostava(id_dostava);















-- Insert 20 rows into table_dostava
INSERT INTO dbo.table_tip_zaposlenog (id, naziv, dashboard, zaposleni, racuni, artikli)
VALUES
  (1, 'admin', 1, 1, 1, 1),
  (2, 'menadzer', 1, 0, 1, 1),
  (3, 'kasir', 0, 0, 1, 0),
  (4, 'magacioner', 0, 0, 0, 1);

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
  ('0000000000000', 'admin',  'admin',    0,  0,  NULL, '2024-01-01', 0,  'admin',                  'admin',      1),

  ('1234567890123', 'John',   'Doe',      40, 10, NULL, '2024-01-01', 20, 'JohnDoeSales',           'kasir',      2),
  ('1234567890124', 'Jane',   'Smith',    35, 12, NULL, '2024-01-02', 22, 'JaneSmithMarketing',     'kasir',      2),
  ('1234567890125', 'Alice',  'Johnson',  38, 11, NULL, '2024-01-03', 18, 'AliceJohnsonIT',         'kasir',      2),
  ('1234567890126', 'Bob',    'Brown',    42, 9,  NULL, '2024-01-04', 19, 'BobBrownSales',          'kasir',      2),
  ('1234567890137', 'Mike',   'Baker',    39, 11, NULL, '2024-01-15', 18, 'MikeBakerIT',            'kasir',      2),
  ('1234567890138', 'Nancy',  'Carter',   37, 10, NULL, '2024-01-16', 19, 'NancyCarterSales',       'kasir',      2),
  ('1234567890139', 'Olivia', 'Evans',    40, 12, NULL, '2024-01-17', 21, 'OliviaEvansMarketing',   'kasir',      2),
  ('1234567890127', 'Charlie','Davis',    37, 11, NULL, '2024-01-05', 21, 'CharlieDavisMarketing',  'kasir',      2),
  ('1234567890128', 'David',  'Wilson',   39, 10, NULL, '2024-01-06', 17, 'DavidWilsonIT',          'kasir',      2),
  ('1234567890129', 'Eve',    'Miller',   36, 12, NULL, '2024-01-07', 20, 'EveMillerSales',         'kasir',      2),

  ('1234567890130', 'Frank',  'Moore',    41, 9,  NULL, '2024-01-08', 22, 'FrankMooreMarketing',    'dostavljac', 3),
  ('1234567890131', 'Grace',  'Lee',      38, 11, NULL, '2024-01-09', 18, 'GraceLeeIT',             'dostavljac', 3),
  ('1234567890132', 'Henry',  'Clark',    43, 10, NULL, '2024-01-10', 19, 'HenryClarkSales',        'dostavljac', 3),
  ('1234567890133', 'Ivy',    'Young',    37, 11, NULL, '2024-01-11', 21, 'IvyYoungMarketing',      'dostavljac', 3),
  ('1234567890134', 'Jack',   'Hill',     40, 9,  NULL, '2024-01-12', 17, 'JackHillIT',             'dostavljac', 3),
  ('1234567890135', 'Kevin',  'Green',    36, 12, NULL, '2024-01-13', 20, 'KevinGreenSales',        'dostavljac', 3),
  ('1234567890136', 'Linda',  'Adams',    42, 10, NULL, '2024-01-14', 22, 'LindaAdamsMarketing',    'dostavljac', 3),

  ('1234567890140', 'Peter',  'Ford',     38, 9,  NULL, '2024-01-18', 17, 'PeterFordIT',            'menadzer',   4),
  ('1234567890141', 'Quincy', 'Graham',   44, 11, NULL, '2024-01-19', 20, 'QuincyGrahamSales',      'menadzer',   4),
  ('1234567890142', 'Rachel', 'Harris',   37, 10, NULL, '2024-01-20', 22, 'RachelHarrisMarketing',  'menadzer',   4);

-- Insert 20 rows into table_artikli
INSERT INTO dbo.table_artikli (naziv, kolicina, cena)
VALUES
  ('Shoes', 50, 25.99),
  ('Shirts', 100, 15.99),
  ('Pants', 75, 35.99),
  ('Hats', 30, 10.99),
  ('Jackets', 25, 45.99),
  ('Socks', 200, 5.99),
  ('Gloves', 50, 8.99),
  ('Scarves', 40, 12.99),
  ('Belts', 60, 18.99),
  ('Ties', 70, 14.99),
  ('Dresses', 40, 55.99),
  ('Skirts', 35, 30.99),
  ('Jeans', 80, 40.99),
  ('Sweaters', 45, 35.99),
  ('Blouses', 55, 25.99),
  ('Shorts', 65, 20.99),
  ('Coats', 30, 65.99),
  ('Vests', 20, 32.99),
  ('Pajamas', 40, 22.99),
  ('Underwear', 100, 7.99);

-- Insert 20 rows into table_racun_header
INSERT INTO dbo.table_racun_header (id_zaposleni, ukupna_cena, datum)
VALUES
  ('1234567890123', 100, '2024-01-01'),
  ('1234567890124', 150, '2024-01-02'),
  ('1234567890125', 120, '2024-01-03'),
  ('1234567890126', 90, '2024-01-04'),
  ('1234567890127', 200, '2024-01-05'),
  ('1234567890128', 80, '2024-01-06'),
  ('1234567890129', 110, '2024-01-07'),
  ('1234567890130', 95, '2024-01-08'),
  ('1234567890131', 130, '2024-01-09'),
  ('1234567890132', 180, '2024-01-10'),
  ('1234567890133', 75, '2024-01-11'),
  ('1234567890134', 160, '2024-01-12'),
  ('1234567890135', 85, '2024-01-13'),
  ('1234567890136', 220, '2024-01-14'),
  ('1234567890137', 105, '2024-01-15'),
  ('1234567890138', 70, '2024-01-16'),
  ('1234567890139', 145, '2024-01-17'),
  ('1234567890140', 100, '2024-01-18'),
  ('1234567890141', 190, '2024-01-19'),
  ('1234567890142', 115, '2024-01-20');

-- Insert 20 rows into table_racun_body
INSERT INTO dbo.table_racun_body (id_artikla, id_racun_header, kolicina, prodajna_cena)
VALUES
  (1, 1, 2, 25.99),
  (2, 2, 3, 15.99),
  (3, 3, 1, 35.99),
  (4, 4, 4, 10.99),
  (5, 5, 5, 45.99),
  (6, 6, 6, 5.99),
  (7, 7, 7, 8.99),
  (8, 8, 8, 12.99),
  (9, 9, 9, 18.99),
  (10, 10, 10, 14.99),
  (11, 11, 11, 55.99),
  (12, 12, 12, 30.99),
  (13, 13, 13, 40.99),
  (14, 14, 14, 35.99),
  (15, 15, 15, 25.99),
  (16, 16, 16, 20.99),
  (17, 17, 17, 65.99),
  (18, 18, 18, 32.99),
  (19, 19, 19, 22.99),
  (20, 20, 20, 7.99);

-- Insert 20 rows into table_dostava
INSERT INTO dbo.table_dostava (datum_dostave)
VALUES
  ('2024-01-01'),
  ('2024-01-02'),
  ('2024-01-03'),
  ('2024-01-04'),
  ('2024-01-05'),
  ('2024-01-06'),
  ('2024-01-07'),
  ('2024-01-08'),
  ('2024-01-09'),
  ('2024-01-10'),
  ('2024-01-11'),
  ('2024-01-12'),
  ('2024-01-13'),
  ('2024-01-14'),
  ('2024-01-15'),
  ('2024-01-16'),
  ('2024-01-17'),
  ('2024-01-18'),
  ('2024-01-19'),
  ('2024-01-20');


INSERT INTO dbo.table_dostava_artikl (id_dostava, id_artikla, dostavljena_kolicina)
VALUES
  (2, 1, 5),    -- Delivery 2, Article 1, another 5 units delivered
  (2, 2, 3),    -- Delivery 2, Article 2, another 3 units delivered
  (2, 1, 10),   -- Delivery 2, Article 1, another 10 units delivered
  (2, 2, 7),    -- Delivery 2, Article 2, another 7 units delivered
  (2, 1, 8),    -- Delivery 2, Article 1, another 8 units delivered
  (2, 2, 4),    -- Delivery 2, Article 2, another 4 units delivered
  (2, 1, 12),   -- Delivery 2, Article 1, another 12 units delivered
  (2, 2, 6),    -- Delivery 2, Article 2, another 6 units delivered
  (2, 1, 3),    -- Delivery 2, Article 1, another 3 units delivered
  (2, 2, 9);    -- Delivery 2, Article 2, another 9 units delivered
