using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMenuListControl : MonoBehaviour {


    [SerializeField]
    private GameObject characterButtonTemplate;

    [SerializeField]
    private VariableMaster VarMaster;

    IEnumerator Start()
    {
        yield return new WaitForSeconds(2f);

        int ammount = VarMaster.characters.Count;
        for (int i = 1; i <= ammount; i++)
        {
            GameObject go = Instantiate(characterButtonTemplate) as GameObject;
            go.transform.parent = this.gameObject.transform;
        }
    }


}
