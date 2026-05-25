def iota(n):
    res = []
    for i in range(1, n+1):
        res.append(i)
    return res
L = iota(6)
for i in L:
    print(f'{i}')
