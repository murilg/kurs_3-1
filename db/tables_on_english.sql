use [RTA]

create table Insurance_company
(
    Insurance_company_id int primary key identity (1, 1),
    Name                 varchar(40) not null,
)

create table Driver
(
    Driver_id      int primary key IDENTITY (1, 1),
    Surname        varchar(30)  not null check (Surname like '[�-��-�]%'),
    Name           varchar(20)  not null check (Name like '[�-��-�]%'),
    Patronymic     varchar(30) check (Patronymic like '[�-��-�]%'),
    Date_of_birth  date         not null,
    Address        varchar(100),
    Phone_number   varchar(10) check (Phone_number like '%[0-9]%'),
    Driver_licence varchar(10) check (Driver_licence like '%[0-9]%'), -- 4, 6
    Category       varchar(5),
    Date_of_issue  date,
    Password       varchar(128) not null,
    constraint CHECK_Category CHECK (Category like 'A'
        or Category like 'B'
        or Category like 'C'
        or Category like 'D'
        or Category like 'E'
        or Category like 'A[BCDE]'
        or Category like 'AB[CDE]'
        or Category like 'AC[DE]'
        or Category like 'AD[E]'
        or Category like 'ABC[DE]'
        or Category like 'ABD[E]'
        or Category like 'ABCD[E]'
        or Category like 'B[CDE]'
        or Category like 'BC[DE]'
        or Category like 'BD[E]'
        or Category like 'BCD[E]'
        or Category like 'C[DE]'
        or Category like 'CD[E]'
        or Category like 'D[E]'
        ),
    constraint UQ_PhoneNumber_on_Driver unique (Phone_number),
    constraint UQ_DriverLicence unique (Driver_licence),
)

create table Vehicle
(
    Vehicle_id                 int primary key IDENTITY (1, 1),
    Owner_id                   int         not null,
    VIN                        varchar(17) not null,
    Number_plate               varchar(9),
    Make                       varchar(30) not null,
    Model                      varchar(30) not null,
    Year_of_manufacture        date        not null,
    Color                      varchar(25) not null,
    Registration               varchar(10), -- 2 �����, 2 �����, 6 ����
    Registration_date_of_issue date,
    constraint FK_DriverId_on_Vehicle foreign key (Owner_id) references Driver (Driver_id),
    constraint UQ_Vin unique (VIN),
    constraint UQ_Registration unique (Registration),
    constraint UQ_NumberPlate unique (Number_plate),
)

create table Insurance
(
    Insurance_id         INT PRIMARY KEY IDENTITY (1, 1),
    Insurance_company_id int         not null,
    Type                 varchar(5)  not null,
    Insurance            varchar(13) not null, -- 3 ��� ����� (�����), 10 ��� ������ (�����) -- ��� �����_�_����� ����� �������� �� ���������?
    Date_of_issue        date        not null,
    Vehicle_id           int         not null,
    constraint FK_InsuranceCompanyId_on_Insurance foreign key (Insurance_company_id) references Insurance_company (Insurance_company_id),
    constraint FK_VehicleId_on_Insurance foreign key (Vehicle_id) references Vehicle (Vehicle_id),
    constraint CK_Type_in_Insurance check (Type IN ('�����', '�����')),
    constraint UQ_Insurance unique (Insurance),
)

create table Driver_Insurance
(
    Driver_Insurance_id int primary key IDENTITY (1, 1),
    Driver_id           int not null,
    Insurance_id        int not null,
    constraint FK_DriverId_on_DriverInsurance foreign key (Driver_id) references Driver (Driver_id),
    constraint FK_InsuranceId_on_DriverInsurance foreign key (Insurance_id) references Insurance (Insurance_id),
    constraint UQ_DriverId_and_InsuranceId unique (Driver_id, Insurance_id),
)

create table GIBDD_officer
(
    GIBDD_officer_id int primary key IDENTITY (1, 1),
    Surname          varchar(30)  not null check (Surname like '[�-��-�]%'),
    Name             varchar(20)  not null check (Name like '[�-��-�]%'),
    Patronymic       varchar(30) check (Patronymic like '[�-��-�]%'),
    Badge_number     varchar(9)   not null, -- 6 ����, 3 �����
    Post             varchar(50)  not null,
    Special_rank     varchar(20)  not null,
    Division         varchar(7)   not null,
    Password         varchar(128) not null,
    constraint UQ_BadgeNumber unique (Badge_number),
)

