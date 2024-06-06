# Define Display

## ViewWindow
`ViewWindow` are windows into the virtual environment that is being rendered.

A `ViewWindow` is a flat screen defined by 6 measurements. 

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

Each `ViewWindow` must be accompanied by a `DrawViewport` operator. Additional displays can be defined by adding multiple `ViewingWindow`/`DrawViewport` nodes.

:::workflow
![Multiple Displays](../workflows/overview-multiple-displays.bonsai)
:::


## DrawViewport

The `DrawViewport` operator draws the `ViewWindow` to a display and provides additional options for positioning the `ViewWindow` on a display.

This example workflow illustrates how we can combine the `ViewWindow` and `DrawViewport` operators to flexibly position different views 




<div style="max-width: 500px">
<iframe width=100% height = 282 src="https://www.youtube.com/watch?v=V_AMgMIpXew" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share" referrerpolicy="strict-origin-when-cross-origin" allowfullscreen></iframe>
</div>





## (Optional) Post-processing Operators
Bonvision comes with post-processing operators to correct for various distortions in the final display of the image. These operators would be placed between the `ViewWindow` and `DrawViewport` operator.

### PerspectiveMapping and MeshMapping
Using a projector in conjunction with a mirror/lens or projecting on non uniform surfaces can cause distortions in the image, such that pixels across the display surface might not have the same physical dimensions. In this case, one would have to use these operators to warp the images to display them correctly.

The `PerspectiveMapping` operator can be used to correct distortions when projecting displays on the walls of an rectangular arena. One would specify 4 `ViewWindows`, one for each wall, and then specify a `PerspectiveMapping` for each view window to transform the view before attaching a `DrawViewport` operator.

An example implementation can be found at https://groups.google.com/g/bonsai-users/c/WV7V57vlSAk/m/XjQPqCJkCAAJ.

The `MeshMapping` operator is best used to correct distortions when projecting displays on a demispherical dome. As the process is more complicated, check out the [mesh mapping calibration](./mesh-mapping-calibration.md) article for more information how to measure and calibrate this operator.

## GammaCorrection

The `GammaCorrection` operator applies simple intensity mapping of the three colors, to make sure the stimuli are linear. It uses a simple LUT (Look-up-table), for Red, Green and Blue. Check out the [gamma calibration](./gamma-calibration.md) article for more information on how to measure and calibrate this operator.

