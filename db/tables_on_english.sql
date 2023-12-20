USE "RTA";

CREATE TABLE Insurance_company
(
    Insurance_company_id INT PRIMARY KEY IDENTITY (1, 1),
    Name                 VARCHAR(40) NOT NULL
);

CREATE TABLE Driver
(
    Driver_id      INT PRIMARY KEY IDENTITY (1, 1),
    Surname        VARCHAR(30)  NOT NULL CHECK (Surname LIKE '[А-Яа-я]%'),
    Name           VARCHAR(20)  NOT NULL CHECK (Name LIKE '[А-Яа-я]%'),
    Patronymic     VARCHAR(30) CHECK (Patronymic LIKE '[А-Яа-я]%'),
    Date_of_birth  DATE         NOT NULL,
    Address        VARCHAR(100),
    Phone_number   VARCHAR(10) CHECK (Phone_number LIKE '%[0-9]%'),
    Driver_licence VARCHAR(10) CHECK (Driver_licence LIKE '%[0-9]%'),
    Category       VARCHAR(5),
    Date_of_issue  DATE,
    Password       VARCHAR(128) NOT NULL,
    CONSTRAINT CHECK_Category CHECK (Category LIKE 'A'
        OR Category LIKE 'B'
        OR Category LIKE 'C'
        OR Category LIKE 'D'
        OR Category LIKE 'E'
        OR Category LIKE 'A[BCDE]'
        OR Category LIKE 'AB[CDE]'
        OR Category LIKE 'AC[DE]'
        OR Category LIKE 'AD[E]'
        OR Category LIKE 'ABC[DE]'
        OR Category LIKE 'ABD[E]'
        OR Category LIKE 'ABCD[E]'
        OR Category LIKE 'B[CDE]'
        OR Category LIKE 'BC[DE]'
        OR Category LIKE 'BD[E]'
        OR Category LIKE 'BCD[E]'
        OR Category LIKE 'C[DE]'
        OR Category LIKE 'CD[E]'
        OR Category LIKE 'D[E]'
        ),
    CONSTRAINT UQ_PhoneNumber_on_Driver UNIQUE (Phone_number),
    CONSTRAINT UQ_DriverLicence UNIQUE (Driver_licence)
);

CREATE TABLE Vehicle
(
    Vehicle_id                 INT PRIMARY KEY IDENTITY (1, 1),
    Owner_id                   INT         NOT NULL,
    VIN                        VARCHAR(17) NOT NULL,
    Number_plate               VARCHAR(9),
    Make                       VARCHAR(30) NOT NULL,
    Model                      VARCHAR(30) NOT NULL,
    Year_of_manufacture        DATE        NOT NULL,
    Color                      VARCHAR(25) NOT NULL,
    Registration               VARCHAR(10),
    Registration_date_of_issue DATE,
    CONSTRAINT FK_DriverId_on_Vehicle FOREIGN KEY (Owner_id) REFERENCES Driver (Driver_id),
    CONSTRAINT UQ_Vin UNIQUE (VIN),
    CONSTRAINT UQ_Registration UNIQUE (Registration),
    CONSTRAINT UQ_NumberPlate UNIQUE (Number_plate)
);

CREATE TABLE Insurance
(
    Insurance_id         INT PRIMARY KEY IDENTITY (1, 1),
    Vehicle_id           INT         NOT NULL,
    Insurance_company_id INT         NOT NULL,
    Type                 VARCHAR(5)  NOT NULL,
    casco                BIT         NOT NULL,
    Insurance            VARCHAR(13) NOT NULL,
    Date_of_issue        DATE        NOT NULL,
    CONSTRAINT FK_InsuranceCompanyId_on_Insurance FOREIGN KEY (Insurance_company_id) REFERENCES Insurance_company (Insurance_company_id),
    CONSTRAINT FK_VehicleId_on_Insurance FOREIGN KEY (Vehicle_id) REFERENCES Vehicle (Vehicle_id),
    CONSTRAINT UQ_Insurance UNIQUE (Insurance)
);

CREATE TABLE Driver_Insurance
(
    Driver_Insurance_id INT PRIMARY KEY IDENTITY (1, 1),
    Driver_id           INT NOT NULL,
    Insurance_id        INT NOT NULL,
    CONSTRAINT FK_DriverId_on_DriverInsurance FOREIGN KEY (Driver_id) REFERENCES Driver (Driver_id),
    CONSTRAINT FK_InsuranceId_on_DriverInsurance FOREIGN KEY (Insurance_id) REFERENCES Insurance (Insurance_id),
    CONSTRAINT UQ_DriverId_and_InsuranceId UNIQUE (Driver_id, Insurance_id)
);

