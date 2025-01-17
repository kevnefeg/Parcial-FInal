--Creando la base de datos
CREATE DATABASE VaccinationDB;
USE VaccinationDB;
SET LANGUAGE 'us_english';

--Creando las tablas
CREATE TABLE STAFF(
	id varchar(30) PRIMARY KEY,
	name_staff VARCHAR(100) NOT NULL,
	email VARCHAR(40) NOT NULL,
	password_staff VARCHAR(50) DEFAULT 'None' NOT NULL,
	user_staff VARCHAR(40) DEFAULT 'None' NOT NULL,
	address_staff VARCHAR(50) NOT NULL,
	id_type INT NOT NULL
);

CREATE TABLE CABIN(
	id INT PRIMARY KEY IDENTITY,
	address_cabin VARCHAR(50) NOT NULL,
	phone CHAR(9) NOT NULL,
	in_charge VARCHAR(50) NOT NULL,
	email VARCHAR(40) NOT NULL
);

CREATE TABLE LOGIN_INFO(
	id INT PRIMARY KEY IDENTITY,
	id_cabin INT NOT NULL,
	id_staff varchar(30) NOT NULL,
	login_date DATETIME NOT NULL,
);

CREATE TABLE STAFF_TYPE(
	id INT PRIMARY KEY,
	staff_type VARCHAR(50) NOT NULL
);

CREATE TABLE APPOINTMENT(
	id INT PRIMARY KEY IDENTITY,
	place VARCHAR(50) NOT NULL,
	first_dose_date DATETIME NOT NULL,
	second_dose_time DATETIME,
	id_staff varchar(30) NOT NULL,
	dui_citizen CHAR(10) NOT NULL,
);

CREATE TABLE CITIZEN(
	dui CHAR(10) PRIMARY KEY,
	citizen_name VARCHAR(50) NOT NULL,
	age INT NOT NULL,
	address_citizen VARCHAR(50) NOT NULL,
	phone CHAR(9)  NOT NULL,
	email VARCHAR(40) DEFAULT 'None',
	identifier VARCHAR(30) DEFAULT 'None',
	id_institution INT,
	id_queue INT,
	id_vaccination INT
);

CREATE TABLE INSTITUTION(
	id INT PRIMARY KEY IDENTITY,
	institution VARCHAR(40) NOT NULL,
	id_type INT NOT NULL
);

CREATE TABLE INSTITUTION_TYPE(
	id INT PRIMARY KEY IDENTITY,
	inst_type VARCHAR(40) NOT NULL
);

CREATE TABLE CHRONIC_DISEASE(
	id INT PRIMARY KEY IDENTITY,
	chronic_disease VARCHAR(50) NOT NULL,
	dui_citizen CHAR(10) NOT NULL,
	id_disease_type INT NOT NULL
);

CREATE TABLE DISEASE_TYPE(
	id INT PRIMARY KEY IDENTITY,
	disease_type VARCHAR(80) NOT NULL

);

CREATE TABLE VACCINATION(
	id INT PRIMARY KEY IDENTITY,
	vaccination_date DATETIME
);

CREATE TABLE VAC_QUEUE(
	id INT PRIMARY KEY IDENTITY,
	vac_queue DATETIME NOT NULL
);

CREATE TABLE SIDE_EFFECT(
	id INT PRIMARY KEY IDENTITY,
	se_time DATETIME NOT NULL,
	effect VARCHAR(50) NOT NULL
);

CREATE TABLE CITIZENXSIDE_EFFECT(
	id_side_effect INT NOT NULL,
	dui_citizen CHAR(10) NOT NULL,
	CONSTRAINT PK_CITXSE PRIMARY KEY (id_side_effect,dui_citizen)
);

--Creando las llaves foraneas
ALTER TABLE STAFF 
ADD CONSTRAINT FK_STAFF_TYPE
FOREIGN KEY (id_type) REFERENCES STAFF_TYPE (id)

ALTER TABLE LOGIN_INFO
ADD CONSTRAINT FK_LOGIN_INFO_CABIN
FOREIGN KEY (id_cabin) REFERENCES CABIN (id)

ALTER TABLE LOGIN_INFO
ADD CONSTRAINT FK_LOGIN_INFO_STAFF
FOREIGN KEY (id_staff) REFERENCES STAFF (id)

ALTER TABLE APPOINTMENT
ADD CONSTRAINT FK_APPOINTMENT_STAFF
FOREIGN KEY (id_staff) REFERENCES STAFF (id)

ALTER TABLE APPOINTMENT
ADD CONSTRAINT FK_APPOINTMENT_CITIZEN
FOREIGN KEY (dui_citizen) REFERENCES CITIZEN (dui)

ALTER TABLE CITIZEN
ADD CONSTRAINT FK_CITIZEN_INSTITUTION
FOREIGN KEY (id_institution) REFERENCES INSTITUTION (id)

ALTER TABLE CITIZEN
ADD CONSTRAINT FK_CITIZEN_QUEUE
FOREIGN KEY (id_queue) REFERENCES VAC_QUEUE (id)

ALTER TABLE CITIZEN
ADD CONSTRAINT FK_CITIZEN_VACCINATION
FOREIGN KEY (id_vaccination) REFERENCES VACCINATION (id)

ALTER TABLE CHRONIC_DISEASE 
ADD CONSTRAINT FK_CHRONIC_DISEASE_CITIZEN
FOREIGN KEY (dui_citizen) REFERENCES CITIZEN (dui)

ALTER TABLE CITIZENXSIDE_EFFECT
ADD CONSTRAINT FK_CIT_SIDE_CITIZEN
FOREIGN KEY (dui_citizen) REFERENCES CITIZEN (dui)

ALTER TABLE CITIZENXSIDE_EFFECT
ADD CONSTRAINT FK_CIT_SIDE_SIDE_EFFECT
FOREIGN KEY (id_side_effect) REFERENCES SIDE_EFFECT (id)

ALTER TABLE CHRONIC_DISEASE 
ADD CONSTRAINT FK_DISEASE_TYPE
FOREIGN KEY (id_disease_type) REFERENCES DISEASE_TYPE (id)

ALTER TABLE INSTITUTION 
ADD CONSTRAINT FK_INSTITUTION_TYPE
FOREIGN KEY (id_type) REFERENCES INSTITUTION_TYPE (id)

--Datos quemados para los tipos de empleados
INSERT INTO STAFF_TYPE VALUES (1,'Gestor')
INSERT INTO STAFF_TYPE VALUES (2,'Encargado de cabina')
INSERT INTO STAFF_TYPE VALUES (3,'Empleado')

--Datos quemados para los tipos de enfermedades
INSERT INTO DISEASE_TYPE VALUES ('Enfermedades Transmisibles')
INSERT INTO DISEASE_TYPE VALUES ('Enfermedades no transmisibles')
INSERT INTO DISEASE_TYPE VALUES ('Discapacidad')

--Datos quemados para las tipos de instituciones
INSERT INTO INSTITUTION_TYPE VALUES ('Sistema Integrado de Salud')
INSERT INTO INSTITUTION_TYPE VALUES ('Educación')
INSERT INTO INSTITUTION_TYPE VALUES ('Seguridad Nacional')
INSERT INTO INSTITUTION_TYPE VALUES ('Gobierno Central')
INSERT INTO INSTITUTION_TYPE VALUES ('Periodismo')


--Datos quemados de cabina
INSERT INTO CABIN VALUES ('Santa Tecla', '7698-1548', 'Oscar Mandela', 'cabina1@gmail.com')

