using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suffel : MonoBehaviour
{    // we call the function by giving it an gameobject array.
    private void shuffleDeck(GameObject[] deck)
    {
        // we iterate through the entire array
        for (int cardIndex = 0; cardIndex < deck.Length; cardIndex++)
        {
            Debug.Log(deck[cardIndex].name);

            // during each iteration
            // we grab the object at the current index in the array.
            // ie if t is 0 we grab Square
            // if t is 1 grab Square (1)
            GameObject tempCard = deck[cardIndex];
            // we pick a random spot in our array. 


            int newIndex = Random.Range(cardIndex, deck.Length);

            // set the newly, randomly, picked object to the current spot of the array based on where we are in th eloop
            // square (8) is now at position 0
            deck[cardIndex] = deck[newIndex];

            // the object that was previously in the current is placed in the spot of the 
            deck[newIndex] = tempCard;
        }
    }
}
