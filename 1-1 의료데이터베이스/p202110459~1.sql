SELECT name, Saleprice
FROM Customer, Orders
WHERE Customer.custid=Orders.custid;

//징릐 3-23 고객의 이름과 고객이 주문한 도서의 판매가격을 검색하시오