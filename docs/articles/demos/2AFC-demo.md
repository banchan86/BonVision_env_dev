# 2AFC 

* Shawn's note - The existing 2AFC demo in the Bonvision examples repository does not work (the grating orientations do not change, might be a problem with the `EnsureGratingParameters` operator which seems to be outdated), I have used the version from https://bonsai-rx.org/docs/tutorials/vision-psychophysics.html.

This is a demo of a simple orientation discrimination vision psychophysics task using a two-alternative forced choice paradigm.

You can copy and paste the workflow below directly into the `Bonsai` window by clicking on the copy button on the top right of the container.

:::workflow
![Create Window](../../workflows/vision-psychophysics-full-demo.bonsai)
:::

For a full tutorial on how to build this workflow, visit the [Vision Psychophysics](https://bonsai-rx.org/docs/tutorials/vision-psychophysics.html) tutorial on the `Bonsai` documentation website.

## Usage
After pressing run, two gratings will appear on screen in quick succession, followed by a question `A or B`. Press the `Left` keyboard arrow key if the first grating `A` has a more clockwise orientation (to the right) and the `Right` keyboard arrow key if the 2nd grating `B` has a more clockwise orientation. A `green` square will appear onscreen to signify if the choice made was True and `red` for False.


