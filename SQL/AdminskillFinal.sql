create table Users(ID nvarchar(15) primary key,UserImage varbinary(max) null,FirstName nvarchar(30) not null,LastName nvarchar(25) not null,DateOfBirth date null,Gender nvarchar(10) null,EducationLevel nvarchar(30) null, Email nvarchar(50) not null,Roles nvarchar(15) not null, Desgination nvarchar(30) null, PhoneNumber bigint null,"Location" nvarchar(30) null, "Address" nvarchar(100) null,"Password" nvarchar(20) null )

create table Department(ID nvarchar(15) primary key, DepartmentName nvarchar(50) not null)

create table Topic (ID int primary key identity(1,1), TopicName nvarchar(30) not null)

create table Skill (ID nvarchar(15) primary key, SkillLevel nvarchar(15) not null)

create table QuestionType(ID nvarchar(15) primary key, QuestionType nvarchar(40) not null)

create table AddQuestions(ID int primary key, DepartmentID nvarchar(15) foreign key references Department(ID), TopicID int foreign key references Topic(ID),SkillID nvarchar(15) foreign key references Skill(ID),QuestionTypeID nvarchar(15) foreign key references QuestionType(ID),Question nvarchar(250) not null,Option1 nvarchar(100),Option2 nvarchar(100),Option3 nvarchar(100),Option4 nvarchar(100), Answer nvarchar(100) not null)

/* Assessment page */
create table Assessment(ID int primary key,AssessmentID nvarchar(25) ,DepartmentID nvarchar(15) foreign key references Department(ID), TopicID int foreign key references Topic(ID),SkillID nvarchar(15) foreign key references Skill(ID),UserID nvarchar(15) foreign key references Users(ID),NumberOfTopics int not null,NumberOfQuestions bigint not null ,DateOfCompletion date not null,"Description" nvarchar(250) null)

/* QuestionPage */
create table QuestionPage(AssessmentID int foreign key references Assessment(ID),Questions int foreign key references AddQuestions(ID));

/* result for j and emp */
create table Result(ID nvarchar(25) primary key, AssessmentID int foreign key references Assessment(ID) ,"Status" nvarchar(15) not null,Score Decimal(2,2) not null,CorrectAnswer bigint not null,WrongAnswer bigint not null, SkippedAnswer bigint not null, TotalTime date not null)

/* email*/
create table EmailHistory(UserEmail nvarchar(50) not null,AssessmentID nvarchar(15) not null,SentTime datetime not null)

