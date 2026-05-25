def squares(L):
    res = []
    for i in L:
        res.append(i*i)
    return res

L = [2, 3, 5, 7, 11]
for l in squares(L):
    print(f'{l}')
