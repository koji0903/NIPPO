--
-- �e�X�g�f�[�^�쐬�pSQL
--
USE [nippo_db];


---------------------------------------------------------------
-- �������i�S�f�[�^���폜�j
--    �������Ԃ��ԈႦ��Ǝ��s�G���[�ɂȂ�P�[�X����B�����[�V�������l���B�e���珇�Ԃɏ�����OK
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
-- �f�[�^�}��
---------------------------------------------------------------

--
-- sections
--
INSERT INTO sections (code,name,delete_flag) VALUES (1,'�J����','false');
INSERT INTO sections (code,name,delete_flag) VALUES (2,'������','false');


--
-- business_segments
--
INSERT INTO business_segments (FY,code,name,delete_flag) VALUES (2013,1,'�\�t�g�E�F�A�J���{��','false');
INSERT INTO business_segments (FY,code,name,delete_flag) VALUES (2013,2,'�\�����[�V�����J���{��','false');
--
-- business_type
--
SET @d = (SELECT ID FROM business_segments WHERE name = '�\�t�g�E�F�A�J���{��');
INSERT INTO business_type (FY,code,name,delete_flag,business_segments_ID) VALUES (2013,1,'��b','false',@d);
INSERT INTO business_type (FY,code,name,delete_flag,business_segments_ID) VALUES (2013,2,'�X�^���h�A����','false',@d);
INSERT INTO business_type (FY,code,name,delete_flag,business_segments_ID) VALUES (2013,3,'WEB','false',@d);
SET @d = (SELECT ID FROM business_segments WHERE name = '�\�����[�V�����J���{��');
INSERT INTO business_type (FY,code,name,delete_flag,business_segments_ID) VALUES (2013,1,'��b','false',@d);
INSERT INTO business_type (FY,code,name,delete_flag,business_segments_ID) VALUES (2013,2,'�g�ݍ���','false',@d);
INSERT INTO business_type (FY,code,name,delete_flag,business_segments_ID) VALUES (2013,3,'�f�[�^�x�[�X','false',@d);
--
-- business_detail
--
SET @d = (SELECT business_type.ID FROM business_type INNER JOIN business_segments ON business_type.business_segments_ID = business_segments.ID WHERE business_segments.name = '�\�t�g�E�F�A�J���{��' AND business_type.name = '��b');
INSERT INTO business_detail (FY,code,name,delete_flag,business_type_ID) VALUES (2013,1,'�񍐉�','false',@d);
INSERT INTO business_detail (FY,code,name,delete_flag,business_type_ID) VALUES (2013,2,'�G��','false',@d);
SET @d = (SELECT business_type.ID FROM business_type INNER JOIN business_segments ON business_type.business_segments_ID = business_segments.ID WHERE business_segments.name = '�\�t�g�E�F�A�J���{��' AND business_type.name = '�X�^���h�A����');
INSERT INTO business_detail (FY,code,name,delete_flag,business_type_ID) VALUES (2013,1,'�t�H�[���쐬','false',@d);
INSERT INTO business_detail (FY,code,name,delete_flag,business_type_ID) VALUES (2013,2,'�{�^���쐬','false',@d);
SET @d = (SELECT business_type.ID FROM business_type INNER JOIN business_segments ON business_type.business_segments_ID = business_segments.ID WHERE business_segments.name = '�\�t�g�E�F�A�J���{��' AND business_type.name = 'WEB');
INSERT INTO business_detail (FY,code,name,delete_flag,business_type_ID) VALUES (2013,1,'�u���E�U����','false',@d);
INSERT INTO business_detail (FY,code,name,delete_flag,business_type_ID) VALUES (2013,2,'�l�b�g���[�N����','false',@d);
SET @d = (SELECT business_type.ID FROM business_type INNER JOIN business_segments ON business_type.business_segments_ID = business_segments.ID WHERE business_segments.name = '�\�����[�V�����J���{��' AND business_type.name = '��b');
INSERT INTO business_detail (FY,code,name,delete_flag,business_type_ID) VALUES (2013,1,'�Z�~�i�[','false',@d);
INSERT INTO business_detail (FY,code,name,delete_flag,business_type_ID) VALUES (2013,2,'���݉�','false',@d);
SET @d = (SELECT business_type.ID FROM business_type INNER JOIN business_segments ON business_type.business_segments_ID = business_segments.ID WHERE business_segments.name = '�\�����[�V�����J���{��' AND business_type.name = '�g�ݍ���');
INSERT INTO business_detail (FY,code,name,delete_flag,business_type_ID) VALUES (2013,1,'�_��','false',@d);
INSERT INTO business_detail (FY,code,name,delete_flag,business_type_ID) VALUES (2013,2,'�V���|�W�E��','false',@d);
SET @d = (SELECT business_type.ID FROM business_type INNER JOIN business_segments ON business_type.business_segments_ID = business_segments.ID WHERE business_segments.name = '�\�����[�V�����J���{��' AND business_type.name = '�f�[�^�x�[�X');
INSERT INTO business_detail (FY,code,name,delete_flag,business_type_ID) VALUES (2013,1,'�����ݒ�','false',@d);
INSERT INTO business_detail (FY,code,name,delete_flag,business_type_ID) VALUES (2013,2,'�����e�i���X','false',@d);

--
-- user
--   ������GUI����I�����邱�Ƃ�z��i�����l�́AUSER���R�[�h�̑}�����Ɏg�p�j
--
SET @d = (SELECT ID FROM sections WHERE name = '�J����');
INSERT INTO users (login,password,delete_flag,lastname,firstname,sections_ID) VALUES (1,1234,'false','���','���Y',@d);
SET @d = (SELECT ID FROM sections WHERE name = '������');
INSERT INTO users (login,password,delete_flag,lastname,firstname,sections_ID) VALUES (2,1234,'false','�刢�h','��Y',@d);
INSERT INTO users (login,password,delete_flag,lastname,firstname,sections_ID) VALUES (3,1234,'false','�V��','�O�Y',@d);

--
-- projects
--
INSERT INTO projects (FY,num,name,delete_flag,share_flag,tentative_flag) VALUES (2013,1,'��������Ȃ��v���W�F�N�g','false','false','false');
INSERT INTO projects (FY,num,name,delete_flag,share_flag,tentative_flag) VALUES (2013,2,'WHY����l���悤','false','false','false');

--
-- customers
--
SET @d = (SELECT ID FROM projects WHERE name = '��������Ȃ��v���W�F�N�g');
INSERT INTO customers (code,name,delete_flag,projects_ID) VALUES (0001,'�c����i','false',@d);
SET @d = (SELECT ID FROM projects WHERE name = 'WHY����l���悤');
INSERT INTO customers (code,name,delete_flag,projects_ID) VALUES (0002,'�R�c�H�i','false',@d);
SET @d = (SELECT ID FROM projects WHERE name = '��������Ȃ��v���W�F�N�g');
INSERT INTO customers (code,name,delete_flag,projects_ID) VALUES (0003,'������s','false',@d);



--
-- work_reports
--
SET @d = (SELECT ID FROM users WHERE login = '1');
INSERT INTO work_reports (users_ID,year,month,day,FY,start_time,end_time,note) VALUES (@d,2013,12,14,2013,'2013-12-14 8:45:00','2013-12-14 17:30:00','�ʏ�Ζ�');

SET @d = (SELECT ID FROM users WHERE login = '2');
INSERT INTO work_reports (users_ID,year,month,day,FY,start_time,end_time,note) VALUES (@d,2013,12,14,2013,'2013-12-14 8:45:00','2013-12-14 17:30:00','�ʏ�Ζ�');

SET @d = (SELECT ID FROM users WHERE login = '3');
INSERT INTO work_reports (users_ID,year,month,day,FY,start_time,end_time,note) VALUES (@d,2013,12,14,2013,'2013-12-14 8:45:00','2013-12-14 17:30:00','�ʏ�Ζ�');

--
-- work_detail�@�i���ꈵ���j
--
SET @d = (SELECT ID FROM users WHERE login = '1'); -- USERID��I���
SET @d = (SELECT ID FROM work_reports WHERE users_ID = @d); -- ����USERID�������s�b�N�A�b�v�i�{���͕s�\���j���ۂ�GUI��ŔC�ӂ̃f�[�^��I�� 
SET @e = (SELECT ID FROM projects WHERE num = '1');
INSERT INTO work_detail (times,note,work_reports_ID,projects_ID) VALUES ('02:00:00','�񍐏��쐬',@d,@e);
INSERT INTO work_detail (times,note,work_reports_ID,projects_ID) VALUES ('02:00:00','��c',@d,@e);
INSERT INTO work_detail (times,note,work_reports_ID,projects_ID) VALUES ('02:00:00','�J��',@d,@e);

SET @d = (SELECT ID FROM users WHERE login = '2'); -- USERID��I���
SET @d = (SELECT ID FROM work_reports WHERE users_ID = @d); -- ����USERID�������s�b�N�A�b�v�i�{���͕s�\���j���ۂ�GUI��ŔC�ӂ̃f�[�^��I�� 
SET @e = (SELECT ID FROM projects WHERE num = '2');
INSERT INTO work_detail (times,note,work_reports_ID,projects_ID) VALUES ('02:00:00','�d�l����',@d,@e);
INSERT INTO work_detail (times,note,work_reports_ID,projects_ID) VALUES ('02:00:00','�R�[�f�B���O',@d,@e);
INSERT INTO work_detail (times,note,work_reports_ID,projects_ID) VALUES ('02:00:00','�e�X�g',@d,@e);

SET @d = (SELECT ID FROM users WHERE login = '3'); -- USERID��I���
SET @d = (SELECT ID FROM work_reports WHERE users_ID = @d); -- ����USERID�������s�b�N�A�b�v�i�{���͕s�\���j���ۂ�GUI��ŔC�ӂ̃f�[�^��I�� 
SET @e = (SELECT ID FROM projects WHERE num = '1');
INSERT INTO work_detail (times,note,work_reports_ID,projects_ID) VALUES ('02:00:00','�Z�~�i�[',@d,@e);
INSERT INTO work_detail (times,note,work_reports_ID,projects_ID) VALUES ('02:00:00','�ړ�',@d,@e);
INSERT INTO work_detail (times,note,work_reports_ID,projects_ID) VALUES ('02:00:00','��',@d,@e);


---------------------------------------------------------------
-- �\��
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