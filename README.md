### Napisz w C# program, który dla zadanego napisu o długości n (1 ≤ n ≤ 1000, format ASCII 7-bit) wyznaczy frekwencję liter w tym napisie (liczbę wystąpień), bez względu na ich wielkość.

---

W zależności od podanej kwerendy, program wypisuje wyniki w odpowiedniej formie - w kolejnych wierszach

```
litera spacja liczba wystąpień
```

Format kwerendy:
- first|last n byfreq asc|desc byletter asc|desc
- first|last n byletter asc|desc

gdzie:

- first n - pierwsze n (1 ≤ n ≤ 1000)
- last n - ostatnie n (1 ≤ n ≤ 1000)
- byfreq - posortuj ze względu na częstość wystąpień
- byletter - posortuj ze względu na znaki, leksykograficznie
- asc - rosnąco
- desc - malejąco
- | - oznacza lub

Pomiędzy tokenami kwerendy występuje dokładnie jedna spacja.

---

### Input

+ w pierwszym wierszu liczba t przypadków testowych (1 ≤ t ≤ 100)
+ w kolejnych wierszach t par linii danych:
    + w pierwszym wierszu przypadku testowego -- analizowany napis, niepusty, zawierający przynajmniej jedną literę
    + w drugim wierszu przypadku testowego -- kwerenda

### Output
W kolejnych wierszach: ```znak spacja liczba wystąpień```, odpowiednio posortowane. Znaki podaj jako **małe litery**.
Pomiędzy wynikami kwerend występuje jeden pusty wiersz

### Example

```
Input:
2
Ala ma 2 koty, As to Ali pies!
first 3 byfreq asc byletter asc
Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.
last 2 byletter desc

Output:
e 1
k 1
m 1

b 3
a 11
```