create table RTA
(
    RTA_id              int primary key IDENTITY (1, 1),
    City                varchar(20),
    Street              varchar(25),
    Building            varchar(5),
    Date_and_time       datetime2(0) not null,
    Number_of_wounded   tinyint      not null,
    Number_of_dead      tinyint      not null,
    by_an_GIBDD_officer bit          not null,
    GIBDD_officer_id    int,
    constraint FK_GibddOfficerId_on_Rta foreign key (GIBDD_officer_id) references GIBDD_officer (GIBDD_officer_id),
)

create table Witness
(
    Witness_id    int primary key IDENTITY (1, 1),
    RTA_id        int         not null,
    Surname       varchar(30) not null check (Surname like '[�-��-�]%'),
    Name          varchar(20) not null check (Name like '[�-��-�]%'),
    Patronymic    varchar(30) check (Patronymic like '[�-��-�]%'),
    Date_of_birth date        not null,
    Address       varchar(100),
    Phone_number  varchar(10) check (Phone_number like '%[0-9]%'),
    constraint FK_RtaId_on_Witness foreign key (RTA_id) references RTA (RTA_id),
    constraint UQ_PhoneNumber_on_Witness unique (Phone_number),
)

create table RTA_Driver
(
    RTA_Driver_id            int primary key IDENTITY (1, 1),
    RTA_id                   int not null,
    Driver_id                int not null,
    Vehicle_id               int not null,
    the_driver_is_drunk      bit not null, -- ��� �� ���� ��������?
    is_the_owner_a_driver    bit not null,
    is_the_vehicle_insured   bit not null, -- ������������ �� ��?
    Vehicle_damage           varchar(120), -- ����������� ��
    damage_to_other_property bit not null,
    Damaged_property_name    varchar(100),
    Damaged_property_owner   varchar(100),
    can_the_vehicle_move     bit not null,
    Vehicle_parking_address  varchar(100),
    constraint FK_RtaId_on_RtaDriver foreign key (RTA_id) references RTA (RTA_id),
    constraint FK_DriverId_on_RtaDriver foreign key (Driver_id) references Driver (Driver_id),
    constraint FK_VehicleId_on_RtaDriver foreign key (Vehicle_id) references Vehicle (Vehicle_id),
    constraint UQ_RtaId_and_DriverId_and_VehicleId unique (RTA_id, Driver_id, Vehicle_id),
)

create table Tag
(
    Tag_id int primary key identity (1, 1),
    Name   varchar(40) not null,
    constraint UQ_Name unique (Name),
)

create table Tag_map
(
    Tag_map_id    int primary key identity (1, 1),
    RTA_Driver_id int not null,
    Tag_id        int not null,
    constraint FK_RtaDriverId_on_TagMap foreign key (RTA_Driver_id) references RTA_Driver (RTA_Driver_id),
    constraint FK_TagId_on_TagMap foreign key (Tag_id) references Tag (Tag_id),
    constraint UQ_RtaDriverId_and_TagId unique (RTA_Driver_id, Tag_id),
)
go


------------------------------------------ ���������� ������ ------------------------------------------
insert into Driver (Surname, Name, Patronymic, Date_of_birth, Address, Phone_number, Driver_licence, Category,
                    Date_of_issue, Password)
