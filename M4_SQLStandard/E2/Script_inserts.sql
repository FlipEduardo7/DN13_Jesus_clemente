INSERT INTO cities (idcity, cityname) values (1, 'CDMX');
INSERT INTO cities (idcity, cityname) values (2, 'Monterrey');
INSERT INTO cities (idcity, cityname) values (3, 'Guadalajara');
INSERT INTO cities (idcity, cityname) values (4, 'Mexicali');
INSERT INTO cities (idcity, cityname) values (5, 'Morelia');

INSERT INTO equipmenttype (idequipmenttype, equipmentname) values (1, 'Mancuernas');
INSERT INTO equipmenttype (idequipmenttype, equipmentname) values (2, 'Caminadora');
INSERT INTO equipmenttype (idequipmenttype, equipmentname) values (3, 'Barras');
INSERT INTO equipmenttype (idequipmenttype, equipmentname) values (4, 'Bancos');
INSERT INTO equipmenttype (idequipmenttype, equipmentname) values (5, 'Discos');

INSERT INTO producttypes (idproducttype, productname) values (1, 'Proteina');
INSERT INTO producttypes (idproducttype, productname) values (2, 'Agua');
INSERT INTO producttypes (idproducttype, productname) values (3, 'Electrolitos');
INSERT INTO producttypes (idproducttype, productname) values (4, 'Smart Watch');
INSERT INTO producttypes (idproducttype, productname) values (5, 'Desodorante');

INSERT INTO inventory (idinventory, idproducttype, quantity) values (1, 1, 50);
INSERT INTO inventory (idinventory, idproducttype, quantity) values (2, 2, 100);
INSERT INTO inventory (idinventory, idproducttype, quantity) values (3, 3, 30);
INSERT INTO inventory (idinventory, idproducttype, quantity) values (4, 4, 15);
INSERT INTO inventory (idinventory, idproducttype, quantity) values (5, 5, 65);

INSERT INTO membershiptypes (idmembershiptype, membershipname, membershipcost) values (1, 'Basica', 150);
INSERT INTO membershiptypes (idmembershiptype, membershipname, membershipcost) values (2, 'Estandar', 250);
INSERT INTO membershiptypes (idmembershiptype, membershipname, membershipcost) values (3, 'Premium', 500);
INSERT INTO membershiptypes (idmembershiptype, membershipname, membershipcost) values (4, 'Familiar', 750);
INSERT INTO membershiptypes (idmembershiptype, membershipname, membershipcost) values (5, 'VIP', 900);

INSERT INTO members (idmember, memberName, idcity, phonenumber, idmembershiptype) 
values (1, 'Jesus', 1, '495 837-2610', 1);
INSERT INTO members (idmember, memberName, idcity, phonenumber, idmembershiptype) 
values (2, 'Juan', 2, '312 548-9371', 2);
INSERT INTO members (idmember, memberName, idcity, phonenumber, idmembershiptype) 
values (3, 'Omar', 3, '782 910-3654', 3);
INSERT INTO members (idmember, memberName, idcity, phonenumber, idmembershiptype) 
values (4, 'Luis', 4, '429 765-1208', 4);
INSERT INTO members (idmember, memberName, idcity, phonenumber, idmembershiptype) 
values (5, 'David', 5, '613 284-5079', 4);

INSERT INTO roles (idrole, rolename) values (1, 'Admin');
INSERT INTO roles (idrole, rolename) values (2, 'Contador');
INSERT INTO roles (idrole, rolename) values (3, 'Recepcionista');
INSERT INTO roles (idrole, rolename) values (4, 'Entrenador');
INSERT INTO roles (idrole, rolename) values (5, 'Personal de Limpieza');

INSERT INTO sales (idsale, idproducttype, quantity, saledate) values (1, 1, 3, '24-06-2024');
INSERT INTO sales (idsale, idproducttype, quantity, saledate) values (2, 4, 1, '24-06-2024');
INSERT INTO sales (idsale, idproducttype, quantity, saledate) values (3, 2, 1, '25-06-2024');
INSERT INTO sales (idsale, idproducttype, quantity, saledate) values (4, 3, 2, '27-06-2024');
INSERT INTO sales (idsale, idproducttype, quantity, saledate) values (5, 5, 2, '27-06-2024');

INSERT INTO users (iduser, username, password, email) values (1, 'Eduardo', '123456', 'eduardo@email.com');
INSERT INTO users (iduser, username, password, email) values (2, 'Samuel', '123456', 'samuel@email.com');
INSERT INTO users (iduser, username, password, email) values (3, 'Guillermo', '123456', 'guillermo@email.com');
INSERT INTO users (iduser, username, password, email) values (4, 'Asier', '123456', 'asier@email.com');
INSERT INTO users (iduser, username, password, email) values (5, 'Gustavo', '123456', 'gustavo@email.com');

INSERT INTO usersinroles (iduser, idrole) values (1, 1);
INSERT INTO usersinroles (iduser, idrole) values (2, 2);
INSERT INTO usersinroles (iduser, idrole) values (3, 3);
INSERT INTO usersinroles (iduser, idrole) values (4, 4);
INSERT INTO usersinroles (iduser, idrole) values (5, 5);