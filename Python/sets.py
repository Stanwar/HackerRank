i = int(input())
l = set(map(int,input().split(" ")))
s = sum(l)
length = len(l)
average = s/length
print(average)