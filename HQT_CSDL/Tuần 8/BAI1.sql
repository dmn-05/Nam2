CREATE DATABASE GHIDANH

ON PRIMARY(
	NAME = GHIDANH,
	FILENAME ='D:\0306231316\GHIDANH.MDF',
	SIZE = 20,
	MAXSIZE = 40,
	FILEGROWTH = 1
)

LOG ON(
	NAME = GHIDANH_LOG,
	FILENAME ='D:\0306231316\GHIDANH_LOG.LDF',
	SIZE = 6,
	MAXSIZE = 8,
	FILEGROWTH = 1
)
