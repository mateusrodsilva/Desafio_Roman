USE Roman
GO

INSERT INTO TipoUsuario(TituloTipoUsuario)
VALUES				   ('Professor');
GO

INSERT INTO Usuario(IdTipoUsuario,NomeUsuario,Email,Senha)
VALUES					(1,'saulo','saulo@email.com','saulo123'),
						(1,'caique','caique@email.com','caique123');
GO

INSERT INTO Tema(NomeTema)
VALUES			 ('Gestão')
				 ,('HQs');
GO

INSERT INTO Projeto(IdTema,IdUsuario,NomeProjeto,Descricao)
VALUES				(1,1,'Controle de estoque','')
				    ,(2,2,'Listagem de personagens','');
GO