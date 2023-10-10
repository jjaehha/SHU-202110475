select *
from book
order by price, bookname;

-- sum 함수
select min(saleprice) as "최소값"
from order;

-- group by
select custid, count(*) as "도서수량", sum(saleprice)
from orders
group by custid;

-- group by 2
select custid, count(*) as "도서수량"
from orders
where saleprice >= 8000
group by custid having count(*)>=2;

select *
from orders, customer;

