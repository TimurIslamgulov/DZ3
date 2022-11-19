# n-размер стороны квадратной матрицы
# x-строки
# y-столбцы

n = int(input("Введите размер стороны квадратной матрицы: ")) #ввод данных от пользователя
M = [[0] * n for x in range (n)] #массив из n-нулей, повторенный n-раз
size = len(M) ** 2 # количество чисел в массиве
index = 0 #индекс первого числа, с которого начинаем заполнение матрицы
for y in range (n): #заполнение первой строки
    index = index + 1
    M[0][y] = index
x, y = 0, n - 1 #координаты последней ячейки в первой строке
n = n - 1 #остаток ячеек доступных для заполнения по внешнему радиусу спирали
while size > index:
    for a in range(n):
        x = x + 1 #ВНИЗ
        index = index + 1
        M[x][y] = index
    for a in range(n):
        y = y - 1 #ВЛЕВО
        index = index + 1
        M[x][y] = index
    for a in range(n - 1):
        x = x - 1 #ВВЕРХ
        index = index + 1
        M[x][y] = index
    for a in range(n - 1):
        y = y + 1 #ВПРАВО
        index = index + 1
        M[x][y] = index
    n = n - 2 #переход на внутренний радиус спирали
for x in range(len(M)):
    for y in range(len(M)):
        print(M[x][y], end=" ")
    print()