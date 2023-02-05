using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {
    public Level[] levels;
    public static Level selectedLevel;
    [SerializeField]
    private Level nextLevel;
    public Level currentLevel;

    private static LevelManager levelManager;

    public static LevelManager instance {
        get {
            if(!levelManager) {
                levelManager = FindObjectOfType(typeof(LevelManager)) as LevelManager;
            }

            return levelManager;
        }
    }

    // Start is called before the first frame update
    void OnEnable() {
        EventManager.StartListening("GenerateLevel", GenerateLevel);
        EventManager.StartListening("GenerateMostRecentLevel", GenerateMostRecentLevel);
        EventManager.StartListening("SetLevelAsComplete", SetLevelAsComplete);
        EventManager.StartListening("GenerateCurrentLevel", GenerateCurrentLevel);
        EventManager.StartListening("DestroyGeneratedLevel", DestroyGeneratedLevel);

        foreach(Level level in levels) {
            if(level.completed == false) {
                nextLevel = level;
            }
        }
    }

    // Update is called once per frame
    public static void SetSelectedLevel(Level levelChoice) {
        selectedLevel = levelChoice;
    }

    void GenerateLevel() {
        GameObject newLevel = Instantiate(selectedLevel.levelStructurePrefab) as GameObject;
        newLevel.transform.parent = this.gameObject.transform;
        currentLevel = selectedLevel;
    }

    void GenerateMostRecentLevel() {
        GameObject newLevel = Instantiate(nextLevel.levelStructurePrefab) as GameObject;
        newLevel.transform.parent = this.gameObject.transform;
        currentLevel = nextLevel;
    }

    void SetLevelAsComplete() {
        currentLevel.completed = true;
    }

    void GenerateCurrentLevel() {
        GameObject newLevel = Instantiate(currentLevel.levelStructurePrefab) as GameObject;
        newLevel.transform.parent = this.gameObject.transform;
    }

    void DestroyGeneratedLevel() {
        Destroy(this.transform.GetChild(0).gameObject);
    }
}
