cantidad = int(input("Ingrese la cantidad de numeros: "))

pares = impares = ceros = 0

print()
for i in range(0, cantidad):
    num = int(input(f"Ingrese el numero {i+1}: "))
    if (num==0): ceros+=1
    elif num%2 ==0: pares +=1
    else: impares +=1

print ("Cantidad de ceros: "+ceros)
print ("Cantidad de pares: "+pares)
print ("Cantidad de impares: "+impares)


