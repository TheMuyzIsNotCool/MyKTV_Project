use master
go
if exists(select * from sysdatabases where name='SuperKTV')
drop database SuperKTV
go
--�������ݿ�
create database SuperKTV
go
--�������ݿ�
use SuperKTV
go
--�������ͱ�
create table SingerType
(
	SingerTypeID int  primary key identity(1001,1),
	SingerTypeName varchar(20) not null unique
)
go
insert into SingerType values('��½')
insert into SingerType values('��̨')
insert into SingerType values('ŷ��')
insert into SingerType values('�պ�')

--���ֱ�
create table Singer(
	SingerID int primary key identity(1,1),
	SingerName	varchar(50)	not null,
	SingerTypeID	int	not null references SingerType(SingerTypeID),
	Gender	varchar(4)	check(Gender in ('��','Ů','���')),
	Photo	varchar(200)
)
go
insert into Singer values( 'Michael Jackson',1003,'��','Michael Jackson.jpg')
insert into Singer values( '����������',1004,'Ů','����������.jpg')
insert into Singer values( 'super junior',1003,'���','super junior.jpg')
insert into Singer values( '����Ԫ',1002,'��','����.jpg')
insert into Singer values( '��������',1004,'��','��������.jpg')
insert into Singer values( '������',1002,'��','����ͬ.jpg')
insert into Singer values( '����ʫ',1002,'Ů','����ʫ.jpg')
insert into Singer values( '����к�',1003,'���','����к�.jpg')
insert into Singer values( '����',1001,'��','����.jpg')
insert into Singer values( '������',1001,'��','���һ.jpg')
insert into Singer values( '����',1004,'Ů','��Т��.jpg')
insert into Singer values( '���',1001,'Ů','���.jpg')
insert into Singer values( '�ֿϹ�԰',1003,'���','�ֿϹ�԰.jpg')
insert into Singer values( '��ӽ��',1001,'Ů','��Ӣ.jpg')
insert into Singer values( '�մ���',1002,'���','�մ���.jpg')
insert into Singer values( '��־��',1002,'Ů','������.jpg')
insert into Singer values( '����ʤ',1001,'��','Ѧ֮ǫ.jpg')
insert into Singer values( '�Ź���',1002,'��','�Ź���.jpg')
insert into Singer values( '������',1002,'��','��ѧ��.jpg')
insert into Singer values( '������',1002,'��','����ͼƬ.jpg')
go

--���������
create table SongType(
	SongTypeID int primary key identity(2001,1),
	SongTypeName	varchar(50)	not null
)
go
insert into SongType values('��������')
insert into SongType values('�����ϸ�')
insert into SongType values('Ӱ�ӽ���')
insert into SongType values('��Ϸ����')
insert into SongType values('����Ϸ��')
insert into SongType values('����')
go
--������
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
insert into Song values ('�Ǳ�','WB',2,2002,1,'wenbie.mp4',default)
insert into Song values('alarm','alarm',5,2001,2,'alarm.MP3',0)
insert into Song values('everybody','everybody',9,2001,8,'everybody.mp3',0)

insert into Song values ('���볤��','BXZD',4,2001,15,'���볤��.mp3',0)
insert into Song values('��Ҫ������','BYAST',5,2002,16,'��Ҫ������.wma',0)
insert into Song values('������㳡','BLGGC',5,2002,19,'������㳡.WMA',0)

insert into Song values ('��˵','CS',2,2002,19,'��˵.mp3',0)
insert into Song values('��������','DCLR',4,2003,10,'��������.mp3',0)
insert into Song values('�ڰ�','HB',5,2004,17,'�ڰ�.mp3',0)

--����Ա��
create table AdminInfo(
	AID int primary key identity(1,1),
	AName	Varchar(50)	not null,
	APwd	varchar(50)	not null
)
go
insert into AdminInfo values('admin','123')
insert into AdminInfo values('����','666')
insert into AdminInfo values('��͹��','999')

--��Դ�ļ���
create table ResourceUrl(
	RID int primary key identity(1,1),
	RName varchar(50) not null unique,
	RPath text not null
)
go
--����ͼƬ��ַ
insert into ResourceUrl values('SingerPic','D:\MyKTV\SingerPhoto')
--����ͼƬ��ַ
insert into ResourceUrl values('SongPic','D:\MyKTV\SongPic')
--�����ļ���ַ
insert into ResourceUrl values('Song','D:\MyKTV\Radio')
--��ӹ���Ա
insert into AdminInfo values('Muyz','Mtt0810.')

select * from AdminInfo where AName ='Muyz' and APwd = 'Mtt0810.'
