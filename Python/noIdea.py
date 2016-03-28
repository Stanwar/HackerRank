N,M = input().split()
S = list(map(int,input().split()))
A = set(map(int,input().split()))
B = set(map(int,input().split()))
happiness = 0

count = [ 1 if x in A else 0 for x in S]
count2 = [1 if x in B else 0 for x in S]
print(sum(count) - sum(count2))


