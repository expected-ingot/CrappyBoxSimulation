# CrappyBoxSimulation
A crappy "box simulator" 

This is just a quick program I made in C# that took me 30 minutes.
It's a "box simulator" that just simulates movement and collision. Might add more.

To change the scene: go to "Variables" and edit the scene variable. Each number in the scene variable corresponds to a certain object. The list of objects is at "Reminders" > "Object Types".

Object types:


|  ID|  Usage|
|--|--|
| 0 |Nothing. Doesn't move and doesn't collide.  |
| 1 | Surface. Stops any controllables in it's way |
| 2 |Controllable. A movable box that can move.  |
| 3 | Push +Col. Pushes movables towards + (right). |
| 4 | Push -Col. Pushes movables towards - (left). |
| 5 | End Block. When touched, the simulation ends. |
| 6 | Push RandomCol. Pushes movables in a random direction. |