CREATE TABLE GIBDD_officer
(
    GIBDD_officer_id INT PRIMARY KEY IDENTITY (1, 1),
    Surname          VARCHAR(30)  NOT NULL CHECK (Surname LIKE '[А-Яа-я]%'),
    Name             VARCHAR(20)  NOT NULL CHECK (Name LIKE '[А-Яа-я]%'),
    Patronymic       VARCHAR(30) CHECK (Patronymic LIKE '[А-Яа-я]%'),
    Badge_number     VARCHAR(9)   NOT NULL,
    Post             VARCHAR(50)  NOT NULL,
    Special_rank     VARCHAR(20)  NOT NULL,
    Division         VARCHAR(7)   NOT NULL,
    Password         VARCHAR(128) NOT NULL,
    CONSTRAINT UQ_BadgeNumber UNIQUE (Badge_number)
);

CREATE TABLE RTA
(
    RTA_id              INT PRIMARY KEY IDENTITY (1, 1),
    City                VARCHAR(20),
    Street              VARCHAR(25),
    Building            VARCHAR(5),
    Date_and_time       DATETIME2(0) NOT NULL,
    Number_of_wounded   TINYINT      NOT NULL,
    Number_of_dead      TINYINT      NOT NULL,
    by_an_GIBDD_officer BIT          NOT NULL,
    GIBDD_officer_id    INT,
    CONSTRAINT FK_GibddOfficerId_on_Rta FOREIGN KEY (GIBDD_officer_id) REFERENCES GIBDD_officer (GIBDD_officer_id)
);

CREATE TABLE Witness
(
    Witness_id    INT PRIMARY KEY IDENTITY (1, 1),
    RTA_id        INT         NOT NULL,
    Surname       VARCHAR(30) NOT NULL CHECK (Surname LIKE '[А-Яа-я]%'),
    Name          VARCHAR(20) NOT NULL CHECK (Name LIKE '[А-Яа-я]%'),
    Patronymic    VARCHAR(30) CHECK (Patronymic LIKE '[А-Яа-я]%'),
    Date_of_birth DATE        NOT NULL,
    Address       VARCHAR(100),
    Phone_number  VARCHAR(10) CHECK (Phone_number LIKE '%[0-9]%'),
    CONSTRAINT FK_RtaId_on_Witness FOREIGN KEY (RTA_id) REFERENCES RTA (RTA_id),
    CONSTRAINT UQ_PhoneNumber_on_Witness UNIQUE (Phone_number)
);

CREATE TABLE RTA_Driver
(
    RTA_Driver_id            INT PRIMARY KEY IDENTITY (1, 1),
    RTA_id                   INT NOT NULL,
    Driver_id                INT NOT NULL,
    Vehicle_id               INT NOT NULL,
    the_driver_is_drunk      BIT NOT NULL,
    is_the_owner_a_driver    BIT NOT NULL,
    is_the_vehicle_insured   BIT NOT NULL,
    Vehicle_damage           VARCHAR(120),
    damage_to_other_property BIT NOT NULL,
    Damaged_property_name    VARCHAR(100),
    Damaged_property_owner   VARCHAR(100),
    can_the_vehicle_move     BIT NOT NULL,
    Vehicle_parking_address  VARCHAR(100),
    CONSTRAINT FK_RtaId_on_RtaDriver FOREIGN KEY (RTA_id) REFERENCES RTA (RTA_id),
    CONSTRAINT FK_DriverId_on_RtaDriver FOREIGN KEY (Driver_id) REFERENCES Driver (Driver_id),
    CONSTRAINT FK_VehicleId_on_RtaDriver FOREIGN KEY (Vehicle_id) REFERENCES Vehicle (Vehicle_id),
    CONSTRAINT UQ_RtaId_and_DriverId_and_VehicleId UNIQUE (RTA_id, Driver_id, Vehicle_id)
);

CREATE TABLE Tag
(
    Tag_id INT PRIMARY KEY IDENTITY (1, 1),
    Name   VARCHAR(40) NOT NULL,
    CONSTRAINT UQ_Name UNIQUE (Name)
);

CREATE TABLE Tag_map
(
    Tag_map_id    INT PRIMARY KEY IDENTITY (1, 1),
    RTA_Driver_id INT NOT NULL,
    Tag_id        INT NOT NULL,
    CONSTRAINT FK_RtaDriverId_on_TagMap FOREIGN KEY (RTA_Driver_id) REFERENCES RTA_Driver (RTA_Driver_id),
    CONSTRAINT FK_TagId_on_TagMap FOREIGN KEY (Tag_id) REFERENCES Tag (Tag_id),
    CONSTRAINT UQ_RtaDriverId_and_TagId UNIQUE (RTA_Driver_id, Tag_id)
);
go


------------------------------------------ ЗАПОЛНЕНИЕ ТАБЛИЦ ------------------------------------------
insert into Driver (Surname, Name, Patronymic, Date_of_birth, Address, Phone_number, Driver_licence, Category,
                    Date_of_issue, Password)
