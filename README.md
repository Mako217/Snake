# Snake
Prosta aplikacja konsolowa odwzorowująca klasyczną grę Snake.

## Program

  Program składa się z pętli while, która nieprzerwanie oczekuje wciśnięcia klawisza przez gracza, oraz odlicza czas pozostały do wyświetlenia kolejnej klatki gry.<br/>
  
  Zawiera on również funkcję ***DrawFrame()***, która pobiera wysokość oraz szerokość konsoli, oraz w zależności od nich rysuje obszar gry.

## ClassLibrary

  Jest to biblioteka klas, zawierająca 3 klasy oraz 1 enum. Klasy te są zbiorami funkcji, oraz zmiennych odpowiedzialnych za logikę gry.
  
### Coordinates
  
  Jest to klasa odpowiedzialna za współrzędne x i y obiektów występujących w grze. Z tej klasy korzystają klasy Food oraz SnakeClass.

### Direction
  
  Jest to enum, wyliczający możliwe kierunki ruchu węża ***left***, ***right***, ***up***, oraz ***down***
  
### Food
  
  Jest to klasa odpowiedzialna za pojawianie się w grze jedzenia dla węża.
  Konstruktor tej klasy losuje współrzędne x oraz y.<br/>
  Funkcja ***Draw()*** za pomocą wygenerowanych wcześniej współrzędnych, określa położenie kursora w konsoli, oraz rysuje znak "x"
  
### SnakeClass

  Jest to klasa odpowiedzialna za zapisanie długości węża, kierunku jego ruchu i koordynatów jego głowy, oraz każdej z części jego ogona.<br/>
  SnakeClass składa się z następujących funkcji:
  - ***GameOver()*** - Zwraca wartość true, kiedy głowa węża znajdzie się na tych samych współrzędnych co dowolna część jego ogona, lub gdy wąż dotknie ramki wyznaczającej pole gry.
  - ***Eat()*** - Zwiększa długość węża zapisaną w pamięci. Zapisuje nowy wynik nad ramką.
  - ***Move()*** - Sprawdza w którą stronę porusza się wąż. Co klatkę funkcja ta zmienia współrzędne głowy, a na ich podstawie rysuje w jej miejscu nowy symbol "o".
  Funkcja ta odpowiada również za usuwanie z listy niepotrzebnych części ogona, dzięki czemu rysowany wąż zawsze jest tej samej długości co zmienna Length.

  
