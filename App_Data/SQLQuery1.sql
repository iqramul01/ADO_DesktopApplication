
Create TABLE Department(
DepID int primary key IDENTITY(1,1),
DepartmentName varchar(20) Not Null,
NumberOfSeat int,
)
GO



Create TABLE Doctor(
	DoctorID int Primary Key IDENTITY(1001,1) Not Null,
	DoctorName varchar(30) Not Null,
	ContactNumber varchar(30) Null,
	ContactAddress varchar(20) Null,
	EmailAddress varchar(MAX) Null,
	DepID int FOREIGN KEY REFERENCES Department(DepID) ON UPDATE CASCADE ON DELETE CASCADE,
	DoctorImage varchar(120) null
)
GO

CREATE TABLE PatientAdmit(
	PatientID int Primary Key IDENTITY(10000,1) Not Null,
	PatientName varchar(MAX) Not Null,
	Gender varchar(MAX) Null,
	BloodGroup varchar(MAX) Null,
	AdmitDate varchar(MAX),
	AdmitFee decimal(10,2) Not Null,
	EmergencyContact varchar(MAX) Null,
	DepID int FOREIGN KEY REFERENCES Department(DepID) ON UPDATE CASCADE ON DELETE CASCADE
)
GO


CREATE Table PatientRelease
(
BillNo int Primary Key Identity ,
ReleaseDate varchar(MAX),
TotalBill Decimal (10,2),
DiscountRate Decimal (10,2),
NetBill as (TotalBill-(TotalBill*DiscountRate)),
DepID int FOREIGN KEY REFERENCES Department(DepID),
PatientID INT UNIQUE FOREIGN KEY REFERENCES PatientAdmit(PatientID) ON UPDATE CASCADE ON DELETE CASCADE
)
go


Create PROC sp_PatientAddInsert
@patientid int,
@patientname varchar(30),
@gender varchar(10),
@bloodgroup varchar(15),
@admitdate varchar(20),
@admitfee decimal(10,2),
@emergencycontact varchar (15),
@depid int

As
Begin
Insert Into PatientAdmit values(@patientname,@gender,@bloodgroup,@admitdate,@admitfee,@emergencycontact,@depid)
Update Department Set NumberofSeat=NumberofSeat-1
Where DepID=@depid
End
go



CREATE PROC sp_PatientReleaseInsert
@billno int,
@releaseDate varchar(MAX),
@totalBill Decimal (10,2),
@discountrate Decimal (10,2),
@depid int,
@patientid int

As
Begin
Begin Tran
Insert into PatientRelease Values (@releaseDate,@totalBill,@discountrate,@depid,@patientid)

update Department Set NumberofSeat=NumberofSeat+1
Where DepID=@depid
Commit Tran
End
Go

SELECT * From PatientRelease
Select * From PatientAdmit
SELECT * From Department
SELECT * From Doctor
go

EXEC sp_PatientReleaseInsert @billno,@releaseDate,@totalBill,@discountrate,@patientid

EXEC sp_PatientAddInsert @patientid,@patientname,@gender,@bloodgroup,@admitdate,@admitfee,@emergencycontact,@depid

INSERT INTO PatientAdmit (PatientName,Gender,BloodGroup,AdmitFee,EmergencyContact,DepID)
VALUES ('Iqramul Hoque','Male','B positive',100,'aaaa',2)


INSERT INTO PatientAdmit (PatientID,PatientName,Gender,BloodGroup,AdmitDate,AdmitFee,EmergencyContact,DepID) Values
(@patientid,@patientname,@gender,@bloodgroup,@admitdate,@admitfee,@emergencycontact,@depid)

UPDATE PatientAdmit SET PatientName=@patientname, Gender=@gender, BloodGroup=@bloodgroup, AdmitDate=@admitdate, AdmitFee=@admitfee, EmergencyContact=@emergencycontact, DepID=@dipid WHERE PatientID=@patientid;

INSERT INTO Department (DepartmentName,NumberOfSeat) VALUES ('Gynee',10);