values ('�������', '�����', '�����������', '1989-02-22', '������� �����, ������� ���., �. 20, ��. 58',
        '9848309846', '2070674402', 'B', '2014-01-09', '123'),
       ('������', '����', '�����������', '1973-05-02', '�����������, ������� ���., �. 6, ��. 38',
        '9863434046', '9076281026', 'B', '2015-03-28', '11'),
       ('���������', '�����', '������������', '1988-01-04', '�������, ����������� ��., �. 8, ��. 38',
        '9083901167', '5220402357', 'B', '2019-03-22', '22'),
       ('����������', '�����', '����������', '1980-08-15', '������������, ���� ��., �. 20, ��. 55',
        '9485963472', '2131902072', 'B', '2022-03-16', '33'),
       ('�������', '������', '�����������', '1967-03-28', '���������, ���������������� ��., �. 3, ��. 180',
        '9447459184', '2410464660', 'B', '2023-08-25', '44'),
       ('������', '�������', '����������', '1987-12-03', '��������, ���������� ��., �. 20, ��. 184',
        '9158013143', '6120383812', 'B', '2023-10-18', '55'),
       ('�������', '�������', '���������', '1960-10-14', '�������, 17 �������� ��., �. 9, ��. 177',
        '9855446342', '4987620291', 'B', '2017-01-08', '66'),
       ('������', '�����', '��������', '1967-08-19', '�����������, ����������� ���., �. 3, ��. 40',
        '9543528361', '4297476795', 'B', '2019-11-04', '77'),
       ('����', '�������', '����������', '1992-07-04', '�����, ��������� ��., �. 22, ��. 177', '9137644165',
        '3619715644', 'B', '2021-10-06', '88'),
       ('������', '����', '���������', '1990-05-15', '�����������, ��. �������, �.10, ��. 5, ������',
        '9998887766', '1234567890', 'B', '2010-08-20', '99'),
       ('�������', '������', '�����������', '1989-06-14', '�������, ��. �������, �.3, ��. 18, ������',
        '9998887555', '3333333333', 'B', '2014-02-14', '1010'),
       ('��������', '�������', '����������', '1955-08-08', '���, ��. ����������� 45�.10, ��.55, ������',
        '8901234567', '5058664913', 'B', '1980-03-01', '1111'),
       ('�������', '�������', '��������', '1990-01-01', '���, ��. ������� �.10, ��.5, ������', '9841778691',
        '5186966527', 'B', '2010-01-01', '1212'),
       ('������', '�������', '��������', '1985-10-25', '���, ��. ������, �.5, ��. 8, �����-���������',
        '9998887755', '4630893826', 'B', '2007-12-15', '1313'),
       ('��������', '�����', '��������', '1993-11-05',
        '���, ��. ���������, �.15, ��. 55, �����-���������', '9998887444', '8274826679', 'B', '2015-10-01',
        '1414');
go

insert into Vehicle (Owner_id, VIN, Number_plate, Make, Model, Year_of_manufacture, Color, Registration,
                     Registration_date_of_issue)
values (1, 'LM6XJ179795273381', '�274��30', 'Infiniti', 'EX', '2011', '������-�����', '9950216701', '2013-09-11'),
       (1, 'RH4EB752534317602', '�998��12', 'BMW', 'X1', '2011', '����-�����', '99��810381', '2011-08-14'),
       (2, 'SP6AT256826309248', '�189��37', 'Volvo', 'S80', '2009', '����������-������', '47��632050', '2013-09-05'),
       (4, 'WX5BN487192591935', '�637��28', 'Chery', 'Bonus', '2020', '�����', '64��833546', '2020-03-16'),
       (5, 'XB9EA268586359935', '�249��97', 'Citroen', 'C4 Picasso', '2012', '�����������', '9830997040', '2018-09-02'),
       (6, 'EN4JX372866580571', '�711��59', 'Volvo', 'C70 Coupe', '2007', '�����-�������', '3244482152', '2012-01-17'),
       (7, 'PN4PY363798950521', '�390��09', 'Hyundai', 'ix20', '2014', '����-�����', '50��966177', '2014-06-26'),
       (8, 'RL2SW207597100851', '�045��44', 'Lada', 'Vesta', '2021', 'Ҹ���-�����', '9597675058', '2021-06-04'),
       (9, 'RL4WX479658118472', '�101��56', 'Lada', 'Granta', '2023', '�������', '1056232626', '2023-07-07')
go

insert into Insurance_company (Name)
values ('��� "���"'),
       ('��� �� "�������� �����������"'),
       ('�� "��������"'),
       ('�� "����������������"')
go

insert into Tag (Name)
values ('�� ���������� � ����������� ���������'),
       ('����������� �������'),
       ('����������� ������'),
       ('�������� ��������'),
       ('�������� ������ �����')
go

