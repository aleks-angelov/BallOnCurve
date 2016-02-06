# Ball on Curve

### Individual project for COS 240 - Object-oriented Programming (Spring 2015)

##### Task:
Write a program that animates a ball/point moving along a sine curve. When the ball gets to its right border, it starts over from the left. Enable the user to resume/pause the animation with a click on the R (resume) and P (pause) keyboard buttons.

##### Description:
In order to implement the sine curve ball animation, I used the Windows Forms Chart control. This is a very extensive data visualization control, which is part of the default Windows Forms toolbox. Using the chart control, I created a coordinate system, appropriate for displaying the shape of a sine function. The chart has two series. The first one is responsible for the sine curve itself and consists of about 90 points, which are dynamically generated at runtime. The second one consists of a single large point – the ball. For the motion of the ball I use a timer. With every tick, the ball point matches its position to that of the next point in the sine curve series. When the ball reaches the last point along the sine curve, it goes back to the first one. The pause and resume buttons simply disable and enable the animation timer. I also decided to implement a speed control using a track bar. Moving the track bar slider modifies the timer interval, which then alters the speed of the animation.

