import random
# Create the grid of list
vertical1 = [random.randint(1, 10), random.randint(1, 10), random.randint(1, 10)]
vertical2 = [random.randint(1, 10), random.randint(1, 10), random.randint(1, 10)]
vertical3 = [random.randint(1, 10), random.randint(1, 10), random.randint(1, 10)]
horizontal = [vertical1, vertical2, vertical3]
# Function to calculate sum
def sum(num1, num2, num3):
    return num1 + num2 + num3
# Calculate the sum of each row
row1 = sum(vertical1[0], vertical2[0], vertical3[0])
row2 = sum(vertical1[1], vertical2[1], vertical3[1])
row3 = sum(vertical1[2], vertical2[2], vertical3[2])
# Calculate the sum of each column
vert1 = sum(vertical1[0], vertical1[1], vertical1[2])
vert2 = sum(vertical2[0], vertical2[1], vertical2[2])
vert3 = sum(vertical3[0], vertical3[1], vertical3[2])
# Calculate the sum of diagonals
diagonal1 = sum(vertical1[0], vertical2[1], vertical3[2])
diagonal2 = sum(vertical1[2], vertical2[1], vertical3[0])
# Display the lists
print(horizontal)
# Display the sums
print(f"""The sums for the rows are {row1}, {row2}, and {row3}
the sums for the columns are {vert1}, {vert2}, and {vert3}
the sums of the diagonals are {diagonal1} and {diagonal2}""")