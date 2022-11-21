N = int(input())
k = 1
A = [[0 for j in range(N)] for i in range(N)]
M = N
L = 0
H = 0
while k<= N*N:
    for j in range (M):
        i = L
        if (A[i][j] == 0):
            A[i][j] = k
            k +=1
    for i in range (M):
        if (A[i][j] == 0):
            A[i][j] = k
            k +=1
    for j in range (M-1, -1, -1):
        if (A[i][j] == 0):
            A[i][j] = k
            k +=1
            H = j
    for i in range (M-1, -1, -1):
        j = H
        if (A[i][j] == 0):
            A[i][j] = k
            k +=1
            L = i
    M -=1
    
for i in A: 
    for i2 in i: 
        print(i2, end='  ') 
    print()