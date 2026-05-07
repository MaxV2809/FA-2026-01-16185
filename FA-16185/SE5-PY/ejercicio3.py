num = input(int("Ingrese un numero: "))
pares = 0

for i in range(1,num+1):
    if(i%2==0):
        pares+=1;
print("\n\nSuma de pares: ",pares)
