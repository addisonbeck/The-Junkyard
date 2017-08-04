import os
import subprocess
for filename in os.listdir('C:/Users/abeck/Documents/Persona5/GameRaws/font/assist/bustup'):
		subprocess.call(['C:/Users/abeck/Documents/Persona5/Tools/PlanetSide/PlanetSide_DDS_Extractor_0.1.exe', 'C:/Users/abeck/Documents/Persona5/GameRaws/font/assist/bustup/' + filename])
