
use sampledemo;
/* calling fn---> passing arguement*/
select [dbo].[udf_empTableDisplay](10,
(select staff_sal from staff_Master where staff_code=10001)) newsal;

SELECT [dbo].[udf_empName](7)

SELECT ENO,ENAME from [dbo].[udf_emp]()
exec [dbo].[EmpNameDisplay] 

SELECT staffcod , stafname ,mgcode , staf_add from [dbo].[staffMaster]()