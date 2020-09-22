
s=["Максим","Данила","Вика", "Саша"]
ss=[[] for i in range(4)]
for i in range(4):
    for j in s:
        if j!="Максим":
            ss[i].append(j)


for i in range(3):
    stroka="";
    for j in range(3):
        stroka+=" "+ss[i][j]
    print(stroka)

#for i in range(4):
#    for j in range(4):
#        if i!=j:
#            print(ss[i][j] +" love " + ss[j][i])

