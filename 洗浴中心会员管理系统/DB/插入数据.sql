use BC_CMSDB
go

--���벻ͬ��Ȩ��
--0��:��������Ա��ӵ��һ��Ȩ��
--1��:�곤���ɲ�ѯ������Ϣ�����ɹ���۸񣬿ɴ������û�
--2��:���������Ա��Ϣ����Ա��Ϣ��������Ϣ����ȯ���ţ��ɴ������û�
--3��:ǰ̨�������Ա��Ϣ�����ɴ������û�
--4��:���ڣ�����������Ϣ�����ɴ������û�
--5������ͨԱ������Ȩ��
insert into Privilege values(0,1,null)
go
insert into Privilege values(1,1,null)
go
insert into Privilege values(2,1,null)
go
insert into Privilege values(3,0,null)
go
insert into Privilege values(4,0,null)
go
insert into Privilege values(5,0,null)
go

--����Ա��
insert into Employee values('100000','14EE22EABA297944C96AFDBE5B16C65B','����Ա',' ',' ',' ',' ','����Ա',0,0,' ',' ',0,' ',' ','2020-06-01',1,'2020-06-01',null)
go
insert into Employee values('100001','E2A6A1ACE352668000AED191A817D143','��һ','��','����','����ʡ','������Ա','�곤',0,30000,'13900000001','�⽭��',1,'235407198106112745','4846168528655371685','1981-06-11',1,'2020-06-01',null)
go
insert into Employee values('100002','BB36C34EB6644AB9694315AF7D68E629','�Ŷ�','Ů','����','����ʡ','������Ա','����',0,20000,'13900000002','�⽭��',2,'210203198503102721','1675348629437615873','1985-03-10',1,'2020-06-01',null)
go
insert into Employee values('100003','3DC81E3F2C523FB5955761BBE2D150F2','����','Ů','����','����ʡ','Ⱥ��','ǰ̨',0,5000,'13900000003','�⽭��',3,'130102199303250459','1687953735946852164','1993-03-25',1,'2020-06-01',null)
go
insert into Employee values('100004','1EA85063355FBFAD3DE73AB038261D62','����','Ů','����','����ʡ','Ⱥ��','ǰ̨',0,5000,'13900000004','�⽭��',3,'511502199103223189','6287594326849761523','1991-03-22',1,'2020-06-01',null)
go
insert into Employee values('100005','EFD1A2F9B0B5F14B1FAC70A7F8E8A9E7','����','��','����','����ʡ','Ⱥ��','����',0,5000,'13900000005','�⽭��',4,'431202198811101720','9438951674866248951','1988-11-10',1,'2020-06-01',null)
go
insert into Employee values('100006','758691FDF7AE3403DB0D3BD8AC3AD585','��һ','��','����','����ʡ','Ⱥ��','����',0,5000,'13900000006','�⽭��',4,'130821199103278829','1684953289467135863','1991-03-27',1,'2020-06-01',null)
go
insert into Employee values('100007','9E3FC2A6D0F45C7A999AB01EBCACAF94','���','Ů','����','����ʡ','Ⱥ��','Ь��',0,3000,'13900000007','�⽭��',5,'520323198806058856','6897489563021681364','1988-06-05',1,'2020-06-01',null)
go
insert into Employee values('100008','AB24C2FE5B396A574095A73B1AD23356','����','��','����','����ʡ','Ⱥ��','�¹�',0,3000,'13900000008','�⽭��',5,'350105197506138487','5662167932031648922','1975-06-13',1,'2020-06-01',null)
go
insert into Employee values('100009','795202367B2120E77B231D4D2B98E2B9','����','Ů','����','����ʡ','Ⱥ��','�¹�',0,3000,'13900000009','�⽭��',5,'610729198408202551','9516874326984563205','1984-08-20',1,'2020-06-01',null)
go
insert into Employee values('100010','DAA28096F9E8879AB3A02B90AA0E2F83','����','��','����','����ʡ','Ⱥ��','����Ա',0,6000,'13900000010','�⽭��',5,'820000199508115837','7419658946258613076','1995-08-11',1,'2020-06-01',null)
go
insert into Employee values('100011','09A146C8D1CFDBDB54CEB60EDE93CDAB','��һ','Ů','����','����ʡ','Ⱥ��','����Ա',0,6000,'13900000011','�⽭��',5,'450101199405207446','9517896348603489168','1994-05-20',1,'2020-06-01',null)
go
insert into Employee values('100012','21BF043D935E1499B3749C2F483DF890','����','Ů','����','����ʡ','Ⱥ��','����Ա',0,6000,'13900000012','�⽭��',5,'411626199604167401','1579236985562301742','1996-04-16',1,'2020-06-01',null)
go
insert into Employee values('100013','33932D50E450EF3CCFBCF69AC9BA04E5','����','Ů','����','����ʡ','Ⱥ��','�ռ�',0,10000,'13900000013','�⽭��',5,'152224199909289211','1579468236478952103','1999-09-28',0,'2020-06-01',null)
go
insert into Employee values('100014','A3C3A95F3E42519D7BA5284CFFCD4E25','����','��','����','����ʡ','Ⱥ��','����',0,4000,'13900000014','�⽭��',5,'230822198201256034','7849512630278562102','1982-01-25',1,'2020-06-01',null)
go
insert into Employee values('100015','E025B5159BBA8890D4F936973D0BCB2F','����','Ů','����','����ʡ','Ⱥ��','����',0,3000,'13900000015','�⽭��',5,'235402198407121617','1579445467520546626','1984-07-12',1,'2020-06-01',null)
go

