lado1 = input(int("Ingrese lado1: "))
lado2 = input(int("Ingrese lado2: "))
lado3 = input(int("Ingrese lado3: "))

if (lado1==lado2 and lado2==lado3):
    print("Equilatero")
elif (lado1==lado2 or lado2==lado3 or lado3 or lado1):
    print("Isoceles")
else:
    print("Escaleno")