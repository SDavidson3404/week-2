# Create an empty list for prime numbers
primeNums = []
# Function to determine if a number is Prime
def primeTest(testNum):
    if testNum > 1:
        for n in range(2, testNum):
            if testNum % n == 0:
                return False
        return True
    else:
        return False
# Test all numbers 1-100
for num in range(1, 101):
    prime = primeTest(num)
    if prime:
        primeNums.append(num)
# Print the list of Prime Numbers
print(primeNums)