USE Roman

INSERT INTO Professores(NomeProfessor)
VALUES				   ('Caique')
					   ,('Saulo');

INSERT INTO Projetos(IdProfessor, NomeProjeto)
VALUES				('1', 'Controle de estoque')
				    ,('2', 'Listagem de personagens');

INSERT INTO Temas(IdProjeto, NomeTema)
VALUES			 ('1', 'Gestão')
				 ,('2', 'HQs');
