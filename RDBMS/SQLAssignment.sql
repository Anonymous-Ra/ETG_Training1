  /* Show the structure of the DEPT table. Select all the data from the Dept table*/
SELECT *
FROM DEPT;

  /* Show the structure of the EMP table. Create a query to display the name, job, hiredate and employee number.*/
SELECT ENAME, JOB, HIREDATE, EMPNO
FROM EMP;

  /*Display the employee name, job, monthly and annual salary with appropriate column titles.*/
SELECT ENAME , JOB , SAL AS 'Monthly Salary', SAL*12 AS 'Annual Salary'
FROM EMP;

  /*Display the name concatenated with the job, separated by a comma and space, and the name the column Employee and Title.*/
SELECT ENAME + ', ' + JOB AS 'Employee and  Title'
FROM EMP;

  /* Display unique jobs from the emp table.*/
SELECT DISTINCT JOB
FROM EMP;

  /*Display the name and salary of employees earning more than 2850.*/
SELECT ENAME, SAL
FROM EMP
WHERE SAL > 2850;

  /*Create a query to display the employee name and department number for employee SMITH.*/
SELECT ENAME , DEPTNO 
FROM EMP
WHERE ENAME LIKE 'smith';

  /* Display the employee name, job and start date of employees hired between February 20, 1981 and May 1, 1981. Order the query in ascending order of start date.*/
SELECT e.ENAME,e.JOB,j.STARTDATE
FROM EMP e  
FULL OUTER JOIN
jobhist j
ON(e.EMPNO = j.empno)
WHERE HIREDATE BETWEEN '1981-02-20' AND '1981-05-01'
ORDER BY STARTDATE;
 

  /*Display the employee name and department number of all employees in departments 10 and 30 in alphabetical order by name.*/
SELECT ENAME, DEPTNO 
FROM EMP
WHERE DEPTNO IN(10,30)
ORDER BY ENAME;

  /*Display the name and hiredate of every employee who was hired in 1982.*/
SELECT ENAME , HIREDATE
FROM EMP 
WHERE HIREDATE LIKE '1981%';

 /*Display the name and title of all employees who do not have a manager.*/
SELECT ENAME, JOB
FROM EMP 
WHERE MGR IS null;

  /*Write a query to display the current date. Label the column Date.*/
SELECT CAST(GETDATE() AS DATE);
 
  /*Display the employees who were hired before their managers.*/
SELECT MANAGER.ENAME ,MANAGER.HIREDATE, WORKER.ENAME,WORKER.HIREDATE
FROM EMP WORKER , EMP MANAGER
WHERE WORKER.EMPNO = MANAGER.MGR
AND MANAGER.HIREDATE > WORKER.HIREDATE;

  /*Determine the number of managers without listing them.*/
SELECT DISTINCT COUNT(MGR) AS 'NUMBER OF MANAGERS'
FROM EMP;

  /*List employee details working in departments 20,30 & 40.*/
SELECT *
FROM EMP
WHERE DEPTNO IN(20,30,40);

  /* List of employees whose names start with T and end with R.*/
SELECT ENAME
FROM EMP 
WHERE ENAME LIKE 'T%R';

  /*List the name and hiredate of the employee in department 30.*/
SELECT ENAME , HIREDATE
FROM EMP 
WHERE DEPTNO LIKE '30';

  /*Display the hiredate in emp table formatted as ‘mm/dd/yy’.*/
SELECT FORMAT(HIREDATE,'dd-MM-yy') AS 'FORMATED DATE'
FROM EMP;

  /*Retrieve the analysts’ record with the hiredate formatted as ‘the 3rd of Decemeber, 1984’.*/
SELECT FORMAT(HIREDATE,' dd  MMMM, yyyy')  
FROM EMP 
WHERE JOB LIKE 'ANALYST';

  /*List the names of all employees whose hiredate anniversary is in the month of December*/
SELECT ENAME,HIREDATE
FROM EMP
WHERE HIREDATE LIKE '_____12___';

  /*Give SQL command to find the average annual salary per job in each department.*/
SELECT AVG(SAL) AS 'AVERAGE SALARY' , DEPTNO
FROM EMP
GROUP BY DEPTNO;

  /*In one query, count the number of people in department in 30 who receive a salary and the number of people who receive a commission.*/
SELECT COUNT(ENAME) AS 'DEPT 30 with SAL'
FROM EMP
WHERE DEPTNO = '30' AND SAL > 0 AND COMM>0;

  /*Compute the average, minimum and maximum salaries of those groups of employees having the job as clerk or manager.*/
SELECT  AVG(SAL) AS 'AVG' ,MAX(SAL) AS 'MAX' , MIN(SAL) AS 'MIN'
FROM EMP
WHERE JOB='CLERK' OR JOB='MANAGER';

  /* Display the department numbers of departments which have more than one clerk.*/
SELECT DEPTNO 
FROM EMP 
WHERE 1 < (SELECT COUNT(ENAME)
			FROM EMP
			WHERE JOB LIKE 'clerk');

  /*Which employees earn less than 30 persent of the presidents salary.*/
SELECT ENAME , SAL
FROM EMP
WHERE SAL < (SELECT SAL*0.3
		FROM EMP
		WHERE JOB = 'PRESIDENT');

  /*How many employees work in Chicago?*/
SELECT COUNT(ENAME) AS 'EMP in CHICAGO'
FROM EMP e, DEPT d
WHERE e.DEPTNO = d.DEPTNO AND d.LOC = 'CHICAGO';

  /*Which employees work in Chicago?*/
