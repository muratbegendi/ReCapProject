create table Colors(
ColorId int primary key identity(1,1),
ColorName nvarchar(25)
)

create table Brands(
BrandId int primary key identity (1,1),
BrandName nvarchar(25)
)

create table Cars(
Id int primary key identity (1,1),
BrandId int,
ColorId int,
ModelYear nvarchar(25),
DailyPrice decimal,
Descriptions nvarchar(50),
Foreign key (BrandId) references Brands(BrandId),
Foreign key (ColorId) references Colors(ColorId)
)

insert into Colors (ColorName)
values
	('Siyah'),
	('Beyaz'),
	('Kırmızı'),
	('Füme'),
	('Mavi');

insert into Brands (BrandName)
values
	('Bentley'),
	('Mercedes'),
	('Aston Martin'),
	('Bugatti'),
	('Tesla'),
	('McLaren');

INSERT INTO Cars(BrandID,ColorID,ModelYear,DailyPrice,Descriptions)
VALUES
	('1','1','2016','1000','Continental GT'),
	('2','4','2020','1500','Maybach'),
	('3','2','2016','900','Rapide S'),
	('4','3','2020','2000','X-Clusive Chiron'),
	('5','5','2020','1000','Model S Performance'),
	('6','1','2019','1250','McLaren GT'),
	('2','3','2018','1500','Brabus G6'),
	('5','2','2016','900','Model-X P100D'),
	('4','1','2018','1400','EB110');
