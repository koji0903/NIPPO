--
-- テストデータ作成用SQL
--
USE [nippo_db];


---------------------------------------------------------------
-- 初期化（全データを削除）
--    消す順番を間違えると実行エラーになるケースあり。リレーションを考慮。親から順番に消せばOK
---------------------------------------------------------------
DELETE FROM work_detail;
DELETE FROM customers;
DELETE FROM projects;
DELETE FROM tasks;
DELETE FROM work_reports;
DELETE FROM users;
DELETE FROM sections;
DELETE FROM business_detail;
DELETE FROM business_type;
DELETE FROM business_segments;

DECLARE @d INT;
DECLARE @e INT;


---------------------------------------------------------------
-- データ挿入
---------------------------------------------------------------

--
-- sections
--
INSERT INTO sections (code,name,delete_flag) VALUES (1,'開発部','false');
INSERT INTO sections (code,name,delete_flag) VALUES (2,'総務部','false');


--
-- business_segments
--
INSERT INTO business_segments (FY,code,name,delete_flag) VALUES (2013,1,'ソフトウェア開発本部','false');
INSERT INTO business_segments (FY,code,name,delete_flag) VALUES (2013,2,'ソリューション開発本部','false');
--
-- business_type
--
SET @d = (SELECT ID FROM business_segments WHERE name = 'ソフトウェア開発本部');
INSERT INTO business_type (FY,code,name,delete_flag,business_segments_ID) VALUES (2013,1,'基礎','false',@d);
INSERT INTO business_type (FY,code,name,delete_flag,business_segments_ID) VALUES (2013,2,'スタンドアロン','false',@d);
INSERT INTO business_type (FY,code,name,delete_flag,business_segments_ID) VALUES (2013,3,'WEB','false',@d);
SET @d = (SELECT ID FROM business_segments WHERE name = 'ソリューション開発本部');
INSERT INTO business_type (FY,code,name,delete_flag,business_segments_ID) VALUES (2013,1,'基礎','false',@d);
INSERT INTO business_type (FY,code,name,delete_flag,business_segments_ID) VALUES (2013,2,'組み込み','false',@d);
INSERT INTO business_type (FY,code,name,delete_flag,business_segments_ID) VALUES (2013,3,'データベース','false',@d);
--
-- business_detail
--
SET @d = (SELECT business_type.ID FROM business_type INNER JOIN business_segments ON business_type.business_segments_ID = business_segments.ID WHERE business_segments.name = 'ソフトウェア開発本部' AND business_type.name = '基礎');
INSERT INTO business_detail (FY,code,name,delete_flag,business_type_ID) VALUES (2013,1,'報告会','false',@d);
INSERT INTO business_detail (FY,code,name,delete_flag,business_type_ID) VALUES (2013,2,'雑務','false',@d);
SET @d = (SELECT business_type.ID FROM business_type INNER JOIN business_segments ON business_type.business_segments_ID = business_segments.ID WHERE business_segments.name = 'ソフトウェア開発本部' AND business_type.name = 'スタンドアロン');
INSERT INTO business_detail (FY,code,name,delete_flag,business_type_ID) VALUES (2013,1,'フォーム作成','false',@d);
INSERT INTO business_detail (FY,code,name,delete_flag,business_type_ID) VALUES (2013,2,'ボタン作成','false',@d);
SET @d = (SELECT business_type.ID FROM business_type INNER JOIN business_segments ON business_type.business_segments_ID = business_segments.ID WHERE business_segments.name = 'ソフトウェア開発本部' AND business_type.name = 'WEB');
INSERT INTO business_detail (FY,code,name,delete_flag,business_type_ID) VALUES (2013,1,'ブラウザ調査','false',@d);
INSERT INTO business_detail (FY,code,name,delete_flag,business_type_ID) VALUES (2013,2,'ネットワーク調査','false',@d);
SET @d = (SELECT business_type.ID FROM business_type INNER JOIN business_segments ON business_type.business_segments_ID = business_segments.ID WHERE business_segments.name = 'ソリューション開発本部' AND business_type.name = '基礎');
INSERT INTO business_detail (FY,code,name,delete_flag,business_type_ID) VALUES (2013,1,'セミナー','false',@d);
INSERT INTO business_detail (FY,code,name,delete_flag,business_type_ID) VALUES (2013,2,'飲み会','false',@d);
SET @d = (SELECT business_type.ID FROM business_type INNER JOIN business_segments ON business_type.business_segments_ID = business_segments.ID WHERE business_segments.name = 'ソリューション開発本部' AND business_type.name = '組み込み');
INSERT INTO business_detail (FY,code,name,delete_flag,business_type_ID) VALUES (2013,1,'農業','false',@d);
INSERT INTO business_detail (FY,code,name,delete_flag,business_type_ID) VALUES (2013,2,'シンポジウム','false',@d);
SET @d = (SELECT business_type.ID FROM business_type INNER JOIN business_segments ON business_type.business_segments_ID = business_segments.ID WHERE business_segments.name = 'ソリューション開発本部' AND business_type.name = 'データベース');
INSERT INTO business_detail (FY,code,name,delete_flag,business_type_ID) VALUES (2013,1,'初期設定','false',@d);
INSERT INTO business_detail (FY,code,name,delete_flag,business_type_ID) VALUES (2013,2,'メンテナンス','false',@d);

