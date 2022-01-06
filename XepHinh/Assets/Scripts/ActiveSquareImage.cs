using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActiveSquareImage : MonoBehaviour
{
    public SquareTextuaData squareTextuaData;
    public bool updateImageOnRehedTreshold = false;

    private void OnEnable()
    {
        UpdateSquareColorOnCurrentPoints();

        if (updateImageOnRehedTreshold)
            GameEvent.UpdateSquareColor += UpdateSquaresColor;        
    }

    private void OnDisable()
    {
        if (updateImageOnRehedTreshold)
            GameEvent.UpdateSquareColor -= UpdateSquaresColor;
    }


    private void UpdateSquareColorOnCurrentPoints()
    {
        foreach(var squareTextur in squareTextuaData.activeSquareTextures)
        {
            if(squareTextuaData.currentColor==squareTextur.squareColor)
            {
                GetComponent<Image>().sprite = squareTextur.texture;
            }
        }
    }

    private void UpdateSquaresColor(Config.SquareColor color)
    {
        foreach(var squareTexture in squareTextuaData.activeSquareTextures)
        {
            if(color == squareTexture.squareColor)
            {
                GetComponent<Image>().sprite = squareTexture.texture;
            }
        }
    }
}
