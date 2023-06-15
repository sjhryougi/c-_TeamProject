# 2023-1 응용소프트웨어실습 팀프로젝트
# 프로젝트 소개
## TodoList
![스크린샷 2023-06-14 223315](https://github.com/sjhryougi/c-_TeamProject/assets/104803807/f0948d24-af35-424c-b3a7-2ba8636cee39)
- 캘린더를 통한 일정 추가 및 삭제
- 일정 달성 시의 체크 및 해제
- 친구의 일정 확인
- 친구와의 채팅 기능
***
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

id - 사용자의 아이디 (VARCHAR(15))

password - 사용자의 비밀번호 (VARCHAR(20))
### todo
todolist의 데이터를 기록한 테이블

id - 사용자의 id(varchar(15))

date - 해당 list의 날짜(varchar(20))

text - list의 내용 (varchar(100))

check - 해당 list를 check했는지 기록(TINYINT), (0 -> not check,  1 -> check)
### chat
채팅 데이터를 기록한 테이블

sender_id - 보내는 사람의 id(varchar(15))

receiver_id - 받는 사람의 id (varchar(15))

content - 채팅 내용 (TEXT)

time - 채팅을 보낸 시간 (DATETIME)
### friend
친구 데이터를 기록한 테이블

my_id - 사용자의 uid(varchar(15))

friend_id - 사용자 친구의 uid(varchar(15))
### isfriend
친구 신청 유무를 확인하기 위한 db


sender - 친구 신청을 보낸 사람의 id(varchar(15))


receiver - 친구 신청을 받은 사람의 id(varchar(15))