insert into Insurance (Insurance_company_id, Type, Insurance, Date_of_issue, Vehicle_id)
values (1, '�����', 'XXX2327722810', '2023-07-08', 1),
       (4, '�����', 'CCC5691229946', '2023-05-18', 2),
       (2, '�����', 'TTT9623766948', '2023-06-18', 3),
       (1, '�����', 'PPP9749453459', '2023-04-11', 4),
       (3, '�����', 'HHH2131648056', '2023-04-04', 5),
       (1, '�����', 'MMM1295173783', '2023-09-22', 6),
       (4, '�����', 'KKK1559591916', '2023-06-02', 7),
       (2, '�����', 'EEE1976879457', '2023-04-12', 8),
       (2, '�����', 'BBB1601194846', '2023-08-24', 9)
go

insert into Insurance (Insurance_company_id, Type, Insurance, Date_of_issue, Vehicle_id)
values (2, '�����', 'AAM5525818582', '2023-06-18', 3),
       (3, '�����', 'AAK8965966908', '2023-04-04', 5),
       (2, '�����', 'AAB3607608593', '2023-04-12', 8)
go

insert into GIBDD_officer (Surname, Name, Patronymic, Badge_number, Post, Special_rank, Division, Password)
values ('�����', '�����', '���������', '���679820', '��������� �������-���������� ������', '������� �������',
        '720-117', '123'),
       ('��������', '�������', '���������', '���800023', '������� ��������� �������-���������� ������', '���������',
        '340-601', '22'),
       ('��������', '����', '���������', '���301283', '��������� �������-���������� ������', '������� �������',
        '740-919', '44'),
       ('��������', '����', '�������������', '���320979', '��������� �������-���������� ������', '������� �������',
        '430-339', '101')
go

insert into Driver_Insurance (Driver_id, Insurance_id)
values (1, 1),
       (1, 2),
       (2, 3),
       (2, 10),
       (3, 7),
       (4, 4),
       (5, 5),
       (5, 11),
       (6, 6),
       (7, 7),
       (8, 8),
       (8, 12),
       (9, 9),
       (10, 2),
       (11, 9),
       (12, 4),
       (13, 6)
go

insert into RTA (City, Street, Building, Date_and_time, Number_of_wounded, Number_of_dead, by_an_GIBDD_officer,
                 GIBDD_officer_id)
VALUES ('������', '��������� ��������', '10', '2021-05-12 09:15:00', 0, 0, 0, NULL),
       ('�����-���������', '������� ��������', '25', '2021-05-12 09:15:00', 1, 0, 1, 2),
       ('������������', '������ �����', '5', '2021-05-15 18:00:00', 0, 1, 1, 3),
       ('�����������', '����� ������ �����', '12', '2021-05-18 11:45:00', 0, 0, 1, 4),
       ('������', '�������� �����', '8', '2021-05-20 16:20:00', 0, 0, 0, NULL),
       ('�����-���������', '����� ������� �����', '3', '2021-05-22 10:10:00', 0, 0, 1, 1),
       ('������������', '�������� �����', '17', '2021-05-25 13:00:00', 2, 1, 1, 3),
       ('�����������', '����� ������ �����', '20', '2021-05-27 08:45:00', 0, 0, 1, 4)
go

INSERT INTO RTA_Driver(RTA_id, Driver_id, Vehicle_id, the_driver_is_drunk, is_the_vehicle_insured, Vehicle_damage,
                       damage_to_other_property, Damaged_property_name, Damaged_property_owner, can_the_vehicle_move,
                       Vehicle_parking_address, is_the_owner_a_driver)
