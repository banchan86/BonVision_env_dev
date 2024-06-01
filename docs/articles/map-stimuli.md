# Map Stimuli

## Under Construction

## A. Sphere Mapping
> [!NOTE]
> This is best for creating 2D stimuli.
> [!NOTE]
> Needs a Display object: preferably a ViewingWindow

[The details of the implementation of Sphere mapping](https://en.wikibooks.org/wiki/Blender_3D:_Noob_to_Pro/UV_Map_Basics)

In this case, stimuli are always rendered onto the inside of a sphere. This allows easy eye-centric definitions of stimuli in visual angle units. The displays are then windows that observe these rendered stimuli. We use Spherical coordinates to define all stimulus parameters in this case. 

![SphericalCoord](~/images/DisplayLogic/SphericalCoord_resized.png){width=500} 

## B. Cube Mapping
> [!NOTE]
> This is best for creating 3D stimuli, for Virtual or Augmented Reality Systems.
> [!NOTE]
> Needs a Display object: preferably a PerspectiveViewingWindow

[The details of Cube Mapping are explained here:](https://en.wikipedia.org/wiki/Cube_mapping)

In this case all the stimuli are created in eye-centric physical coordinates (centimeters for example) and rendered onto a unit Cube. The displays (Perspective cameras) are then windows into these rendered images.
*probably easiest with a whiteboard drawing here*

### For Virtual Reality (VR)
VR can be easily defined as a situation where the eye, and the screens (windows) are fixed positions, while the all the objects (or VR environment) moves across the eye.

![VR](~/images/DisplayLogic/VRcartoon.png){width=500} 

 Example rendering to be added here

### For Augmented Reality (AR)

This is a scenario where, generally, the screens remain in a fixed position and the animal can move around. Since we have an eye-centric coordinate frame, the objects and the screen move around to generate an AR. 

![AR](~/images/DisplayLogic/ARcartoon.jpg){width=500} 

 Example rendering to be added here