--�����Ա
insert into Member values('200001','EE8F208B135D4940DBB80D0335E20A1F','��һ','Ů','120111198912116881','18200000001','�⽭��','2020-6-1','100003',300,null)
go
insert into Member values('200002','7DB88CDD3C295D227680B119A479DDFB','�Ŷ�','Ů','440282195610226964','18200000002','�⽭��','2020-6-1','100003',450,null)
go
insert into Member values('200003','5C74D3DD8616593A3F272F2114354099','����','��','632223195605199057','18200000003','�⽭��','2020-6-1','100004',600,null)
go
insert into Member values('200004','797E5AF4ABD9F8D8E0CF07550E051B5C','����','Ů','361125195409090039','18200000004','�⽭��','2020-6-1','100003',300,null)
go
insert into Member values('200005','A210495A82B1A68ACB20D201F24DA34B','����','��','350426196812257489','18200000005','�⽭��','2020-6-1','100004',500,null)
go
insert into Member values('200006','302FEDBDF963CA2223BDDD79419730A1','��һ','��','441623198701083264','18200000006','�⽭��','2020-6-1','100004',200,null)
go
insert into Member values('200007','B48CC8E7E27475244A04F087D6234BE8','���','Ů','610724199403025899','18200000007','�⽭��','2020-6-1','100004',350,null)
go
insert into Member values('200008','CBD52A6EF80D39C0087A8B34466C11AD','����','��','51130319560102717X','18200000008','�⽭��','2020-6-1','100003',250,null)
go
insert into Member values('200009','AC194A1FD0B26E8ED9B7973BBB8508B0','����','��','230822197201256344','18200000009','�⽭��','2020-6-1','100004',300,null)
go
insert into Member values('200010','33432E31EA9221137C5939101E2157B8','����','��','152224198908043711','18200000010','�⽭��','2020-6-1','100003',320,null)
go
insert into Member values('200011','4CA1B603A91FA6A51CF23F2EAD5E2313','��һ','��','654022199371228286','18200000011','�⽭��','2020-6-1','100003',550,null)
go
insert into Member values('200012','1FA37726AD9C59AC333417507A6BE14D','����','Ů','431202198811101730','18200000012','�⽭��','2020-6-1','100003',400,null)
go
insert into Member values('200013','209C8CBC87216C83CE038747E2049917','����','��','615729197408202551','18200000013','�⽭��','2020-6-1','100004',150,null)
go
insert into Member values('200014','76F00AFE3AECB62009D3424F927E6223','����','Ů','475101197405207446','18200000014','�⽭��','2020-6-1','100004',500,null)
go
insert into Member values('200015','8093B105ED38C24AC4D2601A3B54B4F7','����','Ů','520313197806058856','18200000015','�⽭��','2020-6-1','100003',300,null)
go

