Lab 4: Textures & Normal Maps

-------------------
Purpose

Learning to use the built-in texture program  within THREE.js along with how 
light reflects off of the texture (with and wihtout a Normal Map). Implementing
with Vertex and Fragment Shaders to create 5+ cubes.

-------------------
Questions

24a.

24b.

24c.

-------------------
Files

-
part4.html

Contains 5 cubes with different textures (some are the same depending if they have a Normal Map
or not).

-
README.txt

Describes the objective of live and instructions on how to view/access
the given files.

------------------
Instructions

Google Drive Link to video of Lab4:
https://drive.google.com/file/d/1cx52PrILJnTeoWd4V0grXiFVOzvSLAWd/view?usp=sharing

------------------
Description of Cubes

: Created a rotating light object to simulate how light reflects off the textures.

: The first cube on the top left uses the THREE.MeshPhongMaterial which is just the texture without a normal map.
	
: The next one on the right uses the same THREE.MeshPhongMaterial and texture
	but includes the normal map, which helps simulate the light source better.

: The the next one does the same thing but with a different texture.

: The bottom left cube uses a vertex and fragment shader to implement the texture.

: The last cube is tiled through multiplying the vec2 vUv by 3.0, and using
	the built in THREE.js repeat function to correctly tile the horizontal and
		vertical aspects of the texture and converting it into a vec4.
