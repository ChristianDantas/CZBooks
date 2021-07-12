USE  CZBooks;

INSERT INTO Categoria(NomeCategoria)
VALUES				 ('Ação')
					 ,('Terror')
					 ,('Sistema RPG')
					 ,('Aventura')
					 ,('Romance');


INSERT INTO TipoUsuario(TipoUsuario)
VALUES				 ('Adm')
					 ,('Usuario')
					 ,('Autor');


INSERT INTO Instituicao(NomeInstituicao,CNPJ, Endereco)
VALUES				 ('Institução Saulão e Caiquera','25307478001.55','Rua Quantos ossos numero 19');


INSERT INTO Usuario(IdTipoUsuario,NomeUsuario,Email,Senha)
VALUES				 (1,'Adm','adm@adm.com','adm')
					 ,(3,'Saulo','sauloS2@autor.com','saulo')
					 ,(3,'Caique','caiqueS2@autor.com','caique')
					 ,(3,'chris','chris@autor.com','chris')
					 ,(2,'alan','alanVR@espec.com','alan');



INSERT INTO Autor(IdUsuario,Idade)
VALUES				 (2,28)
					 ,(3,28)
					 ,(4,17);

INSERT INTO Livro(IdAutor,IdCategoria,IdInstituicao,Titulo,Sinopse,DataPublicacao,Preco)
VALUES				 (1,1,1,'Os Misterios dos codigos','Um livro que o ajuda a fazer codigos melhor','31/05/2020',20.50)
					 ,(2,4,1,'A aventura em IA','O livro que fala sobre as aventuras de um pequeno robo','05/03/2019',20.50)
					 ,(3,2,1,'Os Gritos Mudos','Um pesquisador decidiu se mudar para uma cidade completamente esquecida','20/06/2021',50.75)
					 ,(3,4,1,'Pintas Malditas','Como será que é acordar com um homem ruivo com cara de assasino e forçando você a ouvir a historia dele? descubra lendo','12/07/2021',80)
					 ,(3,5,1,'Amores sucumbidos','"a meu amor, por que você se foi tão cedo" será que se foi mesmo?','17/03/2021',20.50);