--����˿�
insert into Consumer values('001','��','200003',null)
go
insert into Consumer values('002','��','000000',null)
go
insert into Consumer values('003','��','000000',null)
go
insert into Consumer values('004','Ů','000000',null)
go
insert into Consumer values('005','��','200011',null)
go
insert into Consumer values('006','��','000000',null)
go
insert into Consumer values('007','Ů','200004',null)
go
insert into Consumer values('008','Ů','000000',null)
go
insert into Consumer values('009','��','000000',null)
go
insert into Consumer values('010','Ů','200014',null)
go
insert into Consumer values('011','��','000000',null)
go
insert into Consumer values('012','Ů','200007',null)
go
insert into Consumer values('013','��','200013',null)
go
insert into Consumer values('014','��','000000',null)
go
insert into Consumer values('015','Ů','000000',null)
go
--����۸�
insert into Price values('01','��Ʊ','��������',25,12,null)
go
insert into Price values('02','�˹���','����',20,10,null)
go
insert into Price values('03','��ԡ','����',20,10,null)
go
insert into Price values('04','��ԡ','����',20,10,null)
go
insert into Price values('05','����','����',20,10,null)
go
insert into Price values('06','�ι�','����',30,15,null)
go
insert into Price values('07','ͷ��','��Ħ',30,15,null)
go
insert into Price values('08','��','��Ħ',30,15,null)
go
insert into Price values('09','����','��Ħ',30,15,null)
go
insert into Price values('10','С��','��Ħ',30,15,null)
go
insert into Price values('11','�㲿','��Ħ',30,15,null)
go
insert into Price values('12','ȫ��','��Ħ',120,60,null)
go
insert into Price values('13','����','��ˮ',70,35,null)
go
insert into Price values('14','ë��','��ˮ',60,30,null)
go
insert into Price values('15','����','��ˮ',60,30,null)
go
insert into Price values('16','�ն�','��ˮ',60,30,null)
go
insert into Price values('17','���','��ˮ',60,30,null)
go
insert into Price values('18','����','��ˮ',40,20,null)
go
insert into Price values('19','����','��ˮ',30,15,null)
go
insert into Price values('20','��ʽ','��ˮ',30,15,null)
go
insert into Price values('21','������ŵ','��ˮ',30,15,null)
go
insert into Price values('22','��Ϣ��','��ҹ',70,35,null)
go
insert into Price values('23','�ͷ�����','��ҹ',100,50,null)
go
insert into Price values('24','�ͷ���׼��','��ҹ',120,60,null)
go
insert into Price values('25','�ͷ��󴲷�','��ҹ',140,70,null)
go
insert into Price values('26','�ͷ���ͥ��','��ҹ',160,80,null)
go
insert into Price values('27','�ͷ����Ʒ�','��ҹ',200,100,null)
go
insert into Price values('28','�ͷ�ӰԺ��','��ҹ',300,150,null)
go
insert into Price values('29','�ͷ����ⷿ','��ҹ',500,250,null)
go

