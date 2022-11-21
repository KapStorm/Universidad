-- QUE EMPIECEN POR LA LETRA M, G o R
SELECT * 
	FROM products 
	WHERE product_name like '[mgr]%'

SELECT * 
	FROM products	
	WHERE product_name LIKE 'm%' 
		OR product_name LIKE 'g%' 
		OR product_name LIKE 'r%'

SELECT * 
	FROM products
	WHERE SUBSTRING(product_name, 1, 1) IN ('m', 'g', 'r')

-- CONSONANTES
SELECT * 
	FROM products 
	WHERE product_name NOT LIKE '%[aeiou]'

SELECT * 
	FROM products 
	WHERE product_name LIKE '%[^aeiou]'

-- 5 CARACTERES
SELECT * 
	FROM products 
	WHERE product_name LIKE '_____'

SELECT * 
	FROM products 
	WHERE LEN(product_name) = 5
-- LENGTH

-- TERCERA POSICION VOCAL
SELECT * 
	FROM products 
	WHERE product_name LIKE '__[aeiou]%'

-- PRIMERA PALABRA CON 5 CARACTERES
SELECT * 
	FROM products 
	WHERE product_name LIKE '_____%'

-- EMPLEADOS CON REGION NULA
SELECT * 
	FROM employees 
	WHERE region IS NULL

-- SIN RESULTADOS
SELECT * 
	FROM employees 
	WHERE region = NULL

-- NO TIENE ASIGNADO UN FAX
SELECT customer_id, company_name, fax 
	FROM customers
	WHERE fax IS NOT NULL

-- TIENEN ASIGNADO UN FAX
SELECT customer_id, company_name, fax 
	FROM customers
	WHERE fax IS NULL

-- NOMBRE DE EMPLEADOS ORDENADOS POR APELLIDO
SELECT employee_id, last_name, first_name 
	FROM employees
	ORDER BY last_name, employee_id

-- PRODUCTOS DE MAYOR A MENOR PRECIO
SELECT * FROM product_id, product_name, unit_price 
	FROM products
	ORDER BY unit_price DESC, product_id

SELECT product_id, product_name, unit_price 
	FROM products
	ORDER BY 3 DESC, 1

-- 5 PRODUCTOS MAS CAROS
SELECT TOP 5 product_id, product_name, unit_price 
	FROM products
	ORDER BY unit_price DESC, employee_id

-- 2 EMPLEADOS MAS JOVENES
SELECT TOP 2 employee_id, first_name, last_name birthdate 
	FROM employees
	ORDER BY birthdate DESC, employee_id

-- ULTIMAS 5 ORDENES DE 1996 DEL EMPLEADO 2
SELECT TOP 5 order_id, order_date, employee_id 
	FROM orders
	WHERE employee = 2 AND YEAR(order_date) = 1996
	ORDER BY order_date DESC, product_id
-- YEAR()
-- MONTH()
-- DAY()
-- 23/02/2002
-- 2 PRODUCTOS MAS BARATOS DEL PROVEEDOR 2
SELECT TOP 2 product_id, product_name, unit_price, supplier_id 
	FROM products
	WHERE supplier_id = 2
	ORDER BY unit_price ASC, product_id

-- COLUMNAS 10 + 4 = 14
-- RENGLONES 77 * 8 = 616
SELECT * FROM products CROSS JOIN categories
SELECT * FROM products, categories

USE Northwind
SELECT products.ProductName, categories.CategoryName
	FROM products
	INNER JOIN categories ON products.CategoryID = categories.CategoryID

SELECT P.product_name, C.category_name
	FROM products P
	INNER JOIN categories C
	ON P.category_id = C.category_id

SELECT P.product_name, C.category_name
	FROM products P, categories C
	WHERE P.category_id = C.category_id