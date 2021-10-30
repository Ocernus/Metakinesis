using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugginBehavior : MonoBehaviour
{
    // Spawner system can generate these with varying stat distribution based on overall power level needed for scenario
    // Can patrol
    // Can wait at point
    // Can see within cone of vision based on the head type
    // Head color paths are determined by the rest of the parameters
    // Can search for player after first sighting, check last known location, then return to previous path
    // Can attack player if line of sight has been maintained for variable "target accuisition time" and attack range is maintained
    // Can have varying attack setups with either ranged or melee based on arms, legs, and torsos
    // Melee blade arms can slash within a longer range than player melee and can be "poison enhanced" under certain conditions, once per engagement
    // Can have varying armor types indicating hit points and invulnerability / material type
    // Varrying back peices can enable flight, enable 360 degree sight, or enhance armor from behind
    // Different legs determine jumping capability, turn speed, and movement speed
    // Can have different sense attractions based on facepieces
}
