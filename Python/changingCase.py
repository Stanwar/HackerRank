inString = input()

inList = list(inString)
output = ""
for i in inList:
    if(i.isupper()):
        output = output + i.lower()
    elif(i.islower()):
        output = output + i.upper()
    else:
        output = output + i
        
print(output)

#### 
####alternative code 
####
a = print(input().swapcase())