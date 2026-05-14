num = int(input("Ingrese un numero:"))

while num <=0:
    num =int(input("Numero invalido.  Ingrese un numero valido: "))

i=1
print()
while i<=12:
    print(f"{num}x{i}={num*1}")
    i+=1