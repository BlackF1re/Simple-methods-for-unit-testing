CREATE TABLE "Users" (
	"id"	INTEGER NOT NULL UNIQUE,
	"login"	TEXT NOT NULL,
	"pwd"	TEXT NOT NULL,
	"email"	TEXT,
	"birthday"	TEXT,
	PRIMARY KEY("id" AUTOINCREMENT)
);