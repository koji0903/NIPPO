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

--
-- projects
--
INSERT INTO projects (FY,num,name,delete_flag,share_flag,tentative_flag) VALUES (2013,1,'やるっきゃないプロジェクト','false','false','false');
INSERT INTO projects (FY,num,name,delete_flag,share_flag,tentative_flag) VALUES (2013,2,'WHYから考えよう','false','false','false');

--
-- customers
--
SET @d = (SELECT ID FROM projects WHERE name = 'やるっきゃないプロジェクト');
INSERT INTO customers (code,name,delete_flag,projects_ID) VALUES (0001,'田中薬品','false',@d);
SET @d = (SELECT ID FROM projects WHERE name = 'WHYから考えよう');
INSERT INTO customers (code,name,delete_flag,projects_ID) VALUES (0002,'山田食品','false',@d);
SET @d = (SELECT ID FROM projects WHERE name = 'やるっきゃないプロジェクト');
INSERT INTO customers (code,name,delete_flag,projects_ID) VALUES (0003,'佐藤銀行','false',@d);



--
-- work_reports
--
SET @d = (SELECT ID FROM users WHERE login = '1');
INSERT INTO work_reports (users_ID,year,month,day,FY,start_time,end_time,note) VALUES (@d,2013,12,14,2013,'2013-12-14 8:45:00','2013-12-14 17:30:00','通常勤務');

SET @d = (SELECT ID FROM users WHERE login = '2');
INSERT INTO work_reports (users_ID,year,month,day,FY,start_time,end_time,note) VALUES (@d,2013,12,14,2013,'2013-12-14 8:45:00','2013-12-14 17:30:00','通常勤務');

SET @d = (SELECT ID FROM users WHERE login = '3');
INSERT INTO work_reports (users_ID,year,month,day,FY,start_time,end_time,note) VALUES (@d,2013,12,14,2013,'2013-12-14 8:45:00','2013-12-14 17:30:00','通常勤務');

--
-- work_detail　（特殊扱い）
--
SET @d = (SELECT ID FROM users WHERE login = '1'); -- USERIDを選んで
SET @d = (SELECT ID FROM work_reports WHERE users_ID = @d); -- そのUSERIDから一つをピックアップ（本来は不十分）実際はGUI上で任意のデータを選択 
SET @e = (SELECT ID FROM projects WHERE num = '1');
INSERT INTO work_detail (times,note,work_reports_ID,projects_ID) VALUES ('02:00:00','報告書作成',@d,@e);
INSERT INTO work_detail (times,note,work_reports_ID,projects_ID) VALUES ('02:00:00','会議',@d,@e);
INSERT INTO work_detail (times,note,work_reports_ID,projects_ID) VALUES ('02:00:00','開発',@d,@e);

SET @d = (SELECT ID FROM users WHERE login = '2'); -- USERIDを選んで
SET @d = (SELECT ID FROM work_reports WHERE users_ID = @d); -- そのUSERIDから一つをピックアップ（本来は不十分）実際はGUI上で任意のデータを選択 
SET @e = (SELECT ID FROM projects WHERE num = '2');
INSERT INTO work_detail (times,note,work_reports_ID,projects_ID) VALUES ('02:00:00','仕様検討',@d,@e);
INSERT INTO work_detail (times,note,work_reports_ID,projects_ID) VALUES ('02:00:00','コーディング',@d,@e);
INSERT INTO work_detail (times,note,work_reports_ID,projects_ID) VALUES ('02:00:00','テスト',@d,@e);

SET @d = (SELECT ID FROM users WHERE login = '3'); -- USERIDを選んで
SET @d = (SELECT ID FROM work_reports WHERE users_ID = @d); -- そのUSERIDから一つをピックアップ（本来は不十分）実際はGUI上で任意のデータを選択 
SET @e = (SELECT ID FROM projects WHERE num = '1');
INSERT INTO work_detail (times,note,work_reports_ID,projects_ID) VALUES ('02:00:00','セミナー',@d,@e);
INSERT INTO work_detail (times,note,work_reports_ID,projects_ID) VALUES ('02:00:00','移動',@d,@e);
INSERT INTO work_detail (times,note,work_reports_ID,projects_ID) VALUES ('02:00:00','報告',@d,@e);


---------------------------------------------------------------
-- 表示
---------------------------------------------------------------
SELECT * FROM users;
SELECT * FROM sections;
SELECT users.lastname,users.firstname,sections.name FROM users INNER JOIN sections ON users.sections_ID = sections.ID;
SELECT * FROM business_segments;
SELECT * FROM business_type;
SELECT * FROM business_detail;
SELECT * FROM customers;
SELECT * FROM work_reports;
SELECT * FROM work_detail;
SELECT * FROM projects;