VALUES (1, 1, 1, 0, 0, NULL, 0, NULL, NULL, 1, NULL, 1),
       (2, 2, 2, 0, 0, '������ ��������', 0, NULL, NULL, 0, '�����-���������, ��. ���������� ���������, ��. 7�', 0),
       (3, 3, 3, 1, 1, '����� �������� �����', 0, NULL, NULL, 1, NULL, 1),
       (4, 4, 4, 0, 0, '���� ������, ����� �������� ������� ������ �������� ������', 1, '����� �������� ����',
        '��������� ������ ����������', 0, '�����������, ������ �����������, ��. 3', 0),
       (5, 5, 5, 0, 1, NULL, 0, NULL, NULL, 1, NULL, 1),
       (6, 6, 6, 1, 0, NULL, 0, NULL, NULL, 1, NULL, 1),
       (6, 7, 7, 0, 0, '������� ���������, ������ ��������, �����', 1, 'C�������', '����������', 0,
        '������������, ��������������� ��., ��. 4�', 0),
       (7, 8, 8, 1, 1, '����� �����, ����� �������� �����, ������ ����� �������� �����', 1, '�������� ����',
        '����������', 1, NULL, 1),
       (8, 9, 9, 1, 0, NULL, 0, NULL, NULL, 0, '������, ��������� ��., �� 28', 0),
       (7, 10, 1, 1, 0, NULL, 0, NULL, NULL, 1, NULL, 1),
       (1, 11, 2, 0, 0, NULL, 0, NULL, NULL, 1, NULL, 1),
       (2, 12, 3, 0, 1, '������ ������', 0, NULL, NULL, 0, '�����-���������, �������� �����, ��. 14�, ���. 1', 0),
       (3, 13, 4, 1, 0, '����� ������ �����', 1, '�������', '��� ������� � �����', 1, NULL, 1),
       (4, 5, 5, 0, 1, NULL, 0, NULL, NULL, 0, '�����������, ������ ������� ����, ��. 7�', 0),
       (5, 8, 6, 0, 0, NULL, 0, NULL, NULL, 1, NULL, 1),
       (8, 4, 4, 0, 0, '������ ��������, ����� �������� ������', 0, null, null, 1, null, 1)
go

INSERT INTO Witness(RTA_id, Surname, Name, Patronymic, Date_of_birth, Address, Phone_number)
VALUES (1, '������', '����', '��������', '01-01-1980', '������, ��. �������, �. 1', '9991112233'),
       (2, '������', '����', '��������', '02-02-1985', '�����-���������, ��. ������, �. 2', '9992223344'),
       (3, '�������', '�������', '������������', '03-03-1990', '������������, ��. ��������, �. 3', '9993334455'),
       (4, '������', '�������', '���������', '04-04-1987', '�����������, ��. ������, �. 4', '9994445566'),
       (5, '��������', '�����', '���������', '05-05-1983', '������, ��. ���������, �. 5', '9995556677'),
       (6, '�������', '�������', '��������', '06-06-1978', '������ ��������, ��. ����, �. 6', '9996667788'),
       (7, '��������', '���������', '�������������', '07-07-1982', '������, ��. ������, �. 7', '9997778899'),
       (8, '��������', '������', '����������', '08-08-1989', '����, ��. ����������, �. 8', '9998889900'),
       (1, '��������', '�����', '������������', '11-11-1986', '���, ��. ��������, �. 11', '9991117233'),
       (2, '�������', '�����', '���������', '12-12-1991', '���������, ��. ������, �. 12', '9992228344'),
       (3, '���������', '�����', '���������', '13-01-1984', '�����, ��. ���������, �. 13', '9993394455'),
       (4, '��������', '�������', '��������', '14-04-1979', '����������, ��. ����, �. 14', '9994405566'),
       (5, '���������', '�����', '�������������', '15-05-1988', '�����������, ��. ������, �. 15', '9994556677')
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
       (15, 3)
go


------------------------------------------ �������� ------------------------------------------
-- 1. ������� �� �������� ����������� �������� ������ � �������, ���� �� �����������.
CREATE OR ALTER TRIGGER PreventDuplicateRtaDetails
    ON RTA
    AFTER INSERT
    AS
BEGIN
    IF (SELECT count(R.RTA_id)
        FROM RTA R
        WHERE EXISTS (SELECT 1
                      FROM inserted I
                      WHERE R.City = I.City
                        and R.Street = I.Street
                        and R.Building = I.Building
                        AND R.Date_and_time = I.Date_and_time)) > 1
        BEGIN
            RAISERROR ('������ ������� �������� ���.', 16, 1)
            ROLLBACK TRANSACTION
        END
END
go

-- 2. ������� ���������� "�������� ���������" (���� � ��������� ������ 5 �������).
create or alter trigger checkInsurance
    on Driver_Insurance
    instead of insert
    as
begin
    declare @numOfins int
    set @numOfins = (select count(Driver_Insurance.Insurance_id)
                     from Driver_Insurance
                     where Driver_Insurance_id = (select Driver_Insurance_id
                                                  from inserted))
    if @numOfins > 5
        rollback transaction
end
go

