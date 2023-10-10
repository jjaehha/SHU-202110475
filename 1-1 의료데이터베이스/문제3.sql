select name, sum(saleprice)
from customer, orders
where customer.custid = orders.custid
group by customer.name
order by customer.name;