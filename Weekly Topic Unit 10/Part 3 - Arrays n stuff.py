listContent = 'Split'
array = list(listContent)

print(array)

#output
#['S', 'p', 'l', 'i', 't']

testString = "This is a string I guess?"
testArray = testString.split(' ')

print(testArray)

#output
#['This', 'is', 'a', 'string', 'I', 'guess?']

testArray.sort()
print(testArray)

#output
#['I', 'This', 'a', 'guess?', 'is', 'string']

testArray.sort(reverse = True)
print(testArray)

#output
#['string', 'is', 'guess?', 'a', 'This', 'I']

testString = "This is a string I guess?"
testArray = testString.split(' ')

for x in testArray:
    print(x)




inString = "Now is the Time for All Good Men to Come to the Aid of their Country."
myArray = inString.split(' ')

print(myArray)

myArray.sort()

print(myArray)

for x in myArray:
    print(x)