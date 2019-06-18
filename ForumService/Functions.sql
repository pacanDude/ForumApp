
CREATE FUNCTION GetAllUsers ()
    RETURNS TABLE
    AS RETURN 
	(select name from OneUser)


create proc RegisterUser (@name varchar(max), @password varchar(max), @foto varbinary(max), @age int, @rating int,@ratingAnswers int,@ratingQwery int,@about nvarchar(max))
    as 
	begin 
	insert into OneUser(name, password, foto,age,rating,ratingAnswers,ratingQwery,about)
	values
	(@name,	@password, @foto, @age, @rating, @ratingAnswers, @ratingQwery, @about)
	end


CREATE FUNCTION GetUserPassword (@name nvarchar(max))
    RETURNS TABLE
    AS RETURN 
	(select password from OneUser where name = @name)


CREATE FUNCTION GetCategoryList ()
    RETURNS TABLE
    AS RETURN 
	(select distinct category from Qwery)


CREATE FUNCTION GetQwery (@Id int)
    RETURNS TABLE
    AS RETURN 
	(select * from Qwery where Id=@Id)
	
CREATE FUNCTION GetAnsversIdQwery (@QweryId int)
    RETURNS TABLE
    AS RETURN 
	(select * from Ansver where QweryId=@QweryId)


CREATE FUNCTION GetOneUser (@name nvarchar(max))
    RETURNS TABLE
    AS RETURN 
	(select * from OneUser where name=@name)

create proc EditUser (@name varchar(max), @password varchar(max), @foto varbinary(max), @age int, @rating int,@ratingAnswers int,@ratingQwery int,@about nvarchar(max))
    as 
	begin 
	delete from OneUser where name=@name
	insert into OneUser(name, password, foto,age,rating,ratingAnswers,ratingQwery,about)
	values
	(@name,	@password, @foto, @age, @rating, @ratingAnswers, @ratingQwery, @about)
	end

CREATE FUNCTION GetQweryByCategory (@category nvarchar(max))
    RETURNS TABLE
    AS RETURN 
	(select * from Qwery where category=@category)

create proc AddQwery (@header varchar(max), @name varchar(max), @text varchar(max), @date datetime, @rating int,@category nvarchar(max),@code nvarchar(max))
    as 
	begin
	insert into Qwery(header, name, text, date,rating,category,code)
	values
	(@header, @name, @text, @date,@rating,@category,@code)
	end

create proc AddAnsver (@QweryId int, @name varchar(max), @text varchar(max), @date datetime, @rating int, @code nvarchar(max))
    as 
	begin
	insert into Ansver(QweryId, name, text, date,rating,code)
	values
	(@QweryId, @name, @text, @date,@rating,@code)
	end

	create proc AddAnsverAnsver (@AnsverId int, @name varchar(max), @text varchar(max), @date datetime, @rating int, @code nvarchar(max))
    as 
	begin
	insert into AnsverAnsver(AnsverId, name, text, date,rating,code)
	values
	(@AnsverId, @name, @text, @date,@rating,@code)
	end

CREATE FUNCTION GetAllQwery ()
    RETURNS TABLE
    AS RETURN 
	(select * from Qwery)


create proc SetQweryRating (@QweryId int, @rating int)
    as 
	begin
	update Qwery set rating=@rating where Id=@QweryId
	end

create proc SetAnsverRating (@AnsverId int, @rating int)
    as 
	begin
	update Ansver set rating=@rating where Id=@AnsverId
	end

CREATE FUNCTION GetAnsverById (@Id int)
    RETURNS TABLE
    AS RETURN 
(select * from Ansver where Id=@Id)

create proc EditUser2 (@name varchar(max), @password varchar(max), @foto varbinary(max), @age int, @rating int,@ratingAnswers int,@ratingQwery int,@about nvarchar(max))
    as 
	begin 
	delete from OneUser where name=@name
	insert into OneUser(name, password, foto,age,rating,ratingAnswers,ratingQwery,about)
	values
	(@name,	@password, @foto, @age, @rating, @ratingAnswers, @ratingQwery, @about)
	end


CREATE FUNCTION GetOneUser2 (@name nvarchar(max))
    RETURNS TABLE
    AS RETURN 
	(select * from OneUser where name=@name)











create proc EditQwery (@Id int, @header varchar(max), @text varchar(max), @date datetime, @category nvarchar(max),@code nvarchar(max))
    as 
	begin
	update Qwery set header=@header, text=@text, date=@date, category=@category, code=@code where Id=@Id
	end

create proc EditAnsver (@IdAnsver int, @text varchar(max), @date datetime, @code nvarchar(max))
    as 
	begin
	update Ansver set text=@text, date=@date, code=@code where Id=@IdAnsver
	end

create proc EditAnsverAnsver (@IdAnsverAnsver int, @text varchar(max), @date datetime, @code nvarchar(max))
    as 
	begin
	update AnsverAnsver set text=@text, date=@date, code=@code where Id=@IdAnsverAnsver
	end


CREATE FUNCTION GetAnsverAnsverByIdAnsver (@Id int)
    RETURNS TABLE
    AS RETURN 
(select * from AnsverAnsver where AnsverId=@Id)