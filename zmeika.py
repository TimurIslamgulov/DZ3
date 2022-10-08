n=int(input())
def cifr_to_str(a):
    if a<10:
        return str(0)+str(a)
    else:
        return str(a)

def zmeika(n):
    matrix = [[0 for i in range(n)] for _ in range(n)]
    center_index = int(n/2-1)+1
    matrix[center_index][center_index]=cifr_to_str(n*n)
    a=0
    for step in range(center_index):
        lenth = n-1-step
        #uper
        for col in range(step,lenth):
            a+=1
            matrix[step][col]=cifr_to_str(a)
        #right
        for row in range(step,lenth):
            a+=1
            matrix[row][lenth]=cifr_to_str(a)
        #down
        for col in range(step,lenth):
            a+=1
            matrix[lenth][n-1-col]=cifr_to_str(a)
        #left
        for row in range(step,lenth):
            a+=1
            matrix[n-1-row][step]=cifr_to_str(a)

    for roww in matrix:
        print(' '.join(roww))
    print('')
    

zmeika(n)     