values ('Анохина', 'Ирина', 'Прокопьевна', '1989-02-22', 'Сергиев Посад, Зеленый пер., д. 20, кв. 58',
        '9848309846', '2070674402', 'B', '2014-01-09', '123'),
       ('Килиса', 'Лана', 'Афанасьевна', '1973-05-02', 'Нефтеюганск, Зеленый пер., д. 6, кв. 38',
        '9863434046', '9076281026', 'B', '2015-03-28', '11'),
       ('Забродина', 'Лидия', 'Климентьевна', '1988-01-04', 'Иркутск, Космонавтов ул., д. 8, кв. 38',
        '9083901167', '5220402357', 'B', '2019-03-22', '22'),
       ('Густокашин', 'Ефрем', 'Феликсович', '1980-08-15', 'Железногорск, Мира ул., д. 20, кв. 55',
        '9485963472', '2131902072', 'B', '2022-03-16', '33'),
       ('Крамник', 'Филипп', 'Геннадьевич', '1967-03-28', 'Евпатория, Социалистическая ул., д. 3, кв. 180',
        '9447459184', '2410464660', 'B', '2023-08-25', '44'),
       ('Анохин', 'Алексей', 'Степанович', '1987-12-03', 'Норильск, Вокзальная ул., д. 20, кв. 184',
        '9158013143', '6120383812', 'B', '2023-10-18', '55'),
       ('Габулов', 'Серафим', 'Федотович', '1960-10-14', 'Саратов, 17 Сентября ул., д. 9, кв. 177',
        '9855446342', '4987620291', 'B', '2017-01-08', '66'),
       ('Зарица', 'Федор', 'Лукьевич', '1967-08-19', 'Стерлитамак, Октябрьский пер., д. 3, кв. 40',
        '9543528361', '4297476795', 'B', '2019-11-04', '77'),
       ('Блок', 'Валерий', 'Аркадьевич', '1992-07-04', 'Пенза, Березовая ул., д. 22, кв. 177', '9137644165',
        '3619715644', 'B', '2021-10-06', '88'),
       ('Иванов', 'Петр', 'Сергеевич', '1990-05-15', 'Стерлитамак, ул. Пушкина, д. 10, кв. 5',
        '9998887766', '1234567890', 'B', '2010-08-20', '99'),
       ('Павлова', 'Оксана', 'Анатольевна', '1989-06-14', 'Иркутск, пр. Октября, д. 3, кв. 18',
        '9998887555', '3333333333', 'B', '2014-02-14', '1010'),
       ('Дмитриев', 'Дмитрий', 'Дмитриевич', '1955-08-08', 'Уфа, ул. Чайковского, д. 10, кв. 55',
        '8901234567', '5058664913', 'B', '1980-03-01', '1111'),
       ('Иванова', 'Надежда', 'Ивановна', '1990-01-01', 'Уфа, ул. Пушкина д. 10, кв. 5', '9841778691',
        '5186966527', 'B', '2010-01-01', '1212'),
       ('Петров', 'Алексей', 'Иванович', '1985-10-25', 'Уфа, пр. Ленина, д. 5, кв. 8',
        '9998887755', '4630893826', 'B', '2007-12-15', '1313'),
       ('Кузнецов', 'Антон', 'Игоревич', '1993-11-05',
        'Уфа, ул. Советская, д. 15, кв. 55', '9998887444', '8274826679', 'B', '2015-10-01',
        '1414');
go

insert into Vehicle (Owner_id, VIN, Number_plate, Make, Model, Year_of_manufacture, Color, Registration,
                     Registration_date_of_issue)
values (1, 'LM6XJ179795273381', 'Х274ММ30', 'Infiniti', 'EX', '2011', 'Светло-серый', '9950216701', '2013-09-11'),
       (1, 'RH4EB752534317602', 'Е998СН12', 'BMW', 'X1', '2011', 'Ярко-синий', '99КУ810381', '2011-08-14'),
       (2, 'SP6AT256826309248', 'Р189АА37', 'Volvo', 'S80', '2009', 'Серебристо-зелёный', '47НВ632050', '2013-09-05'),
       (4, 'WX5BN487192591935', 'Е637УО28', 'Chery', 'Bonus', '2020', 'Синий', '64АТ833546', '2020-03-16'),
       (5, 'XB9EA268586359935', 'О249ХХ97', 'Citroen', 'C4 Picasso', '2012', 'Серебристый', '9830997040', '2018-09-02'),
       (6, 'EN4JX372866580571', 'Т711ТР59', 'Volvo', 'C70 Coupe', '2007', 'Зелёно-голубой', '3244482152', '2012-01-17'),
       (7, 'PN4PY363798950521', 'Н390ММ09', 'Hyundai', 'ix20', '2014', 'Бело-жёлтый', '50НВ966177', '2014-06-26'),
       (8, 'RL2SW207597100851', 'Т045УЕ44', 'Lada', 'Vesta', '2021', 'Тёмно-серый', '9597675058', '2021-06-04'),
       (9, 'RL4WX479658118472', 'К101СВ56', 'Lada', 'Granta', '2023', 'Красный', '1056232626', '2023-07-07');
