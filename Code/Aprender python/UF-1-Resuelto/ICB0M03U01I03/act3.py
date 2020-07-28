import math
print ("Antiguedad ")
antiguedad= int(input())
print("Retribucion Trienni ")
retribucion= float(input())

trienios=math.floor(antiguedad/3)
precio_trienio= trienios*retribucion

print (precio_trienio)