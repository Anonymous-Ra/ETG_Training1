SELECT ENAME , JOB
FROM EMP
WHERE JOB LIKE 'manager' OR JOB LIKE 'clerk';

SELECT ENAME , SAL
FROM EMP
WHERE SAL BETWEEN 500 AND 1000;

SELECT ENAME , SAL
FROM EMP
WHERE SAL NOT BETWEEN 1000 AND 2500; 

SELECT ENAME , SAL
FROM EMP
WHERE SAL IN (800,950,3000,5000);

SELECT ENAME 
FROM EMP
WHERE ENAME LIKE '_L%';

SELECT ENAME 
FROM EMP
WHERE ENAME LIKE '%D';

SELECT ENAME 
FROM EMP
WHERE ENAME LIKE 'T%R';

SELECT ENAME 
FROM EMP
WHERE ENAME LIKE '%a%';

SELECT ENAME ,EMPNO
FROM EMP
WHERE ENAME LIKE 'JAMES';

SELECT ENAME ,SAL
FROM EMP
WHERE ENAME LIKE 'KING';

SELECT ENAME, JOB 
FROM EMP
WHERE JOB LIKE 'PResident';

SELECT * 
FROM EMP
WHERE JOB LIKE 'manager';


SELECT ENAME , COMM
FROM EMP
WHERE COMM > 0;