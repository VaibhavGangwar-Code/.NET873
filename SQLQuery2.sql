--DATA QUERY LANGUAGE (DQL) SELECT
--SYNTAX
/*SELECT COLUMN1,....,COLUMN N FROM TABLENAME
where condition 
relational | logical operator| etc */
-- to see all the data from table
select * from tblDepartment

-- Select Particular column
select depid,dname from tblDepartment

--Aliase Name-- wll not be reflected to tables( only for final presentation)

select depid as DepartmentID, dname as DepartmentName from tblDepartment
-- 