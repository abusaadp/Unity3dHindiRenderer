using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

public class UnicodeToKrutidev {


	private static string[] array_one = new string[] {"‘",   "’",   "“",   "”",   "(",    ")",   "{",    "}",   "=", "।",  "?",  "-",  "µ", "॰", ",", ".", "् ", 
		"०",  "१",  "२",  "३",     "४",   "५",  "६",   "७",   "८",   "९", "x", 

		"फ़्",  "क़",  "ख़",  "ग़", "ज़्", "ज़",  "ड़",  "ढ़",   "फ़",  "य़",  "ऱ",  "ऩ",  
		"त्त्",   "त्त",     "क्त",  "दृ",  "कृ",

		"ह्न",  "ह्य",  "हृ",  "ह्म",  "ह्र",  "ह्",   "द्द",  "क्ष्", "क्ष", "त्र्", "त्र","ज्ञ",
		"छ्य",  "ट्य",  "ठ्य",  "ड्य",  "ढ्य", "द्य","द्व",
		"श्र",  "ट्र",    "ड्र",    "ढ्र",    "छ्र",   "क्र",  "फ्र",  "द्र",   "प्र",   "ग्र", "रु",  "रू",
		"्र",

		"ओ",  "औ",  "आ",   "अ",   "ई",   "इ",  "उ",   "ऊ",  "ऐ",  "ए", "ऋ",

		"क्",  "क",  "क्क",  "ख्",   "ख",    "ग्",   "ग",  "घ्",  "घ",    "ङ",
		"चै",   "च्",   "च",   "छ",  "ज्", "ज",   "झ्",  "झ",   "ञ",

		"ट्ट",   "ट्ठ",   "ट",   "ठ",   "ड्ड",   "ड्ढ",  "ड",   "ढ",  "ण्", "ण",  
		"त्",  "त",  "थ्", "थ",  "द्ध",  "द", "ध्", "ध",  "न्",  "न",  

		"प्",  "प",  "फ्", "फ",  "ब्",  "ब", "भ्",  "भ",  "म्",  "म",
		"य्",  "य",  "र",  "ल्", "ल",  "ळ",  "व्",  "व", 
		"श्", "श",  "ष्", "ष",  "स्",   "स",   "ह",     

		"ऑ",   "ॉ",  "ो",   "ौ",   "ा",   "ी",   "ु",   "ू",   "ृ",   "े",   "ै",
		"ं",   "ँ",   "ः",   "ॅ",    "ऽ",  "् ", "्" };

	private static string[] array_two = new string[] {"^", "*",  "Þ", "ß", "¼", "½", "¿", "À", "¾", "A", "\\", "&", "&", "Œ", "]","-","~ ", 
		"å",  "ƒ",  "„",   "…",   "†",   "‡",   "ˆ",   "‰",   "Š",   "‹","Û",

		"¶",   "d",    "[k",  "x",  "T",  "t",   "M+", "<+", "Q",  ";",    "j",   "u",
		"Ù",   "Ùk",   "Dr",    "–",   "—",       

		"à",   "á",    "â",   "ã",   "ºz",  "º",   "í", "{", "{k",  "«", "=","K", 
		"Nî",   "Vî",    "Bî",   "Mî",   "<î", "|","}",
		"J",   "Vª",   "Mª",  "<ªª",  "Nª",   "Ø",  "Ý",   "æ", "ç", "xz", "#", ":",
		"z",

		"vks",  "vkS",  "vk",    "v",   "bZ",  "b",  "m",  "Å",  ",s",  ",",   "_",

		"D",  "d",    "ô",     "[",     "[k",    "X",   "x",  "?",    "?k",   "³", 
		"pkS",  "P",    "p",  "N",   "T",    "t",   "÷",  ">",   "¥",

		"ê",      "ë",      "V",  "B",   "ì",       "ï",     "M",  "<",  ".", ".k",   
		"R",  "r",   "F", "Fk",  ")",    "n", "/",  "/k",  "U", "u",   

		"I",  "i",   "¶", "Q",   "C",  "c",  "H",  "Hk", "E",   "e",
		"¸",   ";",    "j",  "Y",   "y",  "G",  "O",  "o",
		"'", "'k",  "\"", "\"k", "L",   "l",   "g",      

		"v‚",    "‚",    "ks",   "kS",   "k",     "h",    "q",   "w",   "`",    "s",    "S",
		"a",    "¡",    "%",     "W",   "·",   "~ ", "~"};


