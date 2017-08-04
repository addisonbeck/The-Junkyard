import os
import shutil
import subprocess
import time
mydir = "C:/Users/abeck/Documents/Persona5/Extracts/sound"
for root, dir, files in os.walk(mydir):
        for file in files:
                path_file = os.path.join(root,file)
                subprocess.Popen(['C:/Program Files/VideoGameSoundConverter_2.0/VGSC.exe',root +"/", root + "/"])

        
                


