Lab 3: Materials & Shaders in Three.js

-------------------
Purpose

Learning the built in Material functions within three.js along with learning what shader programs
are and how to create them.

-------------------
Files

-
part3.html

Contains 5 cubes that will rotate and move in the given scene, each with different materials and
shading.

-
README.txt

Describes the objective of live and instructions on how to view/access
the given files.

------------------
Instructions

Google Drive Link to video of Lab3:
https://drive.google.com/file/d/1Yq789uNjlMSMxco0sqvki0HoEDvw1XcL/view?usp=sharing

------------------
Description of Cubes

The first cube on the left is a wireframed THREE.MeshNormalMaterial with flatShading. 
The next one is a THREE.MeshLambertMaterial({ color: 0x666666, emissive: 0xff0000 }) cube.
The middle cube is using (supposed to at least) fragmentShader1 which is supposed to interpolate between a mixture of 6 colors.
The next cube is using the given fragmentShader from the lab.
The last cube is using the given THREE.MeshPhongMaterial({ color: 0xdddddd, specular: 0x00ff00, shininess: 30 });


