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
INSERT INTO projects (FY,num,name,delete_flag,share_flag,tentative_flag) VALUES (2013,1,'�v���W�F�N�gA','false','false','false');
INSERT INTO projects (FY,num,name,delete_flag,share_flag,tentative_flag) VALUES (2013,2,'�v���W�F�N�gB','false','false','false');
INSERT INTO projects (FY,num,name,delete_flag,share_flag,tentative_flag) VALUES (2013,3,'�v���W�F�N�gC','false','false','false');

--
-- tasks
--
INSERT INTO tasks (code, name, delete_flag ) VALUES (1, '��������', 'false' );
INSERT INTO tasks (code, name, delete_flag ) VALUES (2, '�J��', 'false' );
INSERT INTO tasks (code, name, delete_flag ) VALUES (3, '��', 'false' );

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
INSERT INTO work_reports (users_ID,year,month,day,FY,start_time,end_time,note) VALUES (@d,2013,12,15,2013,'2013-12-15 8:45:00','2013-12-14 17:30:00','�ʏ�Ζ�');
--INSERT INTO work_reports (users_ID,year,month,day,FY,start_time,end_time,note) VALUES (@d,2013,12,16,2013,'2013-12-16 8:45:00','2013-12-14 17:30:00','�ʏ�Ζ�');

SET @d = (SELECT ID FROM users WHERE login = '2');
INSERT INTO work_reports (users_ID,year,month,day,FY,start_time,end_time,note) VALUES (@d,2013,12,14,2013,'2013-12-14 8:45:00','2013-12-14 17:30:00','�ʏ�Ζ�');

SET @d = (SELECT ID FROM users WHERE login = '3');
INSERT INTO work_reports (users_ID,year,month,day,FY,start_time,end_time,note) VALUES (@d,2013,12,14,2013,'2013-12-14 8:45:00','2013-12-14 17:30:00','�ʏ�Ζ�');

--
-- work_detail�@�i���ꈵ���j
--
DECLARE @work_report_id INT;
DECLARE @project_id INT;
DECLARE @task_id INT;
--DECLARE @ids INT(100);

-- �^�[�Q�b�g��User ID�{�N����
SET @d = (SELECT ID FROM users WHERE login = '1'); 
-- ���̃��[�U�ɊY�����郏�[�N���|�[�g�𒊏o
--SET @ids = (SELECT ID, users_ID,note FROM work_reports WHERE users_ID = @d); -- ����USERID�������s�b�N�A�b�v�i�{���͕s�\���j���ۂ�GUI��ŔC�ӂ̃f�[�^��I�� 

SET @work_report_id = (SELECT ID FROM work_reports WHERE users_ID = @d AND year = '2013' AND MONTH = '12' AND DAY = '14');
SET @project_id = (SELECT ID FROM projects WHERE num = '1');
SET @task_id = (SELECT ID FROM tasks WHERE code = '1');
INSERT INTO work_detail (times,note,work_reports_ID,projects_ID,tasks_ID) VALUES ('2.00','�����P',@work_report_id,@project_id,@task_id);
SET @project_id = (SELECT ID FROM projects WHERE num = '2');
SET @task_id = (SELECT ID FROM tasks WHERE code = '2');
INSERT INTO work_detail (times,note,work_reports_ID,projects_ID,tasks_ID) VALUES ('2.00','�����Q',@work_report_id,@project_id,@task_id);
SET @project_id = (SELECT ID FROM projects WHERE num = '2');
SET @task_id = (SELECT ID FROM tasks WHERE code = '3');
INSERT INTO work_detail (times,note,work_reports_ID,projects_ID,tasks_ID) VALUES ('2.00','�����R',@work_report_id,@project_id,@task_id);

SELECT projects.ID, projects.name, tasks.name, work_detail.note, work_detail.times FROM work_detail INNER JOIN projects ON work_detail.projects_ID = projects.ID INNER JOIN tasks ON work_detail.tasks_ID = tasks.ID;



---------------------------------------------------------------
-- �\��
---------------------------------------------------------------
--SELECT * FROM users;
--SELECT * FROM sections;
--SELECT users.lastname,users.firstname,sections.name FROM users INNER JOIN sections ON users.sections_ID = sections.ID;
--SELECT * FROM business_segments;
--SELECT * FROM business_type;
--SELECT * FROM business_detail;
--SELECT * FROM customers;
--SELECT * FROM work_reports;
--SET @d = (SELECT ID FROM users WHERE login = '1'); -- USERID��I���
--SELECT * FROM work_reports WHERE users_ID = @d;
--SELECT * FROM work_reports;
--SELECT * FROM work_detail;
--SELECT projects.name, tasks.name FROM work_detail INNER JOIN projects ON work_detail.projects_ID = projects.ID INNER JOIN tasks ON work_detail.tasks_ID = tasks.ID;
--SELECT * FROM projects;