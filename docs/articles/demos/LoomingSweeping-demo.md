# Looming/Sweeping Stimulus

These are demos of looming and sweeping visual stimuli that are similar to that used in [Yilmaz et al., 2014](https://doi.org/10.1016%2Fj.cub.2013.08.015) and [Franceschi et al., 2016](https://doi.org/10.1016/j.cub.2016.06.006).

You can copy the workflows directly into Bonsai by clicking on the copy button on the top right of the container.

## Looming Stimulus

:::workflow
![Create Window](../../workflows/demo-looming.bonsai)
:::

### Usage
Just hit Start in the menu. Press the `space bar` to initate the looming stimulus. You can change the `Duration` and `RangeEnd` property in the `RangeAnimation` operator to control the size and speed of the looming disk. To control how long the stimulus persists, change the `DueTime` property in the `Timer` node connected to the `TakeUntil` operator.


## Sweeping Stimulus

:::workflow
![Create Window](../../workflows/demo-sweeping.bonsai)
:::

### Usage
Just hit Start in the menu. Press the `space bar` to initate the looming stimulus. You can change the `Duration` property in the `RangeAnimation` operator to control the speed of the sweep. 

## Video Walkthrough
For an indepth walkthrough about how the demo works (with additional details), you can refer to this Bonsai Live Coding session.

<iframe width="500" height="282" src="https://www.youtube.com/embed/RTacTdWuwqA" title="BonVision Live Coding Session 15 Dec 2020" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share" referrerpolicy="strict-origin-when-cross-origin" allowfullscreen></iframe>