go

insert into Insurance_company (Name)
values ('САО "ВСК"'),
       ('ООО СК "Сбербанк Страхование"'),
       ('АО "Тинькофф"'),
       ('АО "АльфаСтрахование"');
go

insert into Tag (Name)
values ('ТС находилось в неподвижном состоянии'),
       ('Поворачивал направо'),
       ('Поворачивал налево'),
       ('Совершал разворот'),
       ('Двигался задним ходом');
go

insert into Insurance (Vehicle_id, Insurance_company_id, Type, Insurance, Date_of_issue, casco)
values (1, 1, 'ОСАГО', 'XXX2327722810', '2023-07-08', 0),
       (2, 4, 'ОСАГО', 'CCC5691229946', '2023-05-18', 0),
       (3, 2, 'ОСАГО', 'TTT9623766948', '2023-06-18', 1),
       (4, 1, 'ОСАГО', 'PPP9749453459', '2023-04-11', 0),
       (5, 3, 'ОСАГО', 'HHH2131648056', '2023-04-04', 1),
       (6, 1, 'ОСАГО', 'MMM1295173783', '2023-09-22', 0),
       (7, 4, 'ОСАГО', 'KKK1559591916', '2023-06-02', 0),
       (8, 2, 'ОСАГО', 'EEE1976879457', '2023-04-12', 1),
       (9, 2, 'ОСАГО', 'BBB1601194846', '2023-08-24', 0);
go

insert into GIBDD_officer (Surname, Name, Patronymic, Badge_number, Post, Special_rank, Division, Password)
values ('Юшков', 'Денис', 'Тарасович', 'ДПС679820', 'Инспектор дорожно-патрульной службы', 'Рядовой полиции',
        '720-117', '123'),
       ('Баренцев', 'Аркадий', 'Артемович', 'ДПС800023', 'Старший инспектор дорожно-патрульной службы', 'Лейтенант',
        '340-601', '22'),
       ('Якубович', 'Марк', 'Семенович', 'ДПС301283', 'Инспектор дорожно-патрульной службы', 'Рядовой полиции',
        '740-919', '44'),
       ('Беленков', 'Адам', 'Севастьянович', 'ДПС320979', 'Инспектор дорожно-патрульной службы', 'Младший сержант',
        '430-339', '101');
go

insert into Driver_Insurance (Driver_id, Insurance_id)
values (1, 1),
       (1, 2),
       (2, 3),
       (3, 7),
       (4, 4),
       (5, 5),
       (6, 6),
       (7, 7),
       (8, 8),
       (9, 9),
       (10, 2),
       (11, 9),
       (12, 4),
       (13, 6);
go

insert into RTA (City, Street, Building, Date_and_time, Number_of_wounded, Number_of_dead, by_an_GIBDD_officer,
                 GIBDD_officer_id)
VALUES ('Москва', 'Ленинский проспект', '10', '2021-05-12 09:15:00', 0, 0, 0, NULL),
       ('Санкт-Петербург', 'Невский проспект', '25', '2021-05-12 09:15:00', 1, 0, 1, 2),
       ('Екатеринбург', 'Кирова улица', '5', '2021-05-15 18:00:00', 0, 1, 1, 3),
       ('Новосибирск', 'Карла Маркса улица', '12', '2021-05-18 11:45:00', 0, 0, 1, 4),
       ('Москва', 'Тверская улица', '8', '2021-05-20 16:20:00', 0, 0, 0, NULL),
       ('Санкт-Петербург', 'Малая Морская улица', '3', '2021-05-22 10:10:00', 0, 0, 1, 1),
       ('Екатеринбург', 'Малышева улица', '17', '2021-05-25 13:00:00', 2, 1, 1, 3),
       ('Новосибирск', 'Карла Маркса улица', '20', '2021-05-27 08:45:00', 0, 0, 1, 4);
go

INSERT INTO RTA_Driver(RTA_id, Driver_id, Vehicle_id, the_driver_is_drunk, is_the_vehicle_insured, Vehicle_damage,
                       damage_to_other_property, Damaged_property_name, Damaged_property_owner, can_the_vehicle_move,
                       Vehicle_parking_address, is_the_owner_a_driver)
