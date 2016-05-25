using System.Collections.Generic;

namespace Enigma {
    public class Machine {
        public struct Rotor {
            public string name;
            public char[] lst, lst_r;
            public string step;
            public char pos;
            
            public Rotor(string name, string s, string step, char pos = 'A') {
                this.name = name;
                lst = s.ToCharArray();
                lst_r = new char[s.Length];

                int x = 0;
                foreach(char c in s) lst_r[c - 'A'] = (char)('A' + x++);

                this.step = step;
                this.pos = pos;
            }
        }

        public struct Reflector {
            public Dictionary<char, char> dict;
            public string name;

            public Reflector(string name, string s) {
                this.name = name;
                dict = new Dictionary<char, char>();

                for(int c = 0; c < s.Length; c += 2) {
                    dict[s[c]] = s[c + 1];
                    dict[s[c + 1]] = s[c];
                }
            }
        }

        public Dictionary<string, Rotor> dict_rotors = new Dictionary<string, Rotor>();
        public Dictionary<string, Reflector> dict_reflectors = new Dictionary<string, Reflector>();
        public Dictionary<char, char> replace = new Dictionary<char, char>();

        public Rotor[] cur_rotors;
        public Reflector reflector;
        public bool replace_enable;
        public int rotors_count;
        public string name;

        public string path;



        public Machine(string name, string[][] rotors, string[][] reflectors, bool comm = true) {
            this.name = name;
            replace_enable = comm;
            rotors_count = rotors.Length;
            cur_rotors = new Rotor[rotors_count];
            int i = 0;

            foreach (string[] rotor in rotors) cur_rotors[i++] = new Rotor(rotor[0], rotor[1], rotor[2]);
            foreach (string[] rotor in rotors) dict_rotors[rotor[0]] = new Rotor(rotor[0], rotor[1], rotor[2]);
            foreach (string[] r in reflectors) dict_reflectors[r[0]] = new Reflector(r[0], r[1]);
            
            reflector = dict_reflectors[reflectors[0][0]];
        }


        public char CharOp(char c, int i) {
            if(i >= 65) i -= 65;
            else if(i <= -65) i += 65;
            return (char)(65 + (26 + c - 65 + i) % 26);
        }


        public char CodeSymbol(char s_in) {
            char s, sr;
            if(replace.ContainsKey(s_in) && replace_enable) s_in = replace[s_in];
            path = s_in.ToString();
            path += s = cur_rotors[0].lst[CharOp(s_in, cur_rotors[0].pos) - 65];

            for(int i = 1; i < rotors_count; i++)
                path += s = cur_rotors[i].lst[CharOp(s, cur_rotors[i].pos - cur_rotors[i - 1].pos) - 65];

            path += sr = reflector.dict[CharOp(s, -cur_rotors[rotors_count - 1].pos)];
            path += s = cur_rotors[rotors_count - 1].lst_r[CharOp(sr, cur_rotors[rotors_count - 1].pos) - 65];

            for (int i = rotors_count - 2; i >= 0; i--)
                path += s = cur_rotors[i].lst_r[CharOp(s, -cur_rotors[i + 1].pos + cur_rotors[i].pos) - 65];

            s = CharOp(s, -cur_rotors[0].pos);
            if (replace.ContainsKey(s) && replace_enable) s = replace[s];
            path += s;
            return path[path.Length - 1];
        }


        public void Step(int i = 0) {
            if(cur_rotors[i].step.IndexOf(cur_rotors[i].pos) != -1 && i != rotors_count - 1)
                Step(i + 1);
            cur_rotors[i].pos = CharOp(cur_rotors[i].pos, 1);
        }


        public void Back(int i = 0) {
            path = path.Substring(0, path.Length - 1);
            foreach (char s in cur_rotors[i].step) {
                if (cur_rotors[i].pos == CharOp(s, -1) && i > 0) {
                    Back(i - 1);
                    break;
                }
            }
            cur_rotors[i].pos = CharOp(cur_rotors[i].pos, -1);
        }
    }
}