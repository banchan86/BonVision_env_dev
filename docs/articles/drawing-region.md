# Drawing Region

Viewports define which region of visual space is used for the visual world. 

> [!NOTE] 
> This can be larger than the actual region used.

All viewports accept a `RenderFrame` as input and a `DrawX` stimuli as output as shown in the basic workflow below.

:::workflow
![Basic Workflow](../workflows/overview-draw-circle.bonsai)
:::

## 2D Stimuli

:::workflow
![2D viewports](../workflows/drawing-region-2d-views.bonsai)
:::

### NormalizedView
For rapid prototyping of 2D stimuli, one can use the `NormalizedView`. This viewport scales the screen from -1 to 1 on both axes

![NormalizedView](~/images/DisplayLogic/NormalizedViewport.png){width=500} 

`NormalizedView` can also be used to display 2D stimuli with parameters (eg, sizes, locations) in terms of proportions of the screen size instead of `OrthographicView`.
If so, then the locations of stimuli defined downstream of this node will use the centre of the screen as the origin, and have sizes that refer to the proportion of the short axis of the screen occupied.
I.e. a quad with an extent of 1 will have a side length equal to the length of the short axis of the screen.

### OrthographicView
`OrthographicView` is the preferred viewport for displaying 2D stimuli, stimuli drawn will have sizes and locations defined in terms of visual angles.

## 3D Stimuli

:::workflow
![3D viewports](../workflows/drawing-region-3d-views.bonsai)
:::

### PerspectiveView

`PerspectiveView` is the preferred viewport for displaying 3D stimuli such as 3D models or scenes.

> [!Warning] 
> Using a 2D `DrawX` stimuli node with a `PerspectiveView` will throw a method overload error. In the example below, we have replaced the 2D draw circle with a 3D `DrawModel` node to draw a 3D plane.

:::workflow
![Perspective View](../workflows/drawing-region-perspective-view.bonsai)
:::


### CubemapView
`CubemapView` is the preferred viewport for display 3D environments such as those commonly used for virtual reality or augmented reality.
It specifies multiple views that are used to render the 6 different faces of a cubemap texture.

- to add example workflow (maybe modify VR treadmill example)