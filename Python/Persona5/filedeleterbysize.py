import os
import filecmp

dir1 = "C:/Users/abeck/Documents/Persona5/GameRaws/ps3"
dir2 = "C:/Users/abeck/Documents/Persona5/GameRaws/data"

list = []
k = 0

for path, subdirs, files in os.walk(dir2):
    for filename in files:
        l = os.path.join(path,filename)
        f = filename
        print f
