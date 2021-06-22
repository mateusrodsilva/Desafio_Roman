CREATE DATABASE Roman

USE Roman

CREATE TABLE Professores
(
	IdProfessor			INT PRIMARY KEY IDENTITY
	,NomeProfessor		VARCHAR(120)
);

CREATE TABLE Projetos
(
	IdProjeto			INT PRIMARY KEY IDENTITY
	,IdProfessor		INT FOREIGN KEY REFERENCES Professores(IdProfessor)
	,NomeProjeto		VARCHAR(120)
);

CREATE TABLE Temas
(
	IdTema				INT PRIMARY KEY IDENTITY
	,NomeTema			VARCHAR(120)
);