	public static string  UnicodeToKrutiDev(string unicode_substring){
		int array_one_length = array_one.Length;
		string modified_substring = unicode_substring;

		int position_of_quote = modified_substring.IndexOf("'");
		while (position_of_quote != -1){ 
			modified_substring =  ReplaceFirstOccurrence(modified_substring,"'","^");
			modified_substring =  ReplaceFirstOccurrence(modified_substring,"'","*");
			position_of_quote = modified_substring.IndexOf("'");
		}

		int position_of_Dquote = modified_substring.IndexOf("\"");
		while (position_of_Dquote != -1){ 
			modified_substring =  ReplaceFirstOccurrence(modified_substring,"\"","ß");
			modified_substring =  ReplaceFirstOccurrence(modified_substring,"\"","Þ");
			position_of_Dquote = modified_substring.IndexOf("\"");
		}
		//Specialty characters
		modified_substring = modified_substring.Replace ("क़", "क़");
		modified_substring = modified_substring.Replace ("ख़‌", "ख़");
		modified_substring = modified_substring.Replace ("ग़", "ग़");
		modified_substring = modified_substring.Replace ("ज़", "ज़");
		modified_substring = modified_substring.Replace ("ड़", "ड़");
		modified_substring = modified_substring.Replace ("ढ़", "ढ़");
		modified_substring = modified_substring.Replace ("ऩ", "ऩ");
		modified_substring = modified_substring.Replace ("फ़", "फ़");
		modified_substring = modified_substring.Replace ("य़", "य़");
		modified_substring = modified_substring.Replace ("ऱ", "ऱ");
		modified_substring = modified_substring.Replace("ि","f");

		//Replace Unicode with ASCII
		for (int input_symbol_idx=0;  input_symbol_idx < array_one_length; input_symbol_idx++){
			modified_substring = modified_substring.Replace (array_one [input_symbol_idx], array_two [input_symbol_idx]);
		}

			// Move "f"  to correct position
		modified_substring = "  " + modified_substring + "  ";
		int position_of_f = modified_substring.IndexOf("f");
		while (position_of_f != -1){   
			modified_substring = modified_substring.Substring(0,position_of_f-1) + modified_substring[position_of_f] + modified_substring[position_of_f-1] + modified_substring.Substring(position_of_f+1);
			position_of_f = modified_substring.IndexOf("f", position_of_f +1 ) ;// search for f ahead of the current position.
		}
		modified_substring = modified_substring.Trim();

					//Move "half R"  to correct position and Replace
		modified_substring = "  " + modified_substring + "  ";
		int position_of_r = modified_substring.IndexOf("j~");
		List<string> set_of_matras =  new List<string>(){"‚",    "ks",   "kS",   "k",     "h",    "q",   "w",   "`",    "s",    "S", "a",    "¡",    "%",     "W",   "·",   "~ ", "~"};
		while (position_of_r != -1){ 
			modified_substring =  ReplaceFirstOccurrence(modified_substring,"j~","");
			if (set_of_matras.Contains(""+modified_substring[position_of_r + 1]))
				modified_substring = modified_substring.Substring(0,position_of_r + 2) + "Z" + modified_substring.Substring(position_of_r + 2);
			else
				modified_substring = modified_substring.Substring(0,position_of_r + 1) + "Z" + modified_substring.Substring(position_of_r + 1);
			position_of_r = modified_substring.IndexOf("j~");
		}
		modified_substring = modified_substring.Trim();

		return modified_substring;
	}

	public static string ReplaceFirstOccurrence (string Source, string Find, string Replace)
	{
		int Place = Source.IndexOf(Find);
		string result = Source.Remove(Place, Find.Length).Insert(Place, Replace);
		return result;
	}
}
