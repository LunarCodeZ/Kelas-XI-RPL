def parkir_fee(hours):
    biaya = 5000
    if (hours > 1):
        for i in range(1, hours):
            biaya += 3000
    if (hours > 5):
        biaya += 5000
    return biaya

print(parkir_fee(1))
print(parkir_fee(4))
print(parkir_fee(6))