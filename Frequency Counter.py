# Creates a dictionary to store word and their frequency
wordDict = {}
# Function to determine if something is in the Dictionary
def dictCheck(testWord):
    if testWord in wordDict:
        wordDict[testWord] += 1
    else:
        wordDict[testWord] = 1
# Asks user to input a sentence
inputSentence = input("Please enter a sentence without the period: ")
# Split the sentence into words
sentence = inputSentence.rsplit(" ")
# Add all words to the dictionary and adds to the count if it already is in there
for word in sentence:
    dictCheck(word)
# Display Dictionary
print(wordDict)