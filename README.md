Здраствуйте, уважаемое жюри хакатона "Вездекод"! Мы, команда FTIT рады представить
вам наше решение в категории Gamedev "Вездекодер против мостов!"

Ссылка на игру - https://vcode-gamedev.flint3s.ru/
(Игра писалсь для full-hd разрешения 1920x1080, поэтому прошу раскрыавть игру на **ПОЛНЫЙ ЭКРАН**,
***в правом нижнем углу кнопка для раскрытия***)
Управление - кнопки **WASD**

Данная игра немного вдохновлена головоломками, где у игрока есть возможность нажатия на
кнопки, которые определенным образом (исходя из тех условий, при которых кнопка нажимается)
активируют какие-то предметы (например, включают лампочки), а цель игрока - добится 
нужной комбинации (зажечь все лампочки). Однако, во-первых, тут у нас не лампочки, а мосты,
которые разделяют нашего Вездекодера от заветной цели - написать Вездекод, плюс по пути
с нашем игроком случается всякое.

Сюжет: Как уже было сказано ранее - игрок - это Вездекодер, которому предстоит
написать финал Вездекода (о сюжете можно узнать во время игры, посредством активации
подсказок в правом верхнем углу). Наш вездекодер немного запозднился, и, чтобы успеть вовремя,
он немножечко взломал центр управления мостами Санкт-Петербурга (Чтобы идти напрямик,
а не в обход). Однако наш Вездекодер еще не овладел искусством взлома в совершенстве, поэтому что-то там
напуталось и ему приходится по пути в офис ВК разгадывать нужную комбинацию, чтобы пройти по нужному мосту.

Так же по пути Вездекодеру часто не везет: то пойдет дождь, то мышку дома забудет, в общем
и с этими проблемами ему придется разбираться на ходу. (Подробности всех ивентов кратко расписаны далее)

Описания решений по баллам:

**10 баллов - все текстуры были отрисованы самостоятельно (что заметно), и находятся
в репозитории гит, в папке Assets/Resources (там же текстуры DLC)**


**20 баллов - UI-элементы:**

Кнопки активации каких-то мостов (зависит от уровня) 
(находятся внизу экрана, со знаком вопроса),
кнопка справки (она же кнопка паузы) - правый верхний угол, и активация DLC - правый нижний 
(о нем еще подробнее далее). Управление игроком осуществляется посредством **WASD**, 
в рамках намеченной дороги.


**30 баллов - События:**

*Текстовые*: на первом уровне это событие забытой мышки. За ней нужно вернуться домой,
а иначе продвинуться дальше будет нельзя.
На втором уровне - это дождь. Наш вездекодер несет в рюкзаке ноутбук, который мочить
не рекомендуется. Игроку предлагается вернуться домой за зонтом, однако, он
может и рискнуть и попробовать добраться до офиса без зонта. В случае риска, когда
игрок доберется до офиса, с шансом 50 на 50 он либо замочит ноут, либо все обойдется.
Если же игрок не захочет рисковать - ему придется вернуться домой за зонтом, но
тогда игра закончется успешно в 100% случаев.
Если ноут замочен - уровень перезагружается. Если все хорошо - то при нажатии
на "ОК" в диалоговом окне игра перезапустится с первого уровня.

*Активные*: активное событие в игре есть на первом уровне, если от дома пойти не к офису,
а по дороге влево (левый нижний угол). Тогда активируется событие "Организаторы Вездекода
расстроились, что вездекодер где-то гуляет". Мир станет черно-белым и пойдет дождь, событие
повлияет только на визуальную составляющую окружающего мира.


**40 баллов - DLC и звуки**

В игре добавлено одно DLC, которое активируется/деактивируется при нажатии на кнопку "DLC"
в нижнем правом углу. Тогда мир немного преображается: дом Вездекодера становится обклеян
наклейками Вездекода, а сам Вездекодер пересаживается на байк, который перемещается быстрее (
Однако порой на байке сложнее войти в поворот, однако въехать и проехаться можно все равно
по любой дороге в игре - возможно понадобится чуть больше времени, чтобы "войти в поворот")
Звуковое оформление: в игру добавлены звуки (скачены из открытых источников):
Фоновая музыка, звуки байка (в том числе в неподвижном положении свой звук),
звуки шагов, поднятия мостов, звуки выскакивания некоторых диалогов, звуки дождя.


**50 баллов: Игра**

В итоге из всего получилась сюжетная двух-уровневая игра с 1 DLC, со своими уникальными событиями и разводом
мостов на каждом уровне.

Спасибо за прекрасный конкурс, и до новых встреч!

-
С уважением,
Команда FTIT
