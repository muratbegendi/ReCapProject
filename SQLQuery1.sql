create table CarImages (
Id int primary key identity (1,1),
CarId int,
ImagePath nvarchar(250),
Date datetime,
foreign key (CarId) references Cars(CarId)
)
