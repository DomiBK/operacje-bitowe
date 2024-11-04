# operacje-bitowe
Operacje bitowe to manipulacje na pojedynczych bitach liczby (0 i 1), które można wykonywać w celu uzyskania bardzo wydajnych obliczeń, szczególnie przy niskopoziomowych operacjach, takich jak optymalizacja algorytmów, zarządzanie pamięcią czy operacje na fladze. W C# operacje na bitach są szczególnie przydatne, gdy zależy nam na minimalizacji użycia zasobów lub czasu obliczeń. Oto krótki przegląd najczęstszych operacji bitowych oraz ich efektywności i zastosowań.

1. Podstawowe operacje bitowe w C#
W C# podstawowe operacje na bitach wykonywane są za pomocą operatorów:

& – AND (koniunkcja)
| – OR (alternatywa)
^ – XOR (alternatywa wykluczająca)
~ – NOT (negacja)
<< – przesunięcie w lewo
>> – przesunięcie w prawo


2. Efektywność operacji bitowych
Operacje bitowe są szybkie, ponieważ odbywają się bezpośrednio na poziomie procesora, który wykonuje je bez dodatkowego przetwarzania. Są z reguły bardziej efektywne niż ich odpowiedniki arytmetyczne i logiczne, np.:

a << 1 (przesunięcie w lewo o jeden bit) odpowiada mnożeniu przez 2.
a >> 1 (przesunięcie w prawo o jeden bit) odpowiada dzieleniu przez 2.
Przykład: Efektywne mnożenie przez potęgi 2
Zamiast mnożyć liczby przez 2, 4, 8, itd., można użyć przesunięcia bitowego:




3. Przykłady zastosowań
A. Ustalanie i sprawdzanie flag
Bity w liczbie całkowitej można traktować jako flagi, co pozwala na oszczędne zarządzanie stanami:


B. Przełączanie stanów
Operacja XOR (^) pozwala na łatwe przełączanie stanów flag:




C. Szybkie obliczenia, np. obliczanie wartości maksymalnej potęgi 2
Bitowe operacje przesunięcia są przydatne w operacjach takich jak znajdowanie najbliższej potęgi 2:




4. Efektywność operacji bitowych w algorytmach
Operacje bitowe są używane tam, gdzie liczy się wydajność, np.:

Kompresja danych – operacje na bitach są przydatne przy tworzeniu struktur danych takich jak bitmapy czy filtry Bloom.
Kryptografia – operacje XOR, przesunięcie i maskowanie są podstawą wielu algorytmów kryptograficznych.
Gry komputerowe – bitmaski są stosowane do zarządzania stanami obiektów (np. AI, animacje).
Algorytmy wyszukiwania i sortowania – bitowe optymalizacje pozwalają zaoszczędzić zasoby podczas przeszukiwania struktur takich jak drzewa lub stosy.
Podsumowanie
Operacje bitowe w C# umożliwiają znaczne przyspieszenie wykonywania algorytmów przy jednoczesnej oszczędności pamięci, co jest szczególnie ważne w aplikacjach wymagających wysokiej wydajności.



Zadanie 1: Licznik bitów ustawionych na 1
Napisz funkcję CountSetBits(int number), która przyjmuje liczbę całkowitą i zwraca liczbę bitów ustawionych na 1 w tej liczbie.

Przykład: Dla liczby 5 (w zapisie binarnym 0101), funkcja powinna zwrócić 2, ponieważ dwa bity są ustawione na 1.

Podpowiedź: Użyj maskowania bitów i przesunięć w pętli, aby sprawdzić każdy bit.

Zadanie 2: Sprawdzenie, czy liczba jest potęgą 2
Napisz funkcję IsPowerOfTwo(int number), która sprawdza, czy dana liczba całkowita jest potęgą 2. Funkcja powinna zwracać true dla liczb będących potęgą 2 (1, 2, 4, 8, 16 itd.) i false w przeciwnym razie.

Podpowiedź: Liczba jest potęgą 2, jeśli w zapisie binarnym ma ustawiony pierwszy bit na 1.


Zadanie 3: Odbijanie bitów
Napisz funkcję ReverseBits(int number), która przyjmuje liczbę całkowitą i zwraca liczbę z odbitymi bitami.

Przykład: Dla liczby 3 (w zapisie binarnym 00000011), wynik powinien być 11000000 (w zależności od długości typu).

Podpowiedź: Użyj pętli i przesunięć bitowych, aby ustawić bity w odwrotnej kolejności.


Zadanie 4: Przełączanie bitu (Toggle)
Napisz funkcję ToggleBit(int number, int position), która zmienia wartość bitu na danej pozycji w liczbie. Funkcja powinna zwracać nową wartość liczby po przełączeniu bitu.

Przykład: Dla liczby 5 (w zapisie binarnym 0101) i pozycji 1, wynik powinien być 7 (binarnie 0111), ponieważ bit na pozycji 1 zmienia się z 0 na 1.

Podpowiedź: Użyj operatora XOR (^) z maską 1 << position.
