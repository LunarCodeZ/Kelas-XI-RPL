def rak_buku(n):
    result = ""
    for i in range(1, n + 1):
        result += "#" * i + "\n"
    return result

print(rak_buku(3))
print(rak_buku(4))