VALUES (1, 1, 1, 0, 0, NULL, 0, NULL, NULL, 1, NULL, 1),
       (2, 2, 3, 0, 0, 'Бампер передний', 0, NULL, NULL, 0, 'Санкт-Петербург, ул. Подольских Курсантов, вл. 7а', 0),
       (3, 3, 7, 1, 1, 'Крыло переднее левое', 0, NULL, NULL, 1, NULL, 1),
       (4, 4, 4, 0, 0, 'Фара правая, крыло переднее правоеб колесо переднее правое', 1, 'Забор частного дома',
        'Терещенко Кирилл Игнатьевич', 0, 'Новосибирск, проезд Энтузиастов, вл. 3', 0),
       (5, 5, 5, 0, 1, NULL, 0, NULL, NULL, 1, NULL, 1),
       (6, 6, 6, 1, 0, NULL, 0, NULL, NULL, 1, NULL, 1),
       (6, 7, 7, 0, 0, 'Решётка радиатора, бампер передний, капот', 1, 'Cветофор', 'Росавтодор', 0,
        'Екатеринбург, Вагоноремонтная ул., вл. 4а', 0),
       (7, 8, 8, 1, 1, 'Порог левый, дверь передняя левая, стекло двери передней левое', 1, 'Дорожный знак',
        'Росавтодор', 1, NULL, 1),
       (8, 9, 9, 1, 0, NULL, 0, NULL, NULL, 0, 'Москва, Каскадная ул., вл 28', 0),
       (7, 10, 2, 1, 0, NULL, 0, NULL, NULL, 1, NULL, 1),
       (1, 11, 2, 0, 0, NULL, 0, NULL, NULL, 1, NULL, 1),
       (2, 12, 4, 0, 1, 'Бампер задний', 0, NULL, NULL, 0, 'Санкт-Петербург, Открытое шоссе, вл. 14Г, стр. 1', 0),
       (3, 13, 6, 1, 0, 'Крыло заднее левое', 1, 'Витрина', 'ООО «Фрукты и овощи»', 1, NULL, 1),
       (4, 5, 5, 0, 1, NULL, 0, NULL, NULL, 0, 'Новосибирск, проезд Дубовой рощи, вл. 7А', 0),
       (5, 8, 8, 0, 0, NULL, 0, NULL, NULL, 1, NULL, 1),
       (8, 4, 4, 0, 0, 'Бампер передний, крыло переднее правое', 0, null, null, 1, null, 1);
go

INSERT INTO Witness(RTA_id, Surname, Name, Patronymic, Date_of_birth, Address, Phone_number)
VALUES (1, 'Иванов', 'Иван', 'Иванович', '01-01-1980', 'Москва, ул. Пушкина, д. 1', '9991112233'),
       (2, 'Петров', 'Петр', 'Петрович', '02-02-1985', 'Санкт-Петербург, ул. Ленина, д. 2', '9992223344'),
       (3, 'Сидоров', 'Алексей', 'Владимирович', '03-03-1990', 'Екатеринбург, ул. Гагарина, д. 3', '9993334455'),
       (4, 'Козлов', 'Дмитрий', 'Сергеевич', '04-04-1987', 'Новосибирск, ул. Кирова, д. 4', '9994445566'),
       (5, 'Васильев', 'Артем', 'Андреевич', '05-05-1983', 'Казань, ул. Советская, д. 5', '9995556677'),
       (6, 'Морозов', 'Евгений', 'Игоревич', '06-06-1978', 'Нижний Новгород, ул. Мира, д. 6', '9996667788'),
       (7, 'Николаев', 'Александр', 'Александрович', '07-07-1982', 'Самара, ул. Ленина, д. 7', '9997778899'),
       (8, 'Кузнецов', 'Максим', 'Николаевич', '08-08-1989', 'Омск, ул. Строителей, д. 8', '9998889900'),
       (1, 'Сидорова', 'Ольга', 'Владимировна', '11-11-1986', 'Уфа, ул. Гагарина, д. 11', '9991117233'),
       (2, 'Козлова', 'Елена', 'Сергеевна', '12-12-1991', 'Волгоград, ул. Кирова, д. 12', '9992228344'),
       (3, 'Васильева', 'Ирина', 'Андреевна', '13-01-1984', 'Пермь, ул. Советская, д. 13', '9993394455'),
       (4, 'Морозова', 'Наталья', 'Игоревна', '14-04-1979', 'Красноярск, ул. Мира, д. 14', '9994405566'),
       (5, 'Николаева', 'Алена', 'Александровна', '15-05-1988', 'Владивосток, ул. Ленина, д. 15', '9994556677');
go

INSERT INTO Tag_map (RTA_Driver_id, Tag_id)
values (1, 1),
       (2, 2),
       (3, 3),
       (4, 4),
       (5, 5),
       (6, 1),
       (7, 2),
       (8, 3),
       (9, 2),
       (10, 5),
       (11, 5),
       (12, 1),
       (13, 4),
       (14, 1),
       (15, 3);
go


------------------------------------------ ТРИГГЕРЫ ------------------------------------------
-- 1. Триггер на проверку уникального значения адреса и времени, чтоб не повторялось.
CREATE OR ALTER TRIGGER PreventDuplicateRtaDetails
  ON RTA
  AFTER INSERT
