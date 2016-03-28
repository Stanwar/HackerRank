inString = input()
inValues = input().split(" ")

listString = list(inString)
listString[int(inValues[0])] = inValues[1]
print("".join(listString))

