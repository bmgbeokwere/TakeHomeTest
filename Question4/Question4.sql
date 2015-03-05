USE SampleDB;
/*
Assume a database with the following structure

Customers

ID | NAME | ADDRESS | PHONE | NUMBER | EMAIL 

Orders

ID | CUSTOMER_ID | ORDER_AMOUNT | ORDER_ADDRESS
1. Write a SQL Query to pull all customers
*/

SELECT C.* FROM Customers C;

/*
2. Write a SQL Query to pull all customers that have orders (no duplicates)
*/

SELECT C.* 
FROM Customers C
JOIN Orders O ON C.ID = O.CUSTOMER_ID
GROUP BY C.ID, C.NAME, C.ADDRESS, C.PHONE, C.NUMBER, C.EMAIL;

/*
3. Write a SQL Query to pull all customers that do not have orders
*/

SELECT C.* 
FROM Customers C
LEFT JOIN Orders O ON C.ID = O.CUSTOMER_ID
WHERE O.ID IS NULL;

/*
4. If you had to create an index on these tables, which fields would you most likely index and why?
*/

Assuming that both tables have the ID columns labled as primary keys (primary keys are indexed by default), I would create an index containing Customers.ID, Customers.NAME, Customers.ADDRESS, Customers.PHONE, Customers.NUMBER, and Customers.EMAIL because of the GROUP BY being done in question # 2 and Orders.CUSTOMER_ID based on the JOIN in question # 3.


/*
5. Write a query that lists each customer name, email, and the number of order they have
*/

SELECT 
	C.NAME, 
	C.EMAIL, 
	COUNT(O.ID) AS ORDER_COUNT
FROM Customers C
JOIN Orders O ON C.ID = O.CUSTOMER_ID
GROUP BY C.NAME, C.EMAIL;

/*
6. Write a query that pulls all customers that have between 2 and 5 orders
*/
SELECT 
	C.*,
	COUNT(O.ID) AS ORDER_COUNT
FROM Customers C
JOIN Orders O ON C.ID = O.CUSTOMER_ID
GROUP BY C.ID, C.NAME, C.ADDRESS, C.PHONE, C.NUMBER, C.EMAIL
HAVING COUNT(O.ID) BETWEEN 2 AND 5;