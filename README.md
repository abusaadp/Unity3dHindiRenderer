Unity is not able to render hindi text properly. The font processing in Unity copes with the glyphs, but does not read the GSUB and GPOS tables that font renderers use to convert strings into rendering components. In this project we convert unicode to Krutidev and then render the text using Kruti dev font. The rendering works for all Devanagiri fonts.
The C# code was created from the python code at [this link][1]

[1]:https://github.com/jmcmanu2/python_practice/blob/e443078b7f0c9287ae29cc54d92fca4807a22955/Unicode%20KrutiDev%20converter.py

The KrutiDev font is not unicode font but rather a view of hindi and hence does not require special layout usually needed for devnagari texts. For further details refer [quora link][2]

[2]:https://www.quora.com/What-is-the-difference-between-the-Mangal-font-and-the-Kruti-Dev-font-in-typing-Hindi

So Krutidev font will work for hindi or any devnagari texts in a system like Unity3d where there is no special font renedering. Since most of our hindi text is in unicode we need to convert that unicode text to krutidev text. In the above project that conversion is done in the script UnicodeToKrutidev.cs

The steps to make this work in Unity3d is very simple.

  1. Convert the unicode hindi text to krutidev text using the above script.
  2. Pass this krutidev text to any UI Textfield of Unity3d which uses the krutidev font.
  3. The hindi text when the app executes will show the correct hindi layout.
