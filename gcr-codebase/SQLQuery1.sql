-- DDL COMMANDS
-- CREATE
/* 
CREATE TABLE table_name (
    column_name datatype constraints
);
*/

CREATE TABLE Students(
StudentId INT PRIMARY KEY,
Name VARCHAR(50),
Age INT
);

-- ALTER (Add Column)
/*
ALTER TABLE table_name
ADD column_name datatype;
*/

ALTER TABLE Students
ADD Address VARCHAR(100);

-- ALTER (Modify Column)
/*
ALTER TABLE table)name
ALTER COLUMN column_name datatype;
*/

ALTER TABLE Students
ALTER COLUMN NAME VARCHAR(100);


-- DROP
/*
DROP TABLE table_name;
*/
DROP TABLE Students;


-- TRUNCATE TABLE 
/*
TRUNCATE TABLE table_name;
*/
TRUNCATE TABLE Students;



-- DML COMMANDS
--INSERT
/*
INSERT INTO table_name (column1, column2, ...)
VALUES (value1, value2, ...);
*/

INSERT INTO Students (StudentId, Name, Age)
VALUES
(1, 'HEMANT', 21),
(2, 'Golu', 26);


-- UPDATE
/*
UPDATE table_name
SET column1 = value1
WHERE condition;
*/
UPDATE Students
SET Age = 22
WHERE StudentId = 1;


-- DELETE
/*
DELETE FROM TableName
WHERE Condition;
*/

DELETE FROM Students
WHERE StudentId = 2;


-- DELETE FROM Students
-- It deletes all the records from the Students table without removing the table itself.
DELETE FROM Students;




-- DQL COMMAND
-- SELECT
-- retrie all columns
/*
SELECT * FROM table_name;
*/
SELECT * FROM Students;


-- retrieve specific columns
/*
select column1, column2 from table_name;
*/
SELECT StudentId, Name from Students;



-- DCL COMMANDS (Data Control Language)
-- Used to control access/permissions on database objects

-- GRANT
/*
GRANT permission_name
ON object_name
TO user_name;
*/

-- Example: Grant SELECT permission on Students table
GRANT SELECT
ON Students
TO User1;


-- REVOKE
/*
REVOKE permission_name
ON object_name
FROM user_name;
*/

-- Example: Revoke SELECT permission from user
REVOKE SELECT
ON Students
FROM User1;



-- TCL COMMANDS (Transaction Control Language)
-- Used to manage transactions in a database

-- BEGIN TRANSACTION
/*
BEGIN TRANSACTION;
*/

BEGIN TRANSACTION;

INSERT INTO Students (StudentId, Name, Age)
VALUES (3, 'Rahul', 23);


-- COMMIT
/*
COMMIT;
*/

COMMIT;


-- ROLLBACK
/*
ROLLBACK;
*/

BEGIN TRANSACTION;

UPDATE Students
SET Age = 30
WHERE StudentId = 3;

ROLLBACK;


-- SAVEPOINT (In SQL Server, SAVE TRANSACTION is used)
/*
SAVE TRANSACTION savepoint_name;
*/

BEGIN TRANSACTION;

INSERT INTO Students (StudentId, Name, Age)
VALUES (4, 'Amit', 25);

SAVE TRANSACTION SavePoint1;

UPDATE Students
SET Age = 28
WHERE StudentId = 4;

-- Rollback to savepoint
ROLLBACK TRANSACTION SavePoint1;

COMMIT;


