use BC_CMSDB
go

--插入不同的权限
--0级:超级管理员，拥有一切权限
--1级:店长，可查询所有信息，仅可管理价格，可创建子用户
--2级:经理，管理店员信息，会员信息，物资信息，奖券发放，可创建子用户
--3级:前台，管理会员信息，不可创建子用户
--4级:后勤，管理物资信息，不可创建子用户
--5级：普通员工，无权限
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

--插入员工
insert into Employee values('100000','14EE22EABA297944C96AFDBE5B16C65B','管理员',' ',' ',' ',' ','管理员',0,0,' ',' ',0,' ',' ','2020-06-01',1,'2020-06-01',null)
go
insert into Employee values('100001','E2A6A1ACE352668000AED191A817D143','张一','男','汉族','江苏省','共产党员','店长',0,30000,'13900000001','吴江区',1,'235407198106112745','4846168528655371685','1981-06-11',1,'2020-06-01',null)
go
insert into Employee values('100002','BB36C34EB6644AB9694315AF7D68E629','张二','女','汉族','江苏省','共产党员','经理',0,20000,'13900000002','吴江区',2,'210203198503102721','1675348629437615873','1985-03-10',1,'2020-06-01',null)
go
insert into Employee values('100003','3DC81E3F2C523FB5955761BBE2D150F2','张三','女','汉族','江苏省','群众','前台',0,5000,'13900000003','吴江区',3,'130102199303250459','1687953735946852164','1993-03-25',1,'2020-06-01',null)
go
insert into Employee values('100004','1EA85063355FBFAD3DE73AB038261D62','张四','女','汉族','江苏省','群众','前台',0,5000,'13900000004','吴江区',3,'511502199103223189','6287594326849761523','1991-03-22',1,'2020-06-01',null)
go
insert into Employee values('100005','EFD1A2F9B0B5F14B1FAC70A7F8E8A9E7','张五','男','汉族','江苏省','群众','后勤',0,5000,'13900000005','吴江区',4,'431202198811101720','9438951674866248951','1988-11-10',1,'2020-06-01',null)
go
insert into Employee values('100006','758691FDF7AE3403DB0D3BD8AC3AD585','李一','男','汉族','江苏省','群众','后勤',0,5000,'13900000006','吴江区',4,'130821199103278829','1684953289467135863','1991-03-27',1,'2020-06-01',null)
go
insert into Employee values('100007','9E3FC2A6D0F45C7A999AB01EBCACAF94','李二','女','汉族','江苏省','群众','鞋管',0,3000,'13900000007','吴江区',5,'520323198806058856','6897489563021681364','1988-06-05',1,'2020-06-01',null)
go
insert into Employee values('100008','AB24C2FE5B396A574095A73B1AD23356','李三','男','汉族','江苏省','群众','衣管',0,3000,'13900000008','吴江区',5,'350105197506138487','5662167932031648922','1975-06-13',1,'2020-06-01',null)
go
insert into Employee values('100009','795202367B2120E77B231D4D2B98E2B9','李四','女','汉族','江苏省','群众','衣管',0,3000,'13900000009','吴江区',5,'610729198408202551','9516874326984563205','1984-08-20',1,'2020-06-01',null)
go
insert into Employee values('100010','DAA28096F9E8879AB3A02B90AA0E2F83','李五','男','汉族','江苏省','群众','服务员',0,6000,'13900000010','吴江区',5,'820000199508115837','7419658946258613076','1995-08-11',1,'2020-06-01',null)
go
insert into Employee values('100011','09A146C8D1CFDBDB54CEB60EDE93CDAB','王一','女','汉族','江苏省','群众','服务员',0,6000,'13900000011','吴江区',5,'450101199405207446','9517896348603489168','1994-05-20',1,'2020-06-01',null)
go
insert into Employee values('100012','21BF043D935E1499B3749C2F483DF890','王二','女','汉族','江苏省','群众','服务员',0,6000,'13900000012','吴江区',5,'411626199604167401','1579236985562301742','1996-04-16',1,'2020-06-01',null)
go
insert into Employee values('100013','33932D50E450EF3CCFBCF69AC9BA04E5','王三','女','汉族','江苏省','群众','艺妓',0,10000,'13900000013','吴江区',5,'152224199909289211','1579468236478952103','1999-09-28',0,'2020-06-01',null)
go
insert into Employee values('100014','A3C3A95F3E42519D7BA5284CFFCD4E25','王四','男','汉族','江苏省','群众','安保',0,4000,'13900000014','吴江区',5,'230822198201256034','7849512630278562102','1982-01-25',1,'2020-06-01',null)
go
insert into Employee values('100015','E025B5159BBA8890D4F936973D0BCB2F','王五','女','汉族','江苏省','群众','保洁',0,3000,'13900000015','吴江区',5,'235402198407121617','1579445467520546626','1984-07-12',1,'2020-06-01',null)
go

