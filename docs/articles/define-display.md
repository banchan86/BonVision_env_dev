# Define Display
## Under Construction
## I. ViewingWindow
> [!NOTE]
> This is best for creating 2D stimuli.

This is a flat screen defined by 6 measurements (for a complete discription). Multiple display objects can be added by just adding additional ViewingWindows.

These are the measures that need to be added for each display object:
1. Distance of left bottom corner (from eye)
2. Distance of left top corner (from eye)
3. Distance of right top corner (from eye)
4. Distance of right bottom corner (from eye)
5. Azimuth (horizontal angle from straight ahead) of the centre of the display
6. Elevation (vertical angle from horizon) of the centre of the display


This is an example of the same stimulus rendered on different displays:

![](~/images/DisplayLogic/DisplayWindowLogic-01.png){width=500} 

![](~/images/DisplayLogic/DisplayWindowLogic-03.png){width=500} 

![](~/images/DisplayLogic/DisplayWindowLogic-05.png){width=500} 

Images on A, B and C

## II. PerspectiveViewingWindow
> [!NOTE]
> This is best for creating 3D VR/AR stimuli.

## III. MeshMapping
> [!NOTE]
> When using a projector in conjunction with a mirror or lens.

Lens or mirrors cause distortions in the image, such that pixels across the display surface might not have the same physical dimensions. In this case, one would have to measure the distortions and use these to warp the images to display them correctly. In the case of 3D worlds, they might be best use in conjunction with multiple PerspectiveViewingWindows looking at different parts of the world.

## IV. GammaCorrection
> [!NOTE]
> When using a projector in conjunction with a mirror or lens.

This is simple intensity mapping of the three colors, to make sure the stimuli are linear. It uses a simple LUT (Look-up-table), for Red, Green and Blue. 
