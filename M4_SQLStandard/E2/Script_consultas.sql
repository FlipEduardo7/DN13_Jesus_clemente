SELECT u.iduser, u.username, r.rolename from usersinroles ur
INNER JOIN users u ON ur.iduser = u.iduser
INNER JOIN roles r ON ur.idrole = r.idrole;

SELECT i.quantity, p.productname from inventory i
INNER JOIN producttypes p ON i.idproducttype = p.idproducttype;

SELECT pt.productname, s.ventas
FROM producttypes pt
JOIN (
    SELECT idproducttype, COUNT(*) ventas
    FROM sales s
    GROUP BY idproducttype
) s ON pt.idproducttype = s.idproducttype
WHERE s.ventas = (
    SELECT MAX(ventas)
    FROM (
        SELECT COUNT(*) ventas
        FROM sales
        GROUP BY idproducttype
    ) total_ventas
);

SELECT m.memberName, ms.membershipname from members m
INNER JOIN membershiptypes ms ON m.idmembershiptype = ms.idmembershiptype
ORDER BY m.idmembershiptype DESC
LIMIT 1;