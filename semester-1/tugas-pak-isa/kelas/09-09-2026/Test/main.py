def prime(input_number):
    if (input_number == 1):
        return "1 is not a Prime number"
    for i in range(1, input_number):
        if (i == 1):
            continue
        else:
            if (input_number % i == 0):
                return str(input_number) + " is not a Prime number"
    return str(input_number) + " is a Prime number"
    

print(prime(1))
print(prime(2))
print(prime(4))
print(prime(7))