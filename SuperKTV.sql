use master
go
if exists(select * from sysdatabases where name='SuperKTV')
drop database SuperKTV
go
--创建数据库
create database SuperKTV
go
--进入数据库
use SuperKTV
go
--歌手类型表
create table SingerType
(
	SingerTypeID int  primary key identity(1001,1),
	SingerTypeName varchar(20) not null unique
)
go
insert into SingerType values('大陆')
insert into SingerType values('港台')
insert into SingerType values('欧美')
insert into SingerType values('日韩')

--歌手表
create table Singer(
	SingerID int primary key identity(1,1),
	SingerName	varchar(50)	not null,
	SingerTypeID	int	not null references SingerType(SingerTypeID),
	Gender	varchar(4)	check(Gender in ('男','女','组合')),
	Photo	varchar(200)
)
go
insert into Singer values( 'Michael Jackson',1003,'男','Michael Jackson.jpg')
insert into Singer values( '安室奈美惠',1004,'女','安室奈美惠.jpg')
insert into Singer values( 'super junior',1003,'组合','super junior.jpg')
insert into Singer values( '左振元',1002,'男','侧田.jpg')
insert into Singer values( '东方神起',1004,'男','东方神起.jpg')
insert into Singer values( '王善勤',1002,'男','方大同.jpg')
insert into Singer values( '何韵诗',1002,'女','何韵诗.jpg')
insert into Singer values( '后街男孩',1003,'组合','后街男孩.jpg')
insert into Singer values( '后弦',1001,'男','后弦.jpg')
insert into Singer values( '李云松',1001,'男','李谷一.jpg')
insert into Singer values( '汪艺',1004,'女','李孝利.jpg')
insert into Singer values( '李宇春',1001,'女','李宇春.jpg')
insert into Singer values( '林肯公园',1003,'组合','林肯公园.jpg')
insert into Singer values( '李咏琪',1001,'女','那英.jpg')
insert into Singer values( '苏打绿',1002,'组合','苏打绿.jpg')
insert into Singer values( '饶志凌',1002,'女','王若琳.jpg')
insert into Singer values( '唐玉胜',1001,'男','薛之谦.jpg')
insert into Singer values( '张国荣',1002,'男','张国荣.jpg')
insert into Singer values( '刘东旭',1002,'男','张学友.jpg')
insert into Singer values( '赵卫东',1002,'男','暂无图片.jpg')
go

--歌曲分类表
create table SongType(
	SongTypeID int primary key identity(2001,1),
	SongTypeName	varchar(50)	not null
)
go
insert into SongType values('热门流行')
insert into SongType values('经典老歌')
insert into SongType values('影视金曲')
insert into SongType values('游戏动漫')
insert into SongType values('京剧戏曲')
insert into SongType values('儿歌')
go
--歌曲表
create table Song(
	SongID	int primary key identity(1,1),
	SongName	varchar(50)	not null,
	Songab	varchar(50)	not null,
	SongWordCount	int	not null,
	SongTypeID	int	references SongType(SongTypeID),
	SingerID	int	references Singer(SingerID),
	Url	varchar(200)	not null,
	ClientCount	int not null default(0)
)
go
insert into Song values ('吻别','WB',2,2002,1,'wenbie.mp4',default)
insert into Song values('alarm','alarm',5,2001,2,'alarm.MP3',0)
insert into Song values('everybody','everybody',9,2001,8,'everybody.mp3',0)

insert into Song values ('不想长大','BXZD',4,2001,15,'不想长大.mp3',0)
insert into Song values('不要爱上她','BYAST',5,2002,16,'不要爱上她.wma',0)
insert into Song values('布拉格广场','BLGGC',5,2002,19,'布拉格广场.WMA',0)

insert into Song values ('传说','CS',2,2002,19,'传说.mp3',0)
insert into Song values('单车恋人','DCLR',4,2003,10,'单车恋人.mp3',0)
insert into Song values('黑白','HB',5,2004,17,'黑白.mp3',0)

--管理员表
create table AdminInfo(
	AID int primary key identity(1,1),
	AName	Varchar(50)	not null,
	APwd	varchar(50)	not null
)
go
insert into AdminInfo values('admin','123')
insert into AdminInfo values('河马','666')
insert into AdminInfo values('凹凸曼','999')

--资源文件表
create table ResourceUrl(
	RID int primary key identity(1,1),
	RName varchar(50) not null unique,
	RPath text not null
)
go
--歌手图片地址
insert into ResourceUrl values('SingerPic','D:\MyKTV\SingerPhoto')
--歌曲图片地址
insert into ResourceUrl values('SongPic','D:\MyKTV\SongPic')
--歌曲文件地址
insert into ResourceUrl values('Song','D:\MyKTV\Radio')
--添加管理员
insert into AdminInfo values('Muyz','Mtt0810.')

select * from AdminInfo where AName ='Muyz' and APwd = 'Mtt0810.'
