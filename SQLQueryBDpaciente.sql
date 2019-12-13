CREATE PROCEDURE pa_Paciente
@nombre varchar(40),
@enfermedadPac varchar(50),
@valorPac int,
@medicoPac varchar(40),
@citaPac date
AS
BEGIN 
INSERT INTO Paciente (nomPac,enfPac,valCitPac,medPac,proCitPac)
			   VALUES(@nombre, @enfermedadPac, @valorPac,@medicoPac, @citaPac)
END
GO
EXECUTE pa_Paciente 'Betuel Castro','Neumonía',7500,'Vargas','2019-01-28';   

SELECT * FROM Paciente

CREATE PROCEDURE pa_Enfermedad
AS
BEGIN 
SELECT * FROM Paciente WHERE enfPac LIKE 'Gripa'
END
GO
EXECUTE pa_Enfermedad

CREATE PROCEDURE pa_Medico
AS
BEGIN 
SELECT * FROM Paciente WHERE medPac LIKE 'Vargas'
END
GO
EXECUTE pa_Medico

CREATE PROCEDURE pa_NombreL
AS
BEGIN 
SELECT * FROM Paciente WHERE nomPac LIKE 'L%'
END
GO
EXECUTE pa_NombreL


ALTER PROCEDURE pa_Cita
AS
BEGIN 
SELECT * FROM Paciente WHERE proCitPac LIKE '2019-06-%'
END
GO
EXECUTE pa_Cita


ALTER PROCEDURE pa_Valor
AS
BEGIN 
SELECT * FROM Paciente WHERE valCitPac > 5000 AND valCitPac < 8000
END
GO
EXECUTE pa_Valor



CREATE PROCEDURE pa_Medicfecha
AS
BEGIN 
SELECT * FROM Paciente WHERE medPac LIKE 'Vargas' AND proCitPac LIKE '2019-05-%'
END
GO
EXECUTE pa_Medicfecha

CREATE PROCEDURE pa_Nombre
AS
BEGIN 
SELECT * FROM Paciente WHERE nomPac LIKE '_____________'
END
GO
EXECUTE pa_Nombre

CREATE PROCEDURE pa_GripaV
AS
BEGIN 
UPDATE Paciente  
SET valCitPac=valCitPac+500 WHERE enfPac LIKE 'Gripa'
END
GO
EXECUTE pa_GripaV

CREATE PROCEDURE pa_CambiarP
AS
BEGIN
UPDATE Paciente 
SET nomPac='Estefanía Calderón', enfPac='Alergia', proCitPac='2018-06-26' WHERE CodPac=7;
END
GO
EXECUTE pa_CambiarP


CREATE PROCEDURE pa_EliminarP
AS
BEGIN
DELETE FROM Paciente WHERE enfPac='Neumonía';
END
GO
EXECUTE pa_EliminarP

CREATE PROCEDURE pa_ContactoP
AS
BEGIN 
SELECT * FROM Paciente;
END
GO 
EXECUTE pa_ContactoP


CREATE PROCEDURE pa_ConsultaCod
@codigoP int
AS 
BEGIN
SELECT * FROM Paciente WHERE codPac=@codigoP
END
GO
EXECUTE pa_ConsultaCod 9