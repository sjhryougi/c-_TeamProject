# 2023-1 응용소프트웨어실습 팀프로젝트
## 팀장
### 2019203074 서정호
## 팀원
### 2018203091 정호윤
### 2017203034 원일환
### 2020203032 윤선경
***
## SQL Table
### account
사용자의 데이터를 기록한 테이블

uid - 사용자의 고유 번호 (INT) 

id - 사용자의 아이디 (VARCHAR(15))

password - 사용자의 비밀번호 (VARCHAR(20))
### todo
todolist의 데이터를 기록한 테이블

uid - 사용자의 고유 번호(INT) 

date - 해당 list의 날짜(DATE)

text - list의 내용 (TEXT)

check - 해당 list를 check했는지 기록(TINYINT), (0 -> not check,  1 -> check)
### chat
채팅 데이터를 기록한 테이블

sender - 보내는 사람의 uid(INT)

receiver - 받는 사람의 uid (INT)

content - 채팅 내용 (TEXT)

TIME - 채팅을 보낸 시간 (DATE)
### friend
친구 데이터를 기록한 테이블

my_uid - 사용자의 uid(INT)

friend_uid - 사용자 친구의 uid(INT)