AS
BEGIN
  SET NOCOUNT ON;
  IF (SELECT COUNT(R.RTA_id)
      FROM RTA R
      WHERE EXISTS (SELECT 1
                    FROM inserted I
                    WHERE R.City = I.City
                      AND R.Street = I.Street
                      AND R.Building = I.Building
                      AND R.Date_and_time = I.Date_and_time)) > 1
  BEGIN
    RAISERROR ('Нельзя создать дубликат ДТП.', 16, 1);
    ROLLBACK TRANSACTION;
  END;
END;
go

-- 2. Триггер обновления "проверка страховки" (если в страховке больше 5 человек).
CREATE OR ALTER TRIGGER checkInsurance
  ON Driver_Insurance
  INSTEAD OF INSERT
AS
BEGIN
  SET NOCOUNT ON;
  DECLARE @numOfins INT;
  SET @numOfins = (SELECT COUNT(Insurance_id)
                   FROM Driver_Insurance
                   WHERE Driver_Insurance_id = (SELECT Driver_Insurance_id
                                                FROM inserted));
  IF @numOfins > 5
    ROLLBACK TRANSACTION;
END;
go

-- 3. Триггер проверки даты страховки, если страховка просрочена, то выводит "просрочено".
CREATE OR ALTER TRIGGER CheckInsuranceDate
  ON Insurance
  AFTER INSERT, UPDATE
AS
BEGIN
  SET NOCOUNT ON;
  DECLARE @InsuranceStartDate DATE;
  DECLARE @InsuranceEndDate DATE;
  DECLARE @CurrentDate DATE;
  SELECT @InsuranceStartDate = Date_of_issue FROM inserted;
  SELECT @InsuranceEndDate = DATEADD(YEAR, 1, @InsuranceStartDate);
  SELECT @CurrentDate = GETDATE();

  IF @InsuranceEndDate < @CurrentDate
    PRINT 'Страховка просрочена.';
  ELSE
    PRINT 'Страховка действительна.';
END;
go


------------------------------------------ ПРОЦЕДУРЫ ------------------------------------------
-- 1. Процедура для вывода всех свидетелей в одном каком-либо нарушении. Входные аргументы: дата, время и место нарушения.
CREATE OR ALTER PROCEDURE GetRtaWitnesses
  @RTADateAndTime DATETIME2(0),
  @RTACity VARCHAR(20),
  @RTAStreet VARCHAR(25),
  @RTABuilding VARCHAR(5)
AS
BEGIN
  SET NOCOUNT ON;
  SELECT RTA.RTA_id, W.Surname, W.Name, W.Patronymic, W.Date_of_birth, W.Address, W.Phone_number
  FROM RTA
    JOIN Witness W ON RTA.RTA_id = W.RTA_id
  WHERE RTA.Date_and_time = @RTADateAndTime
    AND RTA.City = @RTACity
    AND RTA.Street = @RTAStreet
    AND RTA.Building = @RTABuilding;
END;
go

-- 2. Процедура для вывода ДТП, которое оформлял конкретный сотрудник ГИБДД.
CREATE OR ALTER PROCEDURE GetRtaByOfficer @BadgeNumber VARCHAR(9)
AS
BEGIN
  SET NOCOUNT ON;
  SELECT RTA.RTA_id, RTA.Date_and_time, RTA.City, RTA.Street, RTA.Building
  FROM RTA
    JOIN GIBDD_officer ON RTA.GIBDD_officer_id = GIBDD_officer.GIBDD_officer_id
  WHERE GIBDD_officer.Badge_number = @BadgeNumber;
END;
go

-- 3. Процедура, которая выводит водителей по алфавиту, при вызове процедуры задаётся серия и номер страховки.
CREATE OR ALTER PROCEDURE GetDriversByInsuranceNumber @InsuranceNumber VARCHAR(13)
AS
BEGIN
  SET NOCOUNT ON;
  SELECT D.Surname, D.Name, D.Patronymic, D.Driver_licence, D.Address, D.Phone_number
  FROM Driver D
    JOIN Driver_Insurance DI ON D.Driver_id = DI.Driver_id
    JOIN Insurance I ON DI.Insurance_id = I.Insurance_id
  WHERE I.Insurance = @InsuranceNumber
  ORDER BY D.Surname ASC;
END;
go

------------------------------------------ ФУНКЦИИ ------------------------------------------
-- 1. Функция, которая считает количество пострадавших и погибших по определённому обстоятельству ДТП.
CREATE OR ALTER FUNCTION CountWoundedAndDead()
  RETURNS @res Table
    (
      Name              VARCHAR(40),
      Number_of_wounded TINYINT,
      Number_of_dead    TINYINT
    )
AS
BEGIN
  INSERT @res
  SELECT T.Name, sum(R.Number_of_wounded), sum(R.Number_of_dead)
  FROM Tag T
    JOIN Tag_map Tm ON T.Tag_id = Tm.Tag_id
    JOIN RTA_Driver RD ON Tm.RTA_Driver_id = RD.RTA_Driver_id
    JOIN RTA R ON RD.RTA_id = R.RTA_id
  GROUP BY T.Name;
  RETURN;
