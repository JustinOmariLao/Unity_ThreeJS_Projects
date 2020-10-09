Justin Lao
jlao3
Spring 2020
Lab 6: Shading in Unity or Shadertoy

----------
LAB DESCRIPTION

Introduction to creating materials, shading, texturing, and implementing light sources within Unity.
Through the Unity program, created multiple scenes with different forms of light sources (Point, Spot, Area, and
Directional) and how they affect created materials and textures (Brick and Wood texture).

Point Lights: Similar to light bulbs, give off a spherical radius of light around a scene and illuminates any objects caught within the lights distance.

Spotlights: Similar to flash lights, a pointed light that shines in a set degree area and will illuminate anything caught within that degree.

Area Light: Similar to ceiling windows except for the fact that they emit light within their specific pattern (generally a rectangle or circle).

Directional Light: Likened to the sun, illuminates the entire scene no matter the position, will only adjust through rotation of light object.

----------
FILES

-
Lab6.exe

Unity Project executable that is the created project. Includes everything shown in the screenshots (materials,
textures, lights).

-
README.txt

Describes purpose of Lab6 along with what files will be submitted.
Gives description on how to run lab.

----------
ASSIGNMENT DETAILS

1. The real-world material and object I created were brick and wood walls/floors.
![](lab6/Images/Wood_and_Brick_Inspiration.jpg)

2. This picture uses my created brick material and texture along with a spotlight thats been fitted onto a construction light model (thanks to a Unity example model).
The texture pack was pretty easy to create by taking a png of a brick and applying normal maps and height maps to give it a layered look and correct light reflection. The
wooden beams are to show how the spotlight is creating a shadow of them onto the brick wall. You can also infer the directional lighting, which is creating the wall's shadow.
![](lab6/Images/Brick_Material_and_Texture.png)

3. This picture uses my created wood material and texture with a point light such that the shadow of all of the objects placed within the scene are reflected onto the wood walls.
The wood material and texture were created using the same method the brick material was created. If you look within the scene, the paint cans are glossy and shiny, which is due to
a specular shader instead of the regular metallic shader. 
![](lab6/Images/Wood_Material_and_Texture.png)

4. This picture uses the same brick material but is supposed to represent an area light. However from what I can gather, my version of unity has a bugged area light in which
it won't show up on the scene. I tried changing the lightmapping and more, but  from what I can gather on forums online, my version just doesn't show the area light. In the screenshot
you will see though that I do have it added and implemented into the scene.
![](lab6/Images/Area_Light.png)

5. This last picture shows the custom skybox I put into the scene along with the directional light that has been rotated to represent the sun's angle from the skybox to the objects.
This gives off the shadow of the walls and some other objects that you see in the previous images.
![](Unity_ThreeJS_Projects/ShadingUnity/Images/Directional_Light_and_Skybox.png)
