USE `gymmanager`;
DROP procedure IF EXISTS `RegisterSale`;

USE `gymmanager`;
DROP procedure IF EXISTS `gymmanager`.`RegisterSale`;
;

DELIMITER $$
USE `gymmanager`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `RegisterSale`(IN productId INT, 
IN userId INT)
BEGIN
	DECLARE saleDate DATE;
    
	SET saleDate = NOW();
    
    INSERT INTO sales (idproducttype, saledate, iduser)
    VALUES (productId, saleDate, userId);
END$$

DELIMITER ;
;