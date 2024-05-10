# Диагностика материнской платы GIGABYTE B660 DS3H
---
## Алгоритм работы разрабатываемого приложения:
1. Программа написана на WPF с использованием C#.
2. В первую очередь при запуске приложения нужно нажать кнопку "Запустить ПК".
3. Компьютер не запустится, нужно его выключить и начать искать неисправности.
4. Неисправности генерируются на случайных элементах платы по 2-3 штуки.
5. Поиск неисправности осуществляется применением конкретных инструментов к конкретным элементам платы.
       
__Например: Выбран осциллограф, нажата кнопка SOCKET. Частота на сокете равна ... МГц.__

6. Если пользователь считает, что на данном элементе неисправность, то он нажимает кнопку "отремонтировать" и выбирает действие, которое приведёт к починке данного элемента.
7. После починки всех неисправностей кнока __"Запустить ПК"__ выдаёт сообщение о том, что ПК запустился.
8. Можно нажать кнопку "Начать сначала" и все неисправности сгенерируются заново.
---
## Инструкция
1. В первую очередь попробовать запустить ПК.
2. ПК не запускается, нужно приступить к поиску неисправностей.
3. Нажимайте разными инструментами в разные элементы платы и смотрите на характеристики.
4. Если считаете, что где-то показатели отклоняются от нормы, то примите меры в меню __"отремонтировать"__.
5. Когда все неисправности будут исправлены ПК запустится, а вы молодец.     

---
## Текущие неисправности платы и их решения:
|Неисправности                                               |Решения неисправностей   |      
|---                                                         |---|
|Короткое замыкание на линиях +12В, +5В, +3.3В               |Выполнить поиск неисправного элемента используя схему последовательного запуска и формирования определенных сигналов на контрольных точках|
|Неисправен южный мост                                       |Замена южного моста|
|Неисправность микросхемы BIOS, либо ее прошивки             |Перепрошивка микросхемы BIOS, либо замена в случае ее неисправности   |
|Неисправность RTC                                           |Перепайка кварцевого резонатора, поиск неисправности в системе питания, замена южного моста   |
|Проблемы с разъемом видеокарты, либо линиями передачи данных|Выполнить восстановление линий передачи данных, заменить разъем видеокарты   |
---
## Разрабатывали:
- Старков Александр (Crybaba) - __Всех пинал и немного коммитил__
- Юсупов Иван (MAKKKINTOSH) - __Лидер проекта и просто хороший человек__
- Юсупова Юлия (Soukokku) - __Программист__
- Юдина Елена (eleleech) - __Программист__
- Мжельская Жанна (Mzhelskaya) - __Программист__
