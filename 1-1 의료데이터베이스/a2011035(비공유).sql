update customer
set address=(select address from customer where name='김연아')
where name='박세리';