--
-- user
--   所属はGUIから選択することを想定（得た値は、USERレコードの挿入時に使用）
--
SET @d = (SELECT ID FROM sections WHERE name = '開発部');
INSERT INTO users (login,password,delete_flag,lastname,firstname,sections_ID) VALUES (1,1234,'false','肥後','太郎',@d);
SET @d = (SELECT ID FROM sections WHERE name = '総務部');
INSERT INTO users (login,password,delete_flag,lastname,firstname,sections_ID) VALUES (2,1234,'false','大阿蘇','二郎',@d);
INSERT INTO users (login,password,delete_flag,lastname,firstname,sections_ID) VALUES (3,1234,'false','天草','三郎',@d);
INSERT INTO users (login,password,delete_flag,lastname,firstname,sections_ID) VALUES (4,1234,'false','櫻木','誠',@d);
INSERT INTO users (login,password,delete_flag,lastname,firstname) VALUES (5,1234,'false','櫻木','ダミー');
SET @d = (SELECT ID FROM sections WHERE name = '開発部');
INSERT INTO users (login,password,delete_flag,lastname,firstname,sections_ID) VALUES ('6','goal','false','本田','圭右',@d);
INSERT INTO users (login,password,delete_flag,lastname,firstname,sections_ID) VALUES ('7','@-!=?','false','長友','佑都',@d);
INSERT INTO users (login,password,delete_flag,lastname,firstname,sections_ID) VALUES ('10','0123','false','香川','真司',@d);
INSERT INTO users (login,password,delete_flag,lastname,firstname,sections_ID) VALUES ('01','Kakitani','false','柿谷','曜一朗',@d);
INSERT INTO users (login,password,delete_flag,lastname,firstname,sections_ID) VALUES ('02','ほたる','false','山口','蛍',@d);
INSERT INTO users (login,password,delete_flag,lastname,firstname,sections_ID) VALUES ('001','','false','遠藤','保仁',@d);
INSERT INTO users (login,password,delete_flag,lastname,firstname,sections_ID) VALUES ('002','岡崎','false','岡崎','慎司',@d);
INSERT INTO users (login,password,delete_flag,lastname,firstname,sections_ID) VALUES ('003','Zac@0401','false','Zaccheroni','Alberto',@d);
INSERT INTO users (login,password,delete_flag,lastname,firstname,sections_ID) VALUES ('7204382','Naoki.Otani','false','大谷','直毅',@d);


--
-- projects
--
INSERT INTO projects (FY,num,name,delete_flag,share_flag,tentative_flag) VALUES (2013,1,'プロジェクトA','false','false','false');
INSERT INTO projects (FY,num,name,delete_flag,share_flag,tentative_flag) VALUES (2013,2,'プロジェクトB','false','false','false');
INSERT INTO projects (FY,num,name,delete_flag,share_flag,tentative_flag) VALUES (2013,3,'プロジェクトC','false','false','false');
INSERT INTO projects (FY,num,name,delete_flag,share_flag,tentative_flag) VALUES (2013,10,'登録テスト用プロジェクト','false','false','false');

