Justin Lao
jlao3
Spring 2020
Lab 7: Mesh Manipulation

----------
DESCRIPTION

Working within Unity's provided Shader Graph function to create mountain ranges
and water ripple effects through use of transforming vectors in the vertex shader.

----------
GOOGLE DRIVE LINK

https://drive.google.com/file/d/1OFkB7-RTCXi11q1yQWzNtRZ8ZGMDtO07/view?usp=sharing

----------
Explanation

I wanted to create a scene texture somewhat akin to The Legend of Zelda: The Wind Waker, with it's
cell shaded toon mountains and water. And while I got the water color scheme correct, I am slightly
disappointed in my clouds, whcih used the shader graph also. The Mountain Range also includes some small tree models.
I wanted to make the water look look it was overtaking or overlapping on top of the mountain however collision physics was a whole other beast
that my computer started to freeze up on so I couldn't continue further.

To create the mountain-scape, I had a singlular Position node which used the mountain's
position hooked up to an Add node. Here's where it get's tricky, attached to the add node
is another system of complex nodes beginning with the Normal Vector (which effectively affects
the object's height). It's multiplied with the Vertex Color node to change based off how high it
is at every fragment (theoretically). Along with that, a Voronoi node gives the mountains it's
sharp edges and cliffsides. The Voronoi is multiplied with the product of said Vertex Color and
Normal Vector node and added with the previously mentioned Position node and set to the
Vertex Position input thus giving it's shape (grey texture pack input into albedo).

Using the built-in Shader Graph still, the water shader uses the same general concept except adding
more properties such as the time and power node to affect water ripple size and speed. While also interpolating
between two different shades of blue during waves to create a sense of movement and the wave-foam created. 

----------
PARTNER CHECK-IN

Couldn't find or contact partner on Discord (maybe they didn't change their nickname) and wasn't contacted by them either
so I couldn't do the Check-In Questions or parts.

----------
FILES

-
Lab7

Contains Unity files/program used to create scene. 

-
README.txt

Describes purpose of Lab4 along with what files will be submitted.
Gives description on how to run lab.

----------
INSTRUCTIONS

This program is intended to be run using the Unity executable. Double-click the Unity
executable and survey the scene.