# Multiple Stimuli
`BonVision` has two methods for drawing multiple stimuli simultaneously

## Array Primitives
For several stimuli primitives, `BonVision` includes array versions of these primitives that can be used to draw several of them simultaneously.

:::workflow
![Create Window](../workflows/array-primitives.bonsai)
:::

* to add more details

## Publish and Subscribe Subject
For scenarios not covered by the above primitives, we can use the `PublishSubject` and `SubscribeSubject` operators to give multiple drawing commands to the `RenderFrame` operator.
First connect a `PublishSubject` operator to the viewport (in our example workflow below, a `NormalizedView`) and give it a name, like `DrawStimuli`.
Next, you can add multiple `SubscribeSubject` operators for each of the stimuli type you want to draw and connect `DrawX` operators to them.
In the `SubscribeSubject` operators, you will need to select the name you have given to the `Subject` you have created (in this example, `DrawStimuli )
The end result should look like this: 

:::workflow
![Create Window](../workflows/multiple-stimuli-publish.bonsai)
:::

This example workflow draws a circle and a quad side by side.

For a video walkthrough of this process, see this youtube video.

<div style="max-width: 500px">
<iframe width=100%  height="282" src="https://www.youtube.com/embed/NudcbbQ2AMg" title="BonVision quick tips: Presenting two stimuli on screen simultaneously" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share" referrerpolicy="strict-origin-when-cross-origin" allowfullscreen></iframe>
</div>

