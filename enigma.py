#-*-coding:utf8;-*-
#qpy:2
#qpy:console

rotor_1 = {"lst": "EKMFLGDQVZNTOWYHXUSPAIBRCJ",
           "pos": ord("R")}
rotor_1["lst_r"] = "".join([chr(65+rotor_1["lst"].index(chr(x))) for x in range(65, 91)])

rotor_2 = {"lst": "AJDKSIRUXBLHWTMCQGZNPYFVOE",
           "pos": ord("V")}
rotor_2["lst_r"] = "".join([chr(65+rotor_2["lst"].index(chr(x))) for x in range(65, 91)])

rotor_3 = {"lst": "BDFHJLCPRTXVZNYEIWGAKMUSQO",
                     "pos": ord("C")}
rotor_3["lst_r"] = "".join([chr(65+rotor_3["lst"].index(chr(x))) for x in range(65, 91)])

rstr = "AYBRCUDHEQFSGLIPJXKNMOTZVW"
reflector_b = {rstr[i]:rstr[i+1] for i in range(0, 26, 2)}
for k, v in reflector_b.items(): reflector_b[v] = k

c = "A"

s1 = rotor_1["lst"][(26+(ord(c)+rotor_1["pos"]-130))%26]
s2 = rotor_2["lst"][(26+(ord(s1)+rotor_2["pos"]-rotor_1["pos"]-65))%26]
s3 = rotor_3["lst"][(26+(ord(s2)+rotor_3["pos"]-rotor_2["pos"]-65))%26]
sr = reflector_b[chr(65+(26+ord(s3)-rotor_3["pos"])%26)]
sr1 = rotor_3["lst_r"][(26+(ord(sr)+rotor_3["pos"]-130))%26]
sr2 = rotor_2["lst_r"][(26+(ord(sr1)-rotor_3["pos"]+rotor_2["pos"]-65))%26]
sr3 = rotor_1["lst_r"][(26+(ord(sr2)-rotor_2["pos"]+rotor_1["pos"]-65))%26]
out = chr(65+(26+ord(sr3)-rotor_1["pos"])%26)


print "%s -> %s -> %s -> %s -> %s"%(c, s1, s2, s3, reflector_b[sr])
print "%s <- %s -< %s <- %s <- %s"%(out, sr3, sr2, sr1, sr)