END;
go
-- SELECT *
-- from CountWoundedAndDead();
-- go

-- 2. Функция сортировка ДТП по городу.
CREATE OR ALTER FUNCTION GetRtaByCity(
  @cityName VARCHAR(20)
)
  RETURNS TABLE
AS
  RETURN(SELECT *
         FROM RTA
         WHERE City = @cityName);
go

-- 3. Функция возврат таблицы: сколько водителей попали в ДТП по определённому обстоятельству.
CREATE OR ALTER FUNCTION GetRtaDetailsByType(
  @RtaType VARCHAR(40)
)
  RETURNS TABLE
AS
  RETURN(SELECT T.Name, COUNT(Tm.RTA_Driver_id) AS PeopleCount
         FROM Tag T
           JOIN Tag_map Tm ON T.Tag_id = Tm.Tag_id
         WHERE T.Name = @RtaType
         GROUP BY T.Name);
go
-- SELECT *
-- from dbo.GetRtaDetailsByType('Двигался задним ходом');
-- go


------------------------------------------ ПРЕДСТАВЛЕНИЯ ------------------------------------------
-- 1. Представление, которое выводит всех водителей, которые попали в ДТП, потому что находились в состоянии алкогольного опьянения.
CREATE OR ALTER VIEW DriversInDUIRta
AS
SELECT DISTINCT D.Surname, D.Name, D.Patronymic, D.Driver_licence, D.Category, D.Date_of_issue
FROM RTA_Driver RD
  JOIN Driver D ON RD.Driver_id = D.Driver_id
WHERE the_driver_is_drunk = 1;
go

-- 2. Представление, которое выводит количество ДТП для всех машин.
CREATE OR ALTER VIEW RtaCountByCar
AS
SELECT V.Number_plate, COUNT(RTA_id) AS RtaCount
FROM RTA_Driver RD
  JOIN Vehicle V ON RD.Vehicle_id = V.Vehicle_id
GROUP BY V.Number_plate;
go

---- 3. Представление, которое выводит госномера машин и ФИО их собственников.
CREATE OR ALTER VIEW OwnersView
AS
SELECT Vehicle.Number_plate, Driver.Surname, Driver.Name, Driver.Patronymic
FROM Driver
  JOIN Vehicle ON Driver.Driver_id = Vehicle.Owner_id;
go


------------------------------------------ ДЛЯ ОТЧЁТА ------------------------------------------
CREATE OR ALTER PROC gag @rtaid INT
AS
SET NOCOUNT ON;
SELECT RTA.RTA_id,
       CONCAT(CONVERT(VARCHAR(10), RTA.Date_and_time, 104), ' ',
              SUBSTRING(CONVERT(VARCHAR(19), RTA.Date_and_time), 12, 5)) AS Date_and_time,
       CONCAT(RTA.City, ', ', RTA.Street, ', ', RTA.Building) AS Address,
       RTA.Number_of_dead,
       RTA.Number_of_wounded,
       CASE by_an_GIBDD_officer
         WHEN 1 THEN 'Да'
         WHEN 0 THEN 'Нет' END AS by_an_GIBDD_officer,
       CASE by_an_GIBDD_officer
         WHEN 0 THEN '–'
         ELSE G.Badge_number END AS Badge_number
FROM RTA
  LEFT JOIN GIBDD_officer G ON G.GIBDD_officer_id = RTA.GIBDD_officer_id
WHERE RTA_id = @rtaid;
go

CREATE OR ALTER PROC Car2 @rtaid INT
AS
SET NOCOUNT ON;
SELECT CONCAT(V.Make, ' ', V.Model) AS MakeModel,
       V.VIN,
       V.Number_plate,
       V.Registration,
       CONCAT(O.Surname, ' ', O.Name, ' ', O.Patronymic) AS o_FIO,
       O.Address AS o_address,
       CONCAT(D.Surname, ' ', D.Name, ' ', D.Patronymic) AS d_FIO,
       CASE the_driver_is_drunk
         WHEN 1 THEN 'Да'
         WHEN 0 THEN 'Нет' END AS drunk,
       CONVERT(VARCHAR(10), D.Date_of_birth, 104) AS Date_of_birth,
       D.Address AS d_address,
       D.Phone_number,
       D.Driver_licence,
       D.Category,
       CONVERT(VARCHAR(10), D.Date_of_issue, 104) AS DL_Date_of_issue,
       Ic.Name,
       I.Insurance,
       CONVERT(VARCHAR(10), DATEADD(YEAR, 1, I.date_of_issue), 104) AS I_Expiration_Date,
       ISNULL(RD.Vehicle_damage, '–') AS Vehicle_damage,
       CASE I.casco
         WHEN 1 THEN 'Да'
         WHEN 0 THEN 'Нет' END AS is_the_vehicle_insured,
       CASE RD.damage_to_other_property
         WHEN 1 THEN 'Да'
         WHEN 0 THEN 'Нет' END AS damage_to_other_property,
       CASE RD.damage_to_other_property
         WHEN 1 THEN RD.Damaged_property_name
         ELSE '–' END AS Damaged_property_name,
       CASE RD.damage_to_other_property
         WHEN 1 THEN RD.Damaged_property_owner
         ELSE '–' END AS Damaged_property_owner,
       CASE RD.can_the_vehicle_move
         WHEN 1 THEN 'Да'
         WHEN 0 THEN 'Нет' END AS can_the_vehicle_move,
       CASE RD.can_the_vehicle_move
         WHEN 1 THEN '–'
         ELSE RD.Vehicle_parking_address END AS Vehicle_parking_address