--��������֧��
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('Ӫҵ��','2019-1-31',0,590000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('ˮ��','2019-1-31',1,9000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('����','2019-1-31',1,27000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('����','2019-1-31',1,11400,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('Ӫҵ��','2019-2-28',0,575000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('ˮ��','2019-2-28',1,86000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('����','2019-2-28',1,26000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('����','2019-2-28',1,11400,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('Ӫҵ��','2019-3-31',0,630000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('ˮ��','2019-3-31',1,11000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('����','2019-3-31',1,33000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('����','2019-3-31',1,11400,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('Ӫҵ��','2019-4-30',0,650000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('ˮ��','2019-4-30',1,13000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('����','2019-4-30',1,35000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('����','2019-4-30',1,11400,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('Ӫҵ��','2019-5-31',0,670000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('ˮ��','2019-5-31',1,15000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('����','2019-5-31',1,38000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('����','2019-5-31',1,11400,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('Ӫҵ��','2019-6-30',0,630000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('ˮ��','2019-6-30',1,12000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('����','2019-6-30',1,34000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('����','2019-6-30',1,11400,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('Ӫҵ��','2019-7-31',0,690000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('ˮ��','2019-7-31',1,16000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('����','2019-7-31',1,40000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('����','2019-7-31',1,14400,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('Ӫҵ��','2019-8-31',0,705000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('ˮ��','2019-8-31',1,19000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('����','2019-8-31',1,42000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('����','2019-8-31',1,14400,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('Ӫҵ��','2019-9-30',0,720000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('ˮ��','2019-9-30',1,20000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('����','2019-9-30',1,44000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('����','2019-9-30',1,14400,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('Ӫҵ��','2019-10-31',0,680000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('ˮ��','2019-10-31',1,18000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('����','2019-10-31',1,400000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('����','2019-10-31',1,14400,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('Ӫҵ��','2019-11-30',0,650000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('ˮ��','2019-11-30',1,13000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('����','2019-11-30',1,350000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('����','2019-11-30',1,14400,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('Ӫҵ��','2019-12-31',0,630000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('ˮ��','2019-12-31',1,12000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('����','2019-12-31',1,35000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('����','2019-12-31',1,14400,null)
go

--��������
insert into item values('01','ʳ��','ʳ��',54,100,null)
go
insert into item values('02','ë��','ϴԡ',66,100,null)
go
insert into item values('03','����','ϴԡ',33,100,null)
go
insert into item values('04','���','ϴԡ',48,100,null)
go
insert into item values('05','ϴ��ˮ','ϴԡ',21,100,null)
go
insert into item values('06','��ԡ��','ϴԡ',22,100,null)
go
insert into item values('07','����','ϴԡ',66,100,null)
go
insert into item values('08','ú̿','����',72,100,null)
go
insert into item values('09','��ˮ','ʳ��',37,100,null)
go

--��������
insert into Consumption values('001','01')
go
insert into Consumption values('001','02')
go
insert into Consumption values('002','01')
go
insert into Consumption values('002','12')
go
insert into Consumption values('003','01')
go
insert into Consumption values('003','13')
go
insert into Consumption values('004','01')
go
insert into Consumption values('004','13')
go
insert into Consumption values('005','01')
go
insert into Consumption values('005','05')
go
insert into Consumption values('006','01')
go
insert into Consumption values('007','01')
go
insert into Consumption values('008','01')
go
insert into Consumption values('008','22')
go
insert into Consumption values('009','01')
go
insert into Consumption values('009','22')
go
insert into Consumption values('010','01')
go
insert into Consumption values('011','01')
go
insert into Consumption values('012','01')
go
insert into Consumption values('012','22')
go
insert into Consumption values('013','01')
go
insert into Consumption values('014','01')
go
insert into Consumption values('015','01')
go
insert into Consumption values('015','29')
go

--���뽱ȯ
insert into Coupon(Class,Discount,Equivalent,HandlePerson,Numbers,Remark) values('������',10,0,'100002',1000,null)
go
insert into Coupon(Class,Discount,Equivalent,HandlePerson,Numbers,Remark) values('����ȯ',6,0,'100002',500,null)
go
insert into Coupon(Class,Discount,Equivalent,HandlePerson,Numbers,Remark) values('����ȯ',10,50,'100002',400,null)
go
insert into Coupon(Class,Discount,Equivalent,HandlePerson,Numbers,Remark) values('ԡ��ȯ',10,25,'100002',600,null)
go