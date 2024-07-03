USE `gymmanager`;
DROP procedure IF EXISTS `RecentMembers`;

USE `gymmanager`;
DROP procedure IF EXISTS `gymmanager`.`RecentMembers`;
;

DELIMITER $$
USE `gymmanager`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `RecentMembers`()
BEGIN
	DECLARE lastMonday DATE;

	SET lastMonday = DATE_SUB(CURDATE(), INTERVAL WEEKDAY(CURDATE()) DAY);

    SELECT m.idmember, m.registerDate, ms.membershipname FROM members m
    INNER JOIN membershiptypes ms ON m.idmembershiptype = ms.idmembershiptype
    WHERE registerDate >= lastMonday;
    
END$$

DELIMITER ;
;