-- 3. ������� �������� ���� ���������, ���� ��������� ����������, �� ������� "����������".
CREATE OR ALTER TRIGGER CheckInsuranceDate
    ON Insurance
    AFTER INSERT, UPDATE
    AS
BEGIN
    DECLARE @InsuranceStartDate date
    DECLARE @InsuranceEndDate date
    DECLARE @CurrentDate date
    SELECT @InsuranceStartDate = Date_of_issue FROM inserted
    SELECT @InsuranceEndDate = DATEADD(YEAR, 1, @InsuranceStartDate)
    SELECT @CurrentDate = GETDATE()

    IF @InsuranceEndDate < @CurrentDate
        BEGIN
            PRINT '��������� ����������.'
        END
    ELSE
        BEGIN
            PRINT '��������� �������������.'
        END
END
go


------------------------------------------ ��������� ------------------------------------------
-- 1. ��������� ��� ������ ���� ���������� � ����� �����-���� ���������. ������� ���������: ����, ����� � ����� ���������.
CREATE OR ALTER PROCEDURE GetRtaWitnesses @RTADateAndTime datetime2(0),
                                          @RTACity varchar(20),
                                          @RTAStreet varchar(25),
                                          @RTABuilding varchar(5)
AS
BEGIN
    SELECT Witness.Surname, Witness.Name
    FROM RTA
             JOIN Witness ON RTA.RTA_id = Witness.RTA_id
    WHERE RTA.Date_and_time = @RTADateAndTime
      AND RTA.City = @RTACity
      AND RTA.Street = @RTAStreet
      AND RTA.Building = @RTABuilding
END
go

-- 2. ��������� ��� ������ ���, ������� �������� ���������� ��������� �����.
CREATE OR ALTER PROCEDURE GetRtaByOfficer @BadgeNumber int
AS
BEGIN
    SELECT RTA.RTA_id, RTA.Date_and_time, RTA.City, RTA.Street, RTA.Building
    FROM RTA
             join GIBDD_officer on RTA.GIBDD_officer_id = GIBDD_officer.GIBDD_officer_id
    WHERE GIBDD_officer.Badge_number = @BadgeNumber
END
go

-- 3. ���������, ������� ������� ��������� �� ��������, ��� ������ ��������� ������� ����� � ����� ���������.
CREATE OR ALTER PROCEDURE GetDriversByInsuranceNumber @InsuranceNumber VARCHAR(50)
AS
BEGIN
    SELECT Driver.Surname, Driver.Name, Driver.Patronymic, Insurance.Insurance
    FROM Driver
             left join Vehicle ON Driver.Driver_id = Vehicle.Owner_id
             join Insurance on Vehicle.Vehicle_id = Insurance.Vehicle_id
    WHERE Insurance.Insurance = @InsuranceNumber
    ORDER BY Driver.Name ASC
END
go

------------------------------------------ ������� ------------------------------------------
-- 1. �������, ������� ������� ���������� ������������ � ��������.
create or alter function CountWoundedAndDead()
    returns @res Table
                 (
                     Name              varchar(40),
                     Number_of_wounded tinyint,
                     Number_of_dead    tinyint
                 )
as
begin
    insert @res
    select T.Name, sum(R.Number_of_wounded), sum(R.Number_of_dead)
    from Tag T
    join Tag_map Tm on T.Tag_id = Tm.Tag_id
    join RTA_Driver RD on Tm.RTA_Driver_id = RD.RTA_Driver_id
    join RTA R on RD.RTA_id = R.RTA_id
    group by T.Name
    return
end
go

-- 2. ������� ���������� ��� �� ������.
CREATE OR ALTER FUNCTION GetRtaByCity(
    @cityName VARCHAR(100)
)
    RETURNS TABLE
        AS
        RETURN(SELECT *
               FROM RTA
               WHERE City = @cityName)
go

-- 3. ������� ������� �������: ��� ����, ������� ���� � ��� ������������ ����.
CREATE OR ALTER FUNCTION GetRtaDetailsByType(
    @RtaType VARCHAR(100)
)
    RETURNS TABLE
        AS
        RETURN(SELECT Name, COUNT(Tag_id) AS PeopleCount
               FROM Tag
               WHERE Name = @RtaType
               GROUP BY Name)
go
-- select *
-- from dbo.GetRtaDetailsByType('�������')