--插入会员
insert into Member values('200001','EE8F208B135D4940DBB80D0335E20A1F','张一','女','120111198912116881','18200000001','吴江区','2020-6-1','100003',300,null)
go
insert into Member values('200002','7DB88CDD3C295D227680B119A479DDFB','张二','女','440282195610226964','18200000002','吴江区','2020-6-1','100003',450,null)
go
insert into Member values('200003','5C74D3DD8616593A3F272F2114354099','张三','男','632223195605199057','18200000003','吴江区','2020-6-1','100004',600,null)
go
insert into Member values('200004','797E5AF4ABD9F8D8E0CF07550E051B5C','张四','女','361125195409090039','18200000004','吴江区','2020-6-1','100003',300,null)
go
insert into Member values('200005','A210495A82B1A68ACB20D201F24DA34B','张五','男','350426196812257489','18200000005','吴江区','2020-6-1','100004',500,null)
go
insert into Member values('200006','302FEDBDF963CA2223BDDD79419730A1','李一','男','441623198701083264','18200000006','吴江区','2020-6-1','100004',200,null)
go
insert into Member values('200007','B48CC8E7E27475244A04F087D6234BE8','李二','女','610724199403025899','18200000007','吴江区','2020-6-1','100004',350,null)
go
insert into Member values('200008','CBD52A6EF80D39C0087A8B34466C11AD','李三','男','51130319560102717X','18200000008','吴江区','2020-6-1','100003',250,null)
go
insert into Member values('200009','AC194A1FD0B26E8ED9B7973BBB8508B0','李四','男','230822197201256344','18200000009','吴江区','2020-6-1','100004',300,null)
go
insert into Member values('200010','33432E31EA9221137C5939101E2157B8','李五','男','152224198908043711','18200000010','吴江区','2020-6-1','100003',320,null)
go
insert into Member values('200011','4CA1B603A91FA6A51CF23F2EAD5E2313','王一','男','654022199371228286','18200000011','吴江区','2020-6-1','100003',550,null)
go
insert into Member values('200012','1FA37726AD9C59AC333417507A6BE14D','王二','女','431202198811101730','18200000012','吴江区','2020-6-1','100003',400,null)
go
insert into Member values('200013','209C8CBC87216C83CE038747E2049917','王三','男','615729197408202551','18200000013','吴江区','2020-6-1','100004',150,null)
go
insert into Member values('200014','76F00AFE3AECB62009D3424F927E6223','王四','女','475101197405207446','18200000014','吴江区','2020-6-1','100004',500,null)
go
insert into Member values('200015','8093B105ED38C24AC4D2601A3B54B4F7','王五','女','520313197806058856','18200000015','吴江区','2020-6-1','100003',300,null)
go

--插入顾客
insert into Consumer values('001','男','200003',null)
go
insert into Consumer values('002','男','000000',null)
go
insert into Consumer values('003','男','000000',null)
go
insert into Consumer values('004','女','000000',null)
go
insert into Consumer values('005','男','200011',null)
go
insert into Consumer values('006','男','000000',null)
go
insert into Consumer values('007','女','200004',null)
go
insert into Consumer values('008','女','000000',null)
go
insert into Consumer values('009','男','000000',null)
go
insert into Consumer values('010','女','200014',null)
go
insert into Consumer values('011','男','000000',null)
go
insert into Consumer values('012','女','200007',null)
go
insert into Consumer values('013','男','200013',null)
go
insert into Consumer values('014','男','000000',null)
go
insert into Consumer values('015','女','000000',null)
go
--插入价格
insert into Price values('01','门票','基础消费',25,12,null)
go
insert into Price values('02','人工费','搓澡',20,10,null)
go
insert into Price values('03','盐浴','搓澡',20,10,null)
go
insert into Price values('04','奶浴','搓澡',20,10,null)
go
insert into Price values('05','搓泥','搓澡',20,10,null)
go
insert into Price values('06','拔罐','搓澡',30,15,null)
go
insert into Price values('07','头部','按摩',30,15,null)
go
insert into Price values('08','后背','按摩',30,15,null)
go
insert into Price values('09','大腿','按摩',30,15,null)
go
insert into Price values('10','小腿','按摩',30,15,null)
go
insert into Price values('11','足部','按摩',30,15,null)
go
insert into Price values('12','全身','按摩',120,60,null)
go
insert into Price values('13','龙井','茶水',70,35,null)
go
insert into Price values('14','毛尖','茶水',60,30,null)
go
insert into Price values('15','乌龙','茶水',60,30,null)
go
insert into Price values('16','普洱','茶水',60,30,null)
go
insert into Price values('17','红茶','茶水',60,30,null)
go
insert into Price values('18','花茶','茶水',40,20,null)
go
insert into Price values('19','拿铁','茶水',30,15,null)
go
insert into Price values('20','美式','茶水',30,15,null)
go
insert into Price values('21','卡布奇诺','茶水',30,15,null)
go
insert into Price values('22','休息室','过夜',70,35,null)
go
insert into Price values('23','客房单间','过夜',100,50,null)
go
insert into Price values('24','客房标准间','过夜',120,60,null)
go
insert into Price values('25','客房大床房','过夜',140,70,null)
go
insert into Price values('26','客房家庭房','过夜',160,80,null)
go
insert into Price values('27','客房棋牌房','过夜',200,100,null)
go
insert into Price values('28','客房影院房','过夜',300,150,null)
go
insert into Price values('29','客房主题房','过夜',500,250,null)
go

