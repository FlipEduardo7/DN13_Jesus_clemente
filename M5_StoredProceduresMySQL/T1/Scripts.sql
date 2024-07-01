/*Script de procedimiento GetAllUsers*/
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetAllUsers`()
BEGIN

	select * from users;

END

/*Script de procedimiento CreateCompany*/
USE `sqltesting`;
DROP procedure IF EXISTS `CreateCompany`;

USE `sqltesting`;
DROP procedure IF EXISTS `sqltesting`.`CreateCompany`;
;

DELIMITER $$
USE `sqltesting`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `CreateCompany`(in _companyName varchar(100),
in _location char(2), in _adminEmail varchar(500), in _userEmail varchar(500),
out _idcompany int, out _idadmin int, out _iduser int)
BEGIN
	declare _companyId int;
    declare _adminId int;
    declare _userId int;
    
    select max(idcompany) + 1 into _companyId from company;
    
    select max(iduser) + 1, max(iduser) + 2 into _adminId, _userId from users;
    
    INSERT INTO company (idcompany, companyname, location)
    VALUES (_companyId, _companyName, _location);
    
	INSERT INTO users (iduser, username, email, idcompany)
    VALUES (_userId, 'user', _userEmail, _companyId);
    
	INSERT INTO users (iduser, username, email, idcompany)
    VALUES (_userId, 'admin', _userEmail, _companyId);
    
    set _idcompany = _companyId;
    set _idadmin = _adminId;
    set _iduser = _userId;
    
END$$

DELIMITER ;
;

