// first method
SELECT * FROM Worker
SELECT * FROM Worker WHERE SALARY = 
         (
            SELECT MIN(SALARY) FROM Worker 
            WHERE  SALARY IN (
            SELECT DISTINCT TOP 3
            SALARY FROM Worker 
            ORDER BY SALARY DESC
))

// second method
SELECT *
FROM Worker W1
WHERE 3 = (
 SELECT COUNT( DISTINCT ( W2.Salary ) )
 FROM Worker W2
 WHERE W2.Salary >= W1.Salary
 );
