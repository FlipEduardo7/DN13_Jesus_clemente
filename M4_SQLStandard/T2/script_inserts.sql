INSERT INTO country (idcountry, name) values (1, 'USA');
INSERT INTO country (idcountry, name) values (2, 'Argentina');
INSERT INTO country (idcountry, name) values (3, 'Colombia');
INSERT INTO country (idcountry, name) values (4, 'México');
INSERT INTO country (idcountry, name) values (5, 'Cuba');

INSERT INTO company (idcompany, companyname, location) values (1, 'company test', 'SU');
INSERT INTO company (idcompany, companyname, location) values (2, 'contoso', 'NO');
INSERT INTO company (idcompany, companyname, location) values (3, 'Tesla', 'AM');

INSERT INTO users (iduser, username, email, idcompany) values (1, 'admin', 'admin@test.com', 1);
INSERT INTO users (iduser, username, email, idcompany) values (1, 'admin', 'admin@contoso.com', 1);
INSERT INTO users (iduser, username, email, idcompany) values (1, 'admin', 'admin@tesla.com', 1);

INSERT INTO city (idcity, name, idcountry) values (1, 'CDMX', 4);
INSERT INTO city (idcity, name, idcountry) values (2, 'Guadalajara', 4);
INSERT INTO city (idcity, name, idcountry) values (3, 'Monterrey', 4);
INSERT INTO city (idcity, name, idcountry) values (4, 'Los Angeles', 1);
INSERT INTO city (idcity, name, idcountry) values (5, 'New York', 1);
INSERT INTO city (idcity, name, idcountry) values (6, 'Washintong DC', 1);
INSERT INTO city (idcity, name, idcountry) values (7, 'Buenos Aires', 2);
INSERT INTO city (idcity, name, idcountry) values (8, 'La Habana', 5);