--插入收入支出
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('营业额','2019-1-31',0,590000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('水电','2019-1-31',1,9000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('物资','2019-1-31',1,27000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('工资','2019-1-31',1,11400,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('营业额','2019-2-28',0,575000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('水电','2019-2-28',1,86000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('物资','2019-2-28',1,26000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('工资','2019-2-28',1,11400,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('营业额','2019-3-31',0,630000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('水电','2019-3-31',1,11000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('物资','2019-3-31',1,33000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('工资','2019-3-31',1,11400,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('营业额','2019-4-30',0,650000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('水电','2019-4-30',1,13000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('物资','2019-4-30',1,35000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('工资','2019-4-30',1,11400,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('营业额','2019-5-31',0,670000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('水电','2019-5-31',1,15000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('物资','2019-5-31',1,38000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('工资','2019-5-31',1,11400,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('营业额','2019-6-30',0,630000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('水电','2019-6-30',1,12000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('物资','2019-6-30',1,34000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('工资','2019-6-30',1,11400,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('营业额','2019-7-31',0,690000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('水电','2019-7-31',1,16000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('物资','2019-7-31',1,40000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('工资','2019-7-31',1,14400,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('营业额','2019-8-31',0,705000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('水电','2019-8-31',1,19000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('物资','2019-8-31',1,42000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('工资','2019-8-31',1,14400,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('营业额','2019-9-30',0,720000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('水电','2019-9-30',1,20000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('物资','2019-9-30',1,44000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('工资','2019-9-30',1,14400,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('营业额','2019-10-31',0,680000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('水电','2019-10-31',1,18000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('物资','2019-10-31',1,400000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('工资','2019-10-31',1,14400,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('营业额','2019-11-30',0,650000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('水电','2019-11-30',1,13000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('物资','2019-11-30',1,350000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('工资','2019-11-30',1,14400,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('营业额','2019-12-31',0,630000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('水电','2019-12-31',1,12000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('物资','2019-12-31',1,35000,null)
go
insert into Revenue(Class,Date,RevenuesOrExpenditure,Price,Remark) values('工资','2019-12-31',1,14400,null)
go

--插入物资
insert into item values('01','食物','食物',54,100,null)
go
insert into item values('02','毛巾','洗浴',66,100,null)
go
insert into item values('03','牙具','洗浴',33,100,null)
go
insert into item values('04','澡具','洗浴',48,100,null)
go
insert into item values('05','洗发水','洗浴',21,100,null)
go
insert into item values('06','沐浴乳','洗浴',22,100,null)
go
insert into item values('07','衣物','洗浴',66,100,null)
go
insert into item values('08','煤炭','其他',72,100,null)
go
insert into item values('09','茶水','食物',37,100,null)
go

--插入消费
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

--插入奖券
insert into Coupon(Class,Discount,Equivalent,HandlePerson,Numbers,Remark) values('宣传单',10,0,'100002',1000,null)
go
insert into Coupon(Class,Discount,Equivalent,HandlePerson,Numbers,Remark) values('打折券',6,0,'100002',500,null)
go
insert into Coupon(Class,Discount,Equivalent,HandlePerson,Numbers,Remark) values('代金券',10,50,'100002',400,null)
go
insert into Coupon(Class,Discount,Equivalent,HandlePerson,Numbers,Remark) values('浴资券',10,25,'100002',600,null)
go