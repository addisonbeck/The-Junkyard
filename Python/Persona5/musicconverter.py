import os
import subprocess
for filename in os.listdir('C:/Users/abeck/Documents/Persona5/GameRaws/sound'):
    fileExt=os.path.splitext(filename)[-1]
    if fileExt == '.acb':
        subprocess.call(['C:/Users/abeck/Documents/Persona5/GameRaws/sound/AcbEditor.exe', 'C:/Users/abeck/Documents/Persona5/GameRaws/sound/' + filename])
    else:
        print(fileExt)

