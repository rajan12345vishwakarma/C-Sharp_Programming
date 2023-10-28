		SELECT * FROM Worker
SELECT * FROM Worker WHERE SALARY = 
         (
            SELECT MIN(SALARY) FROM Worker 
            WHERE  SALARY IN (
            SELECT DISTINCT TOP 3
            SALARY FROM Worker 
            ORDER BY SALARY DESC
))
