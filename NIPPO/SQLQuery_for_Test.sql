--
-- テストデータ作成用SQL
--



---------------------------------------------------------------
-- 初期化（全データを削除）
---------------------------------------------------------------
DELETE FROM users;


---------------------------------------------------------------
-- データ挿入
---------------------------------------------------------------
-- user
INSERT INTO users (login,password,delete_flag,lastname,firstname) VALUES (1,1234,'false','功司','土黒')

---------------------------------------------------------------
-- 表示
---------------------------------------------------------------
SELECT * FROM users


