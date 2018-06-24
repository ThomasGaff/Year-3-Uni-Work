select a.account_no, c.customer_name Name, c.cust_street Street, c.cust_city City, a.balance, d.store, s.store_region, a.store_location Account_Branch

from customer c, account a, acct_holding ah, store s, deposit d

where c.customer_name = d.customer AND 
a.account_no = ah.account_no AND 
d.store = s.store_location AND
d.account_no = a.account_no 
