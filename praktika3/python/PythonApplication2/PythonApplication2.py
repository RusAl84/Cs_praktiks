s=["Олег","Андрей", "HENESSY", "Владик"]
print(s[1])
ss=[[] for i in range(4)]
print(ss)
for i in range(4):
    for item in s:
        ss[i].append([item])
print(ss[1][1])
for i in range(3):
    for j in range(3):
        print(s[i] + " втюрился в " + s[j])