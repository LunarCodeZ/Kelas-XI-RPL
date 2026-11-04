def looping(input_number):
    result = ""
    for i in range(3, input_number, 3):
        result += str(i) + "\n"
    return result

print(looping(22))