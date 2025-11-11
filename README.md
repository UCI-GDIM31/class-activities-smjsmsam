# in-class-activities
## Devlogs
### W1
Pretend I wrote a beautiful metaphor describing Compnents, GameObjects, and Scenes here.

### W2
Describing RGB channels linearly as floats allow for a more expansive color range because there can be infinitely many intensities of color.

_bounce is a counter, so its values will only update incrementally. Floats are not necessary because there will be no decimal value. Boolean does not make sense because it does not convey the number of bounces. Strings are possible but require extra processing (turning it into an int to increment) so it is better to make it an int in the first place.

Step 4 did not have a semcolon and thus the compiler made a red squiggly underline with "; expected".

### W3
Table #2

bool DidPlayerHitBeat(float hit_time){};
Assuming that the class contains the expected float for beat time as a member variable.

Classes are categories and components are the items of that category. For example, a class would be animal, and components would be zebra, dog, cat, etc.

### W4
Table #2

5: create private float variable for jump force and set to 1

22: calculate translation for z axis based on current position (using .GetAxis), how fast the object moves (_moveSpeed), and how much time has passed (Time.deltaTime)

25: apply translation to Cat's transform component

Table #2

The Cat and SoccerBall objects have Rigidbodies because they need to simulate physics (jumping, kicking, etc). For IsTrigger, SoccerBall should have it because it needs to be detected when it interacts with other game objects.

### W5
Which Update() gets called first?
Ordering of Update() is random but they will run in same frame so the difference is miniscule (multiple frames per second).

### W6
General C#
[Course Review & Resources Doc](https://docs.google.com/document/d/1g257orHX8bQNaC57k1DMqCDIpAd95jDwpQPqJiA4ks8/edit?usp=sharing)

Member variables:
* boolean for chasing
* customizable speed
* vector to track cat position
Methods:
* start for debugging
* update to check for boolean and move accordingly
* setters for chasing

### W7
[Game Idea & Outline Doc](https://docs.google.com/document/d/1G_ZSCA2-UVtHll1uaPGUIZ9OZg3-oBIxvR5bJl7Vl6k/edit?usp=sharing)
Role: gameplay

Step 2 incorrectly transformed the object in global space rather than object space.

## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 