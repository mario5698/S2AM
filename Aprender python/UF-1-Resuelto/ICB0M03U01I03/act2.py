print ("Hores : ")
horas= int( input())
print ("Minuts : ")
minutos= int( input())
print ("Segons : ")
segundos= int( input())

hora_segundo=horas*3600
minutos_segundo=minutos*60

suma=hora_segundo+minutos_segundo+segundos

print(suma)