--
-- tasks
--
INSERT INTO tasks (code, name, delete_flag ) VALUES (1, '事務処理', 'false' );
INSERT INTO tasks (code, name, delete_flag ) VALUES (2, '開発', 'false' );
INSERT INTO tasks (code, name, delete_flag ) VALUES (3, '報告', 'false' );
INSERT INTO tasks (code, name, delete_flag ) VALUES (10, '登録テスト用タスク', 'false' );

--
-- customers
--
SET @d = (SELECT ID FROM projects WHERE name = 'プロジェクトA');
INSERT INTO customers (code,name,delete_flag,projects_ID) VALUES (0001,'田中薬品','false',@d);
SET @d = (SELECT ID FROM projects WHERE name = 'プロジェクトB');
INSERT INTO customers (code,name,delete_flag,projects_ID) VALUES (0002,'山田食品','false',@d);
SET @d = (SELECT ID FROM projects WHERE name = 'プロジェクトC');
INSERT INTO customers (code,name,delete_flag,projects_ID) VALUES (0003,'佐藤銀行','false',@d);



--
-- work_reports
--
SET @d = (SELECT ID FROM users WHERE login = '1');
INSERT INTO work_reports (users_ID,year,month,day,FY,start_time,end_time,note) VALUES (@d,2013,12,14,2013,'2013-12-14 8:45:00','2013-12-14 17:30:00','通常勤務');
INSERT INTO work_reports (users_ID,year,month,day,FY,start_time,end_time,note) VALUES (@d,2013,12,15,2013,'2013-12-15 8:45:00','2013-12-14 17:30:00','通常勤務');
--INSERT INTO work_reports (users_ID,year,month,day,FY,start_time,end_time,note) VALUES (@d,2013,12,16,2013,'2013-12-16 8:45:00','2013-12-14 17:30:00','通常勤務');

SET @d = (SELECT ID FROM users WHERE login = '2');
INSERT INTO work_reports (users_ID,year,month,day,FY,start_time,end_time,note) VALUES (@d,2013,12,14,2013,'2013-12-14 8:45:00','2013-12-14 17:30:00','通常勤務');

SET @d = (SELECT ID FROM users WHERE login = '3');
INSERT INTO work_reports (users_ID,year,month,day,FY,start_time,end_time,note) VALUES (@d,2013,12,14,2013,'2013-12-14 8:45:00','2013-12-14 17:30:00','通常勤務');

SET @d = (SELECT ID FROM users WHERE login = '4');
INSERT INTO work_reports (users_ID,year,month,day,FY,start_time,end_time,work_times,overtime125,overtime150)
VALUES (@d,2013,12,1,2013,'2013-12-01 8:45:00','2013-12-01 17:30:00',7.75,0.00,0.00);
INSERT INTO work_reports (users_ID,year,month,day,FY,start_time,end_time,work_times,overtime125,overtime150)
VALUES (@d,2013,12,2,2013,'2013-12-02 8:45:00','2013-12-02 19:00:00',8.75,1.00,0.00);
INSERT INTO work_reports (users_ID,year,month,day,FY,start_time,end_time,work_times,overtime125,overtime150)
VALUES (@d,2013,12,3,2013,'2013-12-03 8:45:00','2013-12-03 23:00:00',12.75,4.00,1.00);
INSERT INTO work_reports (users_ID,year,month,day,FY,start_time,end_time,work_times,overtime125,overtime150)
VALUES (@d,2013,12,4,2013,'2013-12-04 8:45:00','2013-12-04 17:30:00',7.75,0.00,0.00);
INSERT INTO work_reports (users_ID,year,month,day,FY,start_time,end_time,work_times,overtime125,overtime150)
VALUES (@d,2013,12,7,2013,'2013-12-07 8:45:00','2013-12-07 18:30:00',7.75,0.50,0.00);
INSERT INTO work_reports (users_ID,year,month,day,FY,start_time,end_time,work_times,overtime125,overtime150)
VALUES (@d,2013,12,14,2013,'2013-12-14 8:45:00','2013-12-14 17:30:00',7.75,0.00,0.00);

--
-- work_detail　（特殊扱い）
--
DECLARE @work_report_id INT;
DECLARE @project_id INT;
DECLARE @task_id INT;
--DECLARE @ids INT(100);

-- ターゲットのUser ID＋年月日
SET @d = (SELECT ID FROM users WHERE login = '1'); 
-- そのユーザに該当するワークレポートを抽出
--SET @ids = (SELECT ID, users_ID,note FROM work_reports WHERE users_ID = @d); -- そのUSERIDから一つをピックアップ（本来は不十分）実際はGUI上で任意のデータを選択 

SET @work_report_id = (SELECT ID FROM work_reports WHERE users_ID = @d AND year = '2013' AND MONTH = '12' AND DAY = '14');
SET @project_id = (SELECT ID FROM projects WHERE num = '1');
SET @task_id = (SELECT ID FROM tasks WHERE code = '1');
INSERT INTO work_detail (times,note,work_reports_ID,projects_ID,tasks_ID) VALUES ('2.00','メモ１',@work_report_id,@project_id,@task_id);
SET @project_id = (SELECT ID FROM projects WHERE num = '2');
SET @task_id = (SELECT ID FROM tasks WHERE code = '2');
INSERT INTO work_detail (times,note,work_reports_ID,projects_ID,tasks_ID) VALUES ('2.00','メモ２',@work_report_id,@project_id,@task_id);
SET @project_id = (SELECT ID FROM projects WHERE num = '2');
SET @task_id = (SELECT ID FROM tasks WHERE code = '3');
INSERT INTO work_detail (times,note,work_reports_ID,projects_ID,tasks_ID) VALUES ('2.00','メモ３',@work_report_id,@project_id,@task_id);

-- 日報入力ウィンドウに表示する情報
SET @d = (SELECT ID FROM users WHERE login = '1'); 
SET @work_report_id = (SELECT ID FROM work_reports WHERE users_ID = @d AND year = '2013' AND month = '12' AND day = '14');

SELECT work_detail.work_reports_ID, projects.name, tasks.name, work_detail.note, work_detail.times, work_reports_ID, projects.ID, tasks.ID	
FROM work_detail INNER JOIN projects 
ON work_detail.projects_ID = projects.ID INNER JOIN tasks 
ON work_detail.tasks_ID = tasks.ID
WHERE work_detail.work_reports_ID = @work_report_id;

SELECT work_detail.work_reports_ID, projects.name, tasks.name, work_detail.note, work_detail.times, work_reports_ID, projects_ID, tasks_ID	
FROM work_detail INNER JOIN projects 
ON work_detail.projects_ID = projects.ID INNER JOIN tasks 
ON work_detail.tasks_ID = tasks.ID
WHERE work_detail.work_reports_ID = @work_report_id;

--
-- holidays
--
insert into holidays (year,month,day,name) values (2013,12,1,'日')
insert into holidays (year,month,day,name) values (2013,12,7,'土')
insert into holidays (year,month,day,name) values (2013,12,8,'日')
insert into holidays (year,month,day,name) values (2013,12,14,'土')
insert into holidays (year,month,day,name) values (2013,12,15,'日')
insert into holidays (year,month,day,name) values (2013,12,21,'土')
insert into holidays (year,month,day,name) values (2013,12,22,'日')
insert into holidays (year,month,day,name) values (2013,12,23,'天皇誕生日')
insert into holidays (year,month,day,name) values (2013,12,28,'土')
insert into holidays (year,month,day,name) values (2013,12,29,'日')
insert into holidays (year,month,day,name) values (2013,12,30,'冬期休暇')
insert into holidays (year,month,day,name) values (2013,12,31,'冬期休暇')

---------------------------------------------------------------
-- 表示
---------------------------------------------------------------
--SELECT * FROM users;
--SELECT * FROM sections;
--SELECT users.lastname,users.firstname,sections.name FROM users INNER JOIN sections ON users.sections_ID = sections.ID;
--SELECT * FROM business_segments;
--SELECT * FROM business_type;
--SELECT * FROM business_detail;
--SELECT * FROM customers;
--SELECT * FROM work_reports;
--SET @d = (SELECT ID FROM users WHERE login = '1'); -- USERIDを選んで
--SELECT * FROM work_reports WHERE users_ID = @d;
--SELECT * FROM work_reports;
SELECT * FROM work_detail;
--SELECT projects.name, tasks.name FROM work_detail INNER JOIN projects ON work_detail.projects_ID = projects.ID INNER JOIN tasks ON work_detail.tasks_ID = tasks.ID;
--SELECT * FROM projects;
--SELECT * FROM projects;
--SELECT * FROM tasks;