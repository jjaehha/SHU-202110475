select *
from book
order by price, bookname;

-- sum �Լ�
select min(saleprice) as "�ּҰ�"
from order;

-- group by
select custid, count(*) as "��������", sum(saleprice)
from orders
group by custid;

-- group by 2
select custid, count(*) as "��������"
from orders
where saleprice >= 8000
group by custid having count(*)>=2;

select *
from orders, customer;