------------------------------------------ ������������� ------------------------------------------
-- 1. �������������, ������� ������� ���� ���������, ������� ������ � ���, ������ ��� ���������� � ��������� ������������ ���������.
CREATE OR ALTER VIEW DriversInDUIRta
AS
SELECT DISTINCT D.Surname, D.Name, D.Patronymic, D.Driver_licence, D.Category, D.Date_of_issue
FROM RTA_Driver RD
         JOIN Driver D on RD.Driver_id = D.Driver_id
WHERE the_driver_is_drunk = 1
go

-- 2. �������������, ������� ������� ���������� ��� ��� ���� �����.
CREATE OR ALTER VIEW RtaCountByCar
AS
SELECT V.Number_plate, COUNT(RTA_id) AS RtaCount
FROM RTA_Driver RD
         JOIN Vehicle V on RD.Vehicle_id = V.Vehicle_id
GROUP BY V.Number_plate
go

---- 3. �������������, ������� ������� ��������� ����� � ��� �� �������������.
CREATE OR ALTER VIEW OwnersView
AS
SELECT Vehicle.Number_plate, Driver.Surname, Driver.Name, Driver.Patronymic
FROM Driver
         JOIN Vehicle ON Driver.Driver_id = Vehicle.Owner_id
go


------------------------------------------ ��� ��ר�� ------------------------------------------
create or alter proc gag(
    @rtaid int
)
as
select RTA.RTA_id,
       concat(convert(varchar(10), RTA.Date_and_time, 104), ' ', substring(convert(varchar(19), RTA.Date_and_time), 12, 5)) as Date_and_time,
       concat(RTA.City, ', ', RTA.Street, ', ', RTA.Building) as Address,
       RTA.Number_of_dead,
       RTA.Number_of_wounded,
       'by_an_GIBDD_officer' = (CASE by_an_GIBDD_officer WHEN 1 THEN '��' WHEN 0 THEN '���' END),
       'Badge_number'        = (CASE by_an_GIBDD_officer WHEN 0 THEN '-' else G.Badge_number END)
from rta
         left join GIBDD_officer G on G.GIBDD_officer_id = rta.GIBDD_officer_id
where rta_id = @rtaid
go
--gag 4


create or alter proc Car2 @rtaid int
as
select V.Make,
       V.Model,
       V.Year_of_manufacture,
       V.Color,
       V.VIN,
       V.Registration,
       V.Registration_date_of_issue,
       V.Number_plate,
       D.Surname,
       D.Name,
       D.Patronymic,
       D.Address,
       D.Phone_number,
       D.Date_of_birth,
       D.Driver_licence,
       D.Category,
       Ic.Name,
       I.Insurance,
       I.date_of_issue
from (select top 1 RD.RTA_Driver_id
      from RTA_Driver RD
      where RD.RTA_id = @rtaid
      order by 1 desc) as jj
         join RTA_Driver RD on RD.RTA_Driver_id = jj.RTA_Driver_id
         join Vehicle V on RD.Vehicle_id = V.Vehicle_id
         join Driver D on RD.Driver_id = D.Driver_id
         join Insurance I on I.Insurance_id = D.Driver_id
         join Insurance_company Ic on I.Insurance_company_id = Ic.Insurance_company_id
go
--Car2 1


create or alter proc Car1 @rtaid int
as
select V.Make,
       V.Model,
       V.Year_of_manufacture,
       V.Color,
       V.VIN,
       V.Registration,
       V.Registration_date_of_issue,
       V.Number_plate,
       D.Surname,
       D.Name,
       D.Patronymic,
       D.Address,
       D.Phone_number,
       D.Date_of_birth,
       D.Driver_licence,
       D.Category,
       Ic.Name,
       I.Insurance,
       I.date_of_issue
from (select top 1 RD.RTA_Driver_id
      from RTA_Driver RD
      where RD.RTA_id = @rtaid
      order by 1 asc) as jj
         join RTA_Driver RD on RD.RTA_Driver_id = jj.RTA_Driver_id
         join Vehicle V on RD.Vehicle_id = V.Vehicle_id
         join Driver D on RD.Driver_id = D.Driver_id
         join Insurance I on I.Insurance_id = D.Driver_id
         join Insurance_company Ic on I.Insurance_company_id = Ic.Insurance_company_id
go
--Car1 1