FROM (SELECT TOP (1) RD.RTA_Driver_id
      FROM RTA_Driver RD
      WHERE RD.RTA_id = @rtaid
      ORDER BY 1 DESC) AS jj
        JOIN RTA_Driver RD ON RD.RTA_Driver_id = jj.RTA_Driver_id
        JOIN Vehicle V ON RD.Vehicle_id = V.Vehicle_id
        JOIN Driver O ON O.Driver_id = V.Owner_id
        JOIN Driver D ON RD.Driver_id = D.Driver_id
        JOIN Insurance I ON I.Vehicle_id = V.Vehicle_id
        JOIN Insurance_company Ic ON I.Insurance_company_id = Ic.Insurance_company_id;
go

CREATE OR ALTER PROC Car1 @rtaid INT
AS
SET NOCOUNT ON;
SELECT CONCAT(V.Make, ' ', V.Model) AS MakeModel,
       V.VIN,
       V.Number_plate,
       V.Registration,
       CONCAT(O.Surname, ' ', O.Name, ' ', O.Patronymic) AS o_FIO,
       O.Address AS o_address,
       CONCAT(D.Surname, ' ', D.Name, ' ', D.Patronymic) AS d_FIO,
       CASE the_driver_is_drunk
         WHEN 1 THEN 'Да'
         WHEN 0 THEN 'Нет' END AS drunk,
       CONVERT(VARCHAR(10), D.Date_of_birth, 104) AS Date_of_birth,
       D.Address AS d_address,
       D.Phone_number,
       D.Driver_licence,
       D.Category,
       CONVERT(VARCHAR(10), D.Date_of_issue, 104) AS DL_Date_of_issue,
       Ic.Name,
       I.Insurance,
       CONVERT(VARCHAR(10), DATEADD(YEAR, 1, I.date_of_issue), 104) AS I_Expiration_Date,
       ISNULL(RD.Vehicle_damage, '–') AS Vehicle_damage,
       CASE I.casco
         WHEN 1 THEN 'Да'
         WHEN 0 THEN 'Нет' END AS is_the_vehicle_insured,
       CASE RD.damage_to_other_property
         WHEN 1 THEN 'Да'
         WHEN 0 THEN 'Нет' END AS damage_to_other_property,
       CASE RD.damage_to_other_property
         WHEN 1 THEN RD.Damaged_property_name
         ELSE '–' END AS Damaged_property_name,
       CASE RD.damage_to_other_property
         WHEN 1 THEN RD.Damaged_property_owner
         ELSE '–' END AS Damaged_property_owner,
       CASE RD.can_the_vehicle_move
         WHEN 1 THEN 'Да'
         WHEN 0 THEN 'Нет' END AS can_the_vehicle_move,
       CASE RD.can_the_vehicle_move
         WHEN 1 THEN '–'
         ELSE RD.Vehicle_parking_address END AS Vehicle_parking_address
FROM (SELECT TOP (1) RD.RTA_Driver_id
      FROM RTA_Driver RD
      WHERE RD.RTA_id = @rtaid
      ORDER BY 1 ASC) AS jj
        JOIN RTA_Driver RD ON RD.RTA_Driver_id = jj.RTA_Driver_id
        JOIN Vehicle V ON RD.Vehicle_id = V.Vehicle_id
        JOIN Driver O ON O.Driver_id = V.Owner_id
        JOIN Driver D ON RD.Driver_id = D.Driver_id
        JOIN Insurance I ON I.Vehicle_id = V.Vehicle_id
        JOIN Insurance_company Ic ON I.Insurance_company_id = Ic.Insurance_company_id;
go

CREATE OR ALTER PROC Witness1 @rtaid INT
AS
    SET NOCOUNT ON;
SELECT TOP (1) concat(Surname, ' ', Name, ' ', Patronymic) AS FIO,
               convert(VARCHAR(10), Date_of_birth, 104)    AS Date_of_birth,
               Address,
               Phone_number
FROM Witness
WHERE RTA_id = @rtaid
ORDER BY FIO ASC;
go