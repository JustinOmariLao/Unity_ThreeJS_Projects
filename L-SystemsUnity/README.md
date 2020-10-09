Justin Lao
jlao3
Spring 2020
Lab 9: L-Systems

----------
DESCRIPTION

Working within Unity's provided scripting function to create an algorithm
that generates a representation of natural patterns

----------
IMPORTANT

In lieu of using screenshots, I decided to video my L-Systems being generated as it'll give a better
understanding of how they were created. Both the tutorial and self-made L-System are Google Drive links
that can be clicked on and viewed.

----------
GOOGLE DRIVE

Tutorial L-System (Tree):
	https://drive.google.com/file/d/1WhI6o66a9SNVEzDQRw7cKBce9WH1wcUU/view?usp=sharing	

Self-Made (Sierpinski's Triangle x Snowflake):
	https://drive.google.com/file/d/1TM4AsvnESPmBQUnUCp140Oxt-4x531J0/view?usp=sharing

----------
EXPLANATION

Using an approximation of Sierpinski's triangle, with Start being 'A', rules being (A → B−A−B), (B → A+B+A)
and the angle set to 60f, I created a version of it by giving A and B length and slight changes on how the
lines are drawn. So while '-' means turn left by angle, and '+' means turn right by angle, giving 'A' and 'B'
length to be drawn created a snowflake architecture. Along with this, changes to the formula give the triangle
and ever increasing complexity as it drew around clock-wise. So while Sierpinski's triangle is uniform throughout,
we have multiple ever increasing complex triangles as it travels around the outline.

----------
FILES

-
Lab9 folder

Contains the built version of the scene (Computer doesn't have enough storage to transfer over entire
file assets, which I've been doing on my external hard drive and transfering over to submit).

-
README.txt

Describes purpose of Lab9 along with what files will be submitted.
Gives description on how to run lab.

-
LSystemGenerator.cs

Contains the code for making my L-System.

----------
INSTRUCTIONS

This program is intended to be run using the Unity executable. Double-click the Unity
executable and survey the scene.