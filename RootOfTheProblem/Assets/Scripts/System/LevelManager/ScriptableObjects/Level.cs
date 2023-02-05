using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Level", menuName = "RootOfTheProblem/Level", order = 0)]
public class Level : ScriptableObject {
    public GameObject levelStructurePrefab;
    public int levelNumber;
    public bool completed;
    public bool unlocked;
}
