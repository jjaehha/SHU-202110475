update customer
set address=(select address from customer where name='�迬��')
where name='�ڼ���';