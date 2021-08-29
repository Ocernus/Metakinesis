using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterComments : MonoBehaviour
{
    [TextArea(5,10)]
    public string mostValidComment;
    public string[] randomComments;
    public string[] glossolalia;

    public void FreeComment() // Comment relevancy based on sanity level
    {
        print(mostValidComment);
        // if stressed, make random comment
        // if insane, make glossolaliac comment 
    }
}
