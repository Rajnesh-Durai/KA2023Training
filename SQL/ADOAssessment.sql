select * from Cust_Transaction;
select * from Regions;
select * from Customer_Nodes;
select COUNT(c.node_id) AS NO_OF_NODES, r.Region from Customer_Nodes c inner join Regions r ON r.Region_id=c.Region_id group by r.Region
select COUNT(c.Customer_id) AS No_Of_Customer, r.Region from Customer_Nodes c inner join Regions r ON r.Region_id=c.Region_id group by r.Region;
select COUNT(Customer_id) AS TOTAL_COUNT, AVG(Deposit)AS AVG_DEPOSIT from Cust_transaction;
select Customer_id, Deposit+Balance AS TOTAL_BALANCE from Cust_transaction  order by Date_Trans
select Deposit+Balance AS SUM from Cust_transaction
select COUNT(Customer_id) AS TOTAL_COUNT from Cust_transaction where Deposit>0