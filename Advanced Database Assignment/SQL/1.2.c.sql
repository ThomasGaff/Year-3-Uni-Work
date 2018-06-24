select c.customer_name Name, c.cust_city City

from customer c

where not exists 

(select null
from deposit d
where c.customer_name = d.customer)







