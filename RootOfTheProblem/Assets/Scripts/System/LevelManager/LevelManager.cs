using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {
    public Level[] levels;
    public Level selectedLevel;
    [SerializeField]
    private Level nextLevel;

    // Start is called before the first frame update
    void OnEnable() {
        EventManager.StartListening("GenerateLevel", GenerateLevel);
        EventManager.StartListening("GenerateMostRecentLevel", GenerateMostRecentLevel);

        foreach(Level level in levels) {
            if(level.completed == false) {
                nextLevel = level;
            }
        }
    }

    // Update is called once per frame
    void SetSelectedLevel(Level levelChoice) {
        selectedLevel = levelChoice;
    }

    void GenerateLevel() {
        Instantiate(selectedLevel.levelStructurePrefab, selectedLevel.levelStructurePrefab.transform.position, 
                                                        selectedLevel.levelStructurePrefab.transform.rotation);
    }

    void GenerateMostRecentLevel() {
        GameObject newLevel = Instantiate(nextLevel.levelStructurePrefab) as GameObject;
        newLevel.transform.parent = this.gameObject.transform;
    }
}
