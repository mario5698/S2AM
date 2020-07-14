import math
print ("Transport public :")
preu_transport=float(input ())
print ("KM :")
km=float(input ())
print ("Preu KM :")
preu_KM=float(input ())
preu_kma=km*preu_KM
minim= min([preu_transport,preu_kma ])

print(round(minim,2))

