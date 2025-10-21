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

5: create private variable for jump force and set to 1

22: calculate translation for z axis based on current position, how fast the object moves, and how much time has passed

25: apply translation

## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 