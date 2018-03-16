Unity is not able to render hindi text properly. The font processing in Unity copes with the glyphs, but does not read the GSUB and GPOS tables that font renderers use to convert strings into rendering components. In this project we convert unicode to Krutidev and then render the text using Kruti dev font. The rendering works for all Devanagiri fonts.
The C# code was created from the python code at [this link][1]

[1]:https://github.com/jmcmanu2/python_practice/blob/e443078b7f0c9287ae29cc54d92fca4807a22955/Unicode%20KrutiDev%20converter.py
