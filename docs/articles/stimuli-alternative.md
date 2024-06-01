# Alternative Stimuli Creation
## Under Construction
## Dynamic Textures
In addition to loading premade textures and videos, `BonVision` can display dynamic textures generated online or from other sources. 

In this example workflow, we use dynamic textures to display a webcam feed.

1) Double click the `TextureResources` node and create a `Texture2D` resource and name it `DynamicVideo`.

2) Add a basic Bonvision draw image workflow with a `DrawImage` node drawing the texture `DynamicVideo`.

3) Add a `CameraCapture` node and feed the output to a `UpdateTexture` node.

:::workflow
![Dynamic Textures](../workflows/alternative-stimuli-dynamictexture.bonsai)
:::

## Loading from CSV

## Loading from scripting
