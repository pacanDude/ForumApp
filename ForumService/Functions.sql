
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

CREATE FUNCTION GetAllQwery ()
    RETURNS TABLE
    AS RETURN 
	(select * from Qwery)