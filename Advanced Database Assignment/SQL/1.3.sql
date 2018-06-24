select a.account_no, c.customer_name Name, c.cust_street Street, c.cust_city City, a.store_location, s.store_region,a.balance,a.balance + sum(d.deposit)

from customer c, account a, acct_holding ah, store s, deposit d

where c.customer_name = ah.customer_name AND 
a.account_no = ah.account_no AND 
a.store_location = s.store_location AND
a.account_no = d.account_no

group by a.account_no, c.customer_name, c.cust_street, c.cust_city, a.store_location, s.store_region, a.balance


order by account_no asc
