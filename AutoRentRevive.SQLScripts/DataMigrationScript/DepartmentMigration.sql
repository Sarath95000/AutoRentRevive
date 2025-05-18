IF NOT EXISTS(SELECT * FROM Departments)
BEGIN

	CREATE TABLE #EmployeeDepartmentData
	(
		EmployeeId INT NOT NULL,
		DepartmentId INT NOT NULL
	)

	INSERT INTO #EmployeeDepartmentData(EmployeeId,DepartmentId)
	SELECT EmployeeId,DepartmentId FROM Employees

	--Drop CONSTRAINT From Employees
	ALTER TABLE [dbo].[Employees]
	DROP CONSTRAINT [FK_Employees_Departments_DepartmentId];

	--Clear Departments Records
	TRUNCATE TABLE Departments

	--Migrate Data from AdventureWorks2022 to Auto_RentRevive
	INSERT INTO Auto_RentRevive.dbo.Departments
	(
		Department_Name,
		GroupName,
		Department_Code,
		IsActive,
		CreatedById,
		CreatedTime
	)
	SELECT
		Name,
		GroupName,
		'Default',
		CAST(1 AS bit),
		CAST(1 AS bit),
		SYSDATETIMEOFFSET()
	FROM AdventureWorks2022.HumanResources.Department;


	--Update Existing user
	UPDATE EMP SET EMP.DepartmentId = EDD.DepartmentId
	FROM Employees EMP
	JOIN #EmployeeDepartmentData EDD ON EMP.EmployeeId = EDD.EmployeeId

	--Add Department Constraint Again to Employee
	ALTER TABLE [dbo].[Employees]
	ADD CONSTRAINT [FK_Employees_Departments_DepartmentId]
	FOREIGN KEY ([DepartmentId])
	REFERENCES [Auto_RentRevive].[dbo].[Departments] ([DepartmentId])
	ON DELETE CASCADE          -- Specify Cascade action for deletion
	ON UPDATE NO ACTION;       -- Specify No Action for updates

	SELECT 1
END
GO



--IT	Information Technology
--HR	Human Resource
--FIN	Finance
--MKT	Marketing
--ADM	Admin
--PRL	Payroll
--HR	Human Resource
--IT	Information Technology


--SP
--Temp Table
--Helper Table