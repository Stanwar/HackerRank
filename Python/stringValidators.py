s = input()

l = [[ch.isalnum(), ch.isalpha(), ch.isdigit(), ch.islower(), ch.isupper()] for ch in s]

x = list(zip(*l))

for i in x :
    print(any(i))

