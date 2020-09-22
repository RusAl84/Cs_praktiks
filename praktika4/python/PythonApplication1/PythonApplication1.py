
import numpy as np
from ast import literal_eval

n= np.zeros([2,3])
print(n[1,2])


s=['Andrey','Oleg','Valera']
n = 3
ss = []
for i in range(n):
    ss.append(s)
print(ss)
#for j in ss:
#    print(j)
ss = str(ss)
print(type(ss))
print(literal_eval(ss))
print(type(literal_eval(ss)))


