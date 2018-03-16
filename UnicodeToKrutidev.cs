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
		while (position_of_quote >= 0){ 
			modified_substring =  ReplaceFirstOccurrence(modified_substring,"'","^");
			modified_substring =  ReplaceFirstOccurrence(modified_substring,"'","*");
			position_of_quote = modified_substring.IndexOf("'");
		}

		int position_of_Dquote = modified_substring.IndexOf("\"");
		while (position_of_Dquote >= 0){ 
			modified_substring =  ReplaceFirstOccurrence(modified_substring,"\"","ß");
			modified_substring =  ReplaceFirstOccurrence(modified_substring,"\"","Þ");
			position_of_Dquote = modified_substring.IndexOf("\"");
		}
		// first Replace the two-byte nukta_varNa with corresponding one-byte nukta varNas.

		modified_substring = modified_substring.Replace ( "क़", "क़" ); 
		modified_substring = modified_substring.Replace ( "ख़", "ख़" );
		modified_substring = modified_substring.Replace ( "ग़", "ग़" );
		modified_substring = modified_substring.Replace ( "ज़", "ज़" );
		modified_substring = modified_substring.Replace ( "ड़", "ड़" );
		modified_substring = modified_substring.Replace ( "ढ़", "ढ़" );
		modified_substring = modified_substring.Replace ( "ऩ", "ऩ" );
		modified_substring = modified_substring.Replace ( "फ़", "फ़" );
		modified_substring = modified_substring.Replace ( "य़", "य़" );
		modified_substring = modified_substring.Replace ( "ऱ", "ऱ" );

		// code for replacing "ि" (chhotee ee kii maatraa) with "f"  and correcting its position too.

		var position_of_f = modified_substring.IndexOf( "ि" )  ;
		while ( position_of_f != -1 )  //while-02
		{
			var character_left_to_f = modified_substring[position_of_f - 1];
			modified_substring = modified_substring.Replace( character_left_to_f + "ि" ,  "f" + character_left_to_f )  ;

			position_of_f = position_of_f - 1;

			while (( position_of_f != 0  ) && ( modified_substring[position_of_f - 1] == '्' ) )
			{
				var string_to_be_Replaced = modified_substring[position_of_f - 2 ] + "्"  ;
				modified_substring = modified_substring.Replace( string_to_be_Replaced + "f", "f" + string_to_be_Replaced ) ;

				position_of_f = position_of_f - 2  ;
			}
			position_of_f = modified_substring.IndexOf("ि", position_of_f + 1 ) ; // search for f ahead of the current position.

		} // end of while-02 loop


		//************************************************************     
		//     modified_substring = modified_substring.Replace( /fर्", "£"  )  ;
		//************************************************************     
		// Eliminating "र्" and putting  Z  at proper position for this.

		string set_of_matras = "ािीुूृेैोौं:ँॅ";

		modified_substring += "  ";  // add two spaces after the string to avoid UNDEFINED char in the following code.

		var position_of_half_R = modified_substring.IndexOf( "र्" ) ;
		while ( position_of_half_R > 0  )  // while-04
		{
			// "र्"  is two bytes long
			var probable_position_of_Z = position_of_half_R + 2   ;  

			var character_right_to_probable_position_of_Z = modified_substring[probable_position_of_Z + 1];

			// trying to find non-maatra position right to probable_position_of_Z .

			while ( set_of_matras.IndexOf( character_right_to_probable_position_of_Z ) != -1 )  
			{
				probable_position_of_Z = probable_position_of_Z + 1 ;
				character_right_to_probable_position_of_Z = modified_substring[probable_position_of_Z + 1];
			} // end of while-05

			var string_to_be_Replaced = modified_substring.Substring( position_of_half_R + 2 , ( probable_position_of_Z - position_of_half_R - 1 ))  ;
			modified_substring = modified_substring.Replace( "र्" + string_to_be_Replaced  ,  string_to_be_Replaced + "Z" ) ;
			position_of_half_R = modified_substring.IndexOf( "र्" ) ;
		} // end of while-04

		modified_substring = modified_substring.Substring( 0 , modified_substring.Length - 2 );



		//substitute array_two elements in place of corresponding array_one elements

		for( int input_symbol_idx = 0; input_symbol_idx < array_one_length; input_symbol_idx++ )
		{
			int idx = 0  ;  // index of the symbol being searched for Replacement

			while (idx != -1 ) //whie-00
			{
				modified_substring = modified_substring.Replace (array_one [input_symbol_idx], array_two [input_symbol_idx]);
				idx = modified_substring.IndexOf (array_one [input_symbol_idx]);
			} // end of while-00 loop
		} // end of for loop


		return modified_substring;
	}

	public static string ReplaceFirstOccurrence (string Source, string Find, string Replace)
	{
		int Place = Source.IndexOf(Find);
		string result = Source.Remove(Place, Find.Length).Insert(Place, Replace);
		return result;
	}
}
