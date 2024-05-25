# Frequently Asked Questions

### I can't see the window with the stimulus when I hit Start in Bonsai?
In some cases, the window might appear outside of the screen. 
If that is the case, you can adjust the `Location` parameter in the `CreateWindow` operator by passing a pair of x,y values corresponding to the screen coordinates (for instance: 100,100)

### I see duplicate operators in Bonsai when adding operators, which one should I choose?
As an example, the `Timer` operator that is used to control timing of stimuli exists in two versions, a `Timer` that belongs to the `Bonsai.Reactive` package and a `Timer` that belongs to the `Bonsai.Shaders` package.
These two operators are not identical. The `Bonsai.Reactive` timer is controlled by the operating system while the `Bonsai.Shaders` version is tied to the refresh rate of the visual display. 
For `BonVision`, since we are using the `Bonsai.Shaders` package to present visual stimuli, using a `Bonsai.Shaders` version of the `Timer` or other timing operators ensures greater consistency and timing as it avoids clock drift and jitter when synchronizing multiple visual elements.

However for other instances, you need to carefully consider the underlying behaviour of the different operators. For instance the `Bonsai.Shaders` version of the `KeyDown` operator only detects keys that are pressed when the shader window is in focus whereas the `Bonsai.WindowsInput` version of the `KeyDown` operator detects keys whenever they are pressed. In this instance which operator is preferable depends on your application.

- For instance, if you want to control visual stimuli with keypresses but not have it affect other workflows/windows that are running, the `Bonsai.Shaders` version of the `KeyDown` might be preferrable, but you need to ensure that the shader window is always in focus for when you want to control the visual stimuli. This is similar to how games confine keyboard input whenever they are running.

- On the other hand, if you have other workflow/windows running and may need to bring them up, choosing the `Bonsai.WindowsInput` version of the `KeyDown` operator will ensure that keypresses are always controlling the visual presentation, as long as you select keys that do not interfere with other.



