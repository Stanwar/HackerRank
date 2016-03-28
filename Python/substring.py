string = input()
substring = input()

lenSubstring = len(substring)
count = 0
if substring in string:
    for i in range(0,len(string)):
        word = string[i:lenSubstring+i]
        if word==substring:
            count = count + 1
        elif len(word)<lenSubstring:
            break
print(count)


