--���� 3-1

SELECT name, SUM(saleprice)
FROM customer, orders
WHERE customer.custid = orders.custid
GROUP BY customer.name
ORDER BY customer.name;

--���� 3-2 ���� 3-25 
SELECT name, bookname
From customer, book, orders
WHERE customer.custid=orders.custid and orders.bookid=book.bookid;


