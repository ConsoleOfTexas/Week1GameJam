using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DamagePopUpGenerator : MonoBehaviour
{
    public static DamagePopUpGenerator current;
    public GameObject prefab;

    public void Awake()
    {
        current = this;
    }

    // Update is called once per frame
    void Update()
    {
        // FOR TESTING
        if(Input.GetKeyDown(KeyCode.F10))
        {
            CreatePopUp(Vector3.one, Random.Range(0, 100).ToString());
        }
    }

    public void CreatePopUp(Vector3 position, string text)
    {
        var popup = Instantiate(prefab, position, Quaternion.identity);
        var temp = popup.transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        temp.text = text;

        // Destroy Timer
        Destroy(popup, 1f);
    }
}
