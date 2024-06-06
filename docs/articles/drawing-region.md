# Drawing Region

The drawing views define which region of visual space is used for the visual world as well as the units for the parameters (sizes/locations) that stimuli are drawn with. 

> [!NOTE] 
> This can be larger than the actual region used.

All drawing views accept a `RenderFrame` as input and a `DrawX` stimuli as output as shown in the basic workflow below.

:::workflow
![Basic Workflow](../workflows/overview-draw-circle.bonsai)
:::

## 2D Stimuli

:::workflow
![2D views](../workflows/drawing-region-2d-views.bonsai)
:::

### NormalizedView
For rapid prototyping of 2D stimuli, one can use the `NormalizedView`. This view scales the screen from -1 to 1 on both axes and has no properties to adjust.

![NormalizedView](~/images/DisplayLogic/NormalizedViewport.png){width=500} 

`NormalizedView` can also be used to display 2D stimuli with parameters (eg, sizes, locations) in terms of proportions of the screen size instead of `OrthographicView`.

In this example workflow, we have drawn a circle with a diameter of 1. Since the screen size is scaled from -1 to 1 on both axes, that results in a circle that takes up half the screen in both axes.

:::workflow
![2D views](../workflows/drawing-region-normalized-view.bonsai)
:::


### OrthographicView
`OrthographicView` is the preferred view for displaying 2D stimuli with traditional retino-centric coordinates. Stimuli drawn will have sizes and locations defined in terms of visual angles.

The properties to vary for `OrthographicView` are the visual angles for the top and bottom boundaries (elevation) and left and right boundaries (azimuth).

In this example workflow, we have defined an orthographic view that extends 90 deg in visual angle for all 4 boundaries (essentially a hemisphere in front of the subject) and defined a circle to be drawn with a diameter of 90 degrees centered at 0 deg visual angle. This leads to a circle that takes up half the visual field. Although the outcome is the same with both the `NormalizedView` and `OrthographicView` examples note the differences in terms of units that the stimuli are drawn with.


:::workflow
![2D views](../workflows/drawing-region-orthographic-view.bonsai)
:::


## 3D Stimuli

:::workflow
![3D viewports](../workflows/drawing-region-3d-views.bonsai)
:::

### PerspectiveView

`PerspectiveView` is the preferred view for displaying 3D stimuli such as 3D models or scenes.

> [!Warning] 
> Using a 2D `DrawX` stimuli node with a `PerspectiveView` will throw a method overload error. In the example below, we have replaced the 2D draw circle with a 3D `DrawModel` node to draw a 3D plane.

:::workflow
![Perspective View](../workflows/drawing-region-perspective-view.bonsai)
:::


### CubemapView
`CubemapView` is the preferred view for display 3D environments such as those commonly used for virtual reality or augmented reality.
It specifies multiple views that are used to render the 6 different faces of a cubemap texture.

- to add example workflow (maybe modify VR treadmill example)