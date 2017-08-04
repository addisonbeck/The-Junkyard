import os
import glob

mydir = "C:/Users/abeck/Documents/Persona5/GameRaws/data/effect/event"
newdir = "C:/Users/abeck/Documents/Persona5/dump"

for root, dir, files in os.walk(mydir):
    for filename in glob.glob(mydir + "/*_0.png"):
        path_file = os.path.join(root, filename)
        os.remove(path_file)



