age = int(input("Enter your age: "))
if age <= 3:
    print("You are a toddler.")
elif age >= 4 and age <= 12:
    print("You are a child.")
elif age >= 13 and age <= 19:
    print("You are a teenager.")
elif age >= 20 and age <= 59:
    print("You are an adult.")
else:
    print("You are a senior.")
