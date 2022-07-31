size=int(input ("Введите число? "))
count=1
maxi=size-1
mini=1
minj=0
maxj=size-1
i=0
j=0
matrix=[[0,0,0,0,0,0],[0,0,0,0,0,0],[0,0,0,0,0,0],[0,0,0,0,0,0],[0,0,0,0,0,0],[0,0,0,0,0,0]]
while count<size*size:
    while j<maxj:
        matrix[i][j] = count
        #print(matrix[i][j])
        count = count + 1
        j = j + 1
    maxj=j-1
    while i<maxi:
        matrix[i][j] = count
        #print(matrix[i][j])
        count = count + 1
        i = i + 1
    maxi=maxi-1
    while j>minj:
        matrix[i][j] = count
        #print(matrix[i][j])
        count = count + 1
        j = j - 1
    minj=minj+1
    while i>mini:
        matrix[i][j] = count
        #print(matrix[i][j])
        count = count + 1
        i = i - 1
    mini=mini+1
matrix[i][j] = count
#print('mini=',mini)
#print('maxi=',maxi)
#print('minj=',minj)
#print('maxj=',maxj)
#print(matrix)

for i in range ( size):
    for j in range ( size):
        if matrix[i][j]<10:
            print ( (matrix[i][j]), end = "  " )
        else:
            print((matrix[i][j]), end=" ")
    print ()