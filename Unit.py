number = int(input("Введите число: "))
n = 1
a = 0
b = 0
max = 1
unit = []

for i in range(number):
    unit.append([0] * number)

for i in range(5):
    for c in range(number - max):
        if n <= number * number:
            unit[a][b] = n
            n += 1
            b += 1

    for c in range(number - max):
        if n <= number * number:
            unit[a][b] = n
            n += 1
            a += 1

    for c in range(number - max):
        if n <= number * number:
            unit[a][b] = n
            n += 1
            b -= 1

    for c in range(number - max):
        if n <= number * number:
            unit[a][b] = n
            n += 1
            a -= 1
    a += 1
    b += 1
    max += 2
    if max == number:
        unit[a][b] = n

for a in range(number):
    for b in range(number):
        print(unit[a][b], end=" ")
    print()
