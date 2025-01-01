CREATE TABLE CollectionTypes (
	Id int primary key identity(1,1),
	TypeName varchar(100),
	CreatedBy varchar(100),
	CreatedAt datetime,
	UpdatedBy varchar(100),
	UpdatedAt datetime
)

insert into CollectionTypes
values 
	('Vinyl', 'system', getdate(), null, null)
	,('Microfilm', 'system', getdate(), null, null)
	,('Microfiche', 'system', getdate(), null, null)
	,('Disk', 'system', getdate(), null, null)

CREATE TABLE FormatTypes (
	Id int primary key identity(1,1),
	TypeName varchar(100),
	CreatedBy varchar(100),
	CreatedAt datetime,
	UpdatedBy varchar(100),
	UpdatedAt datetime
)

insert into FormatTypes
values
	('Digital', 'system', getdate(), null, null)
	,('Non Digital', 'system', getdate(), null, null)

CREATE TABLE CollectionSubjects (
	Id int primary key identity(1,1),
	SubjectName varchar(100),
	CreatedBy varchar(100),
	CreatedAt datetime,
	UpdatedBy varchar(100),
	UpdatedAt datetime
)

insert into CollectionSubjects
values
	('Fiction', 'system', getdate(), null, null)
	,('Psychology', 'system', getdate(), null, null)
	,('Business and Economy', 'system', getdate(), null, null)
	,('Information Technology', 'system', getdate(), null, null)

CREATE TABLE CollectionLanguages (
	Id int primary key identity(1,1),
	[Language] varchar(100),
	CreatedBy varchar(100),
	CreatedAt datetime,
	UpdatedBy varchar(100),
	UpdatedAt datetime
)

insert into CollectionLanguages
values
	('English', 'system', getdate(), null, null)
	,('Indonesia', 'system', getdate(), null, null)
	,('Arabic', 'system', getdate(), null, null)

CREATE TABLE CollectionLocations (
	Id int primary key identity(1,1),
	[Location] varchar(100),
	CreatedBy varchar(100),
	CreatedAt datetime,
	UpdatedBy varchar(100),
	UpdatedAt datetime
)

insert into CollectionLocations
values
	('1st Floor', 'system', getdate(), null, null)

CREATE TABLE ReaderCategories (
	Id int primary key identity(1,1),
	CategoryName varchar(100),
	CreatedBy varchar(100),
	CreatedAt datetime,
	UpdatedBy varchar(100),
	UpdatedAt datetime
)

insert into ReaderCategories
values
	('Baby', 'system', getdate(), null, null)

CREATE TABLE Publishers (
	Id int primary key identity(1,1),
	PublisherName varchar(100),
	CreatedBy varchar(100),
	CreatedAt datetime,
	UpdatedBy varchar(100),
	UpdatedAt datetime
)

insert into Publishers
values
	('Erlangga', 'system', getdate(), null, null)

CREATE TABLE Collections (
	Id varchar(50) primary key,
	Title varchar(100),
	Author varchar(100),
	PublishedYear int,
	Publisher int foreign key references Publishers(id),
	CollectionType int foreign key references CollectionTypes(id),
	FormatType int foreign key references FormatTypes(id),
	[Subject] int foreign key references CollectionSubjects(id),
	[Language] int foreign key references CollectionLanguages(id),
	[Location] int foreign key references CollectionLocations(id),
	ReaderCategory int foreign key references ReaderCategories(id),
	CreatedBy varchar(100),
	CreatedAt datetime,
	UpdatedBy varchar(100),
	UpdatedAt datetime
)

insert into Collections
values
	(NEWID(), 'Untitled', 'Mister X', 2000, 1, 1, 1, 1, 1, 1, 1, 'system', getdate(), null, null)