SELECT e.ENAME, d.LOC
FROM EMP e, DEPT d
WHERE e.DEPTNO = d.DEPTNO AND d.LOC = 'CHICAGO';

  /*List the employees’ names and cities in which they work. Order the list by city.*/
SELECT E.ENAME , D.LOC
FROM EMP E , DEPT D
WHERE (E.DEPTNO=D.DEPTNO)
ORDER BY D.LOC

  /*Find the number or different employees and number of departments.*/
SELECT  COUNT(DISTINCT(E.EMPNO)) AS 'NO OF EMP'  ,COUNT(DISTINCT(D.DNAME)) AS 'NO OF DEPT'
FROM EMP E , DEPT D
WHERE (E.DEPTNO=D.DEPTNO);

  /*Determine the average salaries of employees.*/
SELECT ENAME, AVG(SAL) AS 'AVGSAL'
FROM EMP
GROUP BY ENAME;

  /* Determine number of departments in the company.*/
SELECT DISTINCT COUNT(DNAME) AS 'NO OF DEPT'
FROM DEPT;

  /*List department number, department name, location and total commission paid and total salary of each department*/
SELECT D.DNAME,D.DEPTNO, D.LOC,SUM(E.COMM) AS 'TOTALCOMM', SUM(E.SAL) AS ' TOTTALSAL'
FROM EMP E
LEFT OUTER JOIN
DEPT D
ON E.DEPTNO = D.DEPTNO 
GROUP BY  D.DEPTNO,D.DNAME,D.LOC;

   /*RECHECK WRONG*/

   /*Display the employee name, job description and the salary multiplied by 12*/
SELECT ENAME,JOB,SAL*12 AS 'SAL*12'
FROM EMP; 

   /*List the name, job and commission of employee who earn no commission*/
SELECT ENAME, JOB , COMM
FROM EMP 
WHERE COMM IS NULL;

   /*List the name, job and commission of employee who earn commission.*/
SELECT ENAME, JOB , COMM
FROM EMP 
WHERE COMM IS NOT NULL;

   /*List the employee name, job description and salary where the third character of employee name is R.*/
SELECT ENAME ,JOB ,SAL
FROM EMP 
WHERE ENAME LIKE '__R%';

   /* List all the information from emp that are five characters long.*/
SELECT *
FROM EMP
WHERE LEN(ENAME) = 5 ;

   /* List all the information from emp that are not five characters long.*/
SELECT *
FROM EMP
WHERE LEN(ENAME) !=5;

   /*List names that have A and followed by R*/
SELECT ENAME
FROM EMP
WHERE ENAME LIKE '%AR%';

   /*List all the details of employee from emp table where department number is equal to 30, order the list  by their salary.*/
SELECT *
FROM EMP
WHERE DEPTNO = '30'
ORDER BY SAL;

   /*Select name and salary of employees who earn between 1250 and 1600*/
SELECT ENAME, SAL
FROM EMP
WHERE SAL BETWEEN '1250' AND '1600';

   /*List the name and salary of employees who earn less than 1250 or more than 1600.*/
SELECT ENAME, SAL
FROM EMP
WHERE SAL NOT BETWEEN '1250' AND '1600';

   /*Compute the total salary of all employees*/
SELECT SUM(SAL) AS 'TOTAL SAL'
FROM EMP;

   /*Count the number of employees who have job titles(that is, the number of rows where JOB is not NULL).*/
SELECT ENAME 
FROM EMP
WHERE JOB IS NOT NULL;

   /*Compute the minimum and the maximum salary in the company.*/
SELECT MAX(SAL) AS 'MAXSAL',MIN(SAL) AS 'MINSAL'
FROM EMP;

   /*Write a query that produces all rows from the emp table with columns in  the following order with these as heading
   .Emp #, Employee, Salary, Job, Date of Hire, Commission, Department No, MGR No*/
SELECT EMPNO AS '.EMP #',ENAME AS ' EMPLOYEE', SAL AS 'SALARY', JOB, HIREDATE AS 'DATE OF HIRE', COMM AS ' COMMISSION', 
		DEPTNO AS 'DEPARTMENT NUMBER', MGR AS 'MGR NO'
FROM EMP;

   /*What is the earliest date on which someone was hired, and what is the latest date on which someone was hired.*/
SELECT  MIN(HIREDATE) AS 'MINDATE',MAX(HIREDATE) AS 'MAXDATE'
FROM EMP



   /*Count the number of employees working in department 10.*/
SELECT COUNT(EMPNO) AS ' EMP FROM DEPT 10'
FROM EMP 
WHERE DEPTNO = '10';

   /*Write a query that will give you the names and jobs of all employees in New York with a commission above 10*/
SELECT EMP.ENAME, EMP.JOB
FROM EMP, DEPT
WHERE EMP.DEPTNO = DEPT.DEPTNO AND LOC='NEW YORK' AND COMM>10;

   /*Format the hiredate with the following date formats.
a.     DAY MONTH DD, YYY
b.     DY DD Mon YYYY
c.     Day ddth Month YYYY*/
SELECT FORMAT(HIREDATE,'dddd MMMM dd, yyyy') AS 'DAY MONTH DD, YYY',
		FORMAT(HIREDATE,'dy dd MMM yyyy') AS 'DY DD Mon YYYY',
		FORMAT(HIREDATE,'dddd dd\t\h MMMM, yyyy') AS 'Day ddth Month YYYY'
FROM EMP;