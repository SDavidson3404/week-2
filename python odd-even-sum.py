
int1 = int(input("Enter first integer: "))
int2 = int(input("Enter second integer: "))
int3 = int(input("Enter third integer: "))
int4 = int(input("Enter fourth integer: "))
int5 = int(input("Enter fifth integer: "))

if int1 % 2 == 0:
    a = int1
    b = 0
else:
    b = int1
    a = 0

if int2 % 2 == 0:
    c = int2
    d = 0
else:
    d = int2
    c = 0

if int3 % 2 == 0:
    e = int3
    f = 0
else:
    f = int3
    e = 0

if int4 % 2 == 0:
    g = int4
    h = 0
else:
    h = int4
    g = 0

if int5 % 2 == 0:
    i = int5
    j = 0
else:
    j = int5
    i = 0

sum_even = a + c + e + g + i
sum_odd = b + d + f + h + j

print("Sum of even integers:", sum_even, ", sum of odd